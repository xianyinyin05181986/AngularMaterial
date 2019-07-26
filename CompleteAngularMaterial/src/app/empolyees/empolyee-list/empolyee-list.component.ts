import { Component, OnInit, ViewChild } from '@angular/core';
import { EmployeeService } from 'src/app/shared/employee.service';
import { MatTableDataSource, MatSort, MatPaginator } from '@angular/material';
import { DepartmentService } from 'src/app/shared/department.service';
import { MatDialog, MatDialogConfig } from "@angular/material";
import { EmployeeComponent } from 'src/app/employees/employee/employee.component';
import { NotificationService } from 'src/app/shared/notification.service';
import { DialogService } from 'src/app/shared/dialog.service';
@Component({
  selector: 'app-empolyee-list',
  templateUrl: './empolyee-list.component.html',
  styleUrls: ['./empolyee-list.component.css']
})
export class EmpolyeeListComponent implements OnInit {

  constructor(private service: EmployeeService,
    private departmentServeice: DepartmentService,
    private dialog: MatDialog,
    private notificationService:NotificationService,
    private dialogService:DialogService
    ) { }

  listData: MatTableDataSource<any>;
  searchKey: string;
  displayedColumns: string[] = ['fullName', 'email', 'mobile', 'departmentName', 'actions']; // order and visible can be controlled by this array

  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;

  ngOnInit() {
    this.service.getEmpolyees().subscribe(
      list => {
        let array = list.map(item => {
          let departmentName = this.departmentServeice.getDepartionmentName(item.payload.val()['department']);
          return {
            $key: item.key,
            departmentName: departmentName,
            ...item.payload.val()
          };
        });
        this.listData = new MatTableDataSource(array);
        this.listData.sort = this.sort;
        this.listData.paginator = this.paginator;
        this.listData.filterPredicate = (data, filter) => { return this.displayedColumns.some(ele => { return ele != 'actions' && data[ele].toLowerCase().indexOf(filter) != -1; }) }
      });
  }


  onSearchClear() {
    this.searchKey = "";
    this.applyfilter();
  }

  applyfilter() {
    this.listData.filter = this.searchKey.trim().toLowerCase();
  }

  onCreate() {
    this.service.initializeFormGroup();
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = "60%";
    this.dialog.open(EmployeeComponent, dialogConfig);
  }

  onEdit(row) {
    this.service.populateEmployee(row);
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = "60%";
    this.dialog.open(EmployeeComponent, dialogConfig);
  }

  onDelete($key) {
    // if (confirm('Are you sure to delete this record?')) {
    //   this.service.deleteEmployee($key);
    //   this.notificationService.warn('! Deleted sucessfully');
    // }
    this.dialogService.openConfirmDialog('Are you sure to delete this record?')
    .afterClosed().subscribe(res=>{
     if(res)
     {
       this.service.deleteEmployee($key);
       this.notificationService.warn('! Deleted sucessfully');
     }
    });
  }
}

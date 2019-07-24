import { Component, OnInit,ViewChild } from '@angular/core';
import { EmployeeService } from 'src/app/shared/employee.service';
import { MatTableDataSource,MatSort, MatPaginator} from '@angular/material';

@Component({
  selector: 'app-empolyee-list',
  templateUrl: './empolyee-list.component.html',
  styleUrls: ['./empolyee-list.component.css']
})
export class EmpolyeeListComponent implements OnInit {

  constructor(private service: EmployeeService) { }

  listData: MatTableDataSource<any>;
  searchKey:string;
  displayedColumns: string[] = ['fullName', 'email','mobile','actions']; // order and visible can be controlled by this array

  @ViewChild(MatSort) sort:MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;

  ngOnInit() {
    this.service.getEmpolyees().subscribe(
      list => {
        let array = list.map(item => {
          return {
            $key: item.key,
            ...item.payload.val()
          };
        });
        this.listData = new MatTableDataSource(array);
        this.listData.sort = this.sort;
        this.listData.paginator =this.paginator;
      });
  }


  onSearchClear(){
    this.searchKey ="";
    this.applyfilter();
  }

  applyfilter(){
    this.listData.filter = this.searchKey.trim().toLowerCase();
  }
}

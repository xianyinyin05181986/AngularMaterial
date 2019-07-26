import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/shared/employee.service';
import { DepartmentService } from 'src/app/shared/department.service';
import { NotificationService } from 'src/app/shared/notification.service';
import { MatDialogRef } from '@angular/material';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  constructor(private service: EmployeeService,
    private departmentService: DepartmentService,
    private notificationService: NotificationService,
    public dialogRef: MatDialogRef<EmployeeComponent>) { }

  ngOnInit() {
    this.service.getEmpolyees();
  }

  onClear() {
    this.service.form.reset();
    this.service.initializeFormGroup();
    // this.notificationService.success('::Clear successfully!');
  }
  onSubmit() {
    if (this.service.form.valid) {
      let msg = '';
      if (!this.service.form.get('$key').value){
        this.service.insertEmpolyee(this.service.form.value);
        msg ='::Inserted successfully!';
      }
      else
      {
        this.service.updateEmployee(this.service.form.value);
        msg ='::Updated successfully!';
      }
      this.service.form.reset();
      this.service.initializeFormGroup();
      this.notificationService.success(msg);
      this.onClose();

    }
  }

  onClose() {
    this.service.form.reset();
    this.service.initializeFormGroup();
    this.dialogRef.close();
  }
}

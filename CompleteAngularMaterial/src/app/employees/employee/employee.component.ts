import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/shared/employee.service';
import { DepartmentService } from 'src/app/shared/department.service';
import { NotificationService } from 'src/app/shared/notification.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  constructor(private service: EmployeeService,
    private departmentService:DepartmentService,
    private notificationService:NotificationService) { }
  
  ngOnInit() {
    this.service.getEmpolyees();
  }
 
  onClear(){
    this.service.form.reset();
    this.service.initializeFormGroup();
    // this.notificationService.success('::Clear successfully!');
  }
  onSubmit(){
    if(this.service.form.valid) {
      this.service.insertEmpolyee(this.service.form.value);
      this.service.form.reset();
      this.service.initializeFormGroup();
      this.notificationService.success('::Submitted successfully!');
    }
  }
}

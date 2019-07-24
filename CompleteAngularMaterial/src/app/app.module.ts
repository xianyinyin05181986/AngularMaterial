import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeComponent } from './employees/employee/employee.component';
import { MaterialModule } from './material/material.module';
import { EmployeesComponent } from './employees/employees.component';
import { EmployeeService } from './shared/employee.service'
import { ReactiveFormsModule,FormsModule } from "@angular/forms";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AngularFireModule } from 'angularfire2';
import { AngularFireDatabaseModule } from 'angularfire2/database'
import { environment } from '../environments/environment'
import { DepartmentService } from './shared/department.service';
import { EmpolyeeListComponent } from './empolyees/empolyee-list/empolyee-list.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    EmployeesComponent,
    EmpolyeeListComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MaterialModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    AngularFireDatabaseModule,
    FormsModule,
    AngularFireModule.initializeApp(environment.firebaseConfig)
  ],
  providers: [EmployeeService,DepartmentService],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { Injectable } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms'
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private fb: FormBuilder,private http:HttpClient) { }

  readonly BaseURI ='http://localhost:2734/api';

  formModel = this.fb.group({
    UserName: ['default', Validators.required],
    Email: ['default@126.com', Validators.email],
    FullName: [''],
    Passwords: this.fb.group({
      Password: ['1234', [Validators.required, Validators.minLength(4)]],
      ConfirmPassword: ['1234', Validators.required]
    },{ validator: this.comparedPasswords })

  });

  comparedPasswords(fb: FormGroup) {
    let confirmPswrdCtrl = fb.get('ConfirmPassword');
    //passwordMismatch
    //confrimPswrdCtrl.errors = {passwordMismatch:true}
    if (confirmPswrdCtrl.errors == null || 'passwordMismatch' in confirmPswrdCtrl.errors) {
      if (fb.get('Password').value != confirmPswrdCtrl.value)
        confirmPswrdCtrl.setErrors({ passwordMismatch: true });
      else
        confirmPswrdCtrl.setErrors(null);

    }
  }
  register(){
    var body ={
      UserName:this.formModel.value.UserName,
      Email: this.formModel.value.Email,
      FullName: this.formModel.value.FullName,
      Password: this.formModel.value.Passwords.Password,
    }

    return this.http.post(this.BaseURI +'/ApplicationUser/Register',body);
  }
}

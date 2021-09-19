import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Employee } from '../Model/employee';
@Injectable({
  providedIn: 'root'
})
export class EmpserviceService {
   formdata=new Employee;
// readonly baseurl:'http://localhost:64428/api/Auth/';
  constructor(private http:HttpClient) { }
  Register(name:string,desig:string,mobile:string,
    age:string,address:string,
    password:string,Email:string){
      debugger;
    var data={name:this.formdata.name,desig:this.formdata.desig,
    mobile:this.formdata.mobile,age:this.formdata.age,address:this.formdata.address,
  password:this.formdata.password,Email:this.formdata.Email}
    return this.http.post('api/Auth/Register',data);
  }
  Login(EmpUserName:string,Emppassword:string){
      var data={EmpUserName:this.formdata.UserName,Emppassword:this.formdata.password}
        return this.http.post('/api/Auth/Login',data);
    }
}

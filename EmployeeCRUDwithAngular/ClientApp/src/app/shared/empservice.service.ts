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
  Register(EmpId:number,Empname:string,Empdesig:string,Empmobile:string,
    Empage:string,Empaddress:string,EmpUserName:string,
    Emppassword:string){
      debugger;
    var data={EmpId:this.formdata.EmpId,Empname:this.formdata.Empname,Empdesig:this.formdata.Empdesig,
    Empmobile:this.formdata.Empmobile,Empage:this.formdata.Empage,Empaddress:this.formdata.Empaddress,
  EmpUserName:this.formdata.EmpUserName,Emppassword:this.formdata.Emppassword}
    return this.http.post('api/Auth/Register',data);
  }
  Login(EmpUserName:string,Emppassword:string){
      var data={EmpUserName:this.formdata.EmpUserName,Emppassword:this.formdata.Emppassword}
        return this.http.post('/api/Auth/Login',data);
    }
}

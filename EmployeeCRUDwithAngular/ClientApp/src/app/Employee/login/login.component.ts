import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Model/employee';
import { EmpserviceService } from 'src/app/shared/empservice.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(public service:EmpserviceService) { }

  ngOnInit(): void {
    debugger;
    var emp=new Employee;
    emp.UserName='';
    emp.password='';
  }
Login(){
  var emp=new Employee;
  return this.service.Login(emp.UserName,emp.password).subscribe(res=>{
    console.log(res);
  },err=>{
    console.log(err);
  })
}
}

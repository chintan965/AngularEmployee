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
    emp.EmpUserName='';
    emp.Emppassword='';
  }
Login(){
  var emp=new Employee;
  return this.service.Login(emp.EmpUserName,emp.Emppassword).subscribe(res=>{
    console.log(res);
  },err=>{
    console.log(err);
  })
}
}

import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from 'src/app/Model/employee';
import { EmpserviceService } from 'src/app/shared/empservice.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(public service:EmpserviceService,public route:Router) { }

  ngOnInit(): void {
  }
  Register(){
    debugger;
    var emp=new Employee;
    return this.service.Register(emp.name,
      emp.desig,emp.mobile,emp.age,
      emp.address,emp.password,emp.Email).subscribe(res=>{
        console.log(res);
        this.route.navigateByUrl("/Login");
      },err=>{
        console.log(err);
      })
  }

}

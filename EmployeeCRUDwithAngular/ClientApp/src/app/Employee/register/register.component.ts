import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Model/employee';
import { EmpserviceService } from 'src/app/shared/empservice.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(public service:EmpserviceService) { }

  ngOnInit(): void {
  }
  Register(){
    debugger;
    var emp=new Employee;
    return this.service.Register(emp.EmpId,emp.Empname,
      emp.Empdesig,emp.Empmobile,emp.Empage,
      emp.Empaddress,emp.EmpUserName,emp.Emppassword).subscribe(res=>{
        console.log(res);
      },err=>{
        console.log(err);
      })
  }

}

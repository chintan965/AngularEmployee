import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './Employee/login/login.component';
import { RegisterComponent } from './Employee/register/register.component';

const routes: Routes = [
  {path:"Login",component:LoginComponent},
  {path:"",component:RegisterComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

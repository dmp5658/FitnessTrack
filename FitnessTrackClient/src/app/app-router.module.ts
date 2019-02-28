import {RouterModule, Routes} from '@angular/router';
import {NgModule} from '@angular/core';

// component
import {IndexComponent} from './index/index.component';
import {LoginComponent} from './login/login.component';
import {RegisterComponent} from './register/register.component';
import {AddLiftinfoComponent} from './add-liftinfo/add-liftinfo.component';
import {AddWeightinfoComponent} from './add-weightinfo/add-weightinfo.component';
import {AddTargetComponent} from './add-target/add-target.component';
// route
const routes: Routes = [
  {path: '', component: IndexComponent},
  {path: 'login', component: LoginComponent},
  {path: 'register', component: RegisterComponent},
  {path: 'liftinfo', component: AddLiftinfoComponent},
  {path: 'weightinfo', component: AddWeightinfoComponent},
  {path: 'target', component: AddTargetComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRouterModule {}

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CusAddEditComponent } from './cus-add-edit/cus-add-edit.component';

const routes: Routes = 
[
  { path: 'create', component: CusAddEditComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { CustomerService } from '../services/customer.service';
import { DialogRef } from '@angular/cdk/dialog';

@Component({
  selector: 'app-cus-add-edit',
  templateUrl: './cus-add-edit.component.html',
  styleUrl: './cus-add-edit.component.scss'
})
export class CusAddEditComponent {
  cusForm: FormGroup;

  constructor(private _fb: FormBuilder, private _cusService: CustomerService, private _dialogRef: DialogRef) 
  {
    this.cusForm = this._fb.group({
      image:'',
      name:'',
      phone:'',
      email:'',
      address:'',
      opBalance:'',
      limit:''
    });
  }

  onFormSubmit()
  {
    this._cusService.addCustomer(this.cusForm.value).subscribe({
      next: (val: any) => {
        alert('added customer successfully')
        this._dialogRef.close();
      },
      error: (err: any) => {
        console.error(err);
        this._dialogRef.close();
      }
    });
     
  }
}

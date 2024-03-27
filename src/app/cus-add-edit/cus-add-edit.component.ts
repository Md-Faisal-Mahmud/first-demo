import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-cus-add-edit',
  templateUrl: './cus-add-edit.component.html',
  styleUrl: './cus-add-edit.component.scss'
})
export class CusAddEditComponent {
  cusForm: FormGroup;

  constructor(private _fb: FormBuilder) 
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
    console.log(this.cusForm.value);
  }
}

import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CusAddEditComponent } from './cus-add-edit/cus-add-edit.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'firstdemo-front';

  constructor(private _matDialog: MatDialog) 
  {
  }

  openCusAddEditForm()
  {
    this._matDialog.open(CusAddEditComponent)
  }
}

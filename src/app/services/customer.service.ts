import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private _http: HttpClient) { }

  addCustomer(data: any): Observable<any>
  {
    return this._http.post('https://localhost:44356/api/app/customer', data)
  }
}

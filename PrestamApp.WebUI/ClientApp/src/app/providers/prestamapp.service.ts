import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PrestamappService {
  constructor(private _http: HttpClient, @Inject('API_URL') private apiUrl) {}

  getContacts(): Observable<Array<any>> {
    return this._http.get<Array<any>>(this.apiUrl + 'Contact/Get');
  }
}

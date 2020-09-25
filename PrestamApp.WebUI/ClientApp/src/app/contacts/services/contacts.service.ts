import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs';
import { IContact } from '../models/contact.interfase';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ContactsService {
  constructor(private http: HttpClient, @Inject('API_URL') private apiUrl) {}

  get(): Observable<Array<IContact>> {
    return this.http.get<Array<IContact>>(this.apiUrl + 'Contact/Get');
  }

  post(url: string, data: any): Observable<any> {
    let headers = new HttpHeaders();
    headers = headers.set('Content-Type', 'application/json');
    const body = JSON.stringify(data);
    return this.http.post(this.apiUrl + url, body, {  headers }).pipe(map(res => res as any));
  }

}

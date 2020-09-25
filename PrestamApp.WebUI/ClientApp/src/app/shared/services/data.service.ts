import { Injectable, Inject } from '@angular/core';

import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient, @Inject('API_URL') private apiUrl: string) { }

  get(url: string): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl + url);
  }
}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BaseService {

    private config = {
      headers: {
          'Content-Type': 'application/json',
          'Access-Control-Allow-Origin': '*',
          'Access-Control-Allow-Methods': '*',
          'Access-Control-Allow-Headers': '*',
          //'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8'
      }
  }
  private baseUrl = environment.baseUrl;

  constructor(private http: HttpClient) { 

  }
  get (relativeUrl: string): Observable<any>{
    const url = this.baseUrl + relativeUrl;
    return this.http.get(url);
  }

  put (relativeUrl: string, object: any): Observable<any>{
    //const url = "http://localhost:2213/contact/"
    const url = this.baseUrl + relativeUrl;
    console.log(JSON.stringify(object));
    return this.http.put(url, JSON.stringify(object), this.config);
    
  }
}

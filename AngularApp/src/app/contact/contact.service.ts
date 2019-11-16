import { IContact } from './contact';
import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
    providedIn: 'root' //access this service from any component and any service in app
}) 
export class ContactService {

    private contactUrl = environment.baseUrl;

    constructor(private http: HttpClient) { // inject http service to http variable
        
    }

    getContacts(): Observable<IContact[]> { // http causes asynchrous operations, so it returns ONE http response object (Observable)
        return this.http.get<IContact[]>(this.contactUrl) // response object is mapped to <IContact[]> type
    }
}
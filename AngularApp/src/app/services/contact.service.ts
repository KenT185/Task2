import { IContact } from '../models/contact';
import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { BaseService } from './base.service';

@Injectable({
    providedIn: 'root' //access this service from any component and any service in app
}) 
export class ContactService {

    private contactUrl = environment.baseUrl;

    constructor(private baseService: BaseService) { // inject http service to http variable
        
    }

    getContacts(): Observable<IContact[]> { // http causes asynchrous operations, so it returns ONE http response object (Observable)
        return this.baseService.get("contact")
    }

    // putContact(contact: IContact): Observable<IContact> { // http causes asynchrous operations, so it returns ONE http response object (Observable)
    //     const url = "contact/" + contact.id.toString();
    //     return this.baseService.put(url, contact);
    // }

    putContact(contact: IContact): Observable<IContact> { // http causes asynchrous operations, so it returns ONE http response object (Observable)
        return this.baseService.put("contact", contact);
    }
}
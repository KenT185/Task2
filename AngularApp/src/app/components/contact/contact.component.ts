import { Component, OnInit } from '@angular/core';
import { IContact } from '../../models/contact';
import { ContactService } from '../../services/contact.service';
import { Observable } from 'rxjs';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AddressFieldComponent } from '../address-field/address-field.component';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  //data hard coded
  // contacts: IContact[] = [
  //   {
  //     id: 1,
  //      name : "testName1",
  //      surname : "testSurname1",
  //      phoneNumber : "123456789",
  //      email : "testMail1",
  //      address : "address1"
  //   },
    
  //   {
  //     id: 2,
  //      name : "testName2",
  //      surname : "testSurname2",
  //      phoneNumber : "98754321",
  //      email : "testMail2",
  //      address : "address2"
  //   }
  // ];

  // data from service
  contacts$: Observable<IContact[]>;

  displayedColumns: string[] = ['Name', 'Surname', 'Phone', 'Email', 'Address'];

  constructor(private contactService: ContactService, private modalService: NgbModal) { }

  ngOnInit() {
    this.getContacts();
  }

  getContacts(): void {
    this.contacts$ = this.contactService.getContacts();
  }

  updateAddress(contact: IContact) {
    this.contactService.putContact(contact).subscribe();
  } 

  rowclick(contact) {
    const modalRef = this.modalService.open(AddressFieldComponent);
    modalRef.componentInstance.contact=contact;
    modalRef.result.then((updatedContact) => {
        if(updatedContact != null) {
          this.updateAddress(updatedContact);
        } else {
          console.log("Update cancelled");
        }
    })
  }
    
}
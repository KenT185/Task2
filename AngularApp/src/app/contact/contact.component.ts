import { Component, OnInit } from '@angular/core';
import { IContact } from './contact';
import { ContactService } from './contact.service';

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
  contacts: IContact[];

  displayedColumns: string[] = ['Name', 'Surname', 'Phone', 'Email', 'Address'];

  constructor(private contactService: ContactService) { }

  ngOnInit() {
    this.getContacts();
  }

  getContacts(): void {
    this.contactService.getContacts().subscribe( (contacts) => {
      console.log(this.contacts);
      this.contacts = contacts;
    });
  }

  // selectedContact(): boolean {

  // }

    
}
import { Component, OnInit, Input } from '@angular/core';
import { IContact } from 'src/app/models/contact';
import { NgbModal, NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-address-field',
  templateUrl: './address-field.component.html',
  styleUrls: ['./address-field.component.css']
})
export class AddressFieldComponent implements OnInit {
  @Input() contact: IContact;
  constructor(public activeModal: NgbActiveModal) { }

  ngOnInit() {
  }

}

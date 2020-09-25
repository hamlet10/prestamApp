import { Component, OnInit } from '@angular/core';
import { ContactsService } from '../../services/contacts.service';
import { IContact } from '../../models/contact.interfase';

@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html',
  styleUrls: ['./contacts.component.scss']
})
export class ContactsComponent implements OnInit {

  contacts: Array<IContact> = [];
  constructor(private contactService: ContactsService) { }

  ngOnInit() {
    this.contactService.get().subscribe(res => {
       this.contacts = res;
    });
  }

}

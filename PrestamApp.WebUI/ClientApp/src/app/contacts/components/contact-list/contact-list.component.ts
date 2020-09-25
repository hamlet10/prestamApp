import { Component, OnInit, Input } from '@angular/core';
import { IContact } from '../../models/contact.interfase';

@Component({
  selector: 'app-contact-list',
  templateUrl: './contact-list.component.html',
  styleUrls: ['./contact-list.component.scss']
})
export class ContactListComponent implements OnInit {

  @Input() contacts: Array<IContact> = [];
  public pageSettings: any;
  constructor() { }

  ngOnInit() {
    this.pageSettings = { pageCount: 5 };
  }
}

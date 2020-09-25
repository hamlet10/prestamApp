import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/shared/services/data.service';
import { FormGroup } from '@angular/forms';
import { ContactsService } from '../../services/contacts.service';

@Component({
  selector: 'app-contact-create',
  templateUrl: './contact-create.component.html',
  styleUrls: ['./contact-create.component.scss']
})
export class ContactCreateComponent implements OnInit {
  addressTypes: Array<any> = [];
  addressData: Array<any> = [];
  zoneData: Array<any> = [];

  constructor(
    private dataService: DataService,
    private contactService: ContactsService
  ) {}

  ngOnInit() {
    this.dataService
      .get('AddressType/Get')
      .subscribe(res => (this.addressTypes = res));
    this.dataService
      .get('AddressData/Get')
      .subscribe(res => (this.addressData = res));
    this.dataService.get('Zones/Get').subscribe(res => (this.zoneData = res));
  }

  onCreate(event: FormGroup) {
    console.log(event.value);
    this.contactService
      .post('Contact/Create', event.value)
      .subscribe(res => {
        console.log(res);
        alert('Agregado bitches');
      });
  }
}

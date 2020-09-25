import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

import { ContactsRoutingModule, routedComponents } from './contacts-routing.module';

// Syncfusion
import { GridAllModule } from '@syncfusion/ej2-angular-grids';
import { DropDownListModule } from '@syncfusion/ej2-angular-dropdowns';
import { TextBoxModule } from '@syncfusion/ej2-angular-inputs';
import { ButtonModule, RadioButtonModule } from '@syncfusion/ej2-angular-buttons';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [routedComponents],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    ContactsRoutingModule,
    GridAllModule,
    DropDownListModule,
    ButtonModule,
    RadioButtonModule,
    TextBoxModule,
    SharedModule
  ]
})
export class ContactsModule { }

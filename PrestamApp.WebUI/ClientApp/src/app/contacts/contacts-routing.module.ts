import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ContactsComponent } from './containers/contacts/contacts.component';
import { ContactListComponent } from './components/contact-list/contact-list.component';
import { ContactFormComponent } from './components/contact-form/contact-form.component';
import { ContactCreateComponent } from './containers/contact-create/contact-create.component';

const routes: Routes = [
  {
    path: '',
    component: ContactsComponent
  },
  {
    path: 'create',
    component: ContactCreateComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
  declarations: []
})
export class ContactsRoutingModule {}
export const routedComponents = [
  ContactsComponent,
  ContactListComponent,
  ContactFormComponent,
  ContactCreateComponent
];

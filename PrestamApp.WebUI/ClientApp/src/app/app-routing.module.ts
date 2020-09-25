import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { LocationStrategy, HashLocationStrategy } from "@angular/common";
import { HomeComponent } from "./components/home/home.component";


const routes: Routes = [
  { path: "", redirectTo: "/contacts", pathMatch: "full" },
  { path: "home", component: HomeComponent },
  { path: 'contacts', loadChildren: ()=> import('./contacts/contacts.module').then(m=> m.ContactsModule)},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: [{ provide: LocationStrategy, useClass: HashLocationStrategy }]
})
export class AppRoutingModule {}

import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

//syncfusion
import { SyncFusionModule } from "./sync-fusion.module";
import { HttpClientModule } from "@angular/common/http";
import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { HomeComponent } from "./components/home/home.component";
import { RouterModule } from "@angular/router";

@NgModule({
  declarations: [AppComponent, HomeComponent],
  imports: [
    BrowserModule,
    RouterModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    SyncFusionModule
  ],
  providers: [{ provide: "API_URL", useValue: "http://localhost:56534/api/" }],
  bootstrap: [AppComponent]
})
export class AppModule {}

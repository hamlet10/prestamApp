import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

//SF
import { ButtonModule } from "@syncfusion/ej2-angular-buttons";
import {
  SidebarModule,
  MenuAllModule,
  TreeViewAllModule
} from "@syncfusion/ej2-angular-navigations";

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ButtonModule,
    SidebarModule,
    MenuAllModule,
    TreeViewAllModule
    // GridModule
  ],
  exports: [
    CommonModule,
    ButtonModule,
    SidebarModule,
    MenuAllModule,
    TreeViewAllModule
    // GridModule
  ]
})
export class SyncFusionModule {}

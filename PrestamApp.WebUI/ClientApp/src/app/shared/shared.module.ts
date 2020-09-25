import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FieldErrorDisplayComponent } from './components/field-error-display/field-error-display.component';

@NgModule({
  declarations: [FieldErrorDisplayComponent],
  imports: [
    CommonModule
  ],
  exports: [FieldErrorDisplayComponent]
})
export class SharedModule { }

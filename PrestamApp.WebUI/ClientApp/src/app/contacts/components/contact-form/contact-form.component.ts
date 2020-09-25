import {
  Component,
  OnInit,
  ChangeDetectionStrategy,
  Input,
  Output,
  EventEmitter
} from '@angular/core';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-contact-form',
  templateUrl: './contact-form.component.html',
  styleUrls: ['./contact-form.component.scss'],
  changeDetection: ChangeDetectionStrategy.Default
})
export class ContactFormComponent implements OnInit {
  form: FormGroup;
  @Input() addressTypes: Array<any> = [];
  @Input() addressData: Array<any> = [];
  @Input() zoneData: Array<any> = [];

  @Output() create = new EventEmitter<FormGroup>();
  @Output() validateForm = new EventEmitter<FormGroup>();

  constructor(private fb: FormBuilder) {}

  ngOnInit() {
    this.form = this.fb.group({
      identificationNumber: [
        '',
        [Validators.required, Validators.maxLength(13)]
      ],
      name: ['', [Validators.required, Validators.maxLength(50)]],
      lastName: ['', [Validators.required, Validators.maxLength(50)]],
      email: [
        '',
        [Validators.required, Validators.email, Validators.maxLength(50)]
      ],
      gender: [true, [Validators.required]],
      phoneNumberOne: ['', [Validators.required, Validators.maxLength(20)]],
      phoneNumberTwo: ['', [Validators.required, Validators.maxLength(20)]],
      zoneId: [1, []],
      addressTypeId: [1, []],
      addressDataId: [1, []],
      refference: ['', [Validators.maxLength(50)]],
      street: ['', [Validators.required, Validators.maxLength(50)]]
    });
  }

  public isFieldValid(field: string) {
    return (
      !this.form.get(field).valid &&
      (this.form.get(field).dirty || this.form.get(field).touched)
    );
  }

  onSubmit(form: FormGroup) {
    const { value, valid } = form;
    if (valid) {
        console.log('is valid');
        this.create.emit(form);
    } else {
      alert('error');
      this.validateForm.emit(form);
    }
}
}

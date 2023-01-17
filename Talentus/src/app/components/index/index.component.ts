import { validateHorizontalPosition } from '@angular/cdk/overlay';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, FormGroupDirective, NgForm, Validators } from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';
import { FormModel } from 'src/models/form-Model';
import { IndexServices } from 'src/services/index-services';
 
/** Error when invalid control is dirty, touched, or submitted. */
export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent {
  form: FormGroup;
  model: FormModel = new FormModel;
  matcher = new MyErrorStateMatcher();
  constructor(private formBuilder: FormBuilder, private serviceIndex: IndexServices) {
    this.form = this.formBuilder.group({
      name: ['', Validators.required],
      email: ['', Validators.required, Validators.email],
      phone: ['', Validators.required],
      date: ['', Validators.required],
      city: ['', Validators.required],
    })
  }
  
  enviar(){
    console.log(this.form);
  }

  sendForm(){
    console.log(this.form);
    this.model.name = this.form.controls['name'].value;
    this.model.email = this.form.controls['email'].value;
    this.model.phone = this.form.controls['phone'].value;
    this.model.date = this.form.controls['date'].value;
    this.model.city = this.form.controls['city'].value;
    this.serviceIndex.manageForm(this.model).subscribe();
  }
}

import { Component, OnInit } from '@angular/core';
import {InfoService} from '../info.service';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import {AuthService} from '../auth.service';

@Component({
  selector: 'app-add-liftinfo',
  templateUrl: './add-liftinfo.component.html',
  styleUrls: ['./add-liftinfo.component.css']
})
export class AddLiftinfoComponent {

  constructor(private infoservice: InfoService,
              private authservice: AuthService) { }
  addliftForm = new FormGroup({
    currbench: new FormControl('', [Validators.required, Validators.pattern('\\d+\\.?\\d*')]),
    currsquat: new FormControl('', [Validators.required, Validators.pattern('\\d+\\.?\\d*')]),
    currcurl: new FormControl('', [Validators.required, Validators.pattern('\\d+\\.?\\d*')]),
    currlegpress: new FormControl('', [Validators.required, Validators.pattern('\\d+\\.?\\d*')]),
    userid: new FormControl('')
  });

  onSubmit() {
    console.log(this.addliftForm.value);
    console.log(this.authservice.getUserId);
    this.addliftForm.patchValue({
      userid: this.authservice.getUserId
    });

    console.log(this.addliftForm.value);
    this.infoservice.createLiftEntry(this.addliftForm.value).subscribe((data) =>
      console.log('Data - ', data));
  }


}

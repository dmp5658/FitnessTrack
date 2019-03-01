import { Component, OnInit } from '@angular/core';
import {InfoService} from '../info.service';
import {AuthService} from '../auth.service';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import {Router} from '@angular/router';

@Component({
  selector: 'app-add-weightinfo',
  templateUrl: './add-weightinfo.component.html',
  styleUrls: ['./add-weightinfo.component.css']
})
export class AddWeightinfoComponent  {

  constructor(private infoservice: InfoService,
              private authservice: AuthService,
              private router: Router) { }

  addweightForm = new FormGroup({
    currweight: new FormControl('', [Validators.required, Validators.pattern('\\d+\\.?\\d*')]),
    userid: new FormControl('')
  });

  onSubmit() {
    console.log(this.addweightForm.value);
    console.log(this.authservice.getUserId);
    this.addweightForm.patchValue({
      userid: this.authservice.getUserId
    });

    console.log(this.addweightForm.value);
    this.infoservice.createWeightEntry(this.addweightForm.value).subscribe((data) =>
      console.log('Data - ', data));

    this.router.navigate(['/']);
  }




}

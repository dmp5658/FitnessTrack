import { Component, OnInit } from '@angular/core';
import {InfoService} from '../info.service';
import {AuthService} from '../auth.service';
import {FormControl, FormGroup, Validators} from '@angular/forms';

@Component({
  selector: 'app-add-target',
  templateUrl: './add-target.component.html',
  styleUrls: ['./add-target.component.css']
})
export class AddTargetComponent {

  constructor(private infoservice: InfoService,
              private authservice: AuthService) { }

  addtargetForm = new FormGroup({
    targbench: new FormControl('', [Validators.required, Validators.pattern('\\d+\\.?\\d*')]),
    targsquat: new FormControl('', [Validators.required, Validators.pattern('\\d+\\.?\\d*')]),
    targcurl: new FormControl('', [Validators.required, Validators.pattern('\\d+\\.?\\d*')]),
    targlegpress: new FormControl('', [Validators.required, Validators.pattern('\\d+\\.?\\d*')]),
    targweight: new FormControl('', [Validators.required, Validators.pattern('\\d+\\.?\\d*')]),
    userid: new FormControl('')
  });

  onSubmit() {
    console.log(this.addtargetForm.value);
    console.log(this.authservice.getUserId);
    this.addtargetForm.patchValue({
      userid: this.authservice.getUserId
    });

    console.log(this.addtargetForm.value);
    this.infoservice.createTargetEntry(this.addtargetForm.value).subscribe((data) =>
      console.log('Data - ', data));
  }


}

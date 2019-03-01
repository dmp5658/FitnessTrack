import { Component, OnInit } from '@angular/core';
import {AuthService} from '../auth.service';
import {InfoService} from '../info.service';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {

  constructor(private authservice: AuthService,
              private infoservice: InfoService) { }

  ngOnInit() {
    if (this.authservice.isAuthenticated) {
      this.infoservice.getLiftEntrys(this.authservice.getUserId).subscribe((data) => {
        console.log('Lift - ', data);
      });
      this.infoservice.getWeightEntrys(this.authservice.getUserId).subscribe((data) => {
        console.log('Weight - ', data);
      });
      this.infoservice.getTargetEntrys(this.authservice.getUserId).subscribe((data) => {
        console.log('Weight - ', data);
      });
    }
  }

}

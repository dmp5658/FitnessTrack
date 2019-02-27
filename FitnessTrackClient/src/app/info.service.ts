import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class InfoService {

  weightUrl = 'http://localhost:54476/api/WeightInfo/';
  liftUrl = 'http://localhost:54476/api/LiftInfo/';
  targetUrl = 'http://localhost:54476/api/LiftInfo/';


  constructor(private http: HttpClient) { }

  createWeightEntry(weight) {
    return this.http.post(this.weightUrl, weight);
  }

  createLiftEntry(lift) {
    return this.http.post(this.liftUrl, lift);
  }

  createTargetEntry(target) {
    return this.http.post(this.targetUrl, target);
  }
}

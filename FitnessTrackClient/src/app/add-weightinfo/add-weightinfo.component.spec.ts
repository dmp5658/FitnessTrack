import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddWeightinfoComponent } from './add-weightinfo.component';
import {expect} from '@angular/platform-browser/testing/src/matchers';
import {describe} from '@angular/core/testing/src/testing_internal';

describe('AddWeightinfoComponent', () => {
  let component: AddWeightinfoComponent;
  let fixture: ComponentFixture<AddWeightinfoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddWeightinfoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddWeightinfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddWeightinfoComponent } from './add-weightinfo.component';

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

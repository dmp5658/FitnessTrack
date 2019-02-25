import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WeightinfoComponent } from './weightinfo.component';

describe('WeightinfoComponent', () => {
  let component: WeightinfoComponent;
  let fixture: ComponentFixture<WeightinfoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WeightinfoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WeightinfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

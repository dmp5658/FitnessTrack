import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LiftinfoComponent } from './liftinfo.component';

describe('LiftinfoComponent', () => {
  let component: LiftinfoComponent;
  let fixture: ComponentFixture<LiftinfoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LiftinfoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LiftinfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

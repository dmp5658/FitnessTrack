import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddLiftinfoComponent } from './add-liftinfo.component';

describe('AddLiftinfoComponent', () => {
  let component: AddLiftinfoComponent;
  let fixture: ComponentFixture<AddLiftinfoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddLiftinfoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddLiftinfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

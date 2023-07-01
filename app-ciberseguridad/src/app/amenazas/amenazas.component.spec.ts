import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AmenazasComponent } from './amenazas.component';

describe('AmenazasComponent', () => {
  let component: AmenazasComponent;
  let fixture: ComponentFixture<AmenazasComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AmenazasComponent]
    });
    fixture = TestBed.createComponent(AmenazasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

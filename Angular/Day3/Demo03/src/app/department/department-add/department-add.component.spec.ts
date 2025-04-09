import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DepartmentAddComponent } from './department-add.component';

describe('DepartmentAddComponent', () => {
  let component: DepartmentAddComponent;
  let fixture: ComponentFixture<DepartmentAddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DepartmentAddComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DepartmentAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

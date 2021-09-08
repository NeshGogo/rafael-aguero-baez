import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Observable } from 'rxjs';
import { Genders, User } from 'src/app/models/user';
import { Department } from 'src/app/models/department';

import { DepartmentService } from 'src/app/services/department.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-user-form',
  templateUrl: './user-form.component.html',
  styleUrls: ['./user-form.component.css'],
})
export class UserFormComponent implements OnInit {
  @Output() inserted = new EventEmitter();
  readonly cedulaMask = '000-0000000-0';
  genders = Object.values(Genders);
  departments$: Observable<Department[]> | undefined;

  form: FormGroup = this.formbuilder.group({
    fullName: [null, [Validators.required]],
    cedula: [null, [Validators.required]],
    gender: 'Masculino',
    birthDate: [null],
    position: [null, [Validators.required]],
    immediateSupervisor: [null],
    departmentId: ['', [Validators.required]],
  });

  constructor(
    private formbuilder: FormBuilder,
    private userService: UserService,
    private departmentService: DepartmentService
  ) {}

  ngOnInit(): void {
    this.departments$ = this.departmentService.get();
  }

  send(event: Event) {
    event.preventDefault();
    if (!this.form.valid) return this.form.markAsTouched();
    const user: User = this.form.value;
    console.log(user);
    this.userService.set(user).subscribe((user) => this.inserted.emit(user));
    //this.form.reset();
  }

  public get fullNameField(): AbstractControl | null {
    return this.form.get('fullName');
  }

  public get cedulaField(): AbstractControl | null {
    return this.form.get('cedula');
  }

  public get positionField(): AbstractControl | null {
    return this.form.get('position');
  }

  public get departmentField(): AbstractControl | null {
    return this.form.get('departmentId');
  }
}

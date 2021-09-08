import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import {Department} from '../models/department';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {
  private readonly URL = `${environment.API}/departments`;

  constructor(private http: HttpClient) {}

  get(): Observable<Department[]> {
    return this.http.get<Department[]>(this.URL);
  }

  set(department: Department): Observable<Department> {
    return this.http.post<Department>(this.URL, department);
  }
}

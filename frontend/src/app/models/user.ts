import { Department } from "./department";

export interface User {
  id?: number;
  fullName: string;
  cedula: string;
  gender: Genders;
  birthDate?: Date;
  position: string;
  immediateSupervisor?: string;
  departmentId: string;
  department?: Department
}

export enum Genders {
  male = 'Masculino',
  female = 'Femenino'
}
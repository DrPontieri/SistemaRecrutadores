import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AngularRecrutadores } from './angular-recrutadores.model';

@Injectable({
  providedIn: 'root'
})
export class AngularRecrutadoresService {

  constructor(private http:HttpClient) { }
  formData: AngularRecrutadores = new AngularRecrutadores();
}

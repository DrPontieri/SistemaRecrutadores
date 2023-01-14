import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AngularRecrutadores } from './angular-recrutadores.model';

@Injectable({
  providedIn: 'root'
})
export class AngularRecrutadoresService {

  readonly UrlApi="https://localhost:7274/api/Users";

  constructor(private http:HttpClient) { }
  formData: AngularRecrutadores = new AngularRecrutadores();

  PostUsers(){

    const headers = new Headers();
        headers.append('Access-Control-Allow-Headers', 'Content-Type');
        headers.append('Access-Control-Allow-Methods', '*');
        headers.append('Access-Control-Allow-Origin', '*');
        headers.append('Access-Control-Allow-Headers', '*');

console.log(headers);

    return this.http.post(this.UrlApi, this.formData);
  }
}

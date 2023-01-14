import { Component,  OnInit } from '@angular/core';
import { AngularRecrutadoresService } from 'src/app/shared/angular-recrutadores.service'
import { AngularRecrutadores } from 'src/app/shared/angular-recrutadores.model';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-angular-recrutadores-form',
  templateUrl: './angular-recrutadores-form.component.html',
  styleUrls: ['./angular-recrutadores-form.component.css']
})
export class AngularRecrutadoresFormComponent {

  constructor(public service:AngularRecrutadoresService){}
  ngOnInit(): void {}

  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new AngularRecrutadores();
  }

  onSubmit(form:NgForm){
    this.service.PostUsers().subscribe(
      res => {

      },
      err => {
          console.log("err");
      });
  }

}

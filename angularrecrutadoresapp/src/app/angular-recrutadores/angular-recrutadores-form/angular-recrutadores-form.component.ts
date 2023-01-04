import { ImplicitReceiver } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { AngularRecrutadoresService } from 'src/app/shared/angular-recrutadores.service';

@Component({
  selector: 'app-angular-recrutadores-form',
  templateUrl: './angular-recrutadores-form.component.html',
  styleUrls: ['./angular-recrutadores-form.component.css']
})
export class AngularRecrutadoresFormComponent implements OnInit {
  //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
  //Add 'implements OnInit' to the class.
      constructor(public service:AngularRecrutadoresService){}
      ngOnInit(): void {}
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.
    }

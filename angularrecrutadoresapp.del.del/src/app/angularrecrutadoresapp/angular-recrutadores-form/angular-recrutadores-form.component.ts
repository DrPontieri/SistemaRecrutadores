import { Component, OnInit} from '@angular/core';
import { AngularRecrutadoresService } from 'src/app/shared/angular-recrutadores.service';

@Component({
  selector: 'app-angular-recrutadores-form',
  templateUrl: './angular-recrutadores-form.component.html',
  styleUrls: ['./angular-recrutadores-form.component.css']
})
export class AngularRecrutadoresFormComponent implements OnInit {
  constructor(public service:AngularRecrutadoresService){}
  ngOnInit(): void {}
}

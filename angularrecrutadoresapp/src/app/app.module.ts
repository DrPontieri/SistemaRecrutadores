import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { AngularRecrutadoresComponent } from './angular-recrutadores/angular-recrutadores.component';
import { AngularRecrutadoresFormComponent } from './angular-recrutadores/angular-recrutadores-form/angular-recrutadores-form.component';




@NgModule({
  declarations: [
    AppComponent,
    AngularRecrutadoresComponent,
    AngularRecrutadoresFormComponent
  ],
  imports: [
    FormsModule,
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

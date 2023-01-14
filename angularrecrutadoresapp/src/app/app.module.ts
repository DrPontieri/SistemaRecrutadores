import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { AngularRecrutadoresComponent } from './angular-recrutadores/angular-recrutadores.component';
import { AngularRecrutadoresFormComponent } from './angular-recrutadores/angular-recrutadores-form/angular-recrutadores-form.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms'
import { NgForm } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    AngularRecrutadoresComponent,
    AngularRecrutadoresFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

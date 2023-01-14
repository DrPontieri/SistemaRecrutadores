import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { AngularrecrutadoresappComponent } from './angularrecrutadoresapp/angularrecrutadoresapp.component';
import { AngularRecrutadoresFormComponent } from './angularrecrutadoresapp/angular-recrutadores-form/angular-recrutadores-form.component';

@NgModule({
  declarations: [
    AppComponent,
    AngularrecrutadoresappComponent,
    AngularRecrutadoresFormComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

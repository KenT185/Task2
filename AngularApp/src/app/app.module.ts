import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import {HttpClientModule} from '@angular/common/http';
import { MatTableModule } from "@angular/material";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContactComponent } from './contact/contact.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { MainNavComponent } from './main-nav/main-nav.component';
import { AddressFieldComponent } from './address-field/address-field.component';

@NgModule({
  declarations: [
    AppComponent,
    ContactComponent,
    MainNavComponent,
    AddressFieldComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatTableModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NgxMaskModule, IConfig } from 'ngx-mask'

import { AppComponent } from './app.component';
import { UserFormComponent } from './components/user/user-form/user-form.component';
import { HomeComponent } from './components/home/home.component';
import { UserItemComponent } from './components/user/user-item/user-item.component';
import { UserItemListComponent } from './components/user/user-item-list/user-item-list.component';

export const options: Partial<IConfig> | (() => Partial<IConfig> ) | null = null;

@NgModule({
  declarations: [
    AppComponent,
    UserFormComponent,
    HomeComponent,
    UserItemComponent,
    UserItemListComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgxMaskModule.forRoot(),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

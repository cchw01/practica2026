import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule,RoutingComponents } from './app-routing-module';
import { App } from './app';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule} from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';

@NgModule({
  declarations: [App, RoutingComponents],
  imports: [BrowserModule, 
    AppRoutingModule, 
    MatTableModule, 
    MatPaginatorModule, 
    MatSortModule, 
    MatCheckboxModule, 
    FormsModule, 
    ReactiveFormsModule,
    MatInputModule],
  providers: [provideBrowserGlobalErrorListeners()],
  bootstrap: [App],
})
export class AppModule {}

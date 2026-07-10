import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddItem } from './menu-items/add-item/add-item';
import { Contact } from './menu-items/contact/contact';
import { Inventory } from './menu-items/inventory/inventory';
import { Scan } from './menu-items/scan/scan';
import { HomePage } from './menu-items/home-page/home-page';
import { ShowItem } from './menu-items/show-item/show-item';

const routes: Routes = [
  { path: '', component: HomePage },
  { path: 'add-item', component: AddItem },
  { path: 'edit/:id', component: AddItem },
  { path: 'contact', component: Contact },
  { path: 'inventory', component: Inventory },
  { path: 'scan', component: Scan },
  { path: 'item/:id', component: ShowItem }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const RoutingComponents = [HomePage, AddItem, Contact, Inventory, Scan, ShowItem];
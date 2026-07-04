import { Component, OnInit, viewChild, ViewChild } from '@angular/core';
import { InventoryItem } from '../../app-logic/inventory-item';
import { InventoryListMock } from '../../app-logic/inventory-list-mock';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { SelectionModel } from '@angular/cdk/collections';

@Component({
  selector: 'app-inventory',
  standalone: false,
  templateUrl: './inventory.html',
  styleUrl: './inventory.css',
})
export class Inventory implements OnInit {
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator | undefined;
  @ViewChild(MatSort, {static: true}) sort: MatSort | undefined;
  inventoryItems: any;
  inventoryColumns: string[] =[
    'select',
    'id',
    'name',
    'description',
    'user',
    'location',
    'inventoryNumber',
    'createdAt',
    'modifiedAt',
    'deleted',
    'actions'
  ];
  selection = new SelectionModel<Element>(true, []);

  constructor(private inventoryListMock: InventoryListMock) {
    this.inventoryItems = [];
  }
  ngOnInit(): void {
    this.inventoryItems = new MatTableDataSource<InventoryItem>(this.inventoryListMock.getData());
    this.inventoryItems.paginator = this.paginator;
    this.inventoryItems.sort = this.sort;
  }

  masterToggle(){
    this.isAllSelected() 
    ? this.selection.clear() 
    : this.inventoryItems.data.forEach((row: Element) => 
      {this.selection.select(row)});
  }

  isAllSelected(): boolean {
    const numSelected = this.selection.selected.length;
    const numRows = this.inventoryItems.data.length;
    return numSelected === numRows;
  }
   
}

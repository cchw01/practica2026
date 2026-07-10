import { Component, OnInit } from '@angular/core';
import { InventoryItem } from '../../app-logic/inventory-item';
import { ActivatedRoute, Router } from '@angular/router';
import {InventoryListMock} from '../../app-logic/inventory-list-mock';

@Component({    
  selector: 'app-show-item',
  standalone: false,
  templateUrl: './show-item.html',
  styleUrls: ['./show-item.css']  ,
})
export class ShowItem implements OnInit {
  itemId!: number;
  item!: InventoryItem;
  itemFound = false;

  constructor(
    private router: Router,
    private activatedRoute: ActivatedRoute,
    private inventoryListMock: InventoryListMock
  ){
    this.activatedRoute.params.subscribe((params) => {
      this.itemId = params['id'] ?? 0;
    });
  }
  ngOnInit(): void {
    this.inventoryListMock.getItemById(this.itemId).subscribe((data) =>
    {
      this.item = data;
      this.itemFound = this.item != null;
    });
  }

  editItem(): void {
    this.router.navigate(['/edit', this.itemId]);
  }
  
}

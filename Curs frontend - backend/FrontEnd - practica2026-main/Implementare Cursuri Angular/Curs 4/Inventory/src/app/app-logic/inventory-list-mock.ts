import { Injectable } from '@angular/core';
import { InventoryItem } from './inventory-item';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class InventoryListMock {
 
  inventoryData: Array<InventoryItem> = [];
  
  constructor(private httpClient: HttpClient) {}

  private apiUrl= 'https://localhost:7024/api/InventoryItem'

  getData(): Observable<Array<InventoryItem>> {
    return this.httpClient.get<Array<InventoryItem>>(this.apiUrl);
  }

  getLastId(): number {
    return this.inventoryData[this.inventoryData.length - 1].id;
  }

  addItem(item: InventoryItem): void {
    this.httpClient.post<InventoryItem>(this.apiUrl,item).subscribe((data) =>{
      console.log(data);
    })
  }

  // getItemById(id: number): InventoryItem {
  //   return this.inventoryData.filter((item) => item.id == id)[0];
  // }

  updateItem(item: InventoryItem): void {
    this.httpClient.put<InventoryItem>(this.apiUrl,item).subscribe((data) =>{
      console.log(data);
    });
  }

  getItemById(id: number): Observable<InventoryItem> {
    return this.httpClient.get<InventoryItem>(`${this.apiUrl}/${id}`);
  }

}

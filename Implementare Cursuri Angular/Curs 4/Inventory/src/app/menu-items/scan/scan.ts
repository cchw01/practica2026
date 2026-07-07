import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ScannerQRCodeResult } from 'ngx-scanner-qrcode';

@Component({
  selector: 'app-scan',
  standalone: false,
  templateUrl: './scan.html',
  styleUrl: './scan.css',
})
export class Scan {
  constructor(private router:Router) {}

  public onEvent(result: ScannerQRCodeResult[],action?:any): void {
    console.log('Scanned something', result);
    
      this.router.navigate(['/item', result[0].value]);
    
  }

}

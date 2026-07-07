import { Injectable } from '@angular/core';
import { ContactData } from './contact-data';

@Injectable({
  providedIn: 'root',
})
export class ContactProvider {
  private contactData: ContactData = {
    info: 'Storage unit in Brasov, CORESI',
    phone: 'Turnului, nr. 5',
    openDays: 'Monday - Friday',
    timeSlots: '9.00 - 17.00',
    address: '0747212321',
  };

  getContactData(): ContactData {
    return this.contactData;
  }

}

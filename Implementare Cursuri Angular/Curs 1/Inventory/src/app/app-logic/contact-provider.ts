import { Injectable } from '@angular/core';
import { ContactData } from './contact-data';

@Injectable({
  providedIn: 'root',
})
export class ContactProvider {
  providedData = <ContactData>{
    info: 'We are a company that provides high-quality products and services to our customers.',
    phone: '+1 (555) 123-4567',
    openDays: 'Monday - Friday',
    timeSlot: '9:00 AM - 5:00 PM',
    address: '123 Main Street, Anytown, USA',
  };

  getContactData(): ContactData {
    return this.providedData;
  }
}

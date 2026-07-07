import { Component } from '@angular/core';
import { ContactData } from '../../app-logic/contact-data';
import { ContactProvider } from '../../app-logic/contact-provider';

@Component({
  selector: 'app-contact',
  standalone: false,
  templateUrl: './contact.html',
})
export class Contact {
  contactData?: ContactData;

  constructor(private contactProvider: ContactProvider) {
    this.contactData = this.contactProvider.getContactData();
  }
}


import { TestBed } from '@angular/core/testing';

import { ContactPrvider } from './contact-prvider';

describe('ContactPrvider', () => {
  let service: ContactPrvider;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ContactPrvider);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

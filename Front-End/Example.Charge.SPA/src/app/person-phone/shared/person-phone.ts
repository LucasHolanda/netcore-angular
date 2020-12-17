import { Person } from './person';
import { PhoneNumberType } from './phone-number-type';

export class PersonPhone {
    businessEntityID: number = 0;
    phoneNumber: string = '';
    phoneNumberTypeID: number = 0;
    person = Person;
    phoneNumberType = PhoneNumberType;
}

import { Component, OnInit } from '@angular/core';

import { PersonPhoneService } from './person-phone/shared/person-phone.service';
import { PhoneNumberTypeService } from './person-phone/shared/phone-number-type.service';
import { Person } from './person-phone/shared/person';
import { PersonPhone } from './person-phone/shared/person-phone';
import { PhoneNumberType } from './person-phone/shared/phone-number-type';

import { NgForm } from '@angular/forms';

import Swal from 'sweetalert2'
import 'sweetalert2/src/sweetalert2.scss'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  newTeste = {};
  personPhone = {} as PersonPhone;

  persons: Person[] = [];
  personPhones: PersonPhone[] = [];
  phoneNumberTypes: PhoneNumberType[] = [];

  constructor(private personPhoneService: PersonPhoneService, private phoneNumberTypeService: PhoneNumberTypeService) { }

  ngOnInit() {
    this.getAllPersons();
    this.getAllPersonPhone();
    this.getAllPhoneNumberType();
  }

  successMessage() {
    Swal.fire({
      title: 'Salvo!',
      text: 'Os dados foram gravados com sucesso!',
      icon: 'success',
      confirmButtonText: 'Ok'
    })
  }

  errorMessage(msg: string) {
    Swal.fire({
      title: 'Atenção!',
      text: msg,
      icon: 'warning',
      confirmButtonText: 'Ok'
    })
  }

  // defini se será criado ou atualizado
  savePersonPhone(form: NgForm) {
    var idAndTypeExists = Array.from(this.personPhones).filter((value) => {
      return value.businessEntityID == this.personPhone.businessEntityID
        && value.phoneNumberTypeID == this.personPhone.phoneNumberTypeID
    }).length;

    var numberExists = Array.from(this.personPhones).filter((value) => {
      return value.phoneNumber == this.personPhone.phoneNumber;
    }).length;

    if (numberExists) {
      this.errorMessage("Este número de telefone já existe! Verifique os dados e tente novamente.");
      return;
    }

    if (idAndTypeExists) {
      this.personPhoneService.update(this.personPhone).subscribe(() => {
        this.cleanForm(form);
        this.successMessage();
      });
    } else {
      this.personPhoneService.insert(this.personPhone).subscribe(() => {
        this.cleanForm(form);
        this.successMessage();
      });
    }
  }

  // Chama o serviço para obtém todos
  getAllPersons() {
    this.personPhoneService.getAllPersons().subscribe(response => {
      this.persons = response.data.personObjects;
    });
  }

  // Chama o serviço para obtém todos
  getAllPersonPhone() {
    this.personPhoneService.getAll().subscribe(response => {
      this.personPhones = response.data.personObjects;
    });
  }

  // Chama o serviço para obtém todos
  getAllPhoneNumberType() {
    this.phoneNumberTypeService.getAll().subscribe(response => {
      this.phoneNumberTypes = response.data.phoneNumberTypeObjects;
    });
  }

  // deleta
  deletePersonPhone(id: number, idType: number) {
    this.personPhoneService.delete(id, idType).subscribe(() => {
      this.successMessage();
      this.getAllPersonPhone();
    });
  }

  // copia ara ser editado.
  editPersonPhone(personPhone: PersonPhone) {
    this.personPhone = { ...personPhone };
  }

  // limpa o formulario
  cleanForm(form: NgForm) {
    this.getAllPersonPhone();
    form.resetForm();
    this.personPhone = {} as PersonPhone;
  }
}

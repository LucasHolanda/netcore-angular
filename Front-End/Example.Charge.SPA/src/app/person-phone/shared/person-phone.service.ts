import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';

import { PersonPhone } from './person-phone';

@Injectable({
  providedIn: 'root'
})
export class PersonPhoneService {
  constructor(private httpClient: HttpClient) { }

  baseUrlDocker = 'http://localhost:32770';
  baseUrlDotNetRun = 'http://localhost:5000';
  baseUrl = this.baseUrlDotNetRun;

  url = `${this.baseUrl}/api/personphone`;
  urlPerson = `${this.baseUrl}/api/person`;
  // Headers
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    })
  }

  getAllPersons(): Observable<any> {
    return this.httpClient.get<any>(this.urlPerson)
    .pipe(
      retry(2),
      catchError(this.handleError))
  }

  // Obtem todos
  getAll(): Observable<any> {
    return this.httpClient.get<any>(this.url)
      .pipe(
        retry(2),
        catchError(this.handleError))
  }

  // salva
  insert(personPhone: PersonPhone): Observable<any> {
    return this.httpClient.post<any>(this.url, JSON.stringify(personPhone), this.httpOptions)
      .pipe(
        retry(2),
        catchError(this.handleError)
      )
  }

  // utualiza
  update(personPhone: PersonPhone): Observable<any> {
    return this.httpClient.put<any>(this.url, JSON.stringify(personPhone), this.httpOptions)
      .pipe(
        retry(1),
        catchError(this.handleError)
      )
  }

  // deleta 
  delete(id: number, idType: number) {
    return this.httpClient.delete<any>(this.url + '/' + id + '/' + idType, this.httpOptions)
      .pipe(
        retry(1),
        catchError(this.handleError)
      )
  }

  // Manipulação de erros
  handleError(error: HttpErrorResponse) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Erro ocorreu no lado do client
      errorMessage = error.error.message;
    } else {
      // Erro ocorreu no lado do servidor
      errorMessage = `Código do erro: ${error.status}, ` + `menssagem: ${error.message}`;
    }
    console.log(errorMessage);
    return throwError(errorMessage);
  };
}

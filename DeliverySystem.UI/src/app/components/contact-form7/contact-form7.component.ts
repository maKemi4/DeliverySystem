import { Component, Input } from '@angular/core'
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {NgForm} from '@angular/forms';
import { DeliveryRequestCreateModel } from 'src/app/models/deliveryRequestCreateModel';
import { Router } from '@angular/router';

@Component({
  selector: 'contact-form7',
  templateUrl: 'contact-form7.component.html',
  styleUrls: ['contact-form7.component.css'],
})
export class ContactForm7 {
  @Input()
  content1: string = 'Заповніть форму'
  @Input()
  phone: string = 'Ваш номер телефону'
  @Input()
  address: string = 'Наша адреса: вул. Поштова, 1, м. Київ, Україна'
  @Input()
  content2: string = "Ми зв'яжемося з вами найближчим часом"
  @Input()
  action: string = 'Надіслати заявку'
  @Input()
  heading1: string = 'Заповніть заявку'
  @Input()
  email: string = 'Ваша електронна пошта'
  
  private readonly baseUrl = 'http://localhost:5159/DeliveryQueue';
  request: DeliveryRequestCreateModel;

  constructor(private http: HttpClient, private router: Router) {
    this.request = new DeliveryRequestCreateModel();
  }

  onSubmit(){
    const httpOptions = {
      headers: new HttpHeaders({'Content-Type': 'application/json'})
    }

    var json = JSON.stringify(this.request, (key, value) => {
      if (!isNaN(value) && key != "phoneNum")
          value = Number(value)
      return value
    });

    this.http.post(this.baseUrl, json, httpOptions).subscribe(next =>{
      this.router.navigate(['/services']);
    },
    error => {
     console.log(error);
    });
  }
}

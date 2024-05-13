import { Component, Input } from '@angular/core'

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
  constructor() {}

  
}

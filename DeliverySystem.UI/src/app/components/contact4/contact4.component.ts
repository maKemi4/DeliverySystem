import { Component, Input } from '@angular/core'

@Component({
  selector: 'app-contact4',
  templateUrl: 'contact4.component.html',
  styleUrls: ['contact4.component.css'],
})
export class Contact4 {
  @Input()
  phone1: string = 'Ходарченко Артем Андрійович'
  @Input()
  content3: string = 'hodarikoff@gmail.com'
  @Input()
  content1: string = 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. '
  @Input()
  heading1: string = 'Контакти'
  @Input()
  content5: string =
    'Оргінізація: Київський політехнічний інститут імені Ігоря Сікорського'
  @Input()
  content4: string = '+380992166290'
  @Input()
  address1: string =
    'Київський політехнічний інститут імені Ігоря Сікорського. Берестейський проспект, 37, Київ'
  @Input()
  textareaPlaceholder: string = 'placeholder'
  @Input()
  email1: string = 'КОн'
  @Input()
  content2: string = 'Get in touch with us today!'
  constructor() {}
}

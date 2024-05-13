import { Component, Input } from '@angular/core'

@Component({
  selector: 'app-navbar4',
  templateUrl: 'navbar4.component.html',
  styleUrls: ['navbar4.component.css'],
})
export class Navbar4 {
  @Input()
  action1: string = 'Зареєструватися'
  @Input()
  action2: string = 'Увійти'
  @Input()
  logoAlt: string = 'Medical Volunteers Platform'
  @Input()
  link4: string = 'Відгуки'
  @Input()
  link3: string = 'Сервіси'
  @Input()
  link2: string = 'Про нас'
  @Input()
  link1: string = 'Головна'
  @Input()
  link5: string = 'Контакти'
  @Input()
  logoSrc: string =
    'https://aheioqhobo.cloudimg.io/v7/_playground-bucket-v2.teleporthq.io_/84ec08e8-34e9-42c7-9445-d2806d156403/fac575ac-7a41-484f-b7ac-875042de11f8?org_if_sml=1&force_format=original'
  constructor() {}
}

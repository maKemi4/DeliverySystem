import { Component, Input } from '@angular/core'

@Component({
  selector: 'app-hero3',
  templateUrl: 'hero3.component.html',
  styleUrls: ['hero3.component.css'],
})
export class Hero3 {
  @Input()
  content1: string =
    'Оптимізуйте управління медичними волонтерами за допомогою нашої платформи'
  @Input()
  action2: string = 'Увійти'
  @Input()
  image1Alt: string = 'Medical volunteers working together'
  @Input()
  heading1: string = 'Ефективне управління медичними волонтерами'
  @Input()
  image1Src: string =
    'https://images.unsplash.com/photo-1645930899879-7492afcbbec4?ixid=M3w5MTMyMXwwfDF8c2VhcmNofDM0fHxVa3JhaW5pYW4lMjB3YXJ8ZW58MHx8fHwxNzE1NDI5OTg0fDA&ixlib=rb-4.0.3&w=1500'
  @Input()
  action1: string = 'Дізнатися більше'
  constructor() {}
}

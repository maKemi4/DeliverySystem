import { Component, Input } from '@angular/core'

@Component({
  selector: 'app-features18',
  templateUrl: 'features18.component.html',
  styleUrls: ['features18.component.css'],
})
export class Features18 {
  @Input()
  feature1ImageAlt: string =
    'Отримуйте швидку та ефективну допомогу від волонтерів, залишаючи відгук для наступних клієнтів.'
  @Input()
  feature1Slogan: string = 'Streamline your volunteer coordination'
  @Input()
  feature1Description: string =
    'Отримуйте швидку та ефективну допомогу від волонтерів, залишаючи відгук для наступних клієнтів.'
  @Input()
  feature1Title: string = 'Отримання допомоги'
  @Input()
  feature1ImageSrc: string = '/assets/1538564-1400w.webp'
  constructor() {}
}

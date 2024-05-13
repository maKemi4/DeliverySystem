import { Component, Input } from '@angular/core'

@Component({
  selector: 'app-stats21',
  templateUrl: 'stats21.component.html',
  styleUrls: ['stats21.component.css'],
})
export class Stats21 {
  @Input()
  image1Src: string =
    'https://images.unsplash.com/photo-1588616110049-c896a9994669?ixid=M3w5MTMyMXwwfDF8c2VhcmNofDF8fFVrcmFpbmlhbiUyMHxlbnwwfHx8fDE3MTU1MTQwNTF8MA&ixlib=rb-4.0.3&w=1400'
  @Input()
  stat2Description: string = 'Total number of requests submitted by users'
  @Input()
  stat1: string = 'Система для управління медичною волонтерьскою діяльністю'
  @Input()
  stat4Description: string =
    'Total number of requests successfully completed by volunteers'
  @Input()
  text: string =
    'Дана система була створена для ефективного управління медичною волонтерською діяльністю. Доступні функції системи: Створення та оброблення заявок, побудова оптимального маршуту, перегляд створених заявок, вибір серед побудованих маршутів - найопитимальнішого.'
  @Input()
  stat3Description: string =
    'Total number of volunteers available to assist with requests'
  @Input()
  stat3: string = 'Volunteers Available'
  @Input()
  heading1: string = 'Про нас'
  @Input()
  content2: string = 'Example value for content2'
  @Input()
  image1Alt: string = 'Image description for stat1'
  @Input()
  stat2: string = '500+'
  @Input()
  text1: string =
    "В основу даної системи покладена задача Комівояжера, розв'язок критеріальних черг, попарне порівняння шляхів, тощо."
  @Input()
  textareaPlaceholder: string = 'placeholder'
  @Input()
  stat4: string = 'Requests Completed'
  @Input()
  content1: string = '1000+'
  @Input()
  stat1Description: string = 'The total count of requests submitted by users'
  constructor() {}
}

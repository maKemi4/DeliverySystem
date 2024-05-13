import { Component, Input } from '@angular/core'

@Component({
  selector: 'app-hero81',
  templateUrl: 'hero81.component.html',
  styleUrls: ['hero81.component.css'],
})
export class Hero81 {
  @Input()
  heading1: string = 'Тут містяться всі створені заявки:'
  @Input()
  content1: string =
    'Easily request assistance and receive quick help from volunteers.'
  @Input()
  action2: string = 'Learn More'
  @Input()
  image1Src: string =
    'https://images.unsplash.com/photo-1661752545218-5c4c4ce14d6b?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w5MTMyMXwwfDF8cmFuZG9tfHx8fHx8fHx8MTcxNTUxMzA1NXw&ixlib=rb-4.0.3&q=80&w=1080'
  @Input()
  action1: string = 'Request Assistance'
  @Input()
  image1Alt: string = 'Volunteer helping a person in need'
  constructor() {}
}

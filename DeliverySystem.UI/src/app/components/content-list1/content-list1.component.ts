import { Component, Input } from '@angular/core'

@Component({
  selector: 'content-list1',
  templateUrl: 'content-list1.component.html',
  styleUrls: ['content-list1.component.css'],
})
export class ContentList1 {
  @Input()
  text: string = 'Text'
  @Input()
  content3: string = 'Build optimal routes for aid delivery'
  @Input()
  heading4: string = 'Manage Medical Volunteers'
  @Input()
  content2: string = 'Receive quick help from volunteers'
  @Input()
  content5: string = ''
  @Input()
  content6: string = ''
  @Input()
  heading6: string = ''
  @Input()
  content1: string = 'Easily submit assistance requests'
  @Input()
  heading5: string = ''
  @Input()
  heading2: string = 'Fast Volunteer Assistance'
  @Input()
  content4: string = 'Efficiently coordinate medical volunteers'
  @Input()
  heading3: string = 'Optimal Delivery Routes'
  @Input()
  heading1: string = 'Content List'
  constructor() {}
}

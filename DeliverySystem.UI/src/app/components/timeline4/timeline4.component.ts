import { Component, Input } from '@angular/core'

@Component({
  selector: 'app-timeline4',
  templateUrl: 'timeline4.component.html',
  styleUrls: ['timeline4.component.css'],
})
export class Timeline4 {
  @Input()
  card4Action1: string = 'Відк'
  @Input()
  card2Heading: string = 'Receive Volunteer Support'
  @Input()
  card1Content: string = 'Users can fill out a form to request assistance.'
  @Input()
  action1: string = 'Primary action'
  @Input()
  card1Heading: string = 'Submit Assistance Request'
  @Input()
  card1Action1: string = 'Fill out form'
  @Input()
  card2Action2: string = 'Volunteer opportunities'
  @Input()
  card3Heading: string = 'Optimize Volunteer Management'
  @Input()
  card4Content: string =
    'Constantly improve the platform and services based on feedback and evaluation.'
  @Input()
  card4Action2: string = 'Platform updates'
  @Input()
  card2Action1: string = 'Get help from volunteers'
  @Input()
  card4Heading: string = 'Continuous Improvement'
  @Input()
  date2: string = 'February 2022'
  @Input()
  card3Content: string =
    'Efficiently manage and coordinate volunteers for better assistance delivery.'
  @Input()
  title1: string = 'Відгуки від користувачів та волонтерів'
  @Input()
  card1Action2: string = 'Learn more'
  @Input()
  action2: string = 'Seconday action'
  @Input()
  date3: string = 'March 2022'
  @Input()
  date4: string = 'April 2022'
  @Input()
  card3Action2: string = 'Volunteer management tips'
  @Input()
  card2Content: string =
    'Volunteers provide quick assistance based on the requests.'
  @Input()
  card3Action1: string = 'Manage volunteers'
  @Input()
  date1: string = 'January 2022'
  @Input()
  content1: string =
    'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat'
  constructor() {}
}

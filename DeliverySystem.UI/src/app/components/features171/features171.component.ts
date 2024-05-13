import { Component, Input } from '@angular/core'

@Component({
  selector: 'app-features171',
  templateUrl: 'features171.component.html',
  styleUrls: ['features171.component.css'],
})
export class Features171 {
  @Input()
  feature1ImageSrc: string = '/assets/forms-workflow-1400w.png'
  @Input()
  feature1Description: string =
    'Легко оформлюйте заявки на допомогу, вказуючи лише потрібну інформацію.'
  @Input()
  feature1Slogan: string =
    'Efficiently organize and coordinate medical volunteers'
  @Input()
  feature1ImageAlt: string = 'Volunteer Management Image'
  @Input()
  rootClassName: string = ''
  @Input()
  feature1Title: string = 'Оформлення заявок'
  constructor() {}
}

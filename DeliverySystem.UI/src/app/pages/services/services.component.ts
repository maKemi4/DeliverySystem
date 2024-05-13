import { Component } from '@angular/core'
import { Title, Meta } from '@angular/platform-browser'

@Component({
  selector: 'app-services',
  templateUrl: 'services.component.html',
  styleUrls: ['services.component.css'],
})
export class Services {
  constructor(private title: Title, private meta: Meta) {
    this.title.setTitle('Services - Instructive Exemplary Salamander')
    this.meta.addTags([
      {
        property: 'og:title',
        content: 'Services - Instructive Exemplary Salamander',
      },
    ])
  }
}

import { Component } from '@angular/core'
import { Title, Meta } from '@angular/platform-browser'

@Component({
  selector: 'about-page',
  templateUrl: 'about-page.component.html',
  styleUrls: ['about-page.component.css'],
})
export class AboutPage {
  constructor(private title: Title, private meta: Meta) {
    this.title.setTitle('AboutPage - Instructive Exemplary Salamander')
    this.meta.addTags([
      {
        property: 'og:title',
        content: 'AboutPage - Instructive Exemplary Salamander',
      },
    ])
  }
}

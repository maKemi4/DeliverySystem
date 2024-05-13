import { Component } from '@angular/core'
import { Title, Meta } from '@angular/platform-browser'

@Component({
  selector: 'app-feedback',
  templateUrl: 'feedback.component.html',
  styleUrls: ['feedback.component.css'],
})
export class Feedback {
  constructor(private title: Title, private meta: Meta) {
    this.title.setTitle('Feedback - Instructive Exemplary Salamander')
    this.meta.addTags([
      {
        property: 'og:title',
        content: 'Feedback - Instructive Exemplary Salamander',
      },
    ])
  }
}

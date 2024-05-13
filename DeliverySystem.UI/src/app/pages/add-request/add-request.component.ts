import { Component } from '@angular/core'
import { Title, Meta } from '@angular/platform-browser'

@Component({
  selector: 'add-request',
  templateUrl: 'add-request.component.html',
  styleUrls: ['add-request.component.css'],
})
export class AddRequest {
  constructor(private title: Title, private meta: Meta) {
    this.title.setTitle('AddRequest - Instructive Exemplary Salamander')
    this.meta.addTags([
      {
        property: 'og:title',
        content: 'AddRequest - Instructive Exemplary Salamander',
      },
    ])
  }
}

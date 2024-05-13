import { Component } from '@angular/core'
import { Title, Meta } from '@angular/platform-browser'

@Component({
  selector: 'path-creating',
  templateUrl: 'path-creating.component.html',
  styleUrls: ['path-creating.component.css'],
})
export class PathCreating {
  constructor(private title: Title, private meta: Meta) {
    this.title.setTitle('PathCreating - Instructive Exemplary Salamander')
    this.meta.addTags([
      {
        property: 'og:title',
        content: 'PathCreating - Instructive Exemplary Salamander',
      },
    ])
  }
}

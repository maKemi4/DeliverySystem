import { Component } from '@angular/core'
import { Title, Meta } from '@angular/platform-browser'

@Component({
  selector: 'app-home',
  templateUrl: 'home.component.html',
  styleUrls: ['home.component.css'],
})
export class Home {
  constructor(private title: Title, private meta: Meta) {
    this.title.setTitle('Instructive Exemplary Salamander')
    this.meta.addTags([
      {
        property: 'og:title',
        content: 'Instructive Exemplary Salamander',
      },
    ])
  }
}

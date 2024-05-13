import { Component } from '@angular/core'
import { Title, Meta } from '@angular/platform-browser'

@Component({
  selector: 'get-the-orders',
  templateUrl: 'get-the-orders.component.html',
  styleUrls: ['get-the-orders.component.css'],
})
export class GetTheOrders {
  constructor(private title: Title, private meta: Meta) {
    this.title.setTitle('GetTheOrders - Instructive Exemplary Salamander')
    this.meta.addTags([
      {
        property: 'og:title',
        content: 'GetTheOrders - Instructive Exemplary Salamander',
      },
    ])
  }
}

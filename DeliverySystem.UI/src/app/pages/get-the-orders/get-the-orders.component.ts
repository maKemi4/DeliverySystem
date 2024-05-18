import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core'
import { Title, Meta } from '@angular/platform-browser'
import { Observable } from 'rxjs';
import { DeliveryRequestQueueItem } from 'src/app/models/deliveryRequestQueueItem';

@Component({
  selector: 'get-the-orders',
  templateUrl: 'get-the-orders.component.html',
  styleUrls: ['get-the-orders.component.css'],
})
export class GetTheOrders implements OnInit {
  private readonly baseUrl = 'http://localhost:5159/DeliveryQueue';
  items : DeliveryRequestQueueItem[];

  constructor(private title: Title, private meta: Meta, private http: HttpClient) {
    this.title.setTitle('GetTheOrders - Instructive Exemplary Salamander')
    this.meta.addTags([
      {
        property: 'og:title',
        content: 'GetTheOrders - Instructive Exemplary Salamander',
      },
    ])
  }

  ngOnInit() {
    this.getQueueItems().subscribe((items) => {
      console.log(items)
      this.items = items;
    });
  }

  getQueueItems(): Observable<DeliveryRequestQueueItem[]> {
    return this.http.get<DeliveryRequestQueueItem[]>(this.baseUrl);
  }
}

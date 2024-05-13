import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core'
import { RouterModule } from '@angular/router'
import { CommonModule } from '@angular/common'

import { ComponentsModule } from '../../components/components.module'
import { GetTheOrders } from './get-the-orders.component'

const routes = [
  {
    path: '',
    component: GetTheOrders,
  },
]

@NgModule({
  declarations: [GetTheOrders],
  imports: [CommonModule, ComponentsModule, RouterModule.forChild(routes)],
  exports: [GetTheOrders],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class GetTheOrdersModule {}

import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core'
import { RouterModule } from '@angular/router'
import { CommonModule } from '@angular/common'

import { ComponentsModule } from '../../components/components.module'
import { AddRequest } from './add-request.component'

const routes = [
  {
    path: '',
    component: AddRequest,
  },
]

@NgModule({
  declarations: [AddRequest],
  imports: [CommonModule, ComponentsModule, RouterModule.forChild(routes)],
  exports: [AddRequest],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class AddRequestModule {}

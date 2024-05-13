import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core'
import { RouterModule } from '@angular/router'
import { CommonModule } from '@angular/common'

import { ComponentsModule } from '../../components/components.module'
import { Services } from './services.component'

const routes = [
  {
    path: '',
    component: Services,
  },
]

@NgModule({
  declarations: [Services],
  imports: [CommonModule, ComponentsModule, RouterModule.forChild(routes)],
  exports: [Services],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class ServicesModule {}

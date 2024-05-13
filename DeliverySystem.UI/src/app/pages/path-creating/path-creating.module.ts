import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core'
import { RouterModule } from '@angular/router'
import { CommonModule } from '@angular/common'

import { ComponentsModule } from '../../components/components.module'
import { PathCreating } from './path-creating.component'

const routes = [
  {
    path: '',
    component: PathCreating,
  },
]

@NgModule({
  declarations: [PathCreating],
  imports: [CommonModule, ComponentsModule, RouterModule.forChild(routes)],
  exports: [PathCreating],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class PathCreatingModule {}

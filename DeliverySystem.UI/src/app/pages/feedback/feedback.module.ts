import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core'
import { RouterModule } from '@angular/router'
import { CommonModule } from '@angular/common'

import { ComponentsModule } from '../../components/components.module'
import { Feedback } from './feedback.component'

const routes = [
  {
    path: '',
    component: Feedback,
  },
]

@NgModule({
  declarations: [Feedback],
  imports: [CommonModule, ComponentsModule, RouterModule.forChild(routes)],
  exports: [Feedback],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class FeedbackModule {}

import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core'
import { RouterModule } from '@angular/router'
import { CommonModule } from '@angular/common'

import { ComponentsModule } from '../../components/components.module'
import { AboutPage } from './about-page.component'

const routes = [
  {
    path: '',
    component: AboutPage,
  },
]

@NgModule({
  declarations: [AboutPage],
  imports: [CommonModule, ComponentsModule, RouterModule.forChild(routes)],
  exports: [AboutPage],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class AboutPageModule {}

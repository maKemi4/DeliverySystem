import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core'
import { RouterModule } from '@angular/router'
import { CommonModule } from '@angular/common'
import { FormsModule }   from '@angular/forms';

import { Features18 } from './features18/features18.component'
import { ContactForm7 } from './contact-form7/contact-form7.component'
import { Stats21 } from './stats21/stats21.component'
import { Features171 } from './features171/features171.component'
import { Navbar4 } from './navbar4/navbar4.component'
import { Contact11 } from './contact11/contact11.component'
import { Hero3 } from './hero3/hero3.component'
import { FAQ1 } from './faq1/faq1.component'
import { ContentList1 } from './content-list1/content-list1.component'
import { Timeline4 } from './timeline4/timeline4.component'
import { Features17 } from './features17/features17.component'
import { Pricing62 } from './pricing62/pricing62.component'
import { Contact4 } from './contact4/contact4.component'

@NgModule({
  declarations: [
    Features18,
    ContactForm7,
    Stats21,
    Features171,
    Navbar4,
    Contact11,
    Hero3,
    FAQ1,
    ContentList1,
    Timeline4,
    Features17,
    Pricing62,
    Contact4
  ],
  imports: [CommonModule, RouterModule, FormsModule],
  exports: [
    Features18,
    ContactForm7,
    Stats21,
    Features171,
    Navbar4,
    Contact11,
    Hero3,
    FAQ1,
    ContentList1,
    Timeline4,
    Features17,
    Pricing62,
    Contact4
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class ComponentsModule {}

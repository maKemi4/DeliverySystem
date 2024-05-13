import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core'
import { RouterModule } from '@angular/router'
import { BrowserModule } from '@angular/platform-browser'

import { ComponentsModule } from './components/components.module'
import { AppComponent } from './app.component'

const routes = [
  {
    path: 'feedback',
    loadChildren: () =>
      import('./pages/feedback/feedback.module').then((m) => m.FeedbackModule),
  },
  {
    path: 'add-request',
    loadChildren: () =>
      import('./pages/add-request/add-request.module').then(
        (m) => m.AddRequestModule
      ),
  },
  {
    path: 'path-creating',
    loadChildren: () =>
      import('./pages/path-creating/path-creating.module').then(
        (m) => m.PathCreatingModule
      ),
  },
  {
    path: '',
    loadChildren: () =>
      import('./pages/home/home.module').then((m) => m.HomeModule),
  },
  {
    path: 'get-the-orders',
    loadChildren: () =>
      import('./pages/get-the-orders/get-the-orders.module').then(
        (m) => m.GetTheOrdersModule
      ),
  },
  {
    path: 'about-page',
    loadChildren: () =>
      import('./pages/about-page/about-page.module').then(
        (m) => m.AboutPageModule
      ),
  },
  {
    path: 'services',
    loadChildren: () =>
      import('./pages/services/services.module').then((m) => m.ServicesModule),
  },
  {
    path: '**',
    loadChildren: () =>
      import('./pages/not-found/not-found.module').then(
        (m) => m.NotFoundModule
      ),
  },
]

@NgModule({
  declarations: [AppComponent],
  imports: [BrowserModule, RouterModule.forRoot(routes), ComponentsModule],
  providers: [],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class AppModule {}

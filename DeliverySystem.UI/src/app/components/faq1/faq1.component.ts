import { Component, Input } from '@angular/core'

@Component({
  selector: 'app-faq1',
  templateUrl: 'faq1.component.html',
  styleUrls: ['faq1.component.css'],
})
export class FAQ1 {
  @Input()
  faq3Answer: string =
    'Доставка допомоги до населених пунктів грунтується на критеріях важливості заявки. Спочатку доставляється у найтерміновіші, а вже потім у всі інші.'
  @Input()
  faq3Question: string = 'Чи може бути таке, що місто не отримає допомогу?'
  @Input()
  content1: string =
    'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse varius enim in eros elementum tristique.'
  @Input()
  faq5Answer: string =
    'We offer training sessions and resources for volunteers to enhance their skills and knowledge in various medical areas.'
  @Input()
  heading1: string = 'Запитаня та відповіді'
  @Input()
  faq2Answer: string =
    'Шлях будується за допомогою спеціальних алгоритмів, які враховують важливість, терміновість заявки.'
  @Input()
  faq4Question: string = 'Як формується критерій важливості заявки?'
  @Input()
  faq1Answer: string =
    'Ви можете отримати медичну допомогу шляхом реєстрації та заповнення заявки у розділі Сервіси.'
  @Input()
  content2: string = "Зв'яжіться з нами і ми все пояснимо!"
  @Input()
  faq2Question: string = 'Як будується шлях ?'
  @Input()
  faq4Answer: string =
    'Критерій важливості заявки формується шляхом аналізу того, що вказала людина.'
  @Input()
  action1: string = 'Контакти'
  @Input()
  rootClassName: string = ''
  @Input()
  heading2: string = 'Залишились питання?'
  @Input()
  faq1Question: string = 'Як отримати медичну допомогу для мого міста?'
  @Input()
  faq5Question: string = 'Is there any training provided for volunteers?'
  constructor() {}
}

import { Component, Input } from '@angular/core'

@Component({
  selector: 'app-features17',
  templateUrl: 'features17.component.html',
  styleUrls: ['features17.component.css'],
})
export class Features17 {
  @Input()
  feature1ImageAlt: string =
    'Побудова найопитимальнішого маршуту для доставки допомоги. Волонтерам не потрібно думати, куди краще їхати, щоб встигнути у всі міста, за них це зробить наша платформа!'
  @Input()
  feature1Title: string = 'Побудова маршуту'
  @Input()
  feature1Description: string =
    'Побудова найопитимальнішого маршуту для доставки допомоги. Волонтерам не потрібно думати, куди краще їхати, щоб встигнути у всі міста, за них це зробить наша платформа!'
  @Input()
  rootClassName: string = ''
  @Input()
  feature1Slogan: string =
    'Efficiently organize and coordinate medical volunteers'
  @Input()
  feature1ImageSrc: string =
    'https://images.unsplash.com/photo-1617480088922-2f606360c354?ixid=M3w5MTMyMXwwfDF8c2VhcmNofDM4fHxnb29nbGUlMjBtYXB8ZW58MHx8fHwxNzE1NDM0Mjg2fDA&ixlib=rb-4.0.3&w=1400'
  constructor() {}
}

import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Component, Input, OnInit } from '@angular/core'
import { Observable } from 'rxjs'
import { ExecutorModel } from 'src/app/models/executorModel'
import { FoundPathResult } from 'src/app/models/pathModel'

@Component({
  selector: 'app-contact11',
  templateUrl: 'contact11.component.html',
  styleUrls: ['contact11.component.css'],
})
export class Contact11 implements OnInit {
  @Input()
  content1: string = 'Побудований шлях:'
  @Input()
  phone1: string = '+1234567890'
  @Input()
  textinputPlaceholder1: string = "Ім'я"
  @Input()
  text1: string = 'Введіть прізвище:'
  @Input()
  content3: string =
    "Якщо у вас виникли труднощі або потреба у допомозі, будь ласка, зв'яжіться з нами за допомогою форми зворотнього зв'язку нижче."
  @Input()
  content2: string =
    'Маєте питання або потребуєте допомоги? Напишіть нам електронного листа.'
  @Input()
  email: string = 'info@helpplatform.com'
  @Input()
  textinputPlaceholder2: string = 'placeholder'
  @Input()
  content5: string = 'Наша команда готова вам допомогти у будь-який час.'
  @Input()
  text: string = "Введіть ім'я:"
  @Input()
  button1: string = '+'
  @Input()
  location1GoogleMap: string =
    'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d91160.77077631063!2d26.012237766112886!3d44.43779612993267!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40b1f93abf3cad4f%3A0xac0632e37c9ca628!2sBucharest!5e0!3m2!1sen!2sro!4v1713441854828!5m2!1sen!2sro'
  @Input()
  button: string = 'Додати'
  @Input()
  button2: string = 'Побудувати шлях'
  @Input()
  text2: string = 'Введіть назву оранізації:'
  @Input()
  address1: string = 'Вул. Помічників, 25, Київ, Україна'
  @Input()
  heading1: string = 'Оберіть волонтера:'
  @Input()
  textareaPlaceholder: string = ''
  @Input()
  textinputPlaceholder: string = 'placeholder'
  @Input()
  text3: string = 'Text'
  
  private readonly baseExecutorUrl = 'http://localhost:5159/OrderExecutor';
  private readonly basePathBuilderUrl = 'http://localhost:5159/create-with-path';
  
  executors: ExecutorModel[];
  isNewExecutor: boolean = false;
  newExecutor: ExecutorModel = new ExecutorModel();
  selectedExecutorId: number = -1;
  foundPathResult: string;

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getExecutors().subscribe((items) => {
      if(items.length == 0){
        this.isNewExecutor = true;
      }
      else{
        this.executors = items;
      }
    });
  }

  getExecutors(): Observable<ExecutorModel[]> {
    return this.http.get<ExecutorModel[]>(this.baseExecutorUrl);
  }

  createExecutor() {
    const httpOptions = {
      headers: new HttpHeaders({'Content-Type': 'application/json'})
    }

    var json = JSON.stringify(this.newExecutor);

    this.http.post(this.baseExecutorUrl, json, httpOptions).subscribe(next =>{
      window.location.reload();
    },
    error => {
     console.log(error);
    });
  }

  onExecutorChange(executorId) {
    this.selectedExecutorId = executorId;
  }

  buildPath(){
    let url = this.basePathBuilderUrl + '?orderExecutorId=' + this.selectedExecutorId;
    this.http.post<FoundPathResult>(url, {}).subscribe(response =>{
      console.log(response)
      let strResult = '';
      for(let i = 0; i < response.path.length; i++){
        strResult += response.path[i].name;
        if(i < response.path.length - 1){
          strResult += ' - '
        }
      }
      strResult += '\nTotal time: ' + response.totalTime;
      this.foundPathResult = strResult;
    },
    error => {
     console.log(error);
    });
  }
}

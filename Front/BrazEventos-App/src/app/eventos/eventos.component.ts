import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent {

  public eventos: any = [
    {
      Tema: 'Angular',
      Local: 'Curitiba'
    },
    {
      Tema: '.Net 6 ',
      Local: 'São Paulo'
    },
    {
      Tema: 'Novidades de C#',
      Local: 'Rio de Janeiro'
    },
  ]

}

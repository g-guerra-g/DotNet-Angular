import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  constructor(private http: HttpClient) { }

  public Evento: any;

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(){
    this.http.get('https://localhost:5001/api/Evento').subscribe(
      Response => this.Evento = Response,
      Error => console.log(Error)
    );
  }
}

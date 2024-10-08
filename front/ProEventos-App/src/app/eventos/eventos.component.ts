import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import {NgForm} from '@angular/forms';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  constructor(private http: HttpClient) { }

  public Eventos: any[] = []
  public EventosOriginal: any[] = []
  public isCollapsed = false
  public _filtro: string = ""

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(){
    this.http.get('https://localhost:5001/api/Evento').subscribe(
      Response => {
        this.Eventos = Response as any
        this.EventosOriginal = Response as any
      },
        Error => console.log(Error)
    );
  }

  public get filtroLista() {
    return this._filtro
  }

  public set filtroLista(valor: string) {
    this._filtro = valor.toLowerCase();
    this.Eventos = this._filtro ? this.filtrarEvento() : this.EventosOriginal as any
  }

  public filtrarEvento() {
    return this.Eventos.filter(E => 
      E.tema.toLowerCase().includes(this.filtroLista) ||
      E.local.toLowerCase().includes(this.filtroLista) ||
      E.lote.toLowerCase().includes(this.filtroLista)
    )
  }
}

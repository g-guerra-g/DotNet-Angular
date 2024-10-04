import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-palestrantes',
  templateUrl: './palestrantes.component.html',
  styleUrls: ['./palestrantes.component.scss']
})
export class PalestrantesComponent implements OnInit {

  constructor(private http: HttpClient) { }

  public Palestrantes: any;

  ngOnInit(): void {
    this.getPalestrantes();
  }

  public getPalestrantes()
  {
    this.http.get('https://localhost:5001/api/Palestrante').subscribe
    (
      Response => this.Palestrantes = Response,
      Error => console.log(Error)
    )
  };
}

import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Folha } from 'src/app/models/folha';

@Component({
  selector: 'app-cadastrar-folha',
  templateUrl: './cadastrar-folha.component.html',
  styleUrls: ['./cadastrar-folha.component.css']
})
export class CadastrarFolhaComponent implements OnInit {

  valorHora!: number;
  quantidadeHoras!: number;

  constructor(
    private http: HttpClient,
    private router: Router
  ) { }

  ngOnInit(): void {
  }

  cadastrar(): void {
    let folha: Folha = {
      valorHora: this.valorHora,
      quantidadeHoras: this.quantidadeHoras,
      ano: 2022,
      mes: 11,
      funcionarioId: 7
    };

    this.http.
      post<Folha>(
        "https://localhost:5001/api/folha/cadastrar",
        folha
      )
      .subscribe({
        next: (folha) => {
          this.router.navigate(["pages/folha/listar"]);
        }
      });
  }

}

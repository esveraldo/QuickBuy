import { Component, Input, Output } from '@angular/core'
import { Usuario } from '../../modelo/Usuario';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  public usuario;
  public usuarioAutenticado: boolean;
  public usuarioNaoAutenticado: boolean;
  public usuarios = ["Esveraldo", "Adriana", "Anna Luiza", "Maria Eduarda"];

  constructor() {
    this.usuario = new Usuario();
  }

  entrar() {
    if (this.usuario.email == "esveraldo@hotmail.com" && this.usuario.senha == "emo123") {
      this.usuarioAutenticado = true;
    } else {
      //this.usuario.email != "esveraldo@hotmail.com" && this.usuario.senha != "emo123"
        //this.usuarioNaoAutenticado = true;
      this.usuarioAutenticado = false;
      }
    }
  }

import { Component, Input, Output, OnInit } from '@angular/core'
import { Usuario } from '../../modelo/Usuario';
import { Router, ActivatedRoute } from '@angular/router';
import { UsuarioServico } from '../../servicos/usuario/usuario.servico';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public usuario;
  public returnUrl: string;
  public mensagem: string;
  public ativar_spinner: boolean = false;

  

  constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {
    
  }

  ngOnInit(): void {
    this.usuario = new Usuario();
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
  }

  entrar() {
    this.ativar_spinner = true;
    this.usuarioServico.verificaUsuario(this.usuario).subscribe(
      /*data => {
        var usuarioRetorno: Usuario;
        usuarioRetorno = data;
        sessionStorage.setItem("usuario-autenticado", "1");
        sessionStorage.setItem("email-usuario", usuarioRetorno.email);*/
      usuario_json => {

        this.usuarioServico.usuario = usuario_json;

        if (this.returnUrl == null) {
          this.router.navigate(['/']);
        } else {
          this.router.navigate([this.returnUrl]);
        }
        this.router.navigate([this.returnUrl]);
      },
      err => {
        this.mensagem = err.error;
        this.ativar_spinner = false;
      }
    );

    /*if (this.usuario.email == "esveraldo@hotmail.com" && this.usuario.senha == "emo123") {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate([this.returnUrl]);
      }*/
    }
  }

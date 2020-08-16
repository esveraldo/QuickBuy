import { Injectable } from '@angular/core'
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { UsuarioServico } from '../servicos/usuario/usuario.servico';

//@Injectable({
  //providedIn: 'root'
//})
@Injectable()
export class GuardaRotas implements CanActivate {

  constructor(private router: Router, private usuarioServico: UsuarioServico) {

  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    //var autenticado = sessionStorage.getItem("usuario-autenticado");

    //if (autenticado == "1") {
    if (this.usuarioServico.usuario_autenticado()) {
      return true;
    }

    if (this.router) {
      this.router.navigate(['/entrar'], { queryParams: { returnUrl: state.url } });
    }

    return false;
    }

}


/*import { Injectable } from "@angular/core";
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from "@angular/router";
import { Observable } from "rxjs";

@Injectable()

export class AuthGuard implements CanActivate {

  constructor(private router: Router) { }

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot):
    boolean | Observable<boolean> | Promise<boolean> {

    var autenticado = localStorage.getItem("usuario-autenticado");

    if (autenticado == "1") {
      return true;
    }
    this.router.navigate(['/entrar'], { queryParams: { returnUrl: state.url } });

    return false;
    }
  }
}*/

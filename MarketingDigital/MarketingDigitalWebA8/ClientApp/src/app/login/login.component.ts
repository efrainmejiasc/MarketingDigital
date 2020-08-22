import { Component, OnInit } from '@angular/core';
import * as $ from 'jquery';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  public password: string;
  public email: string;
  public robot: boolean;

  public LoginValidated () {
    if (this.email === "" || this.password === "" ||this.robot !== true) {
      alert("TODOS LOS CAMPOS SON REQUERIDOS");
      return false;
    }
    else if (!this.EmailValido(this.email)) {
      alert("EL EMAIL PROPORCIONADO NO ES VALIDO");
      return false;
    }

    $('#msg-process').show();
    $('#loading').show();
    this.Login(this.email, this.password);
  }

  public Login(mail: string, contraseña: string) {

    $.ajax({
      type: "POST",
      url: "/Home/Login",
      data: { email : mail, password: contraseña},
      dataType: "json",
      success: function (data) {
        $('#msg-process').hide();
        $('#loading').hide();
        if (data.result ===  false) {
          alert(data.description);
          console.log(data);
        } else {
          window.location.href = 'http://joselelu-001-site2.etempurl.com/counter';
        }
      },
      complete: function () {
        console.log('LOGIN');
      }

    });

    return false;
  }

  EmailValido(mail: string): boolean {
    const regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(mail);
  }
}

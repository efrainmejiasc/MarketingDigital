import { Component, OnInit } from '@angular/core';
import * as $ from 'jquery';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent  {

  public name: string;
  public lastName: string;
  public email: string;
  public password: string;
  public confirmPassword: string;
  public company: string;
  public phone: string;
  public robot: boolean;

  public RegisteredUser() {
    if (this.name === "" || this.email === "" || this.lastName === "" || this.password === "" || this.robot !== true || this.password === '' || this.confirmPassword === '') {
      alert("TODOS LOS CAMPOS SON REQUERIDOS");
      return false;
    }
    else if (!this.EmailValido(this.email)) {
      alert("EL EMAIL PROPORCIONADO NO ES VALIDO");
      return false;
    }
    else if (this.password !== this.confirmPassword) {
      alert("LAS CONTRASEÑAS DEBEN SER IGUALES");
      return false;
    }

    $('#msg-process').show();
    $('#loading').show();
    this.Registered();
  }

  public Registered() {

    $.ajax({
      type: "POST",
      url: "/Home/RegisteredUser",
      data: { name: this.name, lastName: this.lastName, email: this.email, password: this.password, phone: this.phone, company:this.company },
      dataType: "json",
      success: function (data) {
        if (data.result === true) {
          $('#msg-process').hide();
          $('#loading').hide();
          alert('REGISTRO EXITOSO');
          console.log(data);
          //window.location.href = 'http://joselelu-001-site2.etempurl.com/';
        } else {
          alert('REGISTRO FALLO');
        }
      },
      complete: function () {
        console.log('REGISTEREDUSER');
      }

    });

    return false;
  }


  EmailValido(mail: string): boolean {
    const regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(mail);
  }
}

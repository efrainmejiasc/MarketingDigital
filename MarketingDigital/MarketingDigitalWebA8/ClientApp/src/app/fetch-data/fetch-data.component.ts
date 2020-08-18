import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import * as $ from 'jquery';
import { Router } from '@angular/router';
import { HomeComponent } from '../home/home.component';




@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html',
  styleUrls: ['./fetch-data.component.css']
})
export class FetchDataComponent {
  constructor(@Inject(Router) private router: Router) {}

  public mapa = "assets/image/mapa.JPG";
  public logo2 = "assets/image/logo2.JPG";
  public nombre: string;
  public email: string;
  public asunto: string;
  public mensaje: string;
  public robot: boolean;



  public SendEmail() {
    if (this.nombre === "" || this.email === "" || this.asunto === "" || this.mensaje === "" || this.robot !== true) {
      alert("TODOS LOS CAMPOS SON REQUERIDOS");
      return false;
    }
    if (!this.EmailValido(this.email)) {
      alert("EL EMAIL PROPORCIONADO NO ES VALIDO");
      return false;
    }

    $('#msg-process').show();
    $('#loading').show();
    this.SendEmailTo(this.email, this.asunto, this.mensaje, this.nombre);
  }


  public SendEmailTo(mail: string, asun: string, cuerpo: string, fullName: string) {
  
  $.ajax({
      type: "POST",
      url: "/Home/SendEmail",
      data: { emailTo:mail, subject:asun, body:cuerpo, name:fullName },
      dataType: "json",
      success: function (data) {
        if (data.result === true) {
          $('#msg-process').hide();
          $('#loading').hide();
          alert('EMAIL ENVIADO CORRECTAMENTE');
          console.log(data);
        } else {
           alert('EL EMAIL FALLO AL ENVIAR');
        }
    },
    complete: function () {
      console.log('SEND_EMAIL');
      $('#nombre').val('');
      $('#email').val('');
      $('#asunto').val('');
      $('#mensaje').val('');
      $('#robot').prop("checked", false);
    }

  });

    return false;
  }

  EmailValido(mail: string): boolean {
    const regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(mail);
  }

  public  Navegar() {
    this.router.navigate(['/']);
  }

}



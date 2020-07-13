import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import * as $ from 'jquery';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html',
  styleUrls:['./fetch-data.component.css']
})
export class FetchDataComponent {

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
    this.SendEmailTo(this.email,this.asunto,this.mensaje,this.nombre);
  }


  public SendEmailTo(mail: string,asun: string,cuerpo: string, fullName: string) {
  $.ajax({
      type: "POST",
      url: "/Home/SendEmail",
      data: { emailTo:mail, subject:asun, body:cuerpo, name:fullName },
      dataType: "json",
      success: function (data) {
        if (data.result === true) {
          alert('EMAIL ENVIADO CORRECTAMENTE');
          console.log(data);
        } else {
           alert('EL EMAIL FALLO AL ENVIAR');
        }
      }  
   });
    return false;
  }

  EmailValido(mail: string): boolean {
    const regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(mail);
  }

}



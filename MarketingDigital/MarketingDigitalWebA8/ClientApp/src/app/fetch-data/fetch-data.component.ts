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
    this.SendEmailMe(this.email,this.asunto,this.mensaje);
  }


  public SendEmailMe(mail: string,asun: string,cuerpo: string) {
  $.ajax({
      type: "POST",
      url: "/Home/SendEmail",
      data: { emailTo:mail, subject:asun, body:cuerpo },
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

}



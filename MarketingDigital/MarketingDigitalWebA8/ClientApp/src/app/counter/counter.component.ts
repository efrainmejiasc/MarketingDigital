import { Component, OnInit } from '@angular/core';



@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html',
 styleUrls: ['./counter.component.css']
})


 
export class CounterComponent implements OnInit {
  miImagen = "assets/image/Efrain.png";
  public currentCount = 0;
  public pathFileCv = "assets/MiPerfil/EfrainMejias_CV2020.docx";




  ngOnInit() {
 
  }

  public incrementCounter() {
    this.currentCount++;
  }

  onDownLoadCV(){
    window.open(this.pathFileCv,"_self");
  }


}

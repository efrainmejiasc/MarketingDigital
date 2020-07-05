import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html',
 styleUrls: ['./counter.component.css']
})

export class CounterComponent implements OnInit {
  miImagen = "assets/image/Efrain.png";
  public currentCount = 0


  ngOnInit() {
    alert("Hola Mundo");  
  }

  public incrementCounter() {
    this.currentCount++;
  }


}

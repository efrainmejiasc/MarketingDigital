import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html',
 styleUrls: ['./counter.component.css']
})
export class CounterComponent {
  miImagen = "assets/image/Efrain.png";
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}

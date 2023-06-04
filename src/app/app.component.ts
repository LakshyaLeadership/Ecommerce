import { Component } from '@angular/core';
import { ClickEvent } from 'devextreme/ui/button';
import notify from "devextreme/ui/notify"
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'test-app';
  clickHandler(e: ClickEvent){
    notify("Hello from DevExtreme", "info", 500);
  }
}

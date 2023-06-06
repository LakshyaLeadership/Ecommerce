import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';
import 'devextreme/data/odata/store';

@Component({
  templateUrl: 'tasks.component.html'
})

export class TasksComponent {
  dataSource: any;

  constructor(httpClient: HttpClient){
    httpClient.get('http://localhost:5075/api/sales/ShowReport?startDate=2023-06-05&endDate=2023-06-07').subscribe(x => {
      this.dataSource = x;
    });
  }
}

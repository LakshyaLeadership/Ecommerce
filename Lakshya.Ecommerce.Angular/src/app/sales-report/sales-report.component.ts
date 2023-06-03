import { Component } from '@angular/core';

@Component({
  templateUrl: './sales-report.component.html',
  styleUrls: ['./sales-report.component.scss']
})
export class SalesReportComponent {
  yourDataSource: any[] = [
    { column1: 'Data 1', column2: 'Data 2', column3: 'Data 3' },
    { column1: 'Data 4', column2: 'Data 5', column3: 'Data 6' },
    // Add more data as needed
  ];
}

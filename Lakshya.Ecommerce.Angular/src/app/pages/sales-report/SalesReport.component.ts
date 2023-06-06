import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Component } from '@angular/core';
import { saveAs } from 'file-saver';
@Component({
  templateUrl: 'SalesReport.component.html',
})
export class TasksComponent {
  dataSource: any;
  constructor(private httpClient: HttpClient) {
    httpClient = httpClient;
    httpClient
      .get(
        'http://localhost:5075/api/sales/ShowReport?startDate=2023-06-05&endDate=2023-06-07'
      )
      .subscribe((x) => {
        this.dataSource = x;
      });
  }

  public exportAsPdf() {
    this.httpClient
      .get('http://localhost:5075/api/sales/ExportAsPdf?startDate=2023-06-05&endDate=2023-06-07', { observe: 'response', responseType: 'blob' })
      .subscribe((response: any) => {
        const contentDisposition = response.headers.get('content-disposition');
        const fileName = this.extractFileNameFromContentDisposition(contentDisposition!);

        saveAs(response.body, fileName);
      });
  }

  extractFileNameFromContentDisposition(contentDisposition: string): string {
    const regex = /filename[^;=\n]*=((['"]).*?\2|[^;\n]*)/;
    const matches = regex.exec(contentDisposition);

    if (matches != null && matches[1]) {
      return matches[1].replace(/['"]/g, '');
    }

    return '';
  }
}

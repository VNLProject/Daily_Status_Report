import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public forecasts?: DSRDataModel[];

  constructor(http: HttpClient) {
    debugger;
    http.get<DSRDataModel[]>('https://localhost:7014/api/test/GetDSRData').subscribe(result => {
      debugger;
      this.forecasts = result;
    }, error => console.error(error));
  }

  title = 'DSR_WEB';
}


interface DSRDataModel
{
  project: string;
  scrumMaster: string;
 scrumMasterEmail: string;
  snsiteDevLead: string;
  snsiteDevLeadEmail: string;
}

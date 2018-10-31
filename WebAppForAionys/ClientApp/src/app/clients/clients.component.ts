import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-clients-component',
  templateUrl: './clients.component.html',
  styleUrls: ['./clients.component.css']
})

export class ClientsComponent {
  private http: HttpClient;
  public baseUrl: string;
  public clients: Client[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
    this.http.get<Client[]>(this.baseUrl + 'api/clients').subscribe(
      result => {
        this.clients = result;
      },
      error => {
        console.error(error);
      });
  }

  deleteClientTask(e) {
    let url = this.baseUrl + 'api/clients/' + e.data.id;
    this.http.delete(url).subscribe(
      () => {
        console.log("DELETE call successful, client task with id = " + e.data.id);
      },
      error => {
        console.error(error);
      });
  }
}

interface ClientTask {
  id: number;
  name: string;
  description: string;
  address: string;
  startTime: string;
  endTime: string;
}

interface Client {
  id: number;
  firstName: string;
  lastName: string;
  address: string;
  phoneNumbers: string;
  clientTasks: ClientTask[];
}

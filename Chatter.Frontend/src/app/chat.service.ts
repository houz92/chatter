import { Injectable, EventEmitter } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@microsoft/signalr'
import { ChatMessage } from './chat-message';

@Injectable({
  providedIn: 'root'
})
export class ChatService {
  private hubConnection : HubConnection;
  messageReceived = new EventEmitter<ChatMessage>();

  constructor() { 
    this.buildConnection();
    this.startConneciton();
  }

  buildConnection(){
    this.hubConnection = new HubConnectionBuilder()
      .withUrl('https://localhost:5001/chatter')
      .withAutomaticReconnect()
      .build();
  }

  startConneciton(){
    this.hubConnection
        .start()
        .then(() => {
          console.log('Connection started...');
          this.registerSignalEvents();
        })
        .catch(err => {
          console.log(`Error while starting connection: ${err}`)
          setTimeout(() => {
            this.startConneciton();
          }, 3000); 
        });
  }

  registerSignalEvents(){
    this.hubConnection.on('SendMessage', (data: ChatMessage) => {
      this.messageReceived.emit(data);
    });
  }
}

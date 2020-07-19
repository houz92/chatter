import { Component, OnInit, OnDestroy } from '@angular/core';
import { ChatService } from './chat.service';
import { Observable, Subscription } from 'rxjs';
import { ChatMessage } from './chat-message';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit, OnDestroy {
  title = 'Chatter';
  messages$ : Observable<ChatMessage>;
  messageSubscription : Subscription;

  constructor(private chatService: ChatService) {
  }

  ngOnInit(): void {
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.
    this.messages$ = this.chatService.messageReceived.asObservable();
    this.messageSubscription = this.messages$.subscribe();
  }

  ngOnDestroy(): void {
    this.messageSubscription.unsubscribe();
  }
}

import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';
import { RepositoryService } from '../services/repository.service';
import { Ticket } from '../models/ticket';
import { trigger, state, style, transition, animate } from '@angular/animations';

@Component({
  selector: 'app-ticket',
  templateUrl: './ticket.component.html',
  styleUrls: ['./ticket.component.css']
})
export class TicketComponent implements OnInit {
  public Tickets: Ticket[];

  constructor(private repository: RepositoryService) { }

  ngOnInit() {
    this.getReceipts();

    window.onscroll = function() {scrollFunction()};

  function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
      document.getElementById("scrollButton").style.display = "block";
    } else {
      document.getElementById("scrollButton").style.display = "none";
    }
  }
  }

  // When the user clicks on the button, scroll to the top of the document
  topFunction() {
    document.body.scrollTop = 0; // For Safari
    document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
  }

  getReceipts(){
    let apiAddress: string = 'api/ticket';

    this.repository.getData(apiAddress)
      .subscribe(response =>{
        this.Tickets = response as Ticket[];
      })
  }  
}

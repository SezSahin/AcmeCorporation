import { Component, OnInit, OnChanges } from '@angular/core';
import { Product } from '../models/product';
import { RepositoryService } from '../services/repository.service';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  public Products: Product[];

  constructor(private repository: RepositoryService) { }

  ngOnInit() {
    this.repository.getProducts();
    this.getProducts();

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

  getProducts(){
    let apiAddress: string = 'api/product';

    this.repository.getData(apiAddress)
      .subscribe(response =>{
        this.Products = response as Product[];
      })
  }
}

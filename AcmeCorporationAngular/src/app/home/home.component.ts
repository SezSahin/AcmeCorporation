import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { RepositoryService } from '../services/repository.service';
import swal from 'sweetalert';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  drawForm = new FormGroup({
    firstname: new FormControl(''),
    lastname: new FormControl(''),
    email: new FormControl('',[Validators.required]),
    phoneNumber: new FormControl(''),
    dateOfBirth: new FormControl(''),
    serialNumber: new FormControl('')
  });

  message: string = null;
  
  constructor(private repository: RepositoryService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
  }

  Draw(){
    this.message = null;
    if(this.drawForm.valid){
      this.repository.create('api/ticket', this.drawForm.value)
        .subscribe(
        (data) => {
          swal({text:'You have entered the draw! We will contact you later today!', icon: 'success'});
          this.drawForm.reset();
        },
        (error) => {
          this.message = error['error'];
        }
      )
    }
  }
}

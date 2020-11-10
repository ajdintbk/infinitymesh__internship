import { Component, OnInit } from '@angular/core';
import { RentService } from '../rent.service';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.scss']
})
export class NavigationComponent implements OnInit {
  constructor(public rentService : RentService) { }
  numberOfRenterCars:number = 0;
  
  ngOnInit(): void {
  }
  
}

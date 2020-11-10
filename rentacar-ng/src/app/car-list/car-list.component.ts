import { Component, OnInit } from '@angular/core';
import "jquery";
import { Car } from '../car-model';
import { CarService } from '../car.service';
import { MessageService } from '../message.service';
declare var $:JQueryStatic;

@Component({
  selector: 'app-car-list',
  templateUrl: './car-list.component.html',
  styleUrls: ['./car-list.component.scss']
})
export class CarListComponent implements OnInit {
  cars:Car[];
  selectedcar:string = 'Mercedes';
  savedCar:Car;
  constructor(private carService : CarService, public messageService: MessageService) { 
  }
  
  ngOnInit(): void {
    this.cars = this.carService.getCars();
  }
  openDetails(car:Car):void{
    this.savedCar = car;
  }

  addMessage(){
    this.messageService.add("from parent");
  }
  clearMessages(){
    this.messageService.clear();
  }
  
  
}

import { Injectable } from '@angular/core';
import { CARS } from './car-data';
import { Car } from './car-model';

@Injectable({
  providedIn: 'root'
})
export class CarService {

  constructor() { }

  getCars():Car[]{
    return CARS;
  }
}

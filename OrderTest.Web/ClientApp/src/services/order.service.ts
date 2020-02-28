import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { GetOrdersResponseModel } from '../models/getOrdersResponseModel';
import { GetOrderResponseModel } from '../models/getOrderResponseModel';

@Injectable({
  providedIn: 'root',
})

export class OrderService {
  private apiUrl = "https://localhost:5001/";

  constructor(private http: HttpClient) { }

  public GetOrders() {
    var result = this.http.get<GetOrdersResponseModel>(this.apiUrl + "getOrders");
    return result;
  }

  public GetOrder(orderId: string) {
    var result = this.http.post<GetOrderResponseModel>(this.apiUrl + "GetOrder", { orderId: orderId });
    return result;
  }
}

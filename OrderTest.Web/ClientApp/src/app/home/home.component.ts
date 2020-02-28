import { Component, OnInit } from '@angular/core';
import { OrderService } from '../../services/order.service';
import { GetOrdersResponseModel } from '../../models/getOrdersResponseModel';
import { GetOrderResponseModel } from '../../models/getOrderResponseModel';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public data: GetOrdersResponseModel;
  public order: GetOrderResponseModel;
  public total: number = 0;
  public totalQuantity: number = 0;
  public oneEachTotal: number = 0;

  constructor(private orderService: OrderService) {
    this.data = new GetOrdersResponseModel();
    this.order = new GetOrderResponseModel();
  }

  ngOnInit() {
    this.orderService.GetOrders().subscribe(response => {
      this.data = response;
    });
  }

  public getOrder(orderId: string) {
    this.orderService.GetOrder(orderId).subscribe(response => {
      this.order = response;

      this.order.productsList.forEach(x => {
        this.total += x.totalPrice;
        this.oneEachTotal += x.price;
        this.totalQuantity += x.quantity;
      });
    });
  }

}

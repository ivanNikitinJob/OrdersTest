export class GetOrderResponseModel {
  public id: string;
  public creationDate: Date;
  public name: string;
  public status: string;
  public productsList: Array<GetOrderProductResponseItem>;
}

export class GetOrderProductResponseItem {
  public name: string;
  public quantity: number;
  public price: number;
  public totalPrice: number;
}

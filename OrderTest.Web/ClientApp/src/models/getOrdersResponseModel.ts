export class GetOrdersResponseModel {
  public orders: Array<GetOrdersresponseItem>;
}

export class GetOrdersresponseItem {
  public name: string;
  public id: string;
  public status: string;
  public creationDate: Date;
}

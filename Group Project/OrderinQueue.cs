class OrderinQue{
    private string OrderMenu;
    private int amount;
    private int price; 
    public OrderinQue(string OrderMenu,int amount,int price){
        this.OrderMenu = OrderMenu;
        this.amount = amount;
        this.price = price;
    } 
    public string GetOrderMenu(){
        return this.OrderMenu;
    }
    public int Getamount(){
        return this.amount;
    }
    public int Getprice(){
        return this.price;
    }
}
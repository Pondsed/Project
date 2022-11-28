public class UserOrderHistory{
    private List<Order> orderlist;
    private PickUpTime timebook;
    public UserOrderHistory(PickUpTime timebook){
        this.timebook = timebook;
        this.orderlist = new List<Order>();
    }
    public PickUpTime GetTimebook(){
        return this.timebook;
    }
    public void AddOrdertoHistory(Order order){
        this.orderlist.Add(order);
    }
}
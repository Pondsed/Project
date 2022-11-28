public class Order{
    private string MenuName;
    private int amount;
    private int TotalPrice;
    public Order(string MenuName,int amount,int TotalPrice){
        this.MenuName = MenuName;
        this.amount = amount;
        this.TotalPrice = TotalPrice;
    }
    public string GetMenuName(){
        return this.MenuName;
    }
    public int GetAmount(){
        return this.amount;
    }
    public int GetTotalPrice(){
        return this.TotalPrice;
    }
    public void SetMenuName(string MenuInput){
        this.MenuName = MenuInput;
    }
    public void SetAmount(int AmountInput){
        this.amount = AmountInput;
    }
    public void SetTotalPrice(int TotalPriceInput){
        this.TotalPrice =TotalPriceInput;
    }
}
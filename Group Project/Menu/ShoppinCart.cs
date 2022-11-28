using System.Collections.Generic;
using System;
public class ShoppingCart {
    private User user;
    private Restaurant restaurant;
    private List<Order> Orderlist;
    private PickUpTime timeadd;
    private CalculatePrice calculator;
    public void OrderlistLoad(){
        this.Orderlist = new List<Order>();
    }
    private void SetupUser(User user) {
        this.user = user;
    }
    private void SetupRestaurant(Restaurant restaurant) {
        this.restaurant = restaurant;
    }
    private void SetupCalculator(){
        this.calculator = new CalculatePrice();
    }
    public void ShowShoppingCartMenu(User user,Restaurant restaurant){
        SetupUser(user);
        SetupRestaurant(restaurant);
        OrderlistLoad();
        SetupCalculator();
        ShowMainShoppingMenu(restaurant);
    }
    public void ShowMainShoppingMenu(Restaurant restaurant){
        Console.Clear();
        string orderstatus = "";
        while(orderstatus != "finish"){
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Input add for Add item to your cart");
            Console.WriteLine("Input delete for delete item from your cart");
            Console.WriteLine("Input finish to finish your order");
            Console.Write("Input : ");
            orderstatus = Console.ReadLine();
            if(orderstatus == "add"){
                AddCartItem(user,restaurant);
            }
            if(orderstatus == "delete"){
                DeleteCartItem(Orderlist);
            }
        }
        Console.Clear();
        Console.WriteLine("Select your time to get your order");
        Console.WriteLine("---------------------------------");
        Timeadd();
        Console.Clear();
        Console.WriteLine("Your order is  : {0}",restaurant.GetRestaurantName());
        Console.WriteLine("---------------------------------");
        foreach(Order order in this.Orderlist){
            Console.WriteLine("{0} X {1} : {2}",order.GetMenuName(),order.GetAmount(),order.GetTotalPrice());
            Console.WriteLine("---------------------------------");
        }
        Console.WriteLine("Order Time book at : {0}/{1}/{2} time : {3}:{4} ",timeadd.date,timeadd.month,timeadd.year,timeadd.hour,timeadd.minute);
        Console.WriteLine("---------------------------------");
        bool laststagestatus = false;
        string Input = "";
        while(laststagestatus != true){
            Console.WriteLine("Do you want to Confirm this order ?");
            Console.WriteLine("Input 1 for yes");
            Console.WriteLine("Input 2 for no");
            Console.Write("Input : ");
            string input = Console.ReadLine();
            if(input == "1"){
                laststagestatus = true;
                Input = input;
            }
            else if(input == "2"){
                laststagestatus = true;
                Input = input;
            }
            else{
                Console.WriteLine("Please Input Only 1 or 2");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Going Back to Main Menu");
            Console.WriteLine("Press Enter to Back to Main Menu");
            Console.ReadLine();
        }  
    }
    public void AddCartItem(User user,Restaurant restaurant) {
        restaurant.ShowFoodMenu();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Input Foodnumber of menu and amount");
                Console.Write("Input Foodnumber : ");
                int foodnumber = int.Parse(Console.ReadLine());
                Console.Write("Input amount : ");
                int amount = int.Parse(Console.ReadLine());
                int pricechoice = 0;
                while(pricechoice != 1 && pricechoice != 2){
                    Console.WriteLine("Input 1 for normal price and 2 for high price");
                    Console.Write("Input price choice : ");
                    int Pricechoice = int.Parse(Console.ReadLine());
                    if(Pricechoice == 1 || Pricechoice == 2){
                        pricechoice = Pricechoice;
                    }
                    if(Pricechoice != 1 && Pricechoice != 2){
                        Console.WriteLine("Please input only 1 or 2");
                    }
                }
                string ordername = SetOrdername(foodnumber);
                int price = calculator.SetTotalprice(foodnumber,amount,pricechoice,this.restaurant);
                Order order = new Order(ordername,amount,price);
                this.Orderlist.Add(order);
    }

    public void DeleteCartItem(List<Order> Orderlist) {
        Console.Clear();
        int n = 1;
        foreach(Order order in this.Orderlist){
            Console.WriteLine("Order No. {0} : {1} X {2} : {3}",n,order.GetMenuName(),order.GetAmount(),order.GetTotalPrice());
            Console.WriteLine("---------------------------------");
            n++;
        }
        Console.WriteLine("Select the order to delete by input an order number");
        int MenunameToDelete = int.Parse(Console.ReadLine());
        Orderlist.RemoveAt(MenunameToDelete - 1);
        Console.WriteLine("Order Update");
        foreach(Order order in this.Orderlist){
            Console.WriteLine("{0} X {1} : {2}",order.GetMenuName(),order.GetAmount(),order.GetTotalPrice());
            Console.WriteLine("---------------------------------");
        }
    }
    public void Timeadd() 
    {
        PickUpTime pickuptime = new PickUpTime(0,"",0,0,0);
        pickuptime.PickupMonth();
        pickuptime.PickupDate();
        pickuptime.PickupYear();
        pickuptime.PickupHour();
        pickuptime.PickupMinute();
        this.timeadd = pickuptime;
    }
    public string SetOrdername(int foodnumber){
        string ordername = "";
        foreach(FoodMenu food in restaurant.GetFoodMenuList()){
            if(foodnumber == food.GetFoodNumber()){
                ordername = food.GetFoodName(); 
            }
        }
        return ordername;
    }
}
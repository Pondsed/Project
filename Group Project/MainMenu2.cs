public class MainMenu2{
    private User user;
    private RestaurantList restaurantList;
    private List<OrderinQue> orderList;
    public void ShowUserMenuController(User user) {
        Console.Clear();
        SetupUser(user);
        SetupOrderlist();
        ShowUserMenu();
    }
    public void ShowUserMenu(){
        Console.WriteLine("Welcome {0}.",this.user.GetFirstname());
        Console.WriteLine("*********************************");
        Console.WriteLine("Please Select the Menu");
        Console.WriteLine("Type 1 to choose Select Restaurant");
        Console.WriteLine("Type 2 to choose Select Restaurant From your Late Order history");
        Console.WriteLine("Type 3 to Log out");
        Console.Write("Input : ");
        int input = int.Parse(Console.ReadLine());
        if(input == 1){
            Selectrestaurant();
        }
        if(input == 2){
            // SelectFromYourHistory();
        }
        if(input == 3){
            // Logout();
        }
    }
    private void SetupUser(User user) {
        this.user = (User)user;
    }
    public void SetupOrderlist(){
        this.orderList = new List<OrderinQue>();
    }
    public void Selectrestaurant(){
        this.restaurantList = new RestaurantList();
        restaurantList.ShowRestaurantList();
        Console.WriteLine("Please Select the Restaurant by input 1-6");
        Console.Write("input : ");
        int input = int.Parse(Console.ReadLine());
        Restaurant restaurant = restaurantList.GetRestaurant(input);
        restaurant.GetFoodMenu();
        Console.WriteLine("Do you want to go back?");
        Console.WriteLine("Type yes = Yes");
        Console.WriteLine("Type anything = No");
        Console.Write("input : ");
        string DecideInput = Console.ReadLine();
        if(DecideInput == "yes" ){
            Selectrestaurant();
        }
        if(DecideInput !="yes"){
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Let's put some food to your cart!");
            string exit = "";
            while(exit != "exit"){
                Console.WriteLine("If you want to exit type exit");
                Console.Write("Input : ");
                exit = Console.ReadLine();
                if(exit == "exit"){
                    break;
                }
                Console.Write("Input Food number to add it in your cart : ");
                int Foodnumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Input 1 for choose normal price.");
                Console.WriteLine("Input 2 for choose High price.");
                Console.Write("Input : ");
                int Foodpricechoice = int.Parse(Console.ReadLine());
                // foreach(FoodMenu food)
            }
            
            

        }
    }
        
    }

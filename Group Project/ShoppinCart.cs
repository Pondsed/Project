// public class ShoppingCart {
//     private User user;
//     private Restaurant restaurant;
//     private List<FoodMenu> Orderlist;
//     private PickUpTime timeadd;
//     public ShoppingCart(PickUpTime timeadd){
//         this.timeadd = timeadd;
//     }
//     public void OrderlistLoad(){
//         this.Orderlist = new List<FoodMenu>();
//     }
//     public void ShowShoppingCartMenu(){
//         SetupUser(user);
//         SetupRestaurant(restaurant);
//         OrderlistLoad();
//         Console.WriteLine("Type 1 to go to Add To Cart Menu");
//         AddCartItem(user,restaurant);
//     }

//     public void AddCartItem(User user,Restaurant restaurant) {
//         Console.WriteLine("Select the menu by input the food number");
//         int input = int.Parse(Console.ReadLine());
//         Restaurant restaurant = 


//     }

//     public void DeleteCartItem() {
//         Console.WriteLine("Select the menu to delete");
//     }

//     public void Timeadd() 
//     {
//         PickUpTime pickuptime = new PickUpTime(0,"",0,0,0);
//         pickuptime.PickupMonth();
//         pickuptime.PickupDate();
//         pickuptime.PickupYear();
//         pickuptime.PickupHour();
//         pickuptime.PickupMinute();
//         this.timeadd = pickuptime;
//     }
//     private void SetupUser(User user) {
//         this.user = (User)user;
//     }
//     private void SetupRestaurant(Restaurant restaurant) {
//         this.restaurant = (Restaurant)restaurant;
//     }
//     // public void ViewCartDetail() {
//     //     Console.WriteLine("Your cart detail : {0}".UpdateQuantity());
//     // }
//     // public void BacktoMenu() {
//     //     Console.Clear();
//     //     InputMenuFromKeyboard();
//     // }
// }
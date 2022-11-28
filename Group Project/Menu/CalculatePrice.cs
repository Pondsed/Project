public class CalculatePrice{
    public int SetTotalprice(int foodnumber,int amount,int pricechoice,Restaurant restaurant){
        int totalprice = 0;
        int price = 0;
        foreach(FoodMenu food in restaurant.GetFoodMenuList()){
            if(foodnumber == food.GetFoodNumber()){
                if(pricechoice == 1){
                    price = food.GetNormalPrice();
                }
                if(pricechoice == 2){
                    price = food.GetHighPrice();
                } 
            }
        }
        totalprice = price * amount;
        return totalprice;
    }
}
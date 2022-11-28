public class User {
    private string emailUser;
    private string firstname;
    private string lastname;
    private string password;
    private int phonenumber;
    private List<UserOrderHistory> userOrderHistory;
    public User (string emailUser,string firstname,string lastname,string password,int phonenumber){
        this.emailUser = emailUser;
        this.firstname = firstname;
        this.lastname = lastname;
        this.password = password;
        this.phonenumber = phonenumber;
        this.userOrderHistory = new List<UserOrderHistory>();
    }
    public string GetEmailUser(){
        return this.emailUser;
    }
    public string GetFirstname(){
        return this.firstname;
    }
    public string GetLastname(){
        return this.lastname;
    }
    public string GetPassword(){
        return this.password;
    }
    public int GetPhoneNumber(){
        return this.phonenumber;
    }
    public void ShowLateOrder(){
        foreach(UserOrderHistory lateOrder in this.userOrderHistory){
            Console.WriteLine("{0} x{1} {2} Baht",lateOrder.GetMenuName(),lateOrder.GetAmount(),lateOrder.GetTotalPrice());
        }
    }
    

}
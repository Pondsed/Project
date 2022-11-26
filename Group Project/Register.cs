using System.Collections.Generic;
using System;
public class Register{
    public User InputRegister(){
        Console.Clear();
        Console.WriteLine("Welcome to Register menu");
        Console.WriteLine("Please Setup your Account info");
        string emailUser = InputEmailUser();
        string firstname = InputFirstName();
        string lastname = InputLastName();
        string password = SetupPassword();
        int phonenumber = InputPhonenumber();
        return new User(emailUser,firstname,lastname,password,phonenumber);
    }
    public string InputEmailUser(){
        Console.Write("Input Email : ");
        return Console.ReadLine();
    }
    public string InputFirstName(){
        Console.Write("Input First Name : ");
        return Console.ReadLine();
    }
    public string InputLastName(){
        Console.Write("Input Last name : ");
        return Console.ReadLine();
    }
    public string SetupPassword(){
        Console.Write("Setup Your Password : ");
        return Console.ReadLine();
    }
    public int InputPhonenumber(){
        Console.Write("Input Phone number : ");
        return int.Parse(Console.ReadLine());
    }
}
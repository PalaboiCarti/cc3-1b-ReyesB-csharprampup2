using System;
using System.Linq;

public class HelloWorld
{
    static void weightCv(){
        Console.WriteLine("Enter weight in Pounds(lbs):");
        int lbs = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Weight converted to Kilograms (kg): " + lbs*0.45);
    }
    
    static void distCv(){
        Console.WriteLine("Enter length in Miles (mi):");
        int lbs = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Length converted to Kilometers (km): " + lbs*1.60);
    }
    
    static void tempCv(){
        Console.WriteLine("Enter temperature in Farenheit (f):");
        int fahr = Convert.ToInt32(Console.ReadLine());
        int cels = (fahr - 32) * 5 / 9;
        Console.WriteLine("Temp converted to Celsius (c): " + cels);
    }
    
    static void ages(){
        int[] ages = {22, 19, 20, 20, 18, 21, 23, 25, 19, 21};
        
        for (int i = 0; i < ages.Length; i++){
        Console.WriteLine($"Age of student {i+1}: {ages[i]}");
        }
        
        int sum = ages.Sum();
        int avg = sum / ages.Length;
        Console.WriteLine("The average age of the students is: " + avg);
    }
    
    static void yap(){
        Console.WriteLine("The evil demon king ~Ibrahim the Destroyer~ has attacked the capital of the Magical Kingdom.");
        Console.WriteLine("In order to stop the demon king, the heroes banded together and fought back against thge demon king, but");
        Console.WriteLine("the demon king is simply too strong. He swings his mighty blade, <Sword of Damage go brrrrr> to attack the hero's party.");
        Console.WriteLine("When they try to counterattack, their attacks are deflected thanks to the <Armor of Pls Dont Hurt Me> of the demon king.");
        Console.WriteLine("Using his secret skill <12 Secre Herbs and Spices>, the demon king is then able to quickly gather the mana and");
        Console.WriteLine("items needed to cast his ultimate skill <Unlimited Burger Works>, to defeat the heroes.");
    }
    
    public static void Main(string[] args)
    {
        weightCv();
        Console.WriteLine("===================================");
        distCv();
        Console.WriteLine("===================================");
        tempCv();
        Console.WriteLine("===================================");
        ages();
        Console.WriteLine("===================================");
        yap();
    }
}

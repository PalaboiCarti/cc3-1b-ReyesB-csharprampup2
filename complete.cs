using System;
using System.Linq;
public class HelloWorld
{
    //weight conversion
    static void weightCv()
    {
        Console.WriteLine("Enter weight in Pounds(lbs):");
        int lbs = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Weight converted to Kilograms (kg): " + lbs*0.45);
    }
    //distance conversion
    static void distCv()
    {
        Console.WriteLine("Enter length in Miles (mi):");
        int lbs = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Length converted to Kilometers (km): " + lbs*1.60);
    }
    //temperature conversion
    static void tempCv()
    {
        Console.WriteLine("Enter temperature in Farenheit (f):");
        int fahr = Convert.ToInt32(Console.ReadLine());
        int cels = (fahr - 32) * 5 / 9;
        Console.WriteLine("Temp converted to Celsius (c): " + cels);
    }
    //age array
    static void ages()
    {
        int[] ages = new int[10];
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter age of student {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                ages[i] = age;
            }
            else
            {
                Console.WriteLine("Please enter an appropriate age");
                i--; 
            }
        }
        double sum = 0;
        foreach (int age in ages)
        {
            sum += age;
        }
        double avg = sum / ages.Length;

        Console.WriteLine("Average student age: " + avg);
    }
    //story
    static void yap()
    {
        Console.WriteLine("The main character ~Park JiMid~, wanders alone in a barren wasteland called the Philippines.");
        Console.WriteLine("He has but one goal in mind, and it is to retrieve his boyfriend ~Jungle Kook~,");
        Console.WriteLine("as he is the only person who could revive the ecosystem in the Philippines.");
        Console.WriteLine("As ~Park JiMid~ walks alone, he encounters an evil witch named ~Maddie Lim~");
        Console.WriteLine("who wants to wreak havoc and shed darkness upon the Philippines.");
        Console.WriteLine("Fortunately ~Park Jimid~ has a secret weapon called <MissKoParinSiya>");
        Console.WriteLine("~Maddie Lim~ uses her spell <Skill Issue> to render his weapon abilities useless.");
        Console.WriteLine("However, ~Park JiMid~ has an ability called <Misoginy>");
        Console.WriteLine("which was very effective against ~Maddie Lim~.");
        Console.WriteLine("The saga shall continue..");
    }
    //SECOND HALF
    //part 1
    static void iterator(int num)
    {
         for (int i = 1; i <= num; i++)
         {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine("");
        }
    }
    static void iteration()
    {
        Console.WriteLine("Please input an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num <= 0)
        {
            Console.WriteLine("Integer must not be lower than 0");
            iteration();
        }else
        {
            iterator(num);
        }
    }
    //part 2
    static void thingDoer()
    {
        Console.WriteLine("Please input an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num <= 0)
        {
            Console.WriteLine("Integer must not be lower than 0");
            thingDoer();
        }else
        {
            Console.Write("Formula: ");
            int sum = 0;
            for(int i=1; i<=num; i++)
            {
                Console.Write(i);
                if(i < num){
                    Console.Write("+");
                }
                sum = sum + i;
            }
            Console.WriteLine(" ");
            Console.WriteLine(sum);
        }
    }
    //part 3
    static void decrementStuff(int num)
    {
         for (int i = num; i >= 0; i--)
         {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine("");
        }
    }
    static void decrementation()
    {
        Console.WriteLine("Please input an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num <= 0)
        {
            Console.WriteLine("Integer must not be lower than 0");
            decrementation();
        }else
        {
            decrementStuff(num);
        }
    }
    //main
    public static void Main(string[] args)
    {
        Console.WriteLine("PART ONE");
        weightCv();
        Console.WriteLine("===================================");
        distCv();
        Console.WriteLine("===================================");
        tempCv();
        Console.WriteLine("===================================");
        ages();
        Console.WriteLine("===================================");
        yap();
        Console.WriteLine("===================================");
        Console.WriteLine("PART TWO");
        Console.WriteLine("Part 2 - 1");
        iteration();
        Console.WriteLine("===============================");
        Console.WriteLine("Part 2 - 2");
        thingDoer();
        Console.WriteLine("===============================");
        Console.WriteLine("Part 2 - 3");
        decrementation();
    }
}

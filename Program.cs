//Yuva Reddy
//27/01/25

using System.Data.Common;

namespace HomeWork_1;

class Program
{
    static void Main(string[] args)
    {

        // The triangle farmer
        
        Console.WriteLine("Enter base: ");
        double BaseTriangle = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter height: ");
        double HeightTriangle = Convert.ToDouble(Console.ReadLine());

        double area = 0.5 * BaseTriangle * HeightTriangle;

        Console.WriteLine("Area of triangle: " + area);



        // The four sisters and the Duckbear

        Console.WriteLine("Enter number of eggs: ");
        int EggCount = Convert.ToInt32(Console.ReadLine());
        int Sisters = EggCount / 4;
        int Duckbear = EggCount % 4;

        Console.WriteLine("Sisters get: " + Sisters + " , DuckBear gets: " + Duckbear);

        //if egg count is 1,2,3 then duck bear gets 1,2,3 eggs where the sisters will get 0

        

        // The Dominion of Kings

        Console.WriteLine("Enter number of provinces: ");
        int ProvincesCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of duchies: ");
        int DuchiesCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of estates: ");
        int EstatesCount = Convert.ToInt32(Console.ReadLine());

        int TotalPoints = EstatesCount + 3*DuchiesCount + 6*ProvincesCount;
        Console.WriteLine("Total points for player: " + TotalPoints);


        
        // The defense of Consolas

        Console.Title = "Defense of Consolas";

        Console.Write("Target Row? ");
        int RowNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Target Column? ");
        int CoulumnNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Deploy to:");
        Console.WriteLine("(" + RowNum + "," + (CoulumnNum-1) + ")");
        Console.WriteLine("(" + RowNum + "," + (CoulumnNum+1) + ")");
        Console.WriteLine("(" + (RowNum-1) + "," + CoulumnNum + ")");
        Console.WriteLine("(" + (RowNum+1) + "," + CoulumnNum + ")");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Beep();


      
        // Repairing the Clocktower

        Console.WriteLine("Enter number:");
        int Num = Convert.ToInt32(Console.ReadLine());

        if (Num % 2 == 0)
            Console.WriteLine("Tick");
        else
            Console.WriteLine("Tock");

    }
}

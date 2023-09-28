using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Välkommen till vinstberäknaren!");
        Console.Write("Ange inköpspriset för produkten inklusive moms: ");
        double inköpsprisInklMoms = double.Parse(Console.ReadLine());

        Console.Write("Ange försäljningspriset för produkten inklusive moms: ");
        double försäljningsprisInklMoms = double.Parse(Console.ReadLine());

        // Beräkna kostnaden exklusive moms
        double momsProcent = 25.0; // 25% moms
        double kostnadExklMoms = inköpsprisInklMoms / (1 + (momsProcent / 100));

        // Beräkna intäkten exklusive moms
        double intäktExklMoms = försäljningsprisInklMoms / (1 + (momsProcent / 100));

        // Beräkna vinsten exklusive moms
        double vinstExklMoms = intäktExklMoms - kostnadExklMoms;

        // Beräkna Klarnas avgift
        double klarnaAvgiftProcent = 2.99 / 100; // Omvandla procent till decimaltal
        double klarnaAvgift = (försäljningsprisInklMoms * klarnaAvgiftProcent) + 3.50;

        // Beräkna vinsten inklusive Klarnas avgift
        double vinstMedAvgift = vinstExklMoms - klarnaAvgift;

        // Skattesats (40% skatt)
        double skattesats = 40.0; // 40% skatt
        double skatt = vinstExklMoms * (skattesats / 100);

        Console.WriteLine($"\nKostnaden utan moms är: {kostnadExklMoms} kr\n");
        Console.WriteLine($"Intäkten utan moms är: {intäktExklMoms} kr\n");

        Console.WriteLine($"Klarnas avgift är: {klarnaAvgift} kr\n");

        Console.WriteLine($"Vinsten exklusive moms är: {vinstExklMoms} kr\n");
        Console.WriteLine($"Skatten är: {skatt} kr\n");
        Console.WriteLine($"Vinsten inklusive Klarnas avgift är: {vinstMedAvgift} kr\n");

        double exaktVinst = vinstMedAvgift - skatt;

        Console.WriteLine($"Den exakta vinsten med allt inräknat är: {exaktVinst} kr");

        Console.WriteLine("Tryck på valfri tangent för att avsluta...");
        Console.ReadKey();
    }
}







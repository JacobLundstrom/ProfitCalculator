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

        Console.Write("Ange marknadsföringskostnaden per dag: ");
        double marknadsföringskostnadPerDag = double.Parse(Console.ReadLine());

        //Console.Write("Ange antal sålda produkter per dag (0 om du vill räkna ut break-even): ");
        //int såldaProdukterPerDag = int.Parse(Console.ReadLine());

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

        //// Beräkna marknadsföringskostnaden
        //double totalMarknadsföringskostnad = marknadsföringskostnadPerDag * såldaProdukterPerDag;

        // Skattesats (40% skatt)
        double skattesats = 40.0; // 40% skatt
        double skatt = vinstExklMoms * (skattesats / 100);

        Console.WriteLine($"\nKostnaden utan moms är: {kostnadExklMoms} kr");
        Console.WriteLine($"Intäkten utan moms är: {intäktExklMoms} kr");
        Console.WriteLine($"Klarnas avgift är: {klarnaAvgift} kr");
        Console.WriteLine($"Vinsten exklusive moms är: {vinstExklMoms} kr");
        Console.WriteLine($"Skatten är: {skatt} kr");
        Console.WriteLine($"Vinsten inklusive Klarnas avgift är: {vinstMedAvgift} kr");
        Console.WriteLine($"Marknadsföringskostnaden är: {marknadsföringskostnadPerDag} kr");

        //if (såldaProdukterPerDag == 0)
        //{
        // Räkna ut antal produkter som behöver säljas för break-even
        int produkterFörBreakEven = (int)Math.Ceiling(marknadsföringskostnadPerDag / vinstMedAvgift);

        // Räkna ut den totala vinsten efter marknadsföring
        double totalVinstEfterMarknadsföring = produkterFörBreakEven * vinstMedAvgift - marknadsföringskostnadPerDag;
        Console.WriteLine($"\nDu måste sälja minst {produkterFörBreakEven} st per dag för att inte gå back");
        Console.WriteLine($"Eftersom 1 produkt blir {vinstMedAvgift} kr och ads per dag är {marknadsföringskostnadPerDag} kr vilket blir {totalVinstEfterMarknadsföring} kr över 0kr sträcket!");
        Console.WriteLine($"\nTotala vinsten efter marknadsföring: {totalVinstEfterMarknadsföring} kr");
        Console.WriteLine($"\nTotala vinsten per person blir: {totalVinstEfterMarknadsföring / 2} kr");
        
        


        Console.WriteLine("\nTryck på valfri tangent för att avsluta...");
        Console.ReadKey();
    }
}

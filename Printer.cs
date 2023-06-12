using PrinterApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pilih printer:");
        Console.WriteLine("1. Canon");
        Console.WriteLine("2. Epson");
        Console.WriteLine("3. LaserJet");
        Console.Write("Nomor printer [1...3]: ");
        int choice = int.Parse(Console.ReadLine());

        string brand;
        switch (choice)
        {
            case 1:
                brand = "Canon Printing........";
                break;
            case 2:
                brand = "Epson printing........";
                break;
            case 3:
                brand = "Laserjet Printing........";
                break;
            default:
                Console.WriteLine("tidak ada bg");
                return;
        }

        Printer printer = new Printer(brand);
        printer.Print();

        Console.ReadLine();
    }
}

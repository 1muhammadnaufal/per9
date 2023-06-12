using System;

namespace PrinterApp
{
    class Printer
    {
        private string brand;

        public Printer(string brand)
        {
            this.brand = brand;
        }

        public void Print()
        {
            Console.WriteLine("Printer " + brand);
        }
    }
}
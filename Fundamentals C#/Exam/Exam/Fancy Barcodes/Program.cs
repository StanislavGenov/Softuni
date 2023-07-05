using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex reg = new Regex("^@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+$");
            var digitRegex = new Regex(@"\d");


            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                var match = reg.Match(barcode);

                if (match.Success)
                {
                    string name = match.Groups["barcode"].Value;
                    var digitMatch = digitRegex.Matches(name);
                    string productGroup = string.Empty;

                    foreach (Match digit in digitMatch)
                    {
                        if (digit.Success)
                        {
                            productGroup += digit.Value;
                        }
                    }
                    if (productGroup.Length == 0)
                    {
                        productGroup = "00";
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
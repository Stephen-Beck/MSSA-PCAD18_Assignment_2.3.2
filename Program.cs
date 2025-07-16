// Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.

namespace Assignment_2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float billTotal = 0;
            float tipPercent = 0;
            float tipTotal = 0;
            float grandTotal = 0;
            string tempInput = "";

            Console.Write("Enter the bill total: ");
            tempInput = Console.ReadLine().Trim();

            if (tempInput.StartsWith('$'))
                billTotal = Convert.ToSingle(tempInput.Substring(1));
            else
                billTotal = Convert.ToSingle(tempInput);

            Console.Write("Enter a tip %: ");
            tempInput = Console.ReadLine().Trim();
            if (tempInput.EndsWith('%'))
                tipPercent = Convert.ToSingle(tempInput.Substring(0, tempInput.Length - 1)) / 100;
            else
                tipPercent = Convert.ToSingle(tempInput) / 100;

            tipTotal = TipCalculation(billTotal, tipPercent);
            grandTotal = TotalCalculation(billTotal, tipTotal);

            Console.WriteLine();
            Console.WriteLine($"Bill Total: {billTotal.ToString("C2")}");
            Console.WriteLine($"Tip: {tipPercent.ToString("P0")} ({tipTotal.ToString("C2")})");
            Console.WriteLine($"Grand Total: {grandTotal.ToString("C2")}");
        }

        static float TipCalculation(float billTotal, float tipPercent)
        {
            return billTotal * tipPercent;
        }

        static float TotalCalculation(float billTotal, float tipTotal)
        {
            return billTotal + tipTotal;
        }
    }
}

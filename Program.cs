using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentValueCalculator_HW2
{
    enum TransactionType {
        Buy, Sell
    }
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Input the nominal of the trade:");
            string userInput = Console.ReadLine();
            int nominal = int.Parse(userInput ?? "0");

            Console.WriteLine("Input the trade price of the deal:");
            userInput = Console.ReadLine();
            double tradePrice = double.Parse(userInput ?? "0");

            Console.WriteLine("Input the transaction type:");
            userInput = Console.ReadLine();
            TransactionType trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput ?? "0", true);

            int sign = trcType == TransactionType.Buy ? 1 : -1;
            double currentValue = sign * nominal * tradePrice;
            Console.WriteLine($"The current value of a deal is: {currentValue}");

            Console.WriteLine("Input the original price of the investment:");
            userInput = Console.ReadLine();
            double originalPrice = double.Parse(userInput ?? "0");

            int factor = trcType == TransactionType.Buy ? 0 : 1;
            double profitLoss = (tradePrice - originalPrice) * nominal * factor;
            Console.WriteLine($"Profit/loss of the deal is: {profitLoss}");

            Console.ReadLine();
        }
    }
}


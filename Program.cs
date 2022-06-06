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
            int nominal = string.IsNullOrEmpty(userInput) ? 0 : int.Parse(userInput);

            Console.WriteLine("Input the trade price of the deal:");
            userInput = Console.ReadLine();
            double tradePrice = string.IsNullOrEmpty(userInput) ? 0 : double.Parse(userInput);

            Console.WriteLine("Input the transaction type:");
            userInput = Console.ReadLine();
            TransactionType trcType = string.IsNullOrEmpty(userInput) ? 0 : (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            int sign = trcType == TransactionType.Buy ? 1 : -1;
            double currentValue = sign * nominal * tradePrice;
            Console.WriteLine($"The current value of a deal is: {currentValue}");

            Console.WriteLine("Input the original price of the investment:");
            userInput = Console.ReadLine();
            double originalPrice = string.IsNullOrEmpty(userInput) ? 0 : double.Parse(userInput);

            int factor = trcType == TransactionType.Buy ? 0 : 1;
            double profitLoss = (tradePrice - originalPrice) * nominal * factor;
            Console.WriteLine($"Profit/loss of the deal is: {profitLoss}");

            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class CalculateChange
    {
        public void CalculateChangeToReturn(decimal amount, decimal total)
        {
            decimal totalChange = (amount - total);
            if(totalChange < 0)
            {
                Console.WriteLine("You haven't enough money");
                AmountToPaid();
            }else if (totalChange == 0)
                {
                    Console.WriteLine("Not return money.");             
            }
            else {
                Console.WriteLine($"Your change is : {totalChange}");
            }             
        }
        public decimal AmountToPaid()
        {
            Console.WriteLine("Put amount to pay:");
            decimal amountToPay = Convert.ToDecimal(Console.ReadLine());
            return amountToPay;
        }
    }
}

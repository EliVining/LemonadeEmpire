using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class LemonadeStand
    {
        public string Name { get; set; }
        public int NumberOfCups { get; set; }
        public decimal PricePerCup { get; set; }
        public decimal CostPerCup { get; set; }

        public decimal GetTotalRevenue()
        {
            return NumberOfCups * PricePerCup;
        }

        public decimal GetTotalExpenses()
        {
            return NumberOfCups * CostPerCup;
        }

        public decimal GetTotalProfit()
        {
            return GetTotalRevenue() - GetTotalExpenses();
        }
    }
}

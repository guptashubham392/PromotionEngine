using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static int GetTotalPrice(List<Product> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;
            foreach (Product pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    counterofA = counterofA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    counterofB = counterofB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    CounterofD = CounterofD + 1;
                }
            }
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int totalPriceofCD = 0;
            if (CounterofC > 0 && CounterofD > 0)
            {
                int minValue = 0;
                if (CounterofC < CounterofD)
                    minValue = CounterofC;
                else
                    minValue = CounterofD;
                for (int i = 1; i <= minValue; i++)
                {
                    totalPriceofCD = totalPriceofCD + 30 * i;
                    CounterofC--;
                    CounterofD--;
                }

            }
            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD + totalPriceofCD;

        }
    }
}

    public class Product
    {
        public string Id { get; set; }
        public decimal Price { get; set; }
        public Product(string id)
        {
            this.Id = id;
            switch (id)
            {
                case "A":
                    this.Price = 50m;
                    break;
                case "B":
                    this.Price = 30m;
                    break;
                case "C":
                    this.Price = 20m;
                    break;
                case "D":
                    this.Price = 15m;
                    break;
            }
        }

    }
}

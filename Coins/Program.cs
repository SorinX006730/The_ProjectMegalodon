using System;
using System.Threading;

namespace Area_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal quarterCoin = 0.25M;
            decimal dimeCoin = 0.10M;
            decimal nickelCoin = 0.05M;
            decimal pennyCoin = 0.01M;

            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennys = 0;

            Console.Write("What is the price of the product ? : ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            Console.Write("How much money you have : ");
            decimal userMoney = decimal.Parse(Console.ReadLine());

            Check(productPrice, userMoney);

            decimal productChange = userMoney - productPrice;
            while (productChange > 0)
            {
                if (productChange >= quarterCoin)
                {
                    productChange -= quarterCoin;
                    quarters++;
                }
                else if (productChange >= dimeCoin)
                {
                    productChange -= dimeCoin;
                    dimes++;
                }
                else if (productChange >= nickelCoin)
                {
                    productChange -= nickelCoin;
                    nickels++;
                }
                else if (productChange >= pennyCoin)
                {
                    productChange -= pennyCoin;
                    pennys++;
                }
            }

            Console.WriteLine($"Quarters : {quarters} \n Dimes : {dimes} \n Nickels : {nickels} \n Pennys : {pennys}");
            static void Check(decimal _productprice, decimal _userMoney)
            {
                if (_userMoney < 0)
                    throw new ArgumentOutOfRangeException("You can't have negattive money");
                else if (_productprice > _userMoney)
                    throw new ArgumentOutOfRangeException("You don't have enough money");
            }
        }
    }
}

            
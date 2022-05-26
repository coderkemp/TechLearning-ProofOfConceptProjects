﻿using System;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionDemo
{
    class Program
    {
        public static readonly IServiceProvider container = new ContainerBuilder().Build();
        static void Main(string[] args)
        {
            var product = string.Empty;
            var productStockRepository = new ProductStockRepository();
            var orderManager = container.GetService<IOrderManager>();
            while(product != "exit")
            {
                Console.WriteLine(@"Enter a product
                 Keyboard = 0,
                 Mouse = 1,
                 Mic = 2,
                 Speaker =3
                ");
                product = Console.ReadLine();
                try
                {
                    if (Enum.TryParse(product, out Product productEnum))
                    {
                        Console.WriteLine("Please enter a valid payment method: XXXXXXXXXXXXXXXX;MMYY");
                        var paymentMethod = Console.ReadLine();
                        if (string.IsNullOrEmpty(paymentMethod) || paymentMethod.Split(";").Length != 2)
                            throw new Exception("Invalid payment method");
                        orderManager.Submit(productEnum, paymentMethod.Split(";")[0], paymentMethod.Split(";")[1]);
                        Console.WriteLine($"{productEnum.ToString()} has been shipped");
                    }
                    else
                    {
                        Console.WriteLine("Invalid product entry");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}

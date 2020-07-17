﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo
{
    public class ContainerBuilder
    {
        public IServiceProvider Build()
        {
            var container = new ServiceCollection();

            container.AddSingleton<IOrderManager, OrderManager>();
            container.AddSingleton<IProductStockRepository, ProductStockRepository>();
            container.AddSingleton<IPaymentProcessor, PaymentProcessor>();
            container.AddSingleton<IShippingProcessor, ShippingProcessor>();

            return container.BuildServiceProvider();
        }
    }
}

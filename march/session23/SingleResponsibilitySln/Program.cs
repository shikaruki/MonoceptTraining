﻿using SingleResponsibilitySln.Model;

namespace SingleResponsibilitySln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Training Invoice ", 100, 50);
            invoice.PrintInvoice();
        }
    }
}
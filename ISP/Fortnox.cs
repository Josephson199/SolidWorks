using System;

namespace ISP
{
    public class Fortnox : IInvoiceManagement
    {
        public void CreateClientInvoices()
        {
            Console.WriteLine("Creating client invoices...");
        }

        public void ValidateSupplierInvoices()
        {
            Console.WriteLine("Validating supplier invoices...");
        }
    }
}

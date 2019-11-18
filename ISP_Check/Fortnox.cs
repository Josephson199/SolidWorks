using System;

namespace ISP_Check
{
    public class Fortnox : IClientInvoiceCreator, ISupplierInvoiceValidator
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

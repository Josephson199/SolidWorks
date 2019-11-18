using System;

namespace ISP
{
    public class ProAktivEconomy : IInvoiceManagement
    {
        public void CreateClientInvoices()
        {
            Console.WriteLine("Creating client invoices...");
        }

        public void ValidateSupplierInvoices()
        {
            throw new NotImplementedException();
        }
    }
}

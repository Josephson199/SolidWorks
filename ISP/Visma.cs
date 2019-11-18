using System;

namespace ISP
{
    public class Airplane : IInvoiceManagement
    {
        public void CreateClientInvoices()
        {
            throw new NotImplementedException();
        }

        public void ValidateSupplierInvoices()
        {
            Console.WriteLine("Validating supplier invoices...");
        }
    }
}

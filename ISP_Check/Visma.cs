using System;

namespace ISP_Check
{
    public class Visma : ISupplierInvoiceValidator
    {
        public void ValidateSupplierInvoices()
        {
            Console.WriteLine("Validating supplier invoices...");
        }
    }
}

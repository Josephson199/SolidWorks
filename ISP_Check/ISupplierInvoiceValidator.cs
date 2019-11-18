namespace ISP_Check
{
    public interface ISupplierInvoiceValidator
    {
        void ValidateSupplierInvoices();
    }

    //We could even create a higher level interface
    public interface IInvoiceManagement : ISupplierInvoiceValidator, IClientInvoiceCreator { }

}

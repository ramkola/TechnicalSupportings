using System;

namespace KaterinaPostStuff.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string DossierCode { get; set; }
        public DateTime ConfDelDate { get; set; }
        public string DelAddrCode { get; set; }
    }
}

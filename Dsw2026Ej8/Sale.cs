using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal importe { get; set; }
        public virtual decimal CalculateTotal()
        {
            return importe;
        }
    }
    class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return importe;
        }   
    }
    class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            importe = importe * 0.9m;
            return importe;
        }
    }
}

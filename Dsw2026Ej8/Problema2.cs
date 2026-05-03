using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription,int quantity, decimal unitPrice)
        {
           
           var anonClass = new { 
               _code = productCode, 
               _description = productDescription, 
               _quantity = quantity, 
               _totalPrice = (quantity>0) ? (quantity * unitPrice) : 0 
           };

           return $"[{anonClass._code}] - {anonClass._description}, {anonClass._totalPrice:C}";

        }
    }
}

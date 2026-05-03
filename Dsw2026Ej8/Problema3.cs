using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string ComprarCopias(int originalValue, Product product)
        {
           int _copyValue = originalValue;
           _copyValue++;
           Product copyProduct = product; 
           copyProduct.Update("Descripcion modificada");
           
           return $"{originalValue} - {_copyValue} - {copyProduct.GetDescription()}";

        }
    }
}

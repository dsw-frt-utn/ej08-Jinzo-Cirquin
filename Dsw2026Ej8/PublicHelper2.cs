using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    partial class ProductHelper
    {
        private string ValidarDescripcion(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("La descripción no puede ser vacía.");
            }
            return description.Trim();
        }

    }
}
    
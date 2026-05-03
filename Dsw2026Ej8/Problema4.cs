using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
           
           double _promedio = 0;

           var validNotas = new List<int>();

           if (nota1.HasValue && nota1.Value >= 0 && nota1.Value <= 10) validNotas.Add(nota1.Value);
           if (nota2.HasValue && nota2.Value >= 0 && nota2.Value <= 10) validNotas.Add(nota2.Value);
           if (nota3.HasValue && nota3.Value >= 0 && nota3.Value <= 10) validNotas.Add(nota3.Value);

           if (validNotas.Count > 0)
           {
               _promedio = validNotas.Average();
           }
           else if(validNotas.Count == 0)
           {
               _promedio = 0;
           }

           return _promedio;
        }
    }
}

using System;

namespace Calculadora
{
    public class CalculadoraDeImpuestos
    {
        const decimal porcentaje = 0.16m;
        public decimal ObtenerIVA(decimal monto)
        { 
            return monto * porcentaje;
        }

        public decimal ObtenerISH(decimal monto, decimal porcentaje)
        {
            return monto * porcentaje;
        }

        public decimal ObtenerTotal(decimal monto, decimal porcentaje, decimal iva)
        {
            return monto + porcentaje + iva;
        }

    }
}

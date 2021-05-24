using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessoSeletivo_DTI
{
    public interface IPetshopPriceCalculator
    {
        double CalculateTotalPrice(IEnumerable<Petshop> petshops, DateTime date, int SmallDogAmount, int BigDogAmount);
    }
}

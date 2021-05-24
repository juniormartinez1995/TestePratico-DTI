using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessoSeletivo_DTI
{
    class MeuCaninoFelizCalculator : IPetshopPriceCalculator
    {
        public double CalculateTotalPrice(IEnumerable<Petshop> petshops, DateTime date, int SmallDogAmount, int BigDogAmount) =>
            petshops
                .Where(p => p.PetshopName == Petshop.Name.MeuCaninoFeliz)
                .Select(p => p.CalculatePrice(SmallDogAmount, BigDogAmount) * ((date.DayOfWeek == DayOfWeek.Saturday) || (date.DayOfWeek == DayOfWeek.Sunday) ? 1.20 : 1))
                .Sum();
    }
        
}

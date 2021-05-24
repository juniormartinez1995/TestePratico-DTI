using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessoSeletivo_DTI
{
    class VaiRexCalculator : IPetshopPriceCalculator
    {
        public double CalculateTotalPrice(IEnumerable<Petshop> petshops, DateTime date, int SmallDogAmount, int BigDogAmount) =>
            petshops
                .Where(p => p.PetshopName == Petshop.Name.VaiRex)
                .Select(p => p.CalculatePrice(SmallDogAmount, BigDogAmount) + ((date.DayOfWeek == DayOfWeek.Saturday) || (date.DayOfWeek == DayOfWeek.Sunday) ? (SmallDogAmount * 5) + (BigDogAmount * 5) : 0))
                .Sum();
    }
}

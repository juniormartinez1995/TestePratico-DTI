using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessoSeletivo_DTI
{
    class ChowChawgasCalculator : IPetshopPriceCalculator
    {
        public double CalculateTotalPrice(IEnumerable<Petshop> petshops, DateTime date, int SmallDogAmount, int BigDogAmount) =>
            petshops
                .Where(p => p.PetshopName == Petshop.Name.ChowChawgas)
                .Select(p => p.CalculatePrice(SmallDogAmount, BigDogAmount))
                .Sum();
    }
}

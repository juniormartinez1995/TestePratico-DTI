using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessoSeletivo_DTI
{
    public class PetshopPriceCalculator
    {
        private IPetshopPriceCalculator _calculator;

        public PetshopPriceCalculator(IPetshopPriceCalculator calculator)
        {
            _calculator = calculator;
        }

        public void SetCalculator(IPetshopPriceCalculator calculator) => _calculator = calculator;

        public double Calculate(IEnumerable<Petshop> petshops, DateTime date, int SmallDogAmount, int BigDogAmount) => _calculator.CalculateTotalPrice(petshops, date, SmallDogAmount, BigDogAmount);
    }
}

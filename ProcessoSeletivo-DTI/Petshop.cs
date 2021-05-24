using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessoSeletivo_DTI
{
    public class Petshop
    {
        public enum Name
        {
            MeuCaninoFeliz,
            VaiRex,
            ChowChawgas
        }
        public Name PetshopName { get; set; }
        public double SmallDogPrice { get; set; }
        public double BigDogPrice { get; set; }

        public double CalculatePrice(int SmallDogAmount, int BigDogAmount)
        {
            return ((SmallDogAmount * SmallDogPrice) + (BigDogAmount * BigDogPrice));
        }
    }
}

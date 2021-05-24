using System;
using System.Collections.Generic;
using System.Linq;

namespace ProcessoSeletivo_DTI
{
    class Program
    {
        static void Main(string[] args)
        {
            var Response = new List<Tuple<string, double, double>>();  
            DateTime date = new DateTime();
            int SmallDogsAmount = 0, BigDogsAmount = 0;
            bool InputValidated = false;
            string[] InputData;

            var Petshops = new List<Petshop>
            {
                new Petshop {SmallDogPrice = 20, BigDogPrice = 40, PetshopName = Petshop.Name.MeuCaninoFeliz},
                new Petshop {SmallDogPrice = 15, BigDogPrice = 50, PetshopName = Petshop.Name.VaiRex},
                new Petshop {SmallDogPrice = 30, BigDogPrice = 45, PetshopName = Petshop.Name.ChowChawgas}
            };

            while (!InputValidated)
            {
                Console.WriteLine("Digite a data, a quantidade de cachorros pequenos e cachorros grandes:\n");
                InputData = Console.ReadLine().Split();
                if (int.TryParse(InputData[1], out SmallDogsAmount) && int.TryParse(InputData[2], out BigDogsAmount) && DateTime.TryParse(InputData[0], out date))
                    InputValidated = true;
                else
                    Console.WriteLine("Houve um erro no formato de digitação dos dados. Por favor, digite novamente:\n");
            }

            var calculatorContext = new PetshopPriceCalculator(new MeuCaninoFelizCalculator());
            Response.Add(new Tuple<string, double, double>("Meu canino feliz", calculatorContext.Calculate(Petshops, date, SmallDogsAmount, BigDogsAmount), 2));

            calculatorContext.SetCalculator(new VaiRexCalculator());
            Response.Add(new Tuple<string, double, double>("Vai Rex", calculatorContext.Calculate(Petshops, date, SmallDogsAmount, BigDogsAmount), 1.7));

            calculatorContext.SetCalculator(new ChowChawgasCalculator());
            Response.Add(new Tuple<string, double, double>("ChowChawgas", calculatorContext.Calculate(Petshops, date, SmallDogsAmount, BigDogsAmount), 0.8));

            Response.Sort((x, y) => {
                int result = x.Item2.CompareTo(y.Item2);
                return result == 0 ? x.Item3.CompareTo(y.Item3) : result;
            });

            Console.WriteLine("Melhor petshop: {0} \n Valor total: {1}R$", Response.First().Item1, Response.First().Item2);
        }
    }
}

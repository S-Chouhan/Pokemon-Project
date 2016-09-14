using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectPokemon
{
    public class pokemonOperation
    {
        // Calculating and Returning the pokemon value with out discount 
        public int costForSelectedPokemonQuantity(int Pikachu = 0, int Squirtle = 0, int Charmander = 0)
        {
            int Totalpokemon = (Pikachu * 6) + (Squirtle * 5) + (Charmander * 5);

            return Totalpokemon;
        }
        //Calculating and Returning Final cost of the pokemon value with discount
        public float costForSelectedPokemonWithDiscount(int Pikachu = 0, int Squirtle = 0, int Charmander = 0)
        {
            int discount = 0;
            float getDiscountValue = 0;
            float finalamount = 0;
            int beforeDiscountValue = 0;
            float afterDiscountValue = 0;


            if (Pikachu == Squirtle && Squirtle == Charmander)
            {
                beforeDiscountValue = costForSelectedPokemonQuantity(Pikachu, Squirtle, Charmander);
                discount = 20;
                afterDiscountValue = discountForSelectedPokemonQunatity(beforeDiscountValue, discount);
                return afterDiscountValue;

            }
            else if (Pikachu > 0 && Squirtle > 0 && Charmander > 0)
            {
                beforeDiscountValue = costForSelectedPokemonQuantity(1, 1, 1);

                discount = 20;
                getDiscountValue = discountForSelectedPokemonQunatity(beforeDiscountValue, discount);
                afterDiscountValue = costForSelectedPokemonQuantity(Pikachu - 1, Squirtle - 1, 0);
                finalamount = getDiscountValue + afterDiscountValue;
                return finalamount;
            }

            else if (Pikachu == Squirtle || Squirtle == Charmander || Pikachu == Charmander)
            {
                beforeDiscountValue = costForSelectedPokemonQuantity(Pikachu, Squirtle, Charmander);
                discount = 10;
                afterDiscountValue = discountForSelectedPokemonQunatity(beforeDiscountValue, discount);
                return afterDiscountValue;
            }

            else if (Pikachu > 0 && Squirtle > 0 || Squirtle > 0 && Charmander > 0 || Pikachu > 0 && Charmander > 0)
            {
                beforeDiscountValue = costForSelectedPokemonQuantity(1, 1);

                discount = 10;
                getDiscountValue = discountForSelectedPokemonQunatity(beforeDiscountValue, discount);
                afterDiscountValue = costForSelectedPokemonQuantity(Pikachu - 1, Squirtle - 1, 0);
                finalamount = getDiscountValue + afterDiscountValue;
                return finalamount;
            }
            
            return finalamount;

        }
        //Calculating Discount of Pokemon
        public float discountForSelectedPokemonQunatity(float pokemonValue, float discount)
        {

            float discountValue = (pokemonValue - (pokemonValue * discount) / 100);
            return discountValue;


        }

    }
}

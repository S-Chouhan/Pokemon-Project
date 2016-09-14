using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using projectPokemon;
using System.Threading.Tasks;

namespace PokemonTesting
{
    [TestClass]
    public class pokemonTest
    {
        pokemonOperation obj_Pokoperation;

        private int testPropertyForSinglePokemon
        {
            get
            {
                return obj_Pokoperation.costForSelectedPokemonQuantity(1);
            }
        }
        private int testPropertyForTwoPokemons
        {
            get
            {
                return obj_Pokoperation.costForSelectedPokemonQuantity(1,1);
            }
        }
        private int testPropertyForThreePokemons
        {
            get
            {
                return obj_Pokoperation.costForSelectedPokemonQuantity(1, 1,1);
            }
        }

        private float testPropertyforFinalValueWithTheDiscount
        {
            get
            {
                return obj_Pokoperation.costForSelectedPokemonWithDiscount(2, 2);
            }


        }

        private float testPropertyForCalculatingDiscount
        {
            get
            {
                return obj_Pokoperation.discountForSelectedPokemonQunatity(11, 10);

            }
        }

        float result;
        [TestInitialize]
        public void pokemonTestSetup()
        {
            //Arrange
            obj_Pokoperation = new pokemonOperation();
        }

        [TestMethod]

        public void PokemonCostQuantityForSinglePokemon()
        {
            //Act
            result = testPropertyForSinglePokemon;
            //Assert
            Assert.AreEqual(6, result);

        }

        [TestMethod]
        public void PokemonCostQuantityForTwoPokemons()
        {
            //Act
            result = testPropertyForTwoPokemons;
            //Assert
            Assert.AreEqual(11, result);

        }

        [TestMethod]
        public void PokemonCostQuantityForThreePokemons()
        {
            //Act
            result = testPropertyForThreePokemons;
            //Assert
            Assert.AreEqual(16, result);

        }

        [TestMethod]
        public void fianlCostWithDiscountOfTwoPokemon()
        {
             //Act
             result = testPropertyforFinalValueWithTheDiscount;
            //Assert
            Assert.AreEqual(19.8f, result);

        }
        [TestMethod]
        public void discountOnPokemon()
        {
            //Act
            result = testPropertyForCalculatingDiscount;
            //Assert
            Assert.AreEqual(9.9f, result);

        }

        
        [TestCleanup]
        public void pokemonTestCleanup()
        {
            obj_Pokoperation = null;

        }


    }
}



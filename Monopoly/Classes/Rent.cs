using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Classes
{
    public class Rent
    {
        public int BasicRent;
        public int OneHouse;
        public int TwoHouse;
        public int ThreeHouse;
        public int FourHouse;
        public int Hotel;

        public Rent(int basicRent, int oneHouse, int twoHouse, int threeHouse, int fourHouse, int hotel)
        {
            BasicRent = basicRent;
            OneHouse = oneHouse;
            TwoHouse = twoHouse;
            ThreeHouse = threeHouse;
            FourHouse = fourHouse;
            Hotel = hotel;
        }
    }
}

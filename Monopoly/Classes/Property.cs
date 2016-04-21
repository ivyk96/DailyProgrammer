using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Classes
{
    public class Property
    {
        public string Name;
        public int Price;
        public int HousePrice;
        public Rent Rent;
        public Color Color;
        public bool isStreet;

        public List<House> houses = new List<House>();

        public Property(string name, int price, int housePrice, Rent rent, Color color)
        {
            Name = name;
            Price = price;
            HousePrice = housePrice;
            Color = color;
            isStreet = false;
        }

        public int GetRent()
        {
            switch(houses.Count)
            {
                case 0:
                    if (isStreet == true)
                        return Rent.BasicRent * 2;
                    else
                        return Rent.BasicRent;
                case 1: return Rent.OneHouse;
                case 2: return Rent.TwoHouse;
                case 3: return Rent.ThreeHouse;
                case 4: return Rent.FourHouse;
                case 5: return Rent.Hotel;
                default: return Rent.BasicRent;
            }
        }
    }
}

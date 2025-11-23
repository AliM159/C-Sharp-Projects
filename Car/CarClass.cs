using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarObjectModel
{
    internal class CarClass
    {
        private string _modelMake;
        private int _year, _horsePower;
        private bool _isDrivable;
        private double _price;


        public CarClass (  string modelMake, int year, int horsePower,  double price , bool isDrivable = true)
        {
            this._year = year;
            this._horsePower = horsePower;
            this._modelMake = modelMake;
            this._isDrivable = isDrivable;
            this._price = price;  

            
        }


        public override string ToString()
        {
            return $"Model: {_modelMake} \nYear: {_year} \nHorsepower: {_horsePower} \nDrivable: {_isDrivable} \nPrice: {_price :C} \n";
        }
    }
}

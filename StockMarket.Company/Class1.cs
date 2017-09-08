using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Company
{
    public class Type
    {
        private string _name;
        public Type(string typename)
        {
            _name = typename;
        }
        public String name
        {
            get
            {
                return (_name);
            }
        }
        public Double StartProbability()
        {
            switch (_name)
            {
                case ("Startup"):
                    
                    break;
                case ("SmallBusiness"):

                    break;
                case ("LargeBusiness"):

                    break;
                case ("Corporation"):

                    break;
                case ("Monopoly"):

                    break;
                default:


            }
        }
    }
    
    /// <summary>
    /// Class for individual Company data.
    /// </summary>
    public class Company
    {
        private Double _startupProbability = 0.85;
        private string _name;

        public string name
        {
            get
            {
                return _name;
            }
        }

        public double stockValue
        {
            get
            {
                return 0.0;
            }
        }
    }
    /// <summary>
    /// Class for holding multiple Company objects.
    /// </summary>
    public class Companies
    {

    }
}

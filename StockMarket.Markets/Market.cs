using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket;

namespace StockMarket.Markets
{
    public class Market
    {
        public Market(string marketName)
        {
            _totalAddressableMarket = 0;
            _economicInfluence = 0;
            _name = marketName;
        }

        /// <summary>
        /// List of companies in this market.
        /// </summary>
        public List<Company.Company> companies = new List<Company.Company>();

        private double _totalAddressableMarket;
        private double _economicInfluence;
        private StockMarket.Geography.Location _primaryLocation;
        private string _name;
        private double _coeffecient;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// How the value of this market changes the profitability of the companies within the market.
        /// </summary>
        public double profitabilitycoeffecient
        {
            get
            {
                return _coeffecient;
            }
            set
            {
                _coeffecient = value;
            }
        }

        /// <summary>
        /// Total value of the market in dollars
        /// </summary>
        public double totalAddressableMarket
        {
            get
            {
                _totalAddressableMarket = 0;
                foreach(Company.Company c in companies)
                {
                    _totalAddressableMarket += c.stockValue;
                }

                return _totalAddressableMarket;
            }
        }

        /// <summary>
        /// Percent value of the market relative to the entire economy
        /// </summary>
        public double economicInfluence
        {
            get
            {
                return _economicInfluence;
            }
        }

        /// <summary>
        /// Primary location of the market, disasters in this location have significant effects on this market.
        /// </summary>
        public StockMarket.Geography.Location primaryLocation
        {
            get
            {
                return _primaryLocation;
            }
        }

    }

}

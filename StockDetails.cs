using System;
using System.Collections.Generic;
using System.Text;

namespace StockAccountManagement
{
    public class StockDetails
    {

        public List<TypesOfCompaniesForShares> typesofStocks;

    }

    public class TypesOfCompaniesForShares
    {
        public string ShareName;
        public int NumberofShare;
        public int SharePrice;
    }



    
}

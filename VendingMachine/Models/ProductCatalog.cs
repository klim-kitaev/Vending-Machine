using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Models
{
    public class ProductCatalog:UnitCollection<ProductTypes>
    {
        public ProductCatalog(Dictionary<ProductTypes, int> _products)
            : base(_products)
        {

        }

        protected override IUnit<ProductTypes> _UnitCreator(ProductTypes type)
        {
            return new Product(type);
        }
    }
}
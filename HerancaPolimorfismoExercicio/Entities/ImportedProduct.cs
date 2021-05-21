using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismoExercicio.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) :
            base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            double valor = Price + CustomsFee;
            return Name + " $ " + valor.ToString("F2", CultureInfo.InvariantCulture) + " (Taxa Alfandegaria: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) +")";
        }
    }
}

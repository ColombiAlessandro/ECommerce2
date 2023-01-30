using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce2
{
    public class ProdottoAlimentare : Product
    {
        private string[] _ingredienti;
        private DateTime _dataScadenza;
        
        private bool _isExpired;
        public bool IsExpired { get { return _isExpired; } private set { _isExpired = value; } }

        public string[] Ingredienti
        {
            get { return _ingredienti; }
            set { _ingredienti = value; }
            
        }
        public DateTime DataScadenza
        {
            get { return _dataScadenza; }
            private set { _dataScadenza = value; }
        }
        public ProdottoAlimentare(ProdottoAlimentare prod) : base(prod)
        {
            Ingredienti = prod.Ingredienti;
            DataScadenza= prod.DataScadenza;

        }
        public ProdottoAlimentare(string[] ingredienti, DateTime data, string id, string name, string prod, float price) : base(id, name, prod, price)
        {
            Ingredienti = ingredienti;
            DataScadenza = data;
        }
        public override Product Clone()
        {
            return new ProdottoAlimentare(this);
        }

    }
}

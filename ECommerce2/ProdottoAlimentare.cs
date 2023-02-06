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
        public override float PrezzoScontato()
        {
            float tmp = base.PrezzoScontato();
            if (DateTime.Now.CompareTo(DataScadenza) < 0)
            {
                if (DateTime.Now.AddDays(-7).CompareTo(DataScadenza) >= 0)
                {
                    float sconto = (tmp * 50) / 100;
                    tmp -= sconto;  
                }
            }
            return tmp;
        }
        public override string ToString()
        {
            string stringa = base.ToString();
            return stringa + DataScadenza.ToString() + ";";
        }
    }
}

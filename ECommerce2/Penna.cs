using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce2
{
    public class Penna:ProdottoCancelleria
    {
        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public Penna(Penna p) : base (p)
        {
            Tipo= p.Tipo;
            

        }
        public Penna(string tipo, string id, string name, string prod, float price) : base(id, name, prod, price)
        {
            _tipo = tipo;
        }
        public override Penna Clone()
        {
            return new Penna(this);
        }
        public override string ToString()
        {
            return base.ToString() + Tipo + ";";
        }
    }
}

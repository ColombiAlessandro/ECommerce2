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
        public Penna(Penna p)
        {
            Tipo= p.Tipo;
        }
        public override Penna Clone()
        {
            return new Penna(this);
        }
    }
}

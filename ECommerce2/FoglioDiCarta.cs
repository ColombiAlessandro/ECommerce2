using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce2
{
    public class FoglioDiCarta : ProdottoCancelleria
    {
        private string _grammatura;
        public string Grammatura
        {
            get { return _grammatura; }
            private set { _grammatura = value; }
        }
        public FoglioDiCarta(FoglioDiCarta foglio) : base(foglio)
        {
            Grammatura = foglio.Grammatura;
        }
        public FoglioDiCarta(string grammatura, string id, string name, string prod, float price) : base(id,name,prod,price)
        {
            _grammatura = grammatura;
        }
        public override Product Clone()
        {
            return new FoglioDiCarta(this);
        }
        public override string ToString()
        {
            return base.ToString() + Grammatura +";";
        }
    }
}

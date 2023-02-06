using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce2
{
    public abstract class ProdottoCancelleria : Product
    {
        public ProdottoCancelleria(ProdottoCancelleria p) : base (p)
        {

        }
        public override float PrezzoScontato()
        {
            float tmp = base.PrezzoScontato();
            if (DateTime.Now.Day % 2 == 0)
            {
                float sconto = (tmp * 3) / 100;
                tmp -= sconto;
            }
            return tmp;
        }
        public ProdottoCancelleria(string id, string name, string prod, float price) : base(id, name, prod, price)
        {

        }

    }
}

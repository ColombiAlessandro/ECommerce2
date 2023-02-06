using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce2
{
    public class ProdottoElettronico : Product
    {
        private string _modelloSpecifico;
        public string ModelloSpecifico
        {
            get { return _modelloSpecifico; }
            set { _modelloSpecifico = value; }
        }
        public override Product Clone()
        {
            return new ProdottoElettronico(this);
        }
        public ProdottoElettronico(ProdottoElettronico prod) : base(prod)
        {
            ModelloSpecifico= prod.ModelloSpecifico;
        }
        public ProdottoElettronico(string modello, string id, string name, string prod, float price) : base(id,name,prod,price)
        {
            ModelloSpecifico = modello;
        }
        public override float PrezzoScontato()
        {
            float tmp = base.PrezzoScontato();
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                float sconto = (tmp * 5) / 100;
                tmp-= sconto;
            }
            return tmp;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + ModelloSpecifico + ";";
        }
    }
}

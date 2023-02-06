using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECommerce2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetHeaderList();
        }
        private void SetHeaderList()
        {
            list.View = View.Details;
            list.FullRowSelect = true;

            String[] intestazione = new string[] { "ID", "NOME", "PREZZO", "DESCRIZIONE", "TIPO PRODOTTO" };
            for (int i = 0; i < intestazione.Length; i++)
            {
                list.Columns.Add(intestazione[i]);
            }

            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}

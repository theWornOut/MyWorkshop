using System;
using System.Windows.Forms;
using static EnumExp.MyEnums;

namespace EnumExpForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDene_Click(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] { AlanKodu.Avrupa, AlanKodu.Anadolu, AlanKodu.Ankara, AlanKodu.Izmir });
        }
    }
}

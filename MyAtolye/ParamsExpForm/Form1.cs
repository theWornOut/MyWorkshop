using System;
using System.Data;
using System.Windows.Forms;

namespace ParamsExpForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            ParamsClass c = new ParamsClass();
            DataSet ds = new DataSet();
            ds = c.CreateDataSet("Northwind", "Products", "Orders");
            for (int i = 0; i < ds.Tables.Count; ++i)
            {
                tabControl1.TabPages.Add(new TabPage(ds.Tables[i].TableName.ToString()));
                DataGrid dg = new DataGrid();
                dg.Dock = DockStyle.Fill;
                dg.DataSource = ds.Tables[i];
                tabControl1.TabPages[i].Controls.Add(dg);
            }
        }
    }
}

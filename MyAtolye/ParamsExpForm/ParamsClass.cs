using System.Data;
using System.Data.SqlClient;

namespace ParamsExpForm
{
    public class ParamsClass
    {
        public ParamsClass()
        {

        }

        public DataSet CreateDataSet(string baglantiAdi, params string[] tabloAdi)
        {
            string sqlSelect, conString;
            conString = "data source=localhost;initial catalog=" + baglantiAdi + ";integrated security=sspi";
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(conString);
            SqlDataAdapter da;

            for (int i = 0; i < tabloAdi.Length; ++i)
            {
                sqlSelect = "SELECT * FROM " + tabloAdi[i];
                da = new SqlDataAdapter(sqlSelect, con);
                DataTable dt = new DataTable(tabloAdi[i]);
                da.Fill(dt);
                ds.Tables.Add(dt);
            }
            return ds;
        }
    }
}

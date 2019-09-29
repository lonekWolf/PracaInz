using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoriumWabco
{
    public partial class InformacjaOSorcieWindow : Form
    {
        private string numer;
        private string data;
        private string opis;

        public InformacjaOSorcieWindow(string numer, string data, string opis)
        {
            InitializeComponent();
            this.numer = numer;
            this.data = data;
            this.opis = opis;
        }

        private void listViewInformacjaPobierzDane()
        {
            using (SqlConnection cnn = new SqlConnection(@"Server = tcp:wabcosorty.database.windows.net,1433; Initial Catalog = WabcoDB; Persist Security Info = False; User ID = lonekwolf; Password = Plemion@12; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))  //Data Source = DESKTOP - FN2EULB; Initial Catalog = WabcoDB; Integrated Security = True
            {
                using (SqlCommand command = new SqlCommand("select * from [Wabco.ZbiorSortow] where NumerCzesci = @NumerCzesci and DataUruchomieniaSortu = @DataUruchomieniaSortu and Opis = @Opis", cnn))
                {
                    command.Parameters.AddWithValue("@NumerCzesci", numer);
                    command.Parameters.AddWithValue("@DataUruchomieniaSortu", data);
                    command.Parameters.AddWithValue("@Opis", opis);
                    cnn.Open();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    DataTable dtWynik = new DataTable();
                    SqlDataAdap.Fill(dtWynik);

                    foreach (DataRow row in dtWynik.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["NumerCzesci"].ToString());
                        item.SubItems.Add(row["Linia"].ToString());
                        item.SubItems.Add(row["DataUruchomieniaSortu"].ToString());
                        item.SubItems.Add(row["Opis"].ToString());
                        item.SubItems.Add(row["MQE"].ToString());
                        item.SubItems.Add(row["DostawcaCzesci"].ToString());
                        item.SubItems.Add(row["Inzynier"].ToString());
                        listViewInformacjaOSorcie.Items.Add(item);
                    }
                }
            }
        }



        private void InformacjaOSorcieWindow_Load(object sender, EventArgs e)
        {
            listViewInformacjaPobierzDane();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

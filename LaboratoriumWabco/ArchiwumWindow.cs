using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LaboratoriumWabco
{
    public partial class ArchiwumWindow : Form
    {
        public ArchiwumWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewArchiwumPobierzDane()
        {
            using (SqlConnection cnn = new SqlConnection(@"Server = tcp:wabcosorty.database.windows.net,1433; Initial Catalog = WabcoDB; Persist Security Info = False; User ID = lonekwolf; Password = Plemion@12; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))  //Data Source = DESKTOP - FN2EULB; Initial Catalog = WabcoDB; Integrated Security = True
            {
                using (SqlCommand command = new SqlCommand("select NumerCzesci, DataUruchomieniaSortu, Opis from [Wabco.ZbiorSortow] order by id", cnn))
                {
                    cnn.Open();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    DataTable dtWynik = new DataTable();
                    SqlDataAdap.Fill(dtWynik);

                    foreach (DataRow row in dtWynik.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["NumerCzesci"].ToString()); 
                        item.SubItems.Add(row["DataUruchomieniaSortu"].ToString());
                        item.SubItems.Add(row["Opis"].ToString()); 
                        listViewArchiwum.Items.Add(item);
}
                }
            }
        }

        private void ArchiwumWindow_Load(object sender, EventArgs e)
        {
            listViewArchiwumPobierzDane();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            if (listViewArchiwum.SelectedItems.Count > 0)
            {
                string numer = listViewArchiwum.SelectedItems[0].SubItems[0].Text;
                string data = listViewArchiwum.SelectedItems[0].SubItems[1].Text;
                string opis = listViewArchiwum.SelectedItems[0].SubItems[2].Text;
             
                InformacjaOSorcieWindow informacjaOSorcieWindow = new InformacjaOSorcieWindow(numer, data, opis);
                informacjaOSorcieWindow.Show();
            }
            else
            {
                label1.Visible = true;
                label1.ForeColor = System.Drawing.Color.Red;
                label1.Text = "Wybierz element" + Environment.NewLine + "z listy";  
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}

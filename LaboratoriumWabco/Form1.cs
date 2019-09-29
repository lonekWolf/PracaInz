using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LaboratoriumWabco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        
        private void listView1PobierzDane()
        {
            using (SqlConnection cnn = new SqlConnection(@"Server = tcp:wabcosorty.database.windows.net,1433; Initial Catalog = WabcoDB; Persist Security Info = False; User ID = lonekwolf; Password = Plemion@12; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))  //Data Source = DESKTOP - FN2EULB; Initial Catalog = WabcoDB; Integrated Security = True
            {
                using (SqlCommand command = new SqlCommand("select NumerCzesci, Linia, DataUruchomieniaSortu, Opis, MQE from [Wabco.ZbiorSortow] where Aktywny = 1 order by id", cnn))
                {
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
                        listView1.Items.Add(item); 
                    }
                } 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1PobierzDane();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajWindow openForm2 = new DodajWindow(); 
            openForm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InformacjaWindow informacjaWindow = new InformacjaWindow();
            informacjaWindow.Show();
        }
          
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
         
        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1PobierzDane();
        }

        private void usunZBazyDanych()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string numer = listView1.SelectedItems[0].SubItems[0].Text;
                string data = listView1.SelectedItems[0].SubItems[2].Text;
                string opis = listView1.SelectedItems[0].SubItems[3].Text;

                using (SqlConnection cnn = new SqlConnection(@"Server = tcp:wabcosorty.database.windows.net,1433; Initial Catalog = WabcoDB; Persist Security Info = False; User ID = lonekwolf; Password = Plemion@12; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))  //Data Source = DESKTOP - FN2EULB; Initial Catalog = WabcoDB; Integrated Security = True
                {
                    using (SqlCommand command = new SqlCommand("update [Wabco.ZbiorSortow] set Aktywny = 0 where NumerCzesci = @NumerCzesci and DataUruchomieniaSortu = @DataUruchomieniaSortu and Opis = @opis", cnn))
                    {
                        command.Parameters.AddWithValue("@NumerCzesci", numer);
                        command.Parameters.AddWithValue("@DataUruchomieniaSortu", data);
                        command.Parameters.AddWithValue("@Opis", opis);
                        cnn.Open();
                        command.ExecuteNonQuery();
                        labelInformacja.Visible = true;
                        labelInformacja.ForeColor = System.Drawing.Color.Red;
                        labelInformacja.Text = "Usunięto sort";
                        SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    }
                }
            } else
            {
             labelInformacja.Visible = true;
             labelInformacja.ForeColor = System.Drawing.Color.Red;
             labelInformacja.Text = "Zaznacz sort";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usunZBazyDanych();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ArchiwumWindow archiwumWindow = new ArchiwumWindow();
            archiwumWindow.Show();
        }

        private void labelInformacja_Click(object sender, EventArgs e)
        {
            labelInformacja.Visible = false;
        }
         
    }
}

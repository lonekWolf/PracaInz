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
            using (SqlConnection cnn = new SqlConnection(Properties.Settings.Default.CSBazy))   
            {
                using (SqlCommand command = new SqlCommand("select * from dbo.Sortowania where Aktywny = 0 order by id", cnn))
                {
                    cnn.Open();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    DataTable dtWynik = new DataTable();
                    SqlDataAdap.Fill(dtWynik);
                    
                    foreach (DataRow row in dtWynik.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["NumerCzesci"].ToString());
                        item.SubItems.Add(row["Linia"].ToString());
                        item.SubItems.Add(row["DataUruchomienia"].ToString());
                        item.SubItems.Add(row["Wady"].ToString());
                        item.SubItems.Add(row["MQE"].ToString());
                        listView1.Items.Add(item); 
                    }
                } 
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
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
            long numerCzesci = Convert.ToInt64(listView1.SelectedItems[0].SubItems[0].Text);
            string wada = listView1.SelectedItems[0].SubItems[3].Text;
            EdytujSort edytujSort = new EdytujSort(numerCzesci, wada);
            edytujSort.Show();

        }

        private void usunZBazyDanych()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string numer = listView1.SelectedItems[0].SubItems[0].Text;
                string data = listView1.SelectedItems[0].SubItems[2].Text;
                string opis = listView1.SelectedItems[0].SubItems[3].Text;

                using (SqlConnection cnn = new SqlConnection(Properties.Settings.Default.CSBazy))
                {
                    using (SqlCommand command = new SqlCommand("update [Wabco.ZbiorSortow] set Aktywny = 1 where NumerCzesci = @NumerCzesci and DataUruchomieniaSortu = @DataUruchomieniaSortu and Opis = @opis", cnn))
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

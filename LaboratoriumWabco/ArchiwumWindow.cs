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
            using (SqlConnection cnn = new SqlConnection(Properties.Settings.Default.CSBazy))  
            {
                using (SqlCommand command = new SqlCommand("select * from dbo.Sortowania  order by id", cnn))
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

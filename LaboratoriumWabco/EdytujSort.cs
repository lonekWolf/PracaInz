using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LaboratoriumWabco
{
    public partial class EdytujSort : Form
    {
        private long numerCzesci;
        private string wadaCzesci;
        public EdytujSort(long numerCzesci, string wada)
        {
            InitializeComponent();
            this.numerCzesci = numerCzesci;
            this.wadaCzesci = wada;

            labelEdytowanySort.Text = "Informacje na temat sortu częsci nr: " + numerCzesci;
            richTextBoxWadyCzęsci.Text = wada;
            pobierzDaneSortu();
        }

        private void pobierzDaneSortu()
        {
            int iloscWszystkich = 0, iloscOK = 0, iloscNok = 0;
            using (SqlConnection cnn = new SqlConnection(Properties.Settings.Default.CSBazy))   
            {
                
                using (SqlCommand command = new SqlCommand("select * from dbo.SzczegolySortowan where NumerCzesci = @numerCzesci order by Data", cnn))
                {
                    cnn.Open();
                    command.Parameters.AddWithValue("@NumerCzesci", numerCzesci);
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    DataTable dtWynik = new DataTable();
                    SqlDataAdap.Fill(dtWynik);

                    foreach (DataRow row in dtWynik.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["Data"].ToString()); 
                        item.SubItems.Add(row["IloscSkontrolowanychCzesci"].ToString());
                        iloscWszystkich += Convert.ToInt32(row["IloscSkontrolowanychCzesci"].ToString());
                        item.SubItems.Add(row["IloscSztukOK"].ToString());
                        iloscOK += Convert.ToInt32(row["IloscSztukOK"].ToString());
                        item.SubItems.Add(row["IloscSztukNOK"].ToString());
                        iloscNok += Convert.ToInt32(row["IloscSztukNOK"].ToString());
                        listView1.Items.Add(item);
                    }
                }
            }

            labelStatystyki.Text = "Sprawdzono: " + iloscWszystkich + " sztuk, " + iloscOK + " sztuk było OK, znaleziono" + iloscNok + " sztuk NOK";
        }

        private void dodajDane()
        {
            if(textBoxIloscSprawdzonychSztuk.TextLength == 0 || textBoxIloscOK.TextLength == 0 || textBoxIloscOK.TextLength == 0 || textBoxIloscNok.TextLength == 0)
            {
                labelInfoBlad.Visible = true;
                labelInfoBlad.Text = "Uzupelnij dane";
            }
            else
            {
                string data = textBoxData.Text;
                int iloscWszystkich = Convert.ToInt32(textBoxIloscSprawdzonychSztuk.Text);
                int iloscOK = Convert.ToInt32(textBoxIloscOK.Text);
                int iloscNOK = Convert.ToInt32(textBoxIloscNok.Text);

                if(iloscWszystkich != (iloscOK + iloscNOK))
                { 
                    //error o blednej ilosci sztuk 
                } else
                {
                    //insert do bazy

                    using (SqlConnection cnn = new SqlConnection(Properties.Settings.Default.CSBazy)) 
                    {
                        using (SqlCommand command = new SqlCommand("insert into dbo.SzczegolySortowan(Data, NumerCzesci, IloscSkontrolowanychCzesci, IloscSztukOK, IloscSztukNOK) values (@Data, @NumerCzesci, @IloscSkontrolowanychSztuk, @IloscSztukOK, @IloscSztukNOK)", cnn))
                        {
                            command.Parameters.AddWithValue("@Data", data);
                            command.Parameters.AddWithValue("@NumerCzesci", numerCzesci);
                            command.Parameters.AddWithValue("@IloscSkontrolowanychSztuk", iloscWszystkich);
                            command.Parameters.AddWithValue("@IloscSztukOK", iloscOK);
                            command.Parameters.AddWithValue("@IloscSztukNOK", iloscNOK); 
                            cnn.Open();
                            command.ExecuteNonQuery();
                            SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                            cnn.Close();
                        }
                    } 
                }

            } 
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            dodajDane();
            listView1.Items.Clear();
            pobierzDaneSortu();
        }

        private void buttonAktualizuj_Click(object sender, EventArgs e)
        {
            
            if(wadaCzesci != richTextBoxWadyCzęsci.Text)
            {
                string nowaWada = richTextBoxWadyCzęsci.Text;
                using (SqlConnection cnn = new SqlConnection(Properties.Settings.Default.CSBazy))
                {
                    using (SqlCommand command = new SqlCommand("update dbo.Sortowania set Wady = @nowaWada where NumerCzesci = @numerCzesci and Wady = @staraWada", cnn))
                    {
                        command.Parameters.AddWithValue("@nowaWada", nowaWada);
                        command.Parameters.AddWithValue("@numerCzesci", numerCzesci);
                        command.Parameters.AddWithValue("@staraWada", wadaCzesci);
                        cnn.Open();
                        command.ExecuteNonQuery();
                        SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                        cnn.Close();
                    }
                }
                 
            }

             
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        { 
            string data = listView1.SelectedItems[0].SubItems[0].Text;
            int iloscSprawdzonychSztuk = Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text); 

            using (SqlConnection cnn = new SqlConnection(Properties.Settings.Default.CSBazy))
            {
                using (SqlCommand command = new SqlCommand("delete from dbo.SzczegolySortowan where data = @data and NumerCzesci = @numerCzesci and IloscSkontrolowanychCzesci = @iloscSprawdzonychSztuk", cnn))
                {
                    command.Parameters.AddWithValue("@data", data);
                    command.Parameters.AddWithValue("@numerCzesci", numerCzesci);
                    command.Parameters.AddWithValue("@iloscSprawdzonychSztuk", iloscSprawdzonychSztuk);
                    cnn.Open();
                    command.ExecuteNonQuery();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    cnn.Close();
                }
            }

            listView1.Items.Clear();
            pobierzDaneSortu();
        }
    }
}

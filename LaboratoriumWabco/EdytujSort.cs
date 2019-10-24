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
        private int numerCzesci;
        public EdytujSort(int numerCzesci)
        {
            InitializeComponent();
            this.numerCzesci = numerCzesci;
            labelEdytowanySort.Text = "Informacje na temat sortu częsci nr: " + numerCzesci;
            pobierzDaneSortu();
        }

        private void pobierzDaneSortu()
        {
            using (SqlConnection cnn = new SqlConnection(@"Server = 172.16.16.230\mssqlserver2012r; Database = test; User Id = sa;
                Password = D0breH@sl0;"))   
            {
                
                using (SqlCommand command = new SqlCommand("select * from dbo.doUsuniecia order by id", cnn))
                {
                    cnn.Open();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    DataTable dtWynik = new DataTable();
                    SqlDataAdap.Fill(dtWynik);

                    foreach (DataRow row in dtWynik.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["id"].ToString());
                        item.SubItems.Add(row["Data"].ToString());
                        item.SubItems.Add(row["IloscSprawdzonychSztuk"].ToString());
                        item.SubItems.Add(row["CzesciOk"].ToString());
                        item.SubItems.Add(row["CzesciNok"].ToString());
                        listView1.Items.Add(item);
                    }
                }
            }
        }

        private void dodajDane()
        {
            if(textBoxIloscSprawdzonychSztuk.TextLength == 0 || textBoxIloscOK.TextLength == 0 || textBoxIloscOK.TextLength == 0 || textBoxIloscNok.TextLength == 0)
            {
                //error o pustyych wierszach
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

                    using (SqlConnection cnn = new SqlConnection(@"Server = 172.16.16.230\mssqlserver2012r; Database = test; User Id = sa;
                Password = D0breH@sl0;")) 
                    {
                        using (SqlCommand command = new SqlCommand("insert into dbo.doUsuniecia(Data,IloscSprawdzonychSztuk,CzesciOk,CzesciNok) values (@NumerCzesci, @Linia, @DataUruchomieniaSortu, @Opis, @MQE, @Firma, @Inzynier, 1)", cnn))
                        {
                            command.Parameters.AddWithValue("@Data", data);
                            command.Parameters.AddWithValue("@IloscSprawdzonychSztuk", iloscWszystkich);
                            command.Parameters.AddWithValue("@CzesciOk", iloscOK);
                            command.Parameters.AddWithValue("@CzesciNok", iloscNOK); 
                            cnn.Open();
                            command.ExecuteNonQuery();
                            SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                            cnn.Close();
                        }
                    }
                }

            }
            

            


        }
    }
}

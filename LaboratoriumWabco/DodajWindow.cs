using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LaboratoriumWabco
{
    public partial class DodajWindow : Form
    {
        public DodajWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        private void DodajWindow_Load(object sender, EventArgs e)
        {

        } 
        private void dodajSortDoBazyDanych(string numer, string linia, string data, string opis, string mqe, string firma, string inzynier)
        {
            //Dodawanie do bazy archiwum sortow
            using (SqlConnection cnn = new SqlConnection(Properties.Settings.Default.CSBazy))  
            {
                using (SqlCommand command = new SqlCommand("insert into dbo.Sortowania(NumerCzesci, Linia, DataUruchomienia, Wady, MQE, DostawcaCzesci, InzynierLiniowy, Aktywny)values (@NumerCzesci, @Linia, @DataUruchomieniaSortu, @Opis, @MQE, @Firma, @Inzynier, 0)", cnn))
                {
                    command.Parameters.AddWithValue("@NumerCzesci", numer);
                    command.Parameters.AddWithValue("@Linia", linia);
                    command.Parameters.AddWithValue("@DataUruchomieniaSortu", data);
                    command.Parameters.AddWithValue("@Opis", opis);
                    command.Parameters.AddWithValue("@MQE", mqe);
                    command.Parameters.AddWithValue("@Firma", firma);
                    command.Parameters.AddWithValue("@Inzynier", inzynier);
                    cnn.Open();
                    command.ExecuteNonQuery();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    cnn.Close();
                }
            }

        }

        private bool sprawdzZawartoscTextBox(string numer, string linia, string data, string opis, string mqe, string firma, string inzynier)
        {
            if (numer.Length == 0 || linia.Length == 0 || data.Length == 0 || opis.Length == 0 || mqe.Length == 0 || firma.Length == 0 || inzynier.Length == 0)
            {
                labelInformacja.Visible = true;
                labelInformacja.ForeColor = System.Drawing.Color.Red;
                labelInformacja.Text = "Wypełnij"+Environment.NewLine+"puste pola";
                return false;
            }
            else return true;
        }

        private void dodajDaneDoBazy()
        { 
            string numer = textBoxNumerCzesci.Text.Trim();
            string linia = textBoxLinia.Text.Trim();
            string data = textBoxData.Text.Trim();
            string opis = richTextBoxOpis.Text.Trim();
            string mqe = textBoxMQE.Text.Trim();
            string firma = textBoxFirma.Text.Trim();
            string inzynier = textBoxInzynier.Text.Trim();
            if(sprawdzZawartoscTextBox(numer, linia, data, opis, mqe, firma, inzynier) == true)
            {
                try
                {
                    dodajSortDoBazyDanych(numer, linia, data, opis, mqe, firma, inzynier);
                    labelInformacja.Visible = true;
                    labelInformacja.ForeColor = System.Drawing.Color.Green;
                    labelInformacja.Text = "Dodano sort";
                }
                catch (Exception e)
                {
                    labelInformacja.Visible = true;
                    labelInformacja.ForeColor = System.Drawing.Color.Red;
                    labelInformacja.Text = "Błąd: " + e;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dodajDaneDoBazy();
        }

        private void labelInformacja_Click(object sender, EventArgs e)
        {
            labelInformacja.Visible = false;
        }
    }
}

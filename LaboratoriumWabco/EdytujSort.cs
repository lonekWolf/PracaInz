using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }


    }
}

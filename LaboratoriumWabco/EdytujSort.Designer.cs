namespace LaboratoriumWabco
{
    partial class EdytujSort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label labelInfo;
            this.labelEdytowanySort = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIlosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CzesciOk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CzesciNok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelInofrmacjaOWadzie = new System.Windows.Forms.Label();
            this.richTextBoxWadyCzęsci = new System.Windows.Forms.RichTextBox();
            this.labelDodajInformacje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIloscSprawdzonychSztuk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxIloscOK = new System.Windows.Forms.TextBox();
            this.textBoxIloscNok = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonAktualizuj = new System.Windows.Forms.Button();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.labelInfoBlad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStatystyki = new System.Windows.Forms.Label();
            labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new System.Drawing.Point(19, 48);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new System.Drawing.Size(106, 13);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "Statystyki sortowania";
            // 
            // labelEdytowanySort
            // 
            this.labelEdytowanySort.AutoSize = true;
            this.labelEdytowanySort.Location = new System.Drawing.Point(19, 9);
            this.labelEdytowanySort.Name = "labelEdytowanySort";
            this.labelEdytowanySort.Size = new System.Drawing.Size(174, 13);
            this.labelEdytowanySort.TabIndex = 0;
            this.labelEdytowanySort.Text = "Informacje na temat sortu częsci nr:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Data,
            this.columnIlosc,
            this.CzesciOk,
            this.CzesciNok});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(373, 182);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            // 
            // columnIlosc
            // 
            this.columnIlosc.Text = "Ilosc Sprawdzonych Sztuk";
            this.columnIlosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnIlosc.Width = 150;
            // 
            // CzesciOk
            // 
            this.CzesciOk.Text = "Cześci OK";
            this.CzesciOk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CzesciOk.Width = 80;
            // 
            // CzesciNok
            // 
            this.CzesciNok.Text = "Cześci NOK";
            this.CzesciNok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CzesciNok.Width = 80;
            // 
            // labelInofrmacjaOWadzie
            // 
            this.labelInofrmacjaOWadzie.AutoSize = true;
            this.labelInofrmacjaOWadzie.Location = new System.Drawing.Point(19, 314);
            this.labelInofrmacjaOWadzie.Name = "labelInofrmacjaOWadzie";
            this.labelInofrmacjaOWadzie.Size = new System.Drawing.Size(72, 13);
            this.labelInofrmacjaOWadzie.TabIndex = 3;
            this.labelInofrmacjaOWadzie.Text = "Wada części:";
            // 
            // richTextBoxWadyCzęsci
            // 
            this.richTextBoxWadyCzęsci.Location = new System.Drawing.Point(19, 333);
            this.richTextBoxWadyCzęsci.Name = "richTextBoxWadyCzęsci";
            this.richTextBoxWadyCzęsci.Size = new System.Drawing.Size(373, 96);
            this.richTextBoxWadyCzęsci.TabIndex = 4;
            this.richTextBoxWadyCzęsci.Text = "";
            // 
            // labelDodajInformacje
            // 
            this.labelDodajInformacje.AutoSize = true;
            this.labelDodajInformacje.Location = new System.Drawing.Point(406, 48);
            this.labelDodajInformacje.Name = "labelDodajInformacje";
            this.labelDodajInformacje.Size = new System.Drawing.Size(79, 13);
            this.labelDodajInformacje.TabIndex = 5;
            this.labelDodajInformacje.Text = "Aktualizuj dane";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ilość sprawdzonych sztuk";
            // 
            // textBoxIloscSprawdzonychSztuk
            // 
            this.textBoxIloscSprawdzonychSztuk.Location = new System.Drawing.Point(548, 80);
            this.textBoxIloscSprawdzonychSztuk.Name = "textBoxIloscSprawdzonychSztuk";
            this.textBoxIloscSprawdzonychSztuk.Size = new System.Drawing.Size(125, 20);
            this.textBoxIloscSprawdzonychSztuk.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Częsci OK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Częsci NOK";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(407, 80);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(125, 20);
            this.textBoxData.TabIndex = 13;
            // 
            // textBoxIloscOK
            // 
            this.textBoxIloscOK.Location = new System.Drawing.Point(407, 124);
            this.textBoxIloscOK.Name = "textBoxIloscOK";
            this.textBoxIloscOK.Size = new System.Drawing.Size(125, 20);
            this.textBoxIloscOK.TabIndex = 14;
            // 
            // textBoxIloscNok
            // 
            this.textBoxIloscNok.Location = new System.Drawing.Point(548, 124);
            this.textBoxIloscNok.Name = "textBoxIloscNok";
            this.textBoxIloscNok.Size = new System.Drawing.Size(125, 20);
            this.textBoxIloscNok.TabIndex = 15;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(407, 162);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(266, 36);
            this.buttonDodaj.TabIndex = 16;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(407, 204);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(266, 39);
            this.buttonUsun.TabIndex = 17;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonAktualizuj
            // 
            this.buttonAktualizuj.Location = new System.Drawing.Point(407, 331);
            this.buttonAktualizuj.Name = "buttonAktualizuj";
            this.buttonAktualizuj.Size = new System.Drawing.Size(264, 35);
            this.buttonAktualizuj.TabIndex = 18;
            this.buttonAktualizuj.Text = "Aktualizuj Wadę";
            this.buttonAktualizuj.UseVisualStyleBackColor = true;
            this.buttonAktualizuj.Click += new System.EventHandler(this.buttonAktualizuj_Click);
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Location = new System.Drawing.Point(407, 384);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(264, 45);
            this.buttonZamknij.TabIndex = 19;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // labelInfoBlad
            // 
            this.labelInfoBlad.AutoSize = true;
            this.labelInfoBlad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoBlad.Location = new System.Drawing.Point(406, 9);
            this.labelInfoBlad.Name = "labelInfoBlad";
            this.labelInfoBlad.Size = new System.Drawing.Size(50, 18);
            this.labelInfoBlad.TabIndex = 20;
            this.labelInfoBlad.Text = "label1";
            this.labelInfoBlad.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Statystyki:";
            // 
            // labelStatystyki
            // 
            this.labelStatystyki.AutoSize = true;
            this.labelStatystyki.Location = new System.Drawing.Point(19, 284);
            this.labelStatystyki.Name = "labelStatystyki";
            this.labelStatystyki.Size = new System.Drawing.Size(322, 13);
            this.labelStatystyki.TabIndex = 22;
            this.labelStatystyki.Text = "Sprawdzono:   sztuk, 10 sztuk było OK, znaleziono 100 sztuk NOK";
            // 
            // EdytujSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.labelStatystyki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelInfoBlad);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.buttonAktualizuj);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxIloscNok);
            this.Controls.Add(this.textBoxIloscOK);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIloscSprawdzonychSztuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDodajInformacje);
            this.Controls.Add(this.richTextBoxWadyCzęsci);
            this.Controls.Add(this.labelInofrmacjaOWadzie);
            this.Controls.Add(this.listView1);
            this.Controls.Add(labelInfo);
            this.Controls.Add(this.labelEdytowanySort);
            this.Name = "EdytujSort";
            this.Text = "EdytujSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEdytowanySort;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader columnIlosc;
        private System.Windows.Forms.ColumnHeader CzesciOk;
        private System.Windows.Forms.ColumnHeader CzesciNok;
        private System.Windows.Forms.Label labelInofrmacjaOWadzie;
        private System.Windows.Forms.RichTextBox richTextBoxWadyCzęsci;
        private System.Windows.Forms.Label labelDodajInformacje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIloscSprawdzonychSztuk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxIloscOK;
        private System.Windows.Forms.TextBox textBoxIloscNok;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonAktualizuj;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Label labelInfoBlad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelStatystyki;
    }
}
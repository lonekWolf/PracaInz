namespace LaboratoriumWabco
{
    partial class DodajWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxNumerCzesci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wabcoDBDataSet = new LaboratoriumWabco.WabcoDBDataSet();
            this.textBoxLinia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxMQE = new System.Windows.Forms.TextBox();
            this.textBoxFirma = new System.Windows.Forms.TextBox();
            this.textBoxInzynier = new System.Windows.Forms.TextBox();
            this.labelInformacja = new System.Windows.Forms.Label();
            this.richTextBoxOpis = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wabcoDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zamknij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dodaj sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxNumerCzesci
            // 
            this.textBoxNumerCzesci.Location = new System.Drawing.Point(19, 81);
            this.textBoxNumerCzesci.Name = "textBoxNumerCzesci";
            this.textBoxNumerCzesci.Size = new System.Drawing.Size(123, 20);
            this.textBoxNumerCzesci.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numer częsci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Linia";
            // 
            // wabcoDBDataSet
            // 
            this.wabcoDBDataSet.DataSetName = "WabcoDBDataSet";
            this.wabcoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxLinia
            // 
            this.textBoxLinia.Location = new System.Drawing.Point(19, 125);
            this.textBoxLinia.Name = "textBoxLinia";
            this.textBoxLinia.Size = new System.Drawing.Size(123, 20);
            this.textBoxLinia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data uruchomienia sortu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "MQE odpowiedzialny za sort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(196, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Opis problemu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Firma dostarczająca części";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Inżynier liniowy";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(157, 79);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(137, 20);
            this.textBoxData.TabIndex = 11;
            // 
            // textBoxMQE
            // 
            this.textBoxMQE.Location = new System.Drawing.Point(157, 124);
            this.textBoxMQE.Name = "textBoxMQE";
            this.textBoxMQE.Size = new System.Drawing.Size(137, 20);
            this.textBoxMQE.TabIndex = 12;
            // 
            // textBoxFirma
            // 
            this.textBoxFirma.Location = new System.Drawing.Point(316, 81);
            this.textBoxFirma.Name = "textBoxFirma";
            this.textBoxFirma.Size = new System.Drawing.Size(128, 20);
            this.textBoxFirma.TabIndex = 14;
            // 
            // textBoxInzynier
            // 
            this.textBoxInzynier.Location = new System.Drawing.Point(316, 125);
            this.textBoxInzynier.Name = "textBoxInzynier";
            this.textBoxInzynier.Size = new System.Drawing.Size(131, 20);
            this.textBoxInzynier.TabIndex = 15;
            // 
            // labelInformacja
            // 
            this.labelInformacja.AutoSize = true;
            this.labelInformacja.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInformacja.Location = new System.Drawing.Point(465, 25);
            this.labelInformacja.Name = "labelInformacja";
            this.labelInformacja.Size = new System.Drawing.Size(48, 22);
            this.labelInformacja.TabIndex = 16;
            this.labelInformacja.Text = "Błąd";
            this.labelInformacja.Visible = false;
            this.labelInformacja.Click += new System.EventHandler(this.labelInformacja_Click);
            // 
            // richTextBoxOpis
            // 
            this.richTextBoxOpis.Location = new System.Drawing.Point(19, 178);
            this.richTextBoxOpis.Name = "richTextBoxOpis";
            this.richTextBoxOpis.Size = new System.Drawing.Size(428, 79);
            this.richTextBoxOpis.TabIndex = 13;
            this.richTextBoxOpis.Text = "";
            // 
            // DodajWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 284);
            this.Controls.Add(this.labelInformacja);
            this.Controls.Add(this.textBoxInzynier);
            this.Controls.Add(this.textBoxFirma);
            this.Controls.Add(this.richTextBoxOpis);
            this.Controls.Add(this.textBoxMQE);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLinia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumerCzesci);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DodajWindow";
            this.Text = "Dodaj Sort";
            this.Load += new System.EventHandler(this.DodajWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wabcoDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxNumerCzesci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WabcoDBDataSet wabcoDBDataSet;
        private System.Windows.Forms.TextBox textBoxLinia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxMQE;
        private System.Windows.Forms.TextBox textBoxFirma;
        private System.Windows.Forms.TextBox textBoxInzynier;
        private System.Windows.Forms.Label labelInformacja;
        private System.Windows.Forms.RichTextBox richTextBoxOpis;
    }
}
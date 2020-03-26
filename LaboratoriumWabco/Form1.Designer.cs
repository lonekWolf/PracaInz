namespace LaboratoriumWabco
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.wabcoDBDataSet = new LaboratoriumWabco.WabcoDBDataSet();
            this.aktualneSortyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aktualneSortyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aktualneSortyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aktualneSortyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.aktualneSortyBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.aktualneSortyBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.aktualneSortyBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.labelInformacja = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wabcoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktualneSortyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktualneSortyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktualneSortyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktualneSortyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktualneSortyBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktualneSortyBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktualneSortyBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 79);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(563, 277);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Numer Części";
            this.columnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Linia";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Uruchomienia Sortu";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 139;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Opis";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MQE";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(182, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista Aktualnych Sortów";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Usuń Sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(582, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 27);
            this.button4.TabIndex = 5;
            this.button4.Text = "Zamknij";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(582, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 48);
            this.button5.TabIndex = 7;
            this.button5.Text = "Archiwum";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // wabcoDBDataSet
            // 
            this.wabcoDBDataSet.DataSetName = "WabcoDBDataSet";
            this.wabcoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aktualneSortyBindingSource
            // 
            this.aktualneSortyBindingSource.DataSource = this.wabcoDBDataSet;
            this.aktualneSortyBindingSource.Position = 0;
            // 
            // aktualneSortyBindingSource1
            // 
            this.aktualneSortyBindingSource1.DataSource = this.wabcoDBDataSet;
            this.aktualneSortyBindingSource1.Position = 0;
            // 
            // aktualneSortyBindingSource2
            // 
            this.aktualneSortyBindingSource2.DataSource = this.wabcoDBDataSet;
            this.aktualneSortyBindingSource2.Position = 0;
            // 
            // aktualneSortyBindingSource3
            // 
            this.aktualneSortyBindingSource3.DataSource = this.wabcoDBDataSet;
            this.aktualneSortyBindingSource3.Position = 0;
            // 
            // aktualneSortyBindingSource4
            // 
            this.aktualneSortyBindingSource4.DataSource = this.wabcoDBDataSet;
            this.aktualneSortyBindingSource4.Position = 0;
            // 
            // aktualneSortyBindingSource5
            // 
            this.aktualneSortyBindingSource5.DataSource = this.wabcoDBDataSet;
            this.aktualneSortyBindingSource5.Position = 0;
            // 
            // aktualneSortyBindingSource6
            // 
            this.aktualneSortyBindingSource6.DataSource = this.wabcoDBDataSet;
            this.aktualneSortyBindingSource6.Position = 0;
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(581, 149);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(149, 56);
            this.buttonEdytuj.TabIndex = 8;
            this.buttonEdytuj.Text = "Edytuj sort";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelInformacja
            // 
            this.labelInformacja.AutoSize = true;
            this.labelInformacja.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInformacja.Location = new System.Drawing.Point(579, 51);
            this.labelInformacja.Name = "labelInformacja";
            this.labelInformacja.Size = new System.Drawing.Size(50, 18);
            this.labelInformacja.TabIndex = 9;
            this.labelInformacja.Text = "label1";
            this.labelInformacja.Visible = false;
            this.labelInformacja.Click += new System.EventHandler(this.labelInformacja_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 364);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelInformacja);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wabcoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktualneSortyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktualneSortyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktualneSortyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktualneSortyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktualneSortyBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktualneSortyBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktualneSortyBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private WabcoDBDataSet wabcoDBDataSet;
        private System.Windows.Forms.BindingSource aktualneSortyBindingSource;
         
        private System.Windows.Forms.BindingSource aktualneSortyBindingSource1;
        private System.Windows.Forms.BindingSource aktualneSortyBindingSource2;
        private System.Windows.Forms.BindingSource aktualneSortyBindingSource3;
        private System.Windows.Forms.BindingSource aktualneSortyBindingSource4;
        private System.Windows.Forms.BindingSource aktualneSortyBindingSource5;
        private System.Windows.Forms.BindingSource aktualneSortyBindingSource6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.Label labelInformacja;
        private System.Windows.Forms.Label label2;
    }
}


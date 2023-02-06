namespace ECommerce2
{
    partial class Form1
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
            this.tipoBox = new System.Windows.Forms.ComboBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.descrizioneBox = new System.Windows.Forms.TextBox();
            this.produttoreBox = new System.Windows.Forms.TextBox();
            this.prezzoBox = new System.Windows.Forms.NumericUpDown();
            this.aggiungiButton = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.scadenzaLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.prezzoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoBox
            // 
            this.tipoBox.FormattingEnabled = true;
            this.tipoBox.Items.AddRange(new object[] {
            "Prodotto alimentare",
            "Prodotto elettronico",
            "Penna",
            "Foglio di carta"});
            this.tipoBox.Location = new System.Drawing.Point(590, 24);
            this.tipoBox.Name = "tipoBox";
            this.tipoBox.Size = new System.Drawing.Size(199, 23);
            this.tipoBox.TabIndex = 1;
            this.tipoBox.SelectedIndexChanged += new System.EventHandler(this.tipoBox_SelectedIndexChanged);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(12, 24);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(63, 23);
            this.idBox.TabIndex = 2;
            // 
            // descrizioneBox
            // 
            this.descrizioneBox.Location = new System.Drawing.Point(12, 80);
            this.descrizioneBox.Name = "descrizioneBox";
            this.descrizioneBox.Size = new System.Drawing.Size(169, 23);
            this.descrizioneBox.TabIndex = 3;
            // 
            // produttoreBox
            // 
            this.produttoreBox.Location = new System.Drawing.Point(203, 24);
            this.produttoreBox.Name = "produttoreBox";
            this.produttoreBox.Size = new System.Drawing.Size(169, 23);
            this.produttoreBox.TabIndex = 5;
            // 
            // prezzoBox
            // 
            this.prezzoBox.Location = new System.Drawing.Point(203, 81);
            this.prezzoBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.prezzoBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prezzoBox.Name = "prezzoBox";
            this.prezzoBox.Size = new System.Drawing.Size(120, 23);
            this.prezzoBox.TabIndex = 6;
            this.prezzoBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // aggiungiButton
            // 
            this.aggiungiButton.Location = new System.Drawing.Point(714, 81);
            this.aggiungiButton.Name = "aggiungiButton";
            this.aggiungiButton.Size = new System.Drawing.Size(75, 23);
            this.aggiungiButton.TabIndex = 7;
            this.aggiungiButton.Text = "Aggiungi";
            this.aggiungiButton.UseVisualStyleBackColor = true;
            this.aggiungiButton.Click += new System.EventHandler(this.aggiungiButton_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(12, 145);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(777, 417);
            this.list.TabIndex = 8;
            this.list.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Produttore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Prezzo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tipo di prodotto";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(385, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 23);
            this.textBox3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Varie";
            // 
            // scadenzaLabel
            // 
            this.scadenzaLabel.AutoSize = true;
            this.scadenzaLabel.Location = new System.Drawing.Point(385, 62);
            this.scadenzaLabel.Name = "scadenzaLabel";
            this.scadenzaLabel.Size = new System.Drawing.Size(95, 15);
            this.scadenzaLabel.TabIndex = 17;
            this.scadenzaLabel.Text = "Data di scadenza";
            this.scadenzaLabel.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(385, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2023, 2, 6, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 574);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.scadenzaLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.aggiungiButton);
            this.Controls.Add(this.prezzoBox);
            this.Controls.Add(this.produttoreBox);
            this.Controls.Add(this.descrizioneBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.tipoBox);
            this.Name = "Form1";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prezzoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox tipoBox;
        private TextBox idBox;
        private TextBox descrizioneBox;
        private TextBox produttoreBox;
        private NumericUpDown prezzoBox;
        private Button aggiungiButton;
        private ListView list;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private Label scadenzaLabel;
        private DateTimePicker dateTimePicker1;
    }
}
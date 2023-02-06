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
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(12, 145);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(777, 417);
            this.list.TabIndex = 8;
            this.list.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 574);
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
    }
}
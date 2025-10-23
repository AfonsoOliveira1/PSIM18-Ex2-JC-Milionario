namespace Money230065
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
            this.mtxtSimbolo = new System.Windows.Forms.MaskedTextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblSimbolo = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.mtxtPreco = new System.Windows.Forms.MaskedTextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.grbMoeda = new System.Windows.Forms.GroupBox();
            this.rbEuro = new System.Windows.Forms.RadioButton();
            this.rbDolar = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grbMoeda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxtSimbolo
            // 
            this.mtxtSimbolo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSimbolo.Location = new System.Drawing.Point(38, 73);
            this.mtxtSimbolo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtSimbolo.Mask = "L???";
            this.mtxtSimbolo.Name = "mtxtSimbolo";
            this.mtxtSimbolo.Size = new System.Drawing.Size(71, 27);
            this.mtxtSimbolo.TabIndex = 0;
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txtQtd.Location = new System.Drawing.Point(228, 168);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(202, 27);
            this.txtQtd.TabIndex = 1;
            // 
            // lblSimbolo
            // 
            this.lblSimbolo.AutoSize = true;
            this.lblSimbolo.Location = new System.Drawing.Point(34, 45);
            this.lblSimbolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSimbolo.Name = "lblSimbolo";
            this.lblSimbolo.Size = new System.Drawing.Size(75, 19);
            this.lblSimbolo.TabIndex = 2;
            this.lblSimbolo.Text = "Simbolo";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(224, 140);
            this.lblQtd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(107, 19);
            this.lblQtd.TabIndex = 3;
            this.lblQtd.Text = "Quantidade";
            // 
            // mtxtPreco
            // 
            this.mtxtPreco.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.mtxtPreco.Location = new System.Drawing.Point(34, 168);
            this.mtxtPreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtPreco.Mask = "99990,000";
            this.mtxtPreco.Name = "mtxtPreco";
            this.mtxtPreco.Size = new System.Drawing.Size(186, 27);
            this.mtxtPreco.TabIndex = 4;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(34, 140);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(134, 19);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preço unitário";
            // 
            // grbMoeda
            // 
            this.grbMoeda.Controls.Add(this.rbDolar);
            this.grbMoeda.Controls.Add(this.rbEuro);
            this.grbMoeda.Location = new System.Drawing.Point(451, 45);
            this.grbMoeda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbMoeda.Name = "grbMoeda";
            this.grbMoeda.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbMoeda.Size = new System.Drawing.Size(152, 199);
            this.grbMoeda.TabIndex = 6;
            this.grbMoeda.TabStop = false;
            this.grbMoeda.Text = "Moeda";
            // 
            // rbEuro
            // 
            this.rbEuro.AutoSize = true;
            this.rbEuro.Location = new System.Drawing.Point(24, 71);
            this.rbEuro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbEuro.Name = "rbEuro";
            this.rbEuro.Size = new System.Drawing.Size(70, 23);
            this.rbEuro.TabIndex = 0;
            this.rbEuro.TabStop = true;
            this.rbEuro.Text = "Euro";
            this.rbEuro.UseVisualStyleBackColor = true;
            // 
            // rbDolar
            // 
            this.rbDolar.AutoSize = true;
            this.rbDolar.Location = new System.Drawing.Point(24, 133);
            this.rbDolar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDolar.Name = "rbDolar";
            this.rbDolar.Size = new System.Drawing.Size(76, 23);
            this.rbDolar.TabIndex = 1;
            this.rbDolar.TabStop = true;
            this.rbDolar.Text = "Dólar";
            this.rbDolar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnComprar);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.btnCarregar);
            this.panel1.Controls.Add(this.lblSimbolo);
            this.panel1.Controls.Add(this.mtxtSimbolo);
            this.panel1.Controls.Add(this.grbMoeda);
            this.panel1.Controls.Add(this.txtQtd);
            this.panel1.Controls.Add(this.lblPreco);
            this.panel1.Controls.Add(this.lblQtd);
            this.panel1.Controls.Add(this.mtxtPreco);
            this.panel1.Location = new System.Drawing.Point(45, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 660);
            this.panel1.TabIndex = 8;
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCarregar.Location = new System.Drawing.Point(332, 583);
            this.btnCarregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(271, 44);
            this.btnCarregar.TabIndex = 9;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFiltrar.Location = new System.Drawing.Point(38, 220);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(286, 43);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnComprar.Location = new System.Drawing.Point(38, 583);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(286, 44);
            this.btnComprar.TabIndex = 11;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(38, 279);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(565, 290);
            this.listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(723, 739);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbMoeda.ResumeLayout(false);
            this.grbMoeda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtSimbolo;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblSimbolo;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.MaskedTextBox mtxtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.GroupBox grbMoeda;
        private System.Windows.Forms.RadioButton rbDolar;
        private System.Windows.Forms.RadioButton rbEuro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.ListBox listBox1;
    }
}



namespace daKuzey01
{
    partial class Urunfrm
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
            this.txturunad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nbirimfiyat = new System.Windows.Forms.NumericUpDown();
            this.cmbtedarik = new System.Windows.Forms.ComboBox();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.dgurun = new System.Windows.Forms.DataGridView();
            this.btnekleado = new System.Windows.Forms.Button();
            this.btnekleadosp = new System.Windows.Forms.Button();
            this.btnekleentity = new System.Windows.Forms.Button();
            this.btnekleentitysp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbirimfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgurun)).BeginInit();
            this.SuspendLayout();
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(108, 24);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(277, 23);
            this.txturunad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tedarikçi Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategori Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birim fiyatı";
            // 
            // nbirimfiyat
            // 
            this.nbirimfiyat.Location = new System.Drawing.Point(108, 114);
            this.nbirimfiyat.Name = "nbirimfiyat";
            this.nbirimfiyat.Size = new System.Drawing.Size(120, 23);
            this.nbirimfiyat.TabIndex = 8;
            // 
            // cmbtedarik
            // 
            this.cmbtedarik.FormattingEnabled = true;
            this.cmbtedarik.Location = new System.Drawing.Point(108, 54);
            this.cmbtedarik.Name = "cmbtedarik";
            this.cmbtedarik.Size = new System.Drawing.Size(277, 23);
            this.cmbtedarik.TabIndex = 9;
            // 
            // cmbkategori
            // 
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Location = new System.Drawing.Point(108, 85);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(277, 23);
            this.cmbkategori.TabIndex = 10;
            // 
            // dgurun
            // 
            this.dgurun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgurun.Location = new System.Drawing.Point(12, 146);
            this.dgurun.Name = "dgurun";
            this.dgurun.RowTemplate.Height = 25;
            this.dgurun.Size = new System.Drawing.Size(914, 292);
            this.dgurun.TabIndex = 11;
            // 
            // btnekleado
            // 
            this.btnekleado.Location = new System.Drawing.Point(400, 19);
            this.btnekleado.Name = "btnekleado";
            this.btnekleado.Size = new System.Drawing.Size(122, 23);
            this.btnekleado.TabIndex = 12;
            this.btnekleado.Text = "Ekle (Ado)";
            this.btnekleado.UseVisualStyleBackColor = true;
            this.btnekleado.Click += new System.EventHandler(this.btnekleado_Click);
            // 
            // btnekleadosp
            // 
            this.btnekleadosp.Location = new System.Drawing.Point(400, 52);
            this.btnekleadosp.Name = "btnekleadosp";
            this.btnekleadosp.Size = new System.Drawing.Size(122, 23);
            this.btnekleadosp.TabIndex = 12;
            this.btnekleadosp.Text = "Ekle (Ado SP)";
            this.btnekleadosp.UseVisualStyleBackColor = true;
            this.btnekleadosp.Click += new System.EventHandler(this.btnekleadosp_Click);
            // 
            // btnekleentity
            // 
            this.btnekleentity.Location = new System.Drawing.Point(400, 81);
            this.btnekleentity.Name = "btnekleentity";
            this.btnekleentity.Size = new System.Drawing.Size(122, 23);
            this.btnekleentity.TabIndex = 12;
            this.btnekleentity.Text = "Ekle (Entity)";
            this.btnekleentity.UseVisualStyleBackColor = true;
            // 
            // btnekleentitysp
            // 
            this.btnekleentitysp.Location = new System.Drawing.Point(400, 111);
            this.btnekleentitysp.Name = "btnekleentitysp";
            this.btnekleentitysp.Size = new System.Drawing.Size(122, 23);
            this.btnekleentitysp.TabIndex = 12;
            this.btnekleentitysp.Text = "Ekle (Entity SP)";
            this.btnekleentitysp.UseVisualStyleBackColor = true;
            // 
            // Urunfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.btnekleentitysp);
            this.Controls.Add(this.btnekleentity);
            this.Controls.Add(this.btnekleadosp);
            this.Controls.Add(this.btnekleado);
            this.Controls.Add(this.dgurun);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.cmbtedarik);
            this.Controls.Add(this.nbirimfiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txturunad);
            this.Name = "Urunfrm";
            this.Text = "Urunfrm";
            ((System.ComponentModel.ISupportInitialize)(this.nbirimfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgurun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nbirimfiyat;
        private System.Windows.Forms.ComboBox cmbtedarik;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.DataGridView dgurun;
        private System.Windows.Forms.Button btnekleado;
        private System.Windows.Forms.Button btnekleadosp;
        private System.Windows.Forms.Button btnekleentity;
        private System.Windows.Forms.Button btnekleentitysp;
    }
}
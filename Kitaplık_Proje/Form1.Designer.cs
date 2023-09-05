namespace Kitaplık_Proje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKitapid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxTur = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtKitapad = new System.Windows.Forms.TextBox();
            this.Txtyazar = new System.Windows.Forms.TextBox();
            this.Txtsayfa = new System.Windows.Forms.TextBox();
            this.Btnlistele = new System.Windows.Forms.Button();
            this.Btnsil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.Btnguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap İd:";
            // 
            // TxtKitapid
            // 
            this.TxtKitapid.Location = new System.Drawing.Point(159, 17);
            this.TxtKitapid.Name = "TxtKitapid";
            this.TxtKitapid.Size = new System.Drawing.Size(187, 36);
            this.TxtKitapid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yazar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sayfa:";
            // 
            // CbxTur
            // 
            this.CbxTur.FormattingEnabled = true;
            this.CbxTur.Location = new System.Drawing.Point(159, 230);
            this.CbxTur.Name = "CbxTur";
            this.CbxTur.Size = new System.Drawing.Size(187, 36);
            this.CbxTur.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(159, 279);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(135, 32);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kullanılmış";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(300, 279);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 32);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sıfır";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tür:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durum:";
            // 
            // TxtKitapad
            // 
            this.TxtKitapad.Location = new System.Drawing.Point(159, 69);
            this.TxtKitapad.Name = "TxtKitapad";
            this.TxtKitapad.Size = new System.Drawing.Size(187, 36);
            this.TxtKitapad.TabIndex = 11;
            // 
            // Txtyazar
            // 
            this.Txtyazar.Location = new System.Drawing.Point(159, 127);
            this.Txtyazar.Name = "Txtyazar";
            this.Txtyazar.Size = new System.Drawing.Size(187, 36);
            this.Txtyazar.TabIndex = 12;
            // 
            // Txtsayfa
            // 
            this.Txtsayfa.Location = new System.Drawing.Point(159, 178);
            this.Txtsayfa.Name = "Txtsayfa";
            this.Txtsayfa.Size = new System.Drawing.Size(187, 36);
            this.Txtsayfa.TabIndex = 13;
            // 
            // Btnlistele
            // 
            this.Btnlistele.Location = new System.Drawing.Point(478, 20);
            this.Btnlistele.Name = "Btnlistele";
            this.Btnlistele.Size = new System.Drawing.Size(201, 45);
            this.Btnlistele.TabIndex = 14;
            this.Btnlistele.Text = "Listele";
            this.Btnlistele.UseVisualStyleBackColor = true;
            this.Btnlistele.Click += new System.EventHandler(this.Btnlistele_Click);
            // 
            // Btnsil
            // 
            this.Btnsil.Location = new System.Drawing.Point(478, 97);
            this.Btnsil.Name = "Btnsil";
            this.Btnsil.Size = new System.Drawing.Size(201, 45);
            this.Btnsil.TabIndex = 15;
            this.Btnsil.Text = "Sil";
            this.Btnsil.UseVisualStyleBackColor = true;
            this.Btnsil.Click += new System.EventHandler(this.Btnsil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(478, 173);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(201, 45);
            this.BtnKaydet.TabIndex = 16;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // Btnguncelle
            // 
            this.Btnguncelle.Location = new System.Drawing.Point(478, 245);
            this.Btnguncelle.Name = "Btnguncelle";
            this.Btnguncelle.Size = new System.Drawing.Size(201, 45);
            this.Btnguncelle.TabIndex = 17;
            this.Btnguncelle.Text = "Güncelle";
            this.Btnguncelle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(798, 521);
            this.Controls.Add(this.Btnguncelle);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.Btnsil);
            this.Controls.Add(this.Btnlistele);
            this.Controls.Add(this.Txtsayfa);
            this.Controls.Add(this.Txtyazar);
            this.Controls.Add(this.TxtKitapad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.CbxTur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKitapid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKitapid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxTur;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtKitapad;
        private System.Windows.Forms.TextBox Txtyazar;
        private System.Windows.Forms.TextBox Txtsayfa;
        private System.Windows.Forms.Button Btnlistele;
        private System.Windows.Forms.Button Btnsil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button Btnguncelle;
    }
}


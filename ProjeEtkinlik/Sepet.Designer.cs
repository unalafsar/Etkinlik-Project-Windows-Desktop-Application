namespace ProjeEtkinlik
{
    partial class Sepet
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button67 = new System.Windows.Forms.Button();
            this.etkinlikProjesiDataSet13 = new ProjeEtkinlik.EtkinlikProjesiDataSet13();
            this.etkinlikKayıtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etkinlikKayıtTableAdapter = new ProjeEtkinlik.EtkinlikProjesiDataSet13TableAdapters.EtkinlikKayıtTableAdapter();
            this.etkinlikProjesiDataSet14 = new ProjeEtkinlik.EtkinlikProjesiDataSet14();
            this.ogrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrencilerTableAdapter = new ProjeEtkinlik.EtkinlikProjesiDataSet14TableAdapters.OgrencilerTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.etkinlikProjesiDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etkinlikKayıtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etkinlikProjesiDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(410, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Satın Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sepetim";
            // 
            // button67
            // 
            this.button67.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button67.Location = new System.Drawing.Point(12, 12);
            this.button67.Name = "button67";
            this.button67.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button67.Size = new System.Drawing.Size(98, 36);
            this.button67.TabIndex = 17;
            this.button67.Text = "Geri Dön";
            this.button67.UseVisualStyleBackColor = true;
            this.button67.Click += new System.EventHandler(this.button67_Click);
            // 
            // etkinlikProjesiDataSet13
            // 
            this.etkinlikProjesiDataSet13.DataSetName = "EtkinlikProjesiDataSet13";
            this.etkinlikProjesiDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etkinlikKayıtBindingSource
            // 
            this.etkinlikKayıtBindingSource.DataMember = "EtkinlikKayıt";
            this.etkinlikKayıtBindingSource.DataSource = this.etkinlikProjesiDataSet13;
            // 
            // etkinlikKayıtTableAdapter
            // 
            this.etkinlikKayıtTableAdapter.ClearBeforeFill = true;
            // 
            // etkinlikProjesiDataSet14
            // 
            this.etkinlikProjesiDataSet14.DataSetName = "EtkinlikProjesiDataSet14";
            this.etkinlikProjesiDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencilerBindingSource
            // 
            this.ogrencilerBindingSource.DataMember = "Ogrenciler";
            this.ogrencilerBindingSource.DataSource = this.etkinlikProjesiDataSet14;
            // 
            // ogrencilerTableAdapter
            // 
            this.ogrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(228, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 30);
            this.textBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "label2";
            // 
            // Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button67);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Sepet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.Sepet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.etkinlikProjesiDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etkinlikKayıtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etkinlikProjesiDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button67;
        private EtkinlikProjesiDataSet13 etkinlikProjesiDataSet13;
        private System.Windows.Forms.BindingSource etkinlikKayıtBindingSource;
        private EtkinlikProjesiDataSet13TableAdapters.EtkinlikKayıtTableAdapter etkinlikKayıtTableAdapter;
        private EtkinlikProjesiDataSet14 etkinlikProjesiDataSet14;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource;
        private EtkinlikProjesiDataSet14TableAdapters.OgrencilerTableAdapter ogrencilerTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}
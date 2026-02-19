namespace Fuggohidak
{
    partial class KeresesForm
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
            this.listBoxFormHidak = new System.Windows.Forms.ListBox();
            this.groupBoxKereses = new System.Windows.Forms.GroupBox();
            this.labelOrszagForm = new System.Windows.Forms.Label();
            this.checkBoxKeresos = new System.Windows.Forms.CheckBox();
            this.comboBoxOrszagok = new System.Windows.Forms.ComboBox();
            this.buttonKereses = new System.Windows.Forms.Button();
            this.buttonBezar = new System.Windows.Forms.Button();
            this.groupBoxKereses.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFormHidak
            // 
            this.listBoxFormHidak.FormattingEnabled = true;
            this.listBoxFormHidak.Location = new System.Drawing.Point(37, 12);
            this.listBoxFormHidak.Name = "listBoxFormHidak";
            this.listBoxFormHidak.Size = new System.Drawing.Size(510, 225);
            this.listBoxFormHidak.TabIndex = 0;
            // 
            // groupBoxKereses
            // 
            this.groupBoxKereses.Controls.Add(this.buttonBezar);
            this.groupBoxKereses.Controls.Add(this.buttonKereses);
            this.groupBoxKereses.Controls.Add(this.comboBoxOrszagok);
            this.groupBoxKereses.Controls.Add(this.checkBoxKeresos);
            this.groupBoxKereses.Controls.Add(this.labelOrszagForm);
            this.groupBoxKereses.Location = new System.Drawing.Point(37, 266);
            this.groupBoxKereses.Name = "groupBoxKereses";
            this.groupBoxKereses.Size = new System.Drawing.Size(510, 183);
            this.groupBoxKereses.TabIndex = 1;
            this.groupBoxKereses.TabStop = false;
            this.groupBoxKereses.Text = "Keresés";
            // 
            // labelOrszagForm
            // 
            this.labelOrszagForm.AutoSize = true;
            this.labelOrszagForm.Location = new System.Drawing.Point(23, 42);
            this.labelOrszagForm.Name = "labelOrszagForm";
            this.labelOrszagForm.Size = new System.Drawing.Size(40, 13);
            this.labelOrszagForm.TabIndex = 0;
            this.labelOrszagForm.Text = "Ország";
            // 
            // checkBoxKeresos
            // 
            this.checkBoxKeresos.AutoSize = true;
            this.checkBoxKeresos.Location = new System.Drawing.Point(26, 78);
            this.checkBoxKeresos.Name = "checkBoxKeresos";
            this.checkBoxKeresos.Size = new System.Drawing.Size(126, 17);
            this.checkBoxKeresos.TabIndex = 1;
            this.checkBoxKeresos.Text = "1 km-nél hosszabbak";
            this.checkBoxKeresos.UseVisualStyleBackColor = true;
            // 
            // comboBoxOrszagok
            // 
            this.comboBoxOrszagok.FormattingEnabled = true;
            this.comboBoxOrszagok.Location = new System.Drawing.Point(132, 39);
            this.comboBoxOrszagok.Name = "comboBoxOrszagok";
            this.comboBoxOrszagok.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrszagok.TabIndex = 2;
            // 
            // buttonKereses
            // 
            this.buttonKereses.Location = new System.Drawing.Point(108, 120);
            this.buttonKereses.Name = "buttonKereses";
            this.buttonKereses.Size = new System.Drawing.Size(75, 23);
            this.buttonKereses.TabIndex = 3;
            this.buttonKereses.Text = "Keresés";
            this.buttonKereses.UseVisualStyleBackColor = true;
            this.buttonKereses.Click += new System.EventHandler(this.buttonKereses_Click);
            // 
            // buttonBezar
            // 
            this.buttonBezar.Location = new System.Drawing.Point(331, 120);
            this.buttonBezar.Name = "buttonBezar";
            this.buttonBezar.Size = new System.Drawing.Size(75, 23);
            this.buttonBezar.TabIndex = 4;
            this.buttonBezar.Text = "Bezárás";
            this.buttonBezar.UseVisualStyleBackColor = true;
            this.buttonBezar.Click += new System.EventHandler(this.buttonBezar_Click);
            // 
            // KeresesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.groupBoxKereses);
            this.Controls.Add(this.listBoxFormHidak);
            this.Name = "KeresesForm";
            this.Text = "Keresés";
            this.Load += new System.EventHandler(this.KeresesForm_Load);
            this.groupBoxKereses.ResumeLayout(false);
            this.groupBoxKereses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFormHidak;
        private System.Windows.Forms.GroupBox groupBoxKereses;
        private System.Windows.Forms.Button buttonBezar;
        private System.Windows.Forms.Button buttonKereses;
        private System.Windows.Forms.ComboBox comboBoxOrszagok;
        private System.Windows.Forms.CheckBox checkBoxKeresos;
        private System.Windows.Forms.Label labelOrszagForm;
    }
}
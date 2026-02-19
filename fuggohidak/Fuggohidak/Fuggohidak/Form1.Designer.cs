namespace Fuggohidak
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxHidak = new System.Windows.Forms.ListBox();
            this.groupBoxRadio = new System.Windows.Forms.GroupBox();
            this.radio2000Utan = new System.Windows.Forms.RadioButton();
            this.radio2000Elott = new System.Windows.Forms.RadioButton();
            this.textBoxHidSzam = new System.Windows.Forms.TextBox();
            this.buttonKilep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHely = new System.Windows.Forms.TextBox();
            this.textBoxOrszag = new System.Windows.Forms.TextBox();
            this.textBoxHossz = new System.Windows.Forms.TextBox();
            this.textBoxEv = new System.Windows.Forms.TextBox();
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBoxRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitásToolStripMenuItem,
            this.keresésToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.keresésToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // listBoxHidak
            // 
            this.listBoxHidak.FormattingEnabled = true;
            this.listBoxHidak.Location = new System.Drawing.Point(24, 44);
            this.listBoxHidak.Name = "listBoxHidak";
            this.listBoxHidak.Size = new System.Drawing.Size(275, 212);
            this.listBoxHidak.TabIndex = 2;
            this.listBoxHidak.SelectedIndexChanged += new System.EventHandler(this.listBoxHidak_SelectedIndexChanged);
            // 
            // groupBoxRadio
            // 
            this.groupBoxRadio.Controls.Add(this.label1);
            this.groupBoxRadio.Controls.Add(this.textBoxHidSzam);
            this.groupBoxRadio.Controls.Add(this.radio2000Utan);
            this.groupBoxRadio.Controls.Add(this.radio2000Elott);
            this.groupBoxRadio.Location = new System.Drawing.Point(24, 279);
            this.groupBoxRadio.Name = "groupBoxRadio";
            this.groupBoxRadio.Size = new System.Drawing.Size(275, 159);
            this.groupBoxRadio.TabIndex = 3;
            this.groupBoxRadio.TabStop = false;
            this.groupBoxRadio.Text = "Hidak száma";
            // 
            // radio2000Utan
            // 
            this.radio2000Utan.AutoSize = true;
            this.radio2000Utan.Location = new System.Drawing.Point(29, 70);
            this.radio2000Utan.Name = "radio2000Utan";
            this.radio2000Utan.Size = new System.Drawing.Size(126, 17);
            this.radio2000Utan.TabIndex = 4;
            this.radio2000Utan.TabStop = true;
            this.radio2000Utan.Text = "2000-ben vagy utána";
            this.radio2000Utan.UseVisualStyleBackColor = true;
            this.radio2000Utan.CheckedChanged += new System.EventHandler(this.radio2000Utan_CheckedChanged);
            // 
            // radio2000Elott
            // 
            this.radio2000Elott.AutoSize = true;
            this.radio2000Elott.Location = new System.Drawing.Point(29, 34);
            this.radio2000Elott.Name = "radio2000Elott";
            this.radio2000Elott.Size = new System.Drawing.Size(98, 17);
            this.radio2000Elott.TabIndex = 4;
            this.radio2000Elott.TabStop = true;
            this.radio2000Elott.Text = "2000 előtt épült";
            this.radio2000Elott.UseVisualStyleBackColor = true;
            this.radio2000Elott.CheckedChanged += new System.EventHandler(this.radio2000Elott_CheckedChanged);
            // 
            // textBoxHidSzam
            // 
            this.textBoxHidSzam.Location = new System.Drawing.Point(29, 106);
            this.textBoxHidSzam.Name = "textBoxHidSzam";
            this.textBoxHidSzam.Size = new System.Drawing.Size(100, 20);
            this.textBoxHidSzam.TabIndex = 4;
            // 
            // buttonKilep
            // 
            this.buttonKilep.Location = new System.Drawing.Point(401, 343);
            this.buttonKilep.Name = "buttonKilep";
            this.buttonKilep.Size = new System.Drawing.Size(75, 23);
            this.buttonKilep.TabIndex = 4;
            this.buttonKilep.Text = "Kilépés";
            this.buttonKilep.UseVisualStyleBackColor = true;
            this.buttonKilep.Click += new System.EventHandler(this.buttonKilep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "darab";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hely";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ország";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hossz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Év";
            // 
            // textBoxHely
            // 
            this.textBoxHely.Location = new System.Drawing.Point(401, 55);
            this.textBoxHely.Name = "textBoxHely";
            this.textBoxHely.Size = new System.Drawing.Size(100, 20);
            this.textBoxHely.TabIndex = 9;
            // 
            // textBoxOrszag
            // 
            this.textBoxOrszag.Location = new System.Drawing.Point(401, 113);
            this.textBoxOrszag.Name = "textBoxOrszag";
            this.textBoxOrszag.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrszag.TabIndex = 10;
            // 
            // textBoxHossz
            // 
            this.textBoxHossz.Location = new System.Drawing.Point(401, 171);
            this.textBoxHossz.Name = "textBoxHossz";
            this.textBoxHossz.Size = new System.Drawing.Size(100, 20);
            this.textBoxHossz.TabIndex = 11;
            // 
            // textBoxEv
            // 
            this.textBoxEv.Location = new System.Drawing.Point(401, 229);
            this.textBoxEv.Name = "textBoxEv";
            this.textBoxEv.Size = new System.Drawing.Size(100, 20);
            this.textBoxEv.TabIndex = 12;
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.textBoxEv);
            this.Controls.Add(this.textBoxHossz);
            this.Controls.Add(this.textBoxOrszag);
            this.Controls.Add(this.textBoxHely);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonKilep);
            this.Controls.Add(this.groupBoxRadio);
            this.Controls.Add(this.listBoxHidak);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Függőhidak";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxRadio.ResumeLayout(false);
            this.groupBoxRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxHidak;
        private System.Windows.Forms.GroupBox groupBoxRadio;
        private System.Windows.Forms.RadioButton radio2000Elott;
        private System.Windows.Forms.RadioButton radio2000Utan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHidSzam;
        private System.Windows.Forms.Button buttonKilep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHely;
        private System.Windows.Forms.TextBox textBoxOrszag;
        private System.Windows.Forms.TextBox textBoxHossz;
        private System.Windows.Forms.TextBox textBoxEv;
        private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
    }
}


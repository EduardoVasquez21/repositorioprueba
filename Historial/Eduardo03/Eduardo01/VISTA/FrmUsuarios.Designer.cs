
namespace Eduardo01.VISTA
{
    partial class FrmUsuarios
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
            this.trexnam = new System.Windows.Forms.TextBox();
            this.trexap = new System.Windows.Forms.TextBox();
            this.Txtedad = new System.Windows.Forms.TextBox();
            this.txtpassd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trexnam
            // 
            this.trexnam.Location = new System.Drawing.Point(118, 65);
            this.trexnam.Name = "trexnam";
            this.trexnam.Size = new System.Drawing.Size(365, 20);
            this.trexnam.TabIndex = 1;
            // 
            // trexap
            // 
            this.trexap.Location = new System.Drawing.Point(118, 132);
            this.trexap.Name = "trexap";
            this.trexap.Size = new System.Drawing.Size(354, 20);
            this.trexap.TabIndex = 2;
            // 
            // Txtedad
            // 
            this.Txtedad.Location = new System.Drawing.Point(118, 187);
            this.Txtedad.Name = "Txtedad";
            this.Txtedad.Size = new System.Drawing.Size(192, 20);
            this.Txtedad.TabIndex = 3;
            // 
            // txtpassd
            // 
            this.txtpassd.Location = new System.Drawing.Point(118, 230);
            this.txtpassd.Name = "txtpassd";
            this.txtpassd.Size = new System.Drawing.Size(323, 20);
            this.txtpassd.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtpassd);
            this.Controls.Add(this.Txtedad);
            this.Controls.Add(this.trexap);
            this.Controls.Add(this.trexnam);
            this.Controls.Add(this.button1);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox trexnam;
        private System.Windows.Forms.TextBox trexap;
        private System.Windows.Forms.TextBox Txtedad;
        private System.Windows.Forms.TextBox txtpassd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}
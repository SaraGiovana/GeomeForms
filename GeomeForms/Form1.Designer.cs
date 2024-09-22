
namespace GeomeForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAlegere = new Label();
            rbCerc = new RadioButton();
            rbTriunghiEch = new RadioButton();
            rbPatrat = new RadioButton();
            label2 = new Label();
            btnCalculeaza = new Button();
            gpRezultate = new GroupBox();
            lblArie = new Label();
            lblPerimetru = new Label();
            gpIntro = new GroupBox();
            txtIntro = new TextBox();
            gpRezultate.SuspendLayout();
            gpIntro.SuspendLayout();
            SuspendLayout();
            // 
            // lblAlegere
            // 
            lblAlegere.AutoSize = true;
            lblAlegere.Location = new Point(22, 41);
            lblAlegere.Name = "lblAlegere";
            lblAlegere.Size = new Size(135, 15);
            lblAlegere.TabIndex = 0;
            lblAlegere.Text = "Alege forma geometrică";
            lblAlegere.Click += label1_Click;
            // 
            // rbCerc
            // 
            rbCerc.AutoSize = true;
            rbCerc.Location = new Point(56, 59);
            rbCerc.Name = "rbCerc";
            rbCerc.Size = new Size(49, 19);
            rbCerc.TabIndex = 1;
            rbCerc.TabStop = true;
            rbCerc.Text = "Cerc";
            rbCerc.UseVisualStyleBackColor = true;
            // 
            // rbTriunghiEch
            // 
            rbTriunghiEch.AutoSize = true;
            rbTriunghiEch.Location = new Point(56, 84);
            rbTriunghiEch.Name = "rbTriunghiEch";
            rbTriunghiEch.Size = new Size(125, 19);
            rbTriunghiEch.TabIndex = 2;
            rbTriunghiEch.TabStop = true;
            rbTriunghiEch.Text = "Triunghi echilateral";
            rbTriunghiEch.UseVisualStyleBackColor = true;
            // 
            // rbPatrat
            // 
            rbPatrat.AutoSize = true;
            rbPatrat.Location = new Point(56, 109);
            rbPatrat.Name = "rbPatrat";
            rbPatrat.Size = new Size(56, 19);
            rbPatrat.TabIndex = 3;
            rbPatrat.TabStop = true;
            rbPatrat.Text = "Pătrat";
            rbPatrat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 194);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // btnCalculeaza
            // 
            btnCalculeaza.Location = new Point(284, 285);
            btnCalculeaza.Name = "btnCalculeaza";
            btnCalculeaza.Size = new Size(75, 23);
            btnCalculeaza.TabIndex = 6;
            btnCalculeaza.Text = "Calculează";
            btnCalculeaza.UseVisualStyleBackColor = true;
            // 
            // gpRezultate
            // 
            gpRezultate.Controls.Add(lblArie);
            gpRezultate.Controls.Add(lblPerimetru);
            gpRezultate.Location = new Point(12, 174);
            gpRezultate.Name = "gpRezultate";
            gpRezultate.Size = new Size(380, 86);
            gpRezultate.TabIndex = 7;
            gpRezultate.TabStop = false;
            gpRezultate.Text = "Rezultate";
            // 
            // lblArie
            // 
            lblArie.AutoSize = true;
            lblArie.Location = new Point(44, 53);
            lblArie.Name = "lblArie";
            lblArie.Size = new Size(41, 15);
            lblArie.TabIndex = 1;
            lblArie.Text = "";
            lblArie.Click += label4_Click;
            // 
            // lblPerimetru
            // 
            lblPerimetru.AutoSize = true;
            lblPerimetru.Location = new Point(44, 29);
            lblPerimetru.Name = "lblPerimetru";
            lblPerimetru.Size = new Size(72, 15);
            lblPerimetru.TabIndex = 0;
            lblPerimetru.Text = "";
            // 
            // gpIntro
            // 
            gpIntro.Controls.Add(txtIntro);
            gpIntro.Location = new Point(198, 41);
            gpIntro.Name = "gpIntro";
            gpIntro.Size = new Size(207, 104);
            gpIntro.TabIndex = 8;
            gpIntro.TabStop = false;
            gpIntro.Text = "";
            // 
            // txtIntro
            // 
            txtIntro.Location = new Point(18, 43);
            txtIntro.Name = "txtIntro";
            txtIntro.Size = new Size(100, 23);
            txtIntro.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 343);
            Controls.Add(gpIntro);
            Controls.Add(gpRezultate);
            Controls.Add(btnCalculeaza);
            Controls.Add(label2);
            Controls.Add(rbPatrat);
            Controls.Add(rbTriunghiEch);
            Controls.Add(rbCerc);
            Controls.Add(lblAlegere);
            Name = "Form1";
            Text = "Form1";
            gpRezultate.ResumeLayout(false);
            gpRezultate.PerformLayout();
            gpIntro.ResumeLayout(false);
            gpIntro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

       

        #endregion

        private Label lblAlegere;
        private RadioButton rbCerc;
        private RadioButton rbTriunghiEch;
        private RadioButton rbPatrat;
        private Label label2;
        private Button btnCalculeaza;
        private GroupBox gpRezultate;
        private Label lblArie;
        private Label lblPerimetru;
        private GroupBox gpIntro;
        private TextBox txtIntro;
    }
}

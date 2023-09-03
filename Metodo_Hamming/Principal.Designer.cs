namespace Metodo_Hamming
{
    partial class Principal
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            mostrar = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(175, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1215, 120);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(372, 46);
            label1.Name = "label1";
            label1.Size = new Size(542, 47);
            label1.TabIndex = 0;
            label1.Text = "METODO DE HAMMING";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 623);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(12, 330);
            button2.Name = "button2";
            button2.Size = new Size(174, 78);
            button2.TabIndex = 3;
            button2.Text = "Metodo de Hammig";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 160);
            button1.Name = "button1";
            button1.Size = new Size(174, 78);
            button1.TabIndex = 2;
            button1.Text = "Conversion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // mostrar
            // 
            mostrar.BackColor = SystemColors.ControlDarkDark;
            mostrar.Location = new Point(210, 128);
            mostrar.Name = "mostrar";
            mostrar.Size = new Size(1168, 497);
            mostrar.TabIndex = 2;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 623);
            Controls.Add(mostrar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Principal";
            Text = "Principal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private Button button2;
        private Panel mostrar;
    }
}
namespace Metodo_Hamming
{
    partial class Pariedad
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
            label1 = new Label();
            dato = new TextBox();
            button1 = new Button();
            resultado = new Label();
            error = new Label();
            pari = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(113, 110);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un numero";
            label1.Click += label1_Click;
            // 
            // dato
            // 
            dato.Location = new Point(319, 119);
            dato.Name = "dato";
            dato.Size = new Size(163, 23);
            dato.TabIndex = 1;
            dato.KeyPress += dato_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(555, 99);
            button1.Name = "button1";
            button1.Size = new Size(141, 50);
            button1.TabIndex = 2;
            button1.Text = "Resolver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            resultado.Location = new Point(313, 235);
            resultado.Name = "resultado";
            resultado.Size = new Size(115, 30);
            resultado.TabIndex = 3;
            resultado.Text = "0 0 0 0 0 0";
            // 
            // error
            // 
            error.AutoSize = true;
            error.BackColor = Color.White;
            error.ForeColor = Color.Red;
            error.Location = new Point(319, 145);
            error.Name = "error";
            error.Size = new Size(0, 15);
            error.TabIndex = 4;
            // 
            // pari
            // 
            pari.AutoSize = true;
            pari.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            pari.Location = new Point(596, 235);
            pari.Name = "pari";
            pari.Size = new Size(21, 30);
            pari.TabIndex = 5;
            pari.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(525, 205);
            label2.Name = "label2";
            label2.Size = new Size(171, 30);
            label2.TabIndex = 6;
            label2.Text = "TIPO PARIEDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(164, 233);
            label3.Name = "label3";
            label3.Size = new Size(118, 32);
            label3.TabIndex = 7;
            label3.Text = "Resultado";
            // 
            // Pariedad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pari);
            Controls.Add(error);
            Controls.Add(resultado);
            Controls.Add(button1);
            Controls.Add(dato);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pariedad";
            Text = "Pariedad";
            Load += Pariedad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox dato;
        private Button button1;
        private Label resultado;
        private Label error;
        private Label pari;
        private Label label2;
        private Label label3;
    }
}
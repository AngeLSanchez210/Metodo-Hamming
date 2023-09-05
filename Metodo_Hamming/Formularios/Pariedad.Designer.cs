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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 77);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un numero";
            label1.Click += label1_Click;
            // 
            // dato
            // 
            dato.Location = new Point(262, 74);
            dato.Name = "dato";
            dato.Size = new Size(218, 23);
            dato.TabIndex = 1;
            dato.TextChanged += dato_TextChanged;
            dato.KeyPress += dato_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(525, 70);
            button1.Name = "button1";
            button1.Size = new Size(96, 28);
            button1.TabIndex = 2;
            button1.Text = "Resolver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(282, 221);
            resultado.Name = "resultado";
            resultado.Size = new Size(0, 15);
            resultado.TabIndex = 3;
            // 
            // error
            // 
            error.AutoSize = true;
            error.BackColor = SystemColors.ControlLight;
            error.ForeColor = Color.Red;
            error.Location = new Point(282, 110);
            error.Name = "error";
            error.Size = new Size(0, 15);
            error.TabIndex = 4;
            // 
            // Pariedad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
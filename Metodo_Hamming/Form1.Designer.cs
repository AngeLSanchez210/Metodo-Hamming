namespace Metodo_Hamming
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
            label1 = new Label();
            txtDatoIngresado = new TextBox();
            label2 = new Label();
            cbTipoDato = new ComboBox();
            btnConvertir = new Button();
            label3 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 67);
            label1.Name = "label1";
            label1.Size = new Size(211, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el dato a representar en 16 bits:";
            // 
            // txtDatoIngresado
            // 
            txtDatoIngresado.Location = new Point(346, 95);
            txtDatoIngresado.Name = "txtDatoIngresado";
            txtDatoIngresado.Size = new Size(211, 23);
            txtDatoIngresado.TabIndex = 1;
            txtDatoIngresado.KeyPress += txtDatoIngresado_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 64);
            label2.Name = "label2";
            label2.Size = new Size(213, 15);
            label2.TabIndex = 2;
            label2.Text = "Seleccione el tipo de dato a representar";
            // 
            // cbTipoDato
            // 
            cbTipoDato.FormattingEnabled = true;
            cbTipoDato.Items.AddRange(new object[] { "Entero sin signo", "Entero con signo", "Flotante", "Caracter", "Cadena de caracteres" });
            cbTipoDato.Location = new Point(103, 95);
            cbTipoDato.Name = "cbTipoDato";
            cbTipoDato.Size = new Size(213, 23);
            cbTipoDato.TabIndex = 3;
            cbTipoDato.SelectedIndexChanged += cbTipoDato_SelectedIndexChanged;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(589, 95);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(127, 23);
            btnConvertir.TabIndex = 4;
            btnConvertir.Text = "Convertir a binario";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 157);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 5;
            label3.Text = "Dato convertido:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(264, 189);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(259, 32);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "0000 0000 0000 0000";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(label3);
            Controls.Add(btnConvertir);
            Controls.Add(cbTipoDato);
            Controls.Add(label2);
            Controls.Add(txtDatoIngresado);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDatoIngresado;
        private Label label2;
        private ComboBox cbTipoDato;
        private Button btnConvertir;
        private Label label3;
        private Label lblResultado;
    }
}
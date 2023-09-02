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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatoIngresado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoDato = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el dato a representar en 16 bits:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDatoIngresado
            // 
            this.txtDatoIngresado.Location = new System.Drawing.Point(385, 85);
            this.txtDatoIngresado.Name = "txtDatoIngresado";
            this.txtDatoIngresado.Size = new System.Drawing.Size(211, 23);
            this.txtDatoIngresado.TabIndex = 1;
            this.txtDatoIngresado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatoIngresado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el tipo de dato a representar";
            // 
            // cbTipoDato
            // 
            this.cbTipoDato.FormattingEnabled = true;
            this.cbTipoDato.Items.AddRange(new object[] {
            "Entero sin signo",
            "Entero con signo",
            "Flotante",
            "Caracter",
            "Cadena de caracteres"});
            this.cbTipoDato.Location = new System.Drawing.Point(123, 88);
            this.cbTipoDato.Name = "cbTipoDato";
            this.cbTipoDato.Size = new System.Drawing.Size(213, 23);
            this.cbTipoDato.TabIndex = 3;
            this.cbTipoDato.SelectedIndexChanged += new System.EventHandler(this.cbTipoDato_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTipoDato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDatoIngresado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtDatoIngresado;
        private Label label2;
        private ComboBox cbTipoDato;
    }
}
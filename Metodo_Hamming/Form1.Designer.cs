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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatoIngresado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoDato = new System.Windows.Forms.ComboBox();
            this.errorConversion = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnConversion = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorConversion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el dato a representar en 16 bits:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDatoIngresado
            // 
            this.txtDatoIngresado.Location = new System.Drawing.Point(331, 62);
            this.txtDatoIngresado.Name = "txtDatoIngresado";
            this.txtDatoIngresado.Size = new System.Drawing.Size(211, 23);
            this.txtDatoIngresado.TabIndex = 1;
            this.txtDatoIngresado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatoIngresado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 31);
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
            this.cbTipoDato.Location = new System.Drawing.Point(77, 62);
            this.cbTipoDato.Name = "cbTipoDato";
            this.cbTipoDato.Size = new System.Drawing.Size(213, 23);
            this.cbTipoDato.TabIndex = 3;
            this.cbTipoDato.SelectedIndexChanged += new System.EventHandler(this.cbTipoDato_SelectedIndexChanged);
            // 
            // errorConversion
            // 
            this.errorConversion.ContainerControl = this;
            // 
            // btnConversion
            // 
            this.btnConversion.Location = new System.Drawing.Point(584, 31);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(131, 54);
            this.btnConversion.TabIndex = 4;
            this.btnConversion.Text = "Convertir a binario";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(297, 154);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(294, 37);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.Text = "0000 0000 0000 0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(383, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dato convertido:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.cbTipoDato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDatoIngresado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorConversion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtDatoIngresado;
        private Label label2;
        private ComboBox cbTipoDato;
        private ErrorProvider errorConversion;
        private Label label4;
        private Label txtResultado;
        private Button btnConversion;
    }
}
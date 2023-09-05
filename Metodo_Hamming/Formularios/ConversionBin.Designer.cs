namespace Metodo_Hamming
{
    partial class ConversionBin
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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.errorConversion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorConversion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(484, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el dato a representar en 16 bits:";
            // 
            // txtDatoIngresado
            // 
            this.txtDatoIngresado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDatoIngresado.Location = new System.Drawing.Point(484, 99);
            this.txtDatoIngresado.Name = "txtDatoIngresado";
            this.txtDatoIngresado.Size = new System.Drawing.Size(344, 33);
            this.txtDatoIngresado.TabIndex = 1;
            this.txtDatoIngresado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatoIngresado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el tipo de dato a representar";
            // 
            // cbTipoDato
            // 
            this.cbTipoDato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDato.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipoDato.FormattingEnabled = true;
            this.cbTipoDato.Items.AddRange(new object[] {
            "Entero sin signo",
            "Entero con signo (Complemento 1)",
            "Entero con signo (Bit mas representativo)",
            "Flotante",
            "Caracter",
            "Cadena de caracteres"});
            this.cbTipoDato.Location = new System.Drawing.Point(36, 99);
            this.cbTipoDato.Name = "cbTipoDato";
            this.cbTipoDato.Size = new System.Drawing.Size(374, 33);
            this.cbTipoDato.TabIndex = 3;
            this.cbTipoDato.SelectedIndexChanged += new System.EventHandler(this.cbTipoDato_SelectedIndexChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvertir.Location = new System.Drawing.Point(564, 160);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(188, 33);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir a binario";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(136, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dato convertido:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(52, 210);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(313, 40);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "0000 0000 0000 0000";
            // 
            // errorConversion
            // 
            this.errorConversion.ContainerControl = this;
            // 
            // ConversionBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cbTipoDato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDatoIngresado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConversionBin";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatoIngresado_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.errorConversion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtDatoIngresado;
        private Label label2;
        private ComboBox cbTipoDato;
        private Button btnConvertir;
        private Label label3;
        private Label lblResultado;
        private ErrorProvider errorConversion;
    }
}
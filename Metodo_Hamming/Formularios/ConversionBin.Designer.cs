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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtDatoIngresado = new TextBox();
            label2 = new Label();
            cbTipoDato = new ComboBox();
            btnConvertir = new Button();
            label3 = new Label();
            lblResultado = new Label();
            errorConversion = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorConversion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(484, 61);
            label1.Name = "label1";
            label1.Size = new Size(344, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el dato a representar en 16 bits:";
            // 
            // txtDatoIngresado
            // 
            txtDatoIngresado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDatoIngresado.Location = new Point(484, 99);
            txtDatoIngresado.Name = "txtDatoIngresado";
            txtDatoIngresado.Size = new Size(344, 33);
            txtDatoIngresado.TabIndex = 1;
            txtDatoIngresado.KeyPress += txtDatoIngresado_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 61);
            label2.Name = "label2";
            label2.Size = new Size(346, 25);
            label2.TabIndex = 2;
            label2.Text = "Seleccione el tipo de dato a representar";
            // 
            // cbTipoDato
            // 
            cbTipoDato.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoDato.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoDato.FormattingEnabled = true;
            cbTipoDato.Items.AddRange(new object[] { "Entero sin signo", "Entero con signo (Complemento 1)", "Entero con signo (Bit mas representativo)", "Flotante", "Caracter", "Cadena de caracteres" });
            cbTipoDato.Location = new Point(36, 99);
            cbTipoDato.Name = "cbTipoDato";
            cbTipoDato.Size = new Size(374, 33);
            cbTipoDato.TabIndex = 3;
            cbTipoDato.SelectedIndexChanged += cbTipoDato_SelectedIndexChanged;
            // 
            // btnConvertir
            // 
            btnConvertir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvertir.Location = new Point(564, 160);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(188, 33);
            btnConvertir.TabIndex = 4;
            btnConvertir.Text = "Convertir a binario";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(136, 168);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 5;
            label3.Text = "Dato convertido:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(52, 210);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(313, 40);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "0000 0000 0000 0000";
            // 
            // errorConversion
            // 
            errorConversion.ContainerControl = this;
            // 
            // ConversionBin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(858, 450);
            Controls.Add(lblResultado);
            Controls.Add(label3);
            Controls.Add(btnConvertir);
            Controls.Add(cbTipoDato);
            Controls.Add(label2);
            Controls.Add(txtDatoIngresado);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConversionBin";
            Text = "Form1";
            KeyPress += txtDatoIngresado_KeyPress;
            ((System.ComponentModel.ISupportInitialize)errorConversion).EndInit();
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
        private ErrorProvider errorConversion;
    }
}
namespace Metodo_Hamming
{
    partial class Hamming
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
            txtBits = new TextBox();
            btnEnviar = new Button();
            label2 = new Label();
            lblNumeroCodi = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 43);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un numero de 6 bits:";
            // 
            // txtBits
            // 
            txtBits.Location = new Point(224, 40);
            txtBits.MaxLength = 6;
            txtBits.Name = "txtBits";
            txtBits.Size = new Size(157, 23);
            txtBits.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(406, 40);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(82, 23);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Codificar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 93);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 3;
            label2.Text = "Numero codificado: ";
            // 
            // lblNumeroCodi
            // 
            lblNumeroCodi.AutoSize = true;
            lblNumeroCodi.Location = new Point(195, 93);
            lblNumeroCodi.Name = "lblNumeroCodi";
            lblNumeroCodi.Size = new Size(0, 15);
            lblNumeroCodi.TabIndex = 4;
            // 
            // Hamming
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNumeroCodi);
            Controls.Add(label2);
            Controls.Add(btnEnviar);
            Controls.Add(txtBits);
            Controls.Add(label1);
            Name = "Hamming";
            Text = "Hamming";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBits;
        private Button btnEnviar;
        private Label label2;
        private Label lblNumeroCodi;
    }
}
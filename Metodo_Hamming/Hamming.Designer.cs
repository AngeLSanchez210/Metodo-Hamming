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
            lblErrorInput = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 103);
            label1.Name = "label1";
            label1.Size = new Size(252, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un numero de 6 bits:";
            // 
            // txtBits
            // 
            txtBits.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBits.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBits.Location = new Point(360, 99);
            txtBits.MaximumSize = new Size(204, 33);
            txtBits.MaxLength = 6;
            txtBits.Name = "txtBits";
            txtBits.Size = new Size(204, 33);
            txtBits.TabIndex = 1;
            txtBits.KeyPress += txtBits_KeyPress;
            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEnviar.AutoSize = true;
            btnEnviar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviar.Location = new Point(588, 97);
            btnEnviar.MaximumSize = new Size(115, 35);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(115, 35);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Codificar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(360, 203);
            label2.Name = "label2";
            label2.Size = new Size(202, 30);
            label2.TabIndex = 3;
            label2.Text = "Numero codificado: ";
            // 
            // lblNumeroCodi
            // 
            lblNumeroCodi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNumeroCodi.AutoSize = true;
            lblNumeroCodi.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroCodi.Location = new Point(338, 261);
            lblNumeroCodi.Name = "lblNumeroCodi";
            lblNumeroCodi.Size = new Size(224, 37);
            lblNumeroCodi.TabIndex = 4;
            lblNumeroCodi.Text = " 0 0 0 0 0 0 0 0 0";
            // 
            // lblErrorInput
            // 
            lblErrorInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblErrorInput.AutoSize = true;
            lblErrorInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorInput.ForeColor = Color.Red;
            lblErrorInput.Location = new Point(360, 132);
            lblErrorInput.Name = "lblErrorInput";
            lblErrorInput.Size = new Size(0, 20);
            lblErrorInput.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(300, 9);
            label3.Name = "label3";
            label3.Size = new Size(293, 37);
            label3.TabIndex = 6;
            label3.Text = "Metodo de Hamming";
            // 
            // Hamming
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 543);
            Controls.Add(label3);
            Controls.Add(lblErrorInput);
            Controls.Add(lblNumeroCodi);
            Controls.Add(label2);
            Controls.Add(btnEnviar);
            Controls.Add(txtBits);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label lblErrorInput;
        private Label label3;
    }
}
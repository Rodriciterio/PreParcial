namespace Pre_Parcial.Windows
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
            components = new System.ComponentModel.Container();
            txtRadio = new TextBox();
            txtAltura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGeneratriz = new Button();
            btnArea = new Button();
            btnVolumen = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(289, 55);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 0;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(289, 106);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 64);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese el radio del cono :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 114);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingrese la altura del cono :";
            // 
            // btnGeneratriz
            // 
            btnGeneratriz.Location = new Point(69, 178);
            btnGeneratriz.Name = "btnGeneratriz";
            btnGeneratriz.Size = new Size(151, 23);
            btnGeneratriz.TabIndex = 4;
            btnGeneratriz.Text = "Ver Generatriz";
            btnGeneratriz.UseVisualStyleBackColor = true;
            btnGeneratriz.Click += btnGeneratriz_Click;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(278, 178);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(145, 23);
            btnArea.TabIndex = 5;
            btnArea.Text = "Ver Area del cono";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnVolumen
            // 
            btnVolumen.Location = new Point(493, 178);
            btnVolumen.Name = "btnVolumen";
            btnVolumen.Size = new Size(161, 23);
            btnVolumen.TabIndex = 6;
            btnVolumen.Text = "Ver Volumen del cono";
            btnVolumen.UseVisualStyleBackColor = true;
            btnVolumen.Click += btnVolumen_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(469, 80);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(694, 355);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(btnVolumen);
            Controls.Add(btnArea);
            Controls.Add(btnGeneratriz);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAltura);
            Controls.Add(txtRadio);
            Name = "Form1";
            Text = "Pre-Parcial";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRadio;
        private TextBox txtAltura;
        private Label label1;
        private Label label2;
        private Button btnGeneratriz;
        private Button btnArea;
        private Button btnVolumen;
        private Button btnCancelar;
        private Button btnSalir;
        private ErrorProvider errorProvider1;
    }
}
namespace Pre_Parcial2.Windows
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
            dgvDatos = new DataGridView();
            ColAltura = new DataGridViewTextBoxColumn();
            ColRadio = new DataGridViewTextBoxColumn();
            ColGeneratriz = new DataGridViewTextBoxColumn();
            ColArea = new DataGridViewTextBoxColumn();
            ColVolumen = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnOk = new Button();
            btnCancelar = new Button();
            txtRadio = new TextBox();
            txtAltura = new TextBox();
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColAltura, ColRadio, ColGeneratriz, ColArea, ColVolumen });
            dgvDatos.Dock = DockStyle.Bottom;
            dgvDatos.Location = new Point(0, 219);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(800, 231);
            dgvDatos.TabIndex = 0;
            // 
            // ColAltura
            // 
            ColAltura.HeaderText = "Altura";
            ColAltura.Name = "ColAltura";
            ColAltura.ReadOnly = true;
            // 
            // ColRadio
            // 
            ColRadio.HeaderText = "Radio";
            ColRadio.Name = "ColRadio";
            ColRadio.ReadOnly = true;
            // 
            // ColGeneratriz
            // 
            ColGeneratriz.HeaderText = "Generatriz";
            ColGeneratriz.Name = "ColGeneratriz";
            ColGeneratriz.ReadOnly = true;
            // 
            // ColArea
            // 
            ColArea.HeaderText = "Area";
            ColArea.Name = "ColArea";
            ColArea.ReadOnly = true;
            // 
            // ColVolumen
            // 
            ColVolumen.HeaderText = "Volumen";
            ColVolumen.Name = "ColVolumen";
            ColVolumen.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 70);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese la altura del cono :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 23);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el radio del cono :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(108, 130);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(253, 130);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(242, 20);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 5;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(242, 67);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 6;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAltura);
            Controls.Add(txtRadio);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDatos);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColAltura;
        private DataGridViewTextBoxColumn ColRadio;
        private DataGridViewTextBoxColumn ColGeneratriz;
        private DataGridViewTextBoxColumn ColArea;
        private DataGridViewTextBoxColumn ColVolumen;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
        private TextBox txtAltura;
        private TextBox txtRadio;
        private Button btnCancelar;
        private Button btnOk;
        private ErrorProvider errorProvider2;
    }
}
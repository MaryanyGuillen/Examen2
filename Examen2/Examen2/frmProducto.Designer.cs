namespace Examen2
{
    partial class frmProducto
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
            this.components = new System.ComponentModel.Container();
            this.ListaProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExistenciaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductosDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaProductosDataGridView
            // 
            this.ListaProductosDataGridView.AllowUserToAddRows = false;
            this.ListaProductosDataGridView.AllowUserToDeleteRows = false;
            this.ListaProductosDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.ListaProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaProductosDataGridView.Location = new System.Drawing.Point(13, 264);
            this.ListaProductosDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListaProductosDataGridView.Name = "ListaProductosDataGridView";
            this.ListaProductosDataGridView.ReadOnly = true;
            this.ListaProductosDataGridView.Size = new System.Drawing.Size(539, 197);
            this.ListaProductosDataGridView.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelarButton);
            this.groupBox1.Controls.Add(this.EliminarButton);
            this.groupBox1.Controls.Add(this.GuardarButton);
            this.groupBox1.Controls.Add(this.ModificarButton);
            this.groupBox1.Controls.Add(this.NuevoButton);
            this.groupBox1.Controls.Add(this.ExistenciaTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PrecioTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DescripcionTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CodigoTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(540, 244);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del producto";
            // 
            // ExistenciaTextBox
            // 
            this.ExistenciaTextBox.Enabled = false;
            this.ExistenciaTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistenciaTextBox.Location = new System.Drawing.Point(174, 151);
            this.ExistenciaTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ExistenciaTextBox.Name = "ExistenciaTextBox";
            this.ExistenciaTextBox.Size = new System.Drawing.Size(284, 23);
            this.ExistenciaTextBox.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Existencia:";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Enabled = false;
            this.PrecioTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioTextBox.Location = new System.Drawing.Point(174, 112);
            this.PrecioTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(284, 23);
            this.PrecioTextBox.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Precio:";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Enabled = false;
            this.DescripcionTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(174, 70);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(284, 23);
            this.DescripcionTextBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Descripción:";
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Enabled = false;
            this.CodigoTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoTextBox.Location = new System.Drawing.Point(174, 31);
            this.CodigoTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(284, 23);
            this.CodigoTextBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(436, 196);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(100, 39);
            this.CancelarButton.TabIndex = 42;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EliminarButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.EliminarButton.Location = new System.Drawing.Point(330, 196);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(5);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(100, 39);
            this.EliminarButton.TabIndex = 41;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = false;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(222, 196);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(5);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 39);
            this.GuardarButton.TabIndex = 40;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModificarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Location = new System.Drawing.Point(115, 196);
            this.ModificarButton.Margin = new System.Windows.Forms.Padding(5);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(100, 39);
            this.ModificarButton.TabIndex = 39;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = false;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NuevoButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Location = new System.Drawing.Point(4, 196);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(5);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(100, 39);
            this.NuevoButton.TabIndex = 38;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = false;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(584, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListaProductosDataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductosDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaProductosDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ExistenciaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
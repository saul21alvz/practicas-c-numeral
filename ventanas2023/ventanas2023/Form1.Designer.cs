namespace ventanas2023
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btnaceptar = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btnaceptar
            // 
            this.Btnaceptar.Location = new System.Drawing.Point(174, 424);
            this.Btnaceptar.Margin = new System.Windows.Forms.Padding(5);
            this.Btnaceptar.Name = "Btnaceptar";
            this.Btnaceptar.Size = new System.Drawing.Size(131, 42);
            this.Btnaceptar.TabIndex = 0;
            this.Btnaceptar.Text = "Aceptar";
            this.Btnaceptar.UseVisualStyleBackColor = true;
            this.Btnaceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(327, 424);
            this.Btnsalir.Margin = new System.Windows.Forms.Padding(5);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(131, 42);
            this.Btnsalir.TabIndex = 1;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(74, 59);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(300, 34);
            this.Txtnombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edad";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(74, 128);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(300, 34);
            this.txtedad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sexo \"hombre = h, mujer = m\"";
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(74, 202);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(300, 34);
            this.txtsexo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(686, 515);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btnaceptar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "practica1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnaceptar;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsexo;
    }
}


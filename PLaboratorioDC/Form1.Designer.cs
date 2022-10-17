namespace PLaboratorioDC
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
            this.btnInsDe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnElimtra = new System.Windows.Forms.Button();
            this.btnElimDe = new System.Windows.Forms.Button();
            this.btnInsTra = new System.Windows.Forms.Button();
            this.listMus = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsDe
            // 
            this.btnInsDe.Location = new System.Drawing.Point(185, 182);
            this.btnInsDe.Name = "btnInsDe";
            this.btnInsDe.Size = new System.Drawing.Size(96, 23);
            this.btnInsDe.TabIndex = 0;
            this.btnInsDe.Text = "Insertar-Delante";
            this.btnInsDe.UseVisualStyleBackColor = true;
            this.btnInsDe.Click += new System.EventHandler(this.btnInsDe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.listMus);
            this.panel1.Controls.Add(this.btnInsTra);
            this.panel1.Controls.Add(this.btnElimDe);
            this.panel1.Controls.Add(this.btnElimtra);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnInsDe);
            this.panel1.Controls.Add(this.txtnum);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 269);
            this.panel1.TabIndex = 4;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(185, 124);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(222, 20);
            this.txtnum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(280, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "COLA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pristina", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(208, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "DE";
            // 
            // btnElimtra
            // 
            this.btnElimtra.Location = new System.Drawing.Point(297, 217);
            this.btnElimtra.Name = "btnElimtra";
            this.btnElimtra.Size = new System.Drawing.Size(96, 23);
            this.btnElimtra.TabIndex = 6;
            this.btnElimtra.Text = "Eliminar-Detras";
            this.btnElimtra.UseVisualStyleBackColor = true;
            this.btnElimtra.Click += new System.EventHandler(this.btnElimtra_Click);
            // 
            // btnElimDe
            // 
            this.btnElimDe.Location = new System.Drawing.Point(185, 217);
            this.btnElimDe.Name = "btnElimDe";
            this.btnElimDe.Size = new System.Drawing.Size(96, 23);
            this.btnElimDe.TabIndex = 7;
            this.btnElimDe.Text = "Eliminar-Delante";
            this.btnElimDe.UseVisualStyleBackColor = true;
            this.btnElimDe.Click += new System.EventHandler(this.btnElimDe_Click);
            // 
            // btnInsTra
            // 
            this.btnInsTra.Location = new System.Drawing.Point(297, 182);
            this.btnInsTra.Name = "btnInsTra";
            this.btnInsTra.Size = new System.Drawing.Size(96, 23);
            this.btnInsTra.TabIndex = 8;
            this.btnInsTra.Text = "Insertar-Detras";
            this.btnInsTra.UseVisualStyleBackColor = true;
            this.btnInsTra.Click += new System.EventHandler(this.btnInsTra_Click);
            // 
            // listMus
            // 
            this.listMus.FormattingEnabled = true;
            this.listMus.Location = new System.Drawing.Point(13, 18);
            this.listMus.Name = "listMus";
            this.listMus.Size = new System.Drawing.Size(166, 225);
            this.listMus.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 296);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnInsTra;
        private System.Windows.Forms.Button btnElimDe;
        private System.Windows.Forms.Button btnElimtra;
        private System.Windows.Forms.ListBox listMus;
    }
}


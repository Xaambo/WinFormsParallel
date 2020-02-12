namespace WinForms_Parallel
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
            this.btnParallel = new System.Windows.Forms.Button();
            this.btnNoParallel = new System.Windows.Forms.Button();
            this.tempsNoParallel = new System.Windows.Forms.TextBox();
            this.tempsParallel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnParallel
            // 
            this.btnParallel.Location = new System.Drawing.Point(238, 188);
            this.btnParallel.Name = "btnParallel";
            this.btnParallel.Size = new System.Drawing.Size(121, 46);
            this.btnParallel.TabIndex = 3;
            this.btnParallel.Text = "Parallel";
            this.btnParallel.UseVisualStyleBackColor = true;
            this.btnParallel.Click += new System.EventHandler(this.btnParallel_Click);
            // 
            // btnNoParallel
            // 
            this.btnNoParallel.Location = new System.Drawing.Point(439, 188);
            this.btnNoParallel.Name = "btnNoParallel";
            this.btnNoParallel.Size = new System.Drawing.Size(121, 46);
            this.btnNoParallel.TabIndex = 4;
            this.btnNoParallel.Text = "No Parallel";
            this.btnNoParallel.UseVisualStyleBackColor = true;
            this.btnNoParallel.Click += new System.EventHandler(this.btnNoParallel_Click);
            // 
            // tempsNoParallel
            // 
            this.tempsNoParallel.Location = new System.Drawing.Point(439, 240);
            this.tempsNoParallel.Name = "tempsNoParallel";
            this.tempsNoParallel.Size = new System.Drawing.Size(121, 22);
            this.tempsNoParallel.TabIndex = 5;
            // 
            // tempsParallel
            // 
            this.tempsParallel.Location = new System.Drawing.Point(238, 240);
            this.tempsParallel.Name = "tempsParallel";
            this.tempsParallel.Size = new System.Drawing.Size(121, 22);
            this.tempsParallel.TabIndex = 6;
            this.tempsParallel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tempsParallel);
            this.Controls.Add(this.tempsNoParallel);
            this.Controls.Add(this.btnNoParallel);
            this.Controls.Add(this.btnParallel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnParallel;
        private System.Windows.Forms.Button btnNoParallel;
        private System.Windows.Forms.TextBox tempsNoParallel;
        private System.Windows.Forms.TextBox tempsParallel;
    }
}


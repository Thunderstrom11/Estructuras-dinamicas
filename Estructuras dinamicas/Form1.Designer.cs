namespace Estructuras_dinamicas
{
    partial class Form1
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
            this.btnpila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpila
            // 
            this.btnpila.Location = new System.Drawing.Point(44, 58);
            this.btnpila.Name = "btnpila";
            this.btnpila.Size = new System.Drawing.Size(131, 47);
            this.btnpila.TabIndex = 0;
            this.btnpila.Text = "pila";
            this.btnpila.UseVisualStyleBackColor = true;
            this.btnpila.Click += new System.EventHandler(this.btnpila_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpila);
            this.Name = "Form1";
            this.Text = "Estructuras dinamicas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpila;
    }
}


namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.bLos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTrojk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kliknij aby wylosować liczbę:";
            // 
            // bLos
            // 
            this.bLos.Location = new System.Drawing.Point(244, 42);
            this.bLos.Name = "bLos";
            this.bLos.Size = new System.Drawing.Size(75, 23);
            this.bLos.TabIndex = 1;
            this.bLos.Text = "Losuj";
            this.bLos.UseVisualStyleBackColor = true;
            this.bLos.Click += new System.EventHandler(this.bLos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wylosowałeś tyle punktów na okręgu:";
            // 
            // labelLos
            // 
            this.labelLos.AutoSize = true;
            this.labelLos.Location = new System.Drawing.Point(274, 105);
            this.labelLos.Name = "labelLos";
            this.labelLos.Size = new System.Drawing.Size(13, 13);
            this.labelLos.TabIndex = 3;
            this.labelLos.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Można z nich ułożyć tyle trójkątów:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelTrojk
            // 
            this.labelTrojk.AutoSize = true;
            this.labelTrojk.Location = new System.Drawing.Point(274, 162);
            this.labelTrojk.Name = "labelTrojk";
            this.labelTrojk.Size = new System.Drawing.Size(13, 13);
            this.labelTrojk.TabIndex = 5;
            this.labelTrojk.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 240);
            this.Controls.Add(this.labelTrojk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bLos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Losowe punkty i trójkąty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bLos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTrojk;
    }
}


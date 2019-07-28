namespace RandomPolygon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Vertices = new System.Windows.Forms.TextBox();
            this.button_Genarate = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 415);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Vertices";
            // 
            // textBox_Vertices
            // 
            this.textBox_Vertices.Location = new System.Drawing.Point(487, 12);
            this.textBox_Vertices.Name = "textBox_Vertices";
            this.textBox_Vertices.Size = new System.Drawing.Size(55, 20);
            this.textBox_Vertices.TabIndex = 2;
            // 
            // button_Genarate
            // 
            this.button_Genarate.Location = new System.Drawing.Point(386, 50);
            this.button_Genarate.Name = "button_Genarate";
            this.button_Genarate.Size = new System.Drawing.Size(75, 23);
            this.button_Genarate.TabIndex = 3;
            this.button_Genarate.Text = "Genarate";
            this.button_Genarate.UseVisualStyleBackColor = true;
            this.button_Genarate.Click += new System.EventHandler(this.button_Genarate_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(467, 50);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 4;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 439);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Genarate);
            this.Controls.Add(this.textBox_Vertices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Random Polygon Genarator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Vertices;
        private System.Windows.Forms.Button button_Genarate;
        private System.Windows.Forms.Button button_Clear;
    }
}


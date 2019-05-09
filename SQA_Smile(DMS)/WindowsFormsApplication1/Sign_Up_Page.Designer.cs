namespace WindowsFormsApplication1
{
    partial class Sign_Up_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_Up_Page));
            this.Lpanel = new System.Windows.Forms.Panel();
            this.Create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Llabel3 = new System.Windows.Forms.Label();
            this.Llabel2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbutton = new System.Windows.Forms.Button();
            this.SignUplogout = new System.Windows.Forms.Button();
            this.Lpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lpanel
            // 
            this.Lpanel.BackColor = System.Drawing.Color.Transparent;
            this.Lpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Lpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lpanel.Controls.Add(this.Create);
            this.Lpanel.Controls.Add(this.label3);
            this.Lpanel.Controls.Add(this.panel2);
            this.Lpanel.Controls.Add(this.Lbutton);
            this.Lpanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lpanel.Location = new System.Drawing.Point(12, 12);
            this.Lpanel.Name = "Lpanel";
            this.Lpanel.Size = new System.Drawing.Size(231, 350);
            this.Lpanel.TabIndex = 19;
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.SpringGreen;
            this.Create.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.Create.FlatAppearance.BorderSize = 2;
            this.Create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.Create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.ForeColor = System.Drawing.Color.Black;
            this.Create.Location = new System.Drawing.Point(75, 297);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(81, 33);
            this.Create.TabIndex = 9;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(0, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "[Provide Username and Password]";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(13, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 222);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.Llabel3);
            this.panel1.Controls.Add(this.Llabel2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 181);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(8, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Status: (write patient)";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(32, 146);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 26);
            this.textBox3.TabIndex = 11;
            // 
            // Llabel3
            // 
            this.Llabel3.AutoSize = true;
            this.Llabel3.BackColor = System.Drawing.Color.Transparent;
            this.Llabel3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llabel3.ForeColor = System.Drawing.Color.SpringGreen;
            this.Llabel3.Location = new System.Drawing.Point(8, 61);
            this.Llabel3.Name = "Llabel3";
            this.Llabel3.Size = new System.Drawing.Size(73, 18);
            this.Llabel3.TabIndex = 3;
            this.Llabel3.Text = "Password:";
            // 
            // Llabel2
            // 
            this.Llabel2.AutoSize = true;
            this.Llabel2.BackColor = System.Drawing.Color.DimGray;
            this.Llabel2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llabel2.ForeColor = System.Drawing.Color.SpringGreen;
            this.Llabel2.Location = new System.Drawing.Point(8, 0);
            this.Llabel2.Name = "Llabel2";
            this.Llabel2.Size = new System.Drawing.Size(77, 18);
            this.Llabel2.TabIndex = 2;
            this.Llabel2.Text = "Username:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(35, 82);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(32, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 26);
            this.textBox1.TabIndex = 0;
            // 
            // Lbutton
            // 
            this.Lbutton.BackColor = System.Drawing.Color.Coral;
            this.Lbutton.FlatAppearance.BorderSize = 0;
            this.Lbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.Lbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbutton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lbutton.ForeColor = System.Drawing.Color.White;
            this.Lbutton.Location = new System.Drawing.Point(0, 3);
            this.Lbutton.Name = "Lbutton";
            this.Lbutton.Size = new System.Drawing.Size(226, 43);
            this.Lbutton.TabIndex = 1;
            this.Lbutton.Text = "Sign Up Page";
            this.Lbutton.UseVisualStyleBackColor = false;
            // 
            // SignUplogout
            // 
            this.SignUplogout.BackColor = System.Drawing.Color.Coral;
            this.SignUplogout.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.SignUplogout.FlatAppearance.BorderSize = 2;
            this.SignUplogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SignUplogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.SignUplogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUplogout.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUplogout.ForeColor = System.Drawing.Color.Navy;
            this.SignUplogout.Location = new System.Drawing.Point(523, 12);
            this.SignUplogout.Name = "SignUplogout";
            this.SignUplogout.Padding = new System.Windows.Forms.Padding(2);
            this.SignUplogout.Size = new System.Drawing.Size(68, 39);
            this.SignUplogout.TabIndex = 58;
            this.SignUplogout.Text = "log out";
            this.SignUplogout.UseVisualStyleBackColor = false;
            this.SignUplogout.Click += new System.EventHandler(this.SignUplogout_Click);
            // 
            // Sign_Up_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 386);
            this.Controls.Add(this.SignUplogout);
            this.Controls.Add(this.Lpanel);
            this.Name = "Sign_Up_Page";
            this.Text = "Sign_Up_Page";
            this.Lpanel.ResumeLayout(false);
            this.Lpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Lpanel;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Llabel3;
        private System.Windows.Forms.Label Llabel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Lbutton;
        private System.Windows.Forms.Button SignUplogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
    }
}
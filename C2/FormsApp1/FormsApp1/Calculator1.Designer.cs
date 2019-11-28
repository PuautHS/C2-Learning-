namespace FormsApp1
{
    partial class Calculator1
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
            this.RBC = new System.Windows.Forms.RadioButton();
            this.RBS = new System.Windows.Forms.RadioButton();
            this.RBT = new System.Windows.Forms.RadioButton();
            this.radius1 = new System.Windows.Forms.TextBox();
            this.long2 = new System.Windows.Forms.TextBox();
            this.height3 = new System.Windows.Forms.TextBox();
            this.wide4 = new System.Windows.Forms.TextBox();
            this.Radius = new System.Windows.Forms.Label();
            this.Wide = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.Long = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcutor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RBC
            // 
            this.RBC.AutoSize = true;
            this.RBC.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBC.Location = new System.Drawing.Point(29, 99);
            this.RBC.Name = "RBC";
            this.RBC.Size = new System.Drawing.Size(104, 41);
            this.RBC.TabIndex = 1;
            this.RBC.Text = "CircleO";
            this.RBC.UseVisualStyleBackColor = true;
            this.RBC.CheckedChanged += new System.EventHandler(this.RBC_CheckedChanged);
            // 
            // RBS
            // 
            this.RBS.AutoSize = true;
            this.RBS.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBS.Location = new System.Drawing.Point(151, 99);
            this.RBS.Name = "RBS";
            this.RBS.Size = new System.Drawing.Size(113, 41);
            this.RBS.TabIndex = 2;
            this.RBS.TabStop = true;
            this.RBS.Text = "Square#";
            this.RBS.UseVisualStyleBackColor = true;
            this.RBS.CheckedChanged += new System.EventHandler(this.RBS_CheckedChanged);
            // 
            // RBT
            // 
            this.RBT.AutoSize = true;
            this.RBT.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBT.Location = new System.Drawing.Point(293, 99);
            this.RBT.Name = "RBT";
            this.RBT.Size = new System.Drawing.Size(122, 41);
            this.RBT.TabIndex = 3;
            this.RBT.TabStop = true;
            this.RBT.Text = "TriangleA";
            this.RBT.UseVisualStyleBackColor = true;
            this.RBT.CheckedChanged += new System.EventHandler(this.RBT_CheckedChanged);
            // 
            // radius1
            // 
            this.radius1.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radius1.Location = new System.Drawing.Point(142, 160);
            this.radius1.Name = "radius1";
            this.radius1.Size = new System.Drawing.Size(171, 51);
            this.radius1.TabIndex = 4;
            // 
            // long2
            // 
            this.long2.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.long2.Location = new System.Drawing.Point(504, 160);
            this.long2.Name = "long2";
            this.long2.Size = new System.Drawing.Size(171, 51);
            this.long2.TabIndex = 5;
            // 
            // height3
            // 
            this.height3.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height3.Location = new System.Drawing.Point(142, 217);
            this.height3.Name = "height3";
            this.height3.Size = new System.Drawing.Size(171, 51);
            this.height3.TabIndex = 6;
            // 
            // wide4
            // 
            this.wide4.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wide4.Location = new System.Drawing.Point(504, 217);
            this.wide4.Name = "wide4";
            this.wide4.Size = new System.Drawing.Size(171, 51);
            this.wide4.TabIndex = 7;
            // 
            // Radius
            // 
            this.Radius.AutoSize = true;
            this.Radius.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radius.Location = new System.Drawing.Point(45, 169);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(83, 37);
            this.Radius.TabIndex = 8;
            this.Radius.Text = "Radius ";
            this.Radius.Click += new System.EventHandler(this.label1_Click);
            // 
            // Wide
            // 
            this.Wide.AutoSize = true;
            this.Wide.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wide.Location = new System.Drawing.Point(410, 226);
            this.Wide.Name = "Wide";
            this.Wide.Size = new System.Drawing.Size(68, 37);
            this.Wide.TabIndex = 10;
            this.Wide.Text = "Wide ";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height.Location = new System.Drawing.Point(48, 226);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(80, 37);
            this.Height.TabIndex = 11;
            this.Height.Text = "Height ";
            // 
            // Long
            // 
            this.Long.AutoSize = true;
            this.Long.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Long.Location = new System.Drawing.Point(410, 169);
            this.Long.Name = "Long";
            this.Long.Size = new System.Drawing.Size(66, 37);
            this.Long.TabIndex = 12;
            this.Long.Text = "Long ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(408, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 52);
            this.button2.TabIndex = 14;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 40);
            this.label3.TabIndex = 15;
            this.label3.Text = "Results :";
            // 
            // results
            // 
            this.results.AutoSize = true;
            this.results.BackColor = System.Drawing.Color.DarkOrange;
            this.results.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(242, 316);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(22, 40);
            this.results.TabIndex = 16;
            this.results.Text = ":";
            // 
            // Calculator1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(953, 519);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Long);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Wide);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.wide4);
            this.Controls.Add(this.height3);
            this.Controls.Add(this.long2);
            this.Controls.Add(this.radius1);
            this.Controls.Add(this.RBT);
            this.Controls.Add(this.RBS);
            this.Controls.Add(this.RBC);
            this.Controls.Add(this.label1);
            this.Name = "Calculator1";
            this.Text = "Calculator1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBC;
        private System.Windows.Forms.RadioButton RBS;
        private System.Windows.Forms.RadioButton RBT;
        private System.Windows.Forms.TextBox radius1;
        private System.Windows.Forms.TextBox long2;
        private System.Windows.Forms.TextBox height3;
        private System.Windows.Forms.TextBox wide4;
        private System.Windows.Forms.Label Radius;
        private System.Windows.Forms.Label Wide;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label Long;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label results;
    }
}
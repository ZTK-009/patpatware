using System;

namespace patpatware
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private static string username = Environment.UserName;
        private static string patCountStr;
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainText = new System.Windows.Forms.Label();
            this.warningTitle = new System.Windows.Forms.Label();
            this.headpatter = new System.Windows.Forms.Button();
            this.patText = new System.Windows.Forms.Label();
            this.remainCount = new System.Windows.Forms.Label();
            this.decryptNotifier = new System.Windows.Forms.Label();
            this.add1 = new System.Windows.Forms.Button();
            this.add5 = new System.Windows.Forms.Button();
            this.add10 = new System.Windows.Forms.Button();
            this.addDouble = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 423);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainText.ForeColor = System.Drawing.Color.Maroon;
            this.mainText.Location = new System.Drawing.Point(320, 109);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(646, 120);
            this.mainText.TabIndex = 1;
            this.mainText.Text = resources.GetString("mainText.Text");
            // 
            // warningTitle
            // 
            this.warningTitle.AutoSize = true;
            this.warningTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningTitle.ForeColor = System.Drawing.Color.Maroon;
            this.warningTitle.Location = new System.Drawing.Point(532, 32);
            this.warningTitle.Name = "warningTitle";
            this.warningTitle.Size = new System.Drawing.Size(227, 42);
            this.warningTitle.TabIndex = 2;
            this.warningTitle.Text = "WARNING!!!";
            // 
            // headpatter
            // 
            this.headpatter.Location = new System.Drawing.Point(497, 261);
            this.headpatter.Name = "headpatter";
            this.headpatter.Size = new System.Drawing.Size(245, 34);
            this.headpatter.TabIndex = 3;
            this.headpatter.Text = "Headpat Felix-chan";
            this.headpatter.UseVisualStyleBackColor = true;
            this.headpatter.Click += new System.EventHandler(this.headpatter_Click);
            // 
            // patText
            // 
            this.patText.AutoSize = true;
            this.patText.Enabled = false;
            this.patText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patText.ForeColor = System.Drawing.Color.Maroon;
            this.patText.Location = new System.Drawing.Point(452, 320);
            this.patText.Name = "patText";
            this.patText.Size = new System.Drawing.Size(0, 20);
            this.patText.TabIndex = 4;
            // 
            // remainCount
            // 
            this.remainCount.AutoSize = true;
            this.remainCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainCount.ForeColor = System.Drawing.Color.Maroon;
            this.remainCount.Location = new System.Drawing.Point(452, 352);
            this.remainCount.Name = "remainCount";
            this.remainCount.Size = new System.Drawing.Size(0, 20);
            this.remainCount.TabIndex = 5;
            // 
            // decryptNotifier
            // 
            this.decryptNotifier.AutoSize = true;
            this.decryptNotifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptNotifier.ForeColor = System.Drawing.Color.Green;
            this.decryptNotifier.Location = new System.Drawing.Point(512, 415);
            this.decryptNotifier.Name = "decryptNotifier";
            this.decryptNotifier.Size = new System.Drawing.Size(0, 20);
            this.decryptNotifier.TabIndex = 6;
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(779, 261);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(34, 34);
            this.add1.TabIndex = 7;
            this.add1.Text = "+1";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // add5
            // 
            this.add5.Location = new System.Drawing.Point(779, 302);
            this.add5.Name = "add5";
            this.add5.Size = new System.Drawing.Size(34, 34);
            this.add5.TabIndex = 8;
            this.add5.Text = "+5";
            this.add5.UseVisualStyleBackColor = true;
            this.add5.Click += new System.EventHandler(this.add5_Click);
            // 
            // add10
            // 
            this.add10.Location = new System.Drawing.Point(779, 342);
            this.add10.Name = "add10";
            this.add10.Size = new System.Drawing.Size(34, 34);
            this.add10.TabIndex = 9;
            this.add10.Text = "+10";
            this.add10.UseVisualStyleBackColor = true;
            this.add10.Click += new System.EventHandler(this.add10_Click);
            // 
            // addDouble
            // 
            this.addDouble.Location = new System.Drawing.Point(779, 383);
            this.addDouble.Name = "addDouble";
            this.addDouble.Size = new System.Drawing.Size(34, 34);
            this.addDouble.TabIndex = 10;
            this.addDouble.Text = "x2";
            this.addDouble.UseVisualStyleBackColor = true;
            this.addDouble.Click += new System.EventHandler(this.addDouble_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(819, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "-1000 headpats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(819, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "-5000 headpats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(819, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "-10000 headpats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(819, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "-100000 headpats";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addDouble);
            this.Controls.Add(this.add10);
            this.Controls.Add(this.add5);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.decryptNotifier);
            this.Controls.Add(this.remainCount);
            this.Controls.Add(this.patText);
            this.Controls.Add(this.headpatter);
            this.Controls.Add(this.warningTitle);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "patpatware";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mainText;
        private System.Windows.Forms.Label warningTitle;
        private System.Windows.Forms.Button headpatter;
        private System.Windows.Forms.Label patText;
        private System.Windows.Forms.Label remainCount;
        private System.Windows.Forms.Label decryptNotifier;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.Button add5;
        private System.Windows.Forms.Button add10;
        private System.Windows.Forms.Button addDouble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


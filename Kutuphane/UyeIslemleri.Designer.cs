namespace Kutuphane
{
    partial class UyeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeIslemleri));
            this.uyeeklebtn = new System.Windows.Forms.Button();
            this.uyesilbtn = new System.Windows.Forms.Button();
            this.uyelistbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uyeeklebtn
            // 
            this.uyeeklebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uyeeklebtn.BackgroundImage")));
            this.uyeeklebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uyeeklebtn.Location = new System.Drawing.Point(412, 144);
            this.uyeeklebtn.Name = "uyeeklebtn";
            this.uyeeklebtn.Size = new System.Drawing.Size(234, 214);
            this.uyeeklebtn.TabIndex = 3;
            this.uyeeklebtn.UseVisualStyleBackColor = true;
            this.uyeeklebtn.Click += new System.EventHandler(this.uyeeklebtn_Click);
            // 
            // uyesilbtn
            // 
            this.uyesilbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uyesilbtn.BackgroundImage")));
            this.uyesilbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uyesilbtn.Location = new System.Drawing.Point(724, 144);
            this.uyesilbtn.Name = "uyesilbtn";
            this.uyesilbtn.Size = new System.Drawing.Size(234, 214);
            this.uyesilbtn.TabIndex = 1;
            this.uyesilbtn.UseVisualStyleBackColor = true;
            this.uyesilbtn.Click += new System.EventHandler(this.uyesilbtn_Click);
            // 
            // uyelistbtn
            // 
            this.uyelistbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uyelistbtn.BackgroundImage")));
            this.uyelistbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uyelistbtn.Location = new System.Drawing.Point(100, 144);
            this.uyelistbtn.Name = "uyelistbtn";
            this.uyelistbtn.Size = new System.Drawing.Size(234, 214);
            this.uyelistbtn.TabIndex = 2;
            this.uyelistbtn.UseVisualStyleBackColor = true;
            this.uyelistbtn.Click += new System.EventHandler(this.uyelistbtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(14, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 32);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 41);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.uyesilbtn);
            this.panel2.Controls.Add(this.uyelistbtn);
            this.panel2.Controls.Add(this.uyeeklebtn);
            this.panel2.Location = new System.Drawing.Point(12, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 554);
            this.panel2.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UyeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1099, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UyeIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeIslemleri";
            this.Load += new System.EventHandler(this.UyeIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uyeeklebtn;
        private System.Windows.Forms.Button uyesilbtn;
        private System.Windows.Forms.Button uyelistbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}
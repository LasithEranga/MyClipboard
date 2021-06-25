
namespace MyClipboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.coptBtn = new System.Windows.Forms.Button();
            this.area1 = new System.Windows.Forms.RichTextBox();
            this.area2 = new System.Windows.Forms.RichTextBox();
            this.area3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete1 = new System.Windows.Forms.PictureBox();
            this.pin1 = new System.Windows.Forms.PictureBox();
            this.delete2 = new System.Windows.Forms.PictureBox();
            this.pin2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.delete3 = new System.Windows.Forms.PictureBox();
            this.pin3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin3)).BeginInit();
            this.SuspendLayout();
            // 
            // coptBtn
            // 
            this.coptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.coptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coptBtn.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coptBtn.ForeColor = System.Drawing.Color.Ivory;
            this.coptBtn.Location = new System.Drawing.Point(244, 13);
            this.coptBtn.Margin = new System.Windows.Forms.Padding(0);
            this.coptBtn.Name = "coptBtn";
            this.coptBtn.Size = new System.Drawing.Size(83, 32);
            this.coptBtn.TabIndex = 0;
            this.coptBtn.Text = "Copy";
            this.coptBtn.UseVisualStyleBackColor = false;
            this.coptBtn.Click += new System.EventHandler(this.coptBtn_Click);
            // 
            // area1
            // 
            this.area1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.area1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.area1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.area1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.area1.Location = new System.Drawing.Point(3, 2);
            this.area1.Name = "area1";
            this.area1.ReadOnly = true;
            this.area1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.area1.Size = new System.Drawing.Size(286, 97);
            this.area1.TabIndex = 1;
            this.area1.Text = "";
            this.area1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.area1_click);
            // 
            // area2
            // 
            this.area2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.area2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.area2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.area2.Location = new System.Drawing.Point(3, 3);
            this.area2.Name = "area2";
            this.area2.ReadOnly = true;
            this.area2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.area2.Size = new System.Drawing.Size(286, 94);
            this.area2.TabIndex = 2;
            this.area2.Text = "";
            this.area2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.area2_click);
            // 
            // area3
            // 
            this.area3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.area3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.area3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.area3.Location = new System.Drawing.Point(0, 3);
            this.area3.Name = "area3";
            this.area3.ReadOnly = true;
            this.area3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.area3.Size = new System.Drawing.Size(289, 94);
            this.area3.TabIndex = 3;
            this.area3.Text = "";
            this.area3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.area3_click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clipboard";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delete1);
            this.panel1.Controls.Add(this.pin1);
            this.panel1.Controls.Add(this.area1);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 100);
            this.panel1.TabIndex = 5;
            // 
            // delete1
            // 
            this.delete1.BackColor = System.Drawing.Color.Gray;
            this.delete1.Image = ((System.Drawing.Image)(resources.GetObject("delete1.Image")));
            this.delete1.InitialImage = ((System.Drawing.Image)(resources.GetObject("delete1.InitialImage")));
            this.delete1.Location = new System.Drawing.Point(290, 32);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(32, 32);
            this.delete1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete1.TabIndex = 3;
            this.delete1.TabStop = false;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // pin1
            // 
            this.pin1.BackColor = System.Drawing.Color.Gray;
            this.pin1.Image = global::MyClipboard.Properties.Resources.Pin;
            this.pin1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pin1.InitialImage")));
            this.pin1.Location = new System.Drawing.Point(290, 1);
            this.pin1.Name = "pin1";
            this.pin1.Size = new System.Drawing.Size(32, 32);
            this.pin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin1.TabIndex = 2;
            this.pin1.TabStop = false;
            this.pin1.Click += new System.EventHandler(this.pin1_Click);
            // 
            // delete2
            // 
            this.delete2.BackColor = System.Drawing.Color.Gray;
            this.delete2.Image = ((System.Drawing.Image)(resources.GetObject("delete2.Image")));
            this.delete2.InitialImage = ((System.Drawing.Image)(resources.GetObject("delete2.InitialImage")));
            this.delete2.Location = new System.Drawing.Point(290, 32);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(32, 32);
            this.delete2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete2.TabIndex = 5;
            this.delete2.TabStop = false;
            this.delete2.Click += new System.EventHandler(this.delete2_Click);
            // 
            // pin2
            // 
            this.pin2.BackColor = System.Drawing.Color.Gray;
            this.pin2.Image = ((System.Drawing.Image)(resources.GetObject("pin2.Image")));
            this.pin2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pin2.InitialImage")));
            this.pin2.Location = new System.Drawing.Point(290, 1);
            this.pin2.Name = "pin2";
            this.pin2.Size = new System.Drawing.Size(32, 32);
            this.pin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin2.TabIndex = 4;
            this.pin2.TabStop = false;
            this.pin2.Click += new System.EventHandler(this.pin2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.delete2);
            this.panel2.Controls.Add(this.pin2);
            this.panel2.Controls.Add(this.area2);
            this.panel2.Location = new System.Drawing.Point(12, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 100);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.delete3);
            this.panel3.Controls.Add(this.area3);
            this.panel3.Controls.Add(this.pin3);
            this.panel3.Location = new System.Drawing.Point(12, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 100);
            this.panel3.TabIndex = 7;
            // 
            // delete3
            // 
            this.delete3.BackColor = System.Drawing.Color.Gray;
            this.delete3.Image = ((System.Drawing.Image)(resources.GetObject("delete3.Image")));
            this.delete3.InitialImage = ((System.Drawing.Image)(resources.GetObject("delete3.InitialImage")));
            this.delete3.Location = new System.Drawing.Point(290, 32);
            this.delete3.Name = "delete3";
            this.delete3.Size = new System.Drawing.Size(32, 32);
            this.delete3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete3.TabIndex = 7;
            this.delete3.TabStop = false;
            this.delete3.Click += new System.EventHandler(this.delete3_Click);
            // 
            // pin3
            // 
            this.pin3.BackColor = System.Drawing.Color.Gray;
            this.pin3.Image = ((System.Drawing.Image)(resources.GetObject("pin3.Image")));
            this.pin3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pin3.InitialImage")));
            this.pin3.Location = new System.Drawing.Point(290, 1);
            this.pin3.Name = "pin3";
            this.pin3.Size = new System.Drawing.Size(32, 32);
            this.pin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin3.TabIndex = 6;
            this.pin3.TabStop = false;
            this.pin3.Click += new System.EventHandler(this.pin3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(110, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(346, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coptBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delete1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delete3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button coptBtn;
        private System.Windows.Forms.RichTextBox area1;
        private System.Windows.Forms.RichTextBox area2;
        private System.Windows.Forms.RichTextBox area3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox delete1;
        private System.Windows.Forms.PictureBox pin1;
        private System.Windows.Forms.PictureBox delete2;
        private System.Windows.Forms.PictureBox pin2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox delete3;
        private System.Windows.Forms.PictureBox pin3;
        private System.Windows.Forms.Button button1;
    }
}


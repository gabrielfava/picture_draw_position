namespace DrawPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcBox = new System.Windows.Forms.PictureBox();
            this.pcBoxOverView = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listImages = new System.Windows.Forms.ListBox();
            this.btOpenFolder = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOverView)).BeginInit();
            this.SuspendLayout();
            // 
            // trackZoom
            // 
            this.trackZoom.Location = new System.Drawing.Point(696, 226);
            this.trackZoom.Maximum = 100;
            this.trackZoom.Minimum = -100;
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Size = new System.Drawing.Size(322, 45);
            this.trackZoom.TabIndex = 1;
            this.trackZoom.Scroll += new System.EventHandler(this.trackZoom_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pcBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 493);
            this.panel1.TabIndex = 3;
            // 
            // pcBox
            // 
            this.pcBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcBox.InitialImage")));
            this.pcBox.Location = new System.Drawing.Point(3, 3);
            this.pcBox.Name = "pcBox";
            this.pcBox.Size = new System.Drawing.Size(110, 78);
            this.pcBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcBox.TabIndex = 1;
            this.pcBox.TabStop = false;
            this.pcBox.Click += new System.EventHandler(this.pcBox_Click);
            this.pcBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcBox_MouseDown);
            this.pcBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcBox_MouseMove);
            this.pcBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcBox_MouseUp);
            // 
            // pcBoxOverView
            // 
            this.pcBoxOverView.Location = new System.Drawing.Point(696, 15);
            this.pcBoxOverView.Name = "pcBoxOverView";
            this.pcBoxOverView.Size = new System.Drawing.Size(322, 196);
            this.pcBoxOverView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxOverView.TabIndex = 4;
            this.pcBoxOverView.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(743, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // listImages
            // 
            this.listImages.FormattingEnabled = true;
            this.listImages.Location = new System.Drawing.Point(12, 525);
            this.listImages.Name = "listImages";
            this.listImages.Size = new System.Drawing.Size(669, 186);
            this.listImages.TabIndex = 6;
            this.listImages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listImages_MouseClick);
            this.listImages.SelectedIndexChanged += new System.EventHandler(this.listImages_SelectedIndexChanged);
            // 
            // btOpenFolder
            // 
            this.btOpenFolder.Location = new System.Drawing.Point(696, 439);
            this.btOpenFolder.Name = "btOpenFolder";
            this.btOpenFolder.Size = new System.Drawing.Size(322, 44);
            this.btOpenFolder.TabIndex = 7;
            this.btOpenFolder.Text = "button2";
            this.btOpenFolder.UseVisualStyleBackColor = true;
            this.btOpenFolder.Click += new System.EventHandler(this.btOpenFolder_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(899, 327);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 723);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btOpenFolder);
            this.Controls.Add(this.listImages);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pcBoxOverView);
            this.Controls.Add(this.trackZoom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOverView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcBox;
        private System.Windows.Forms.PictureBox pcBoxOverView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listImages;
        private System.Windows.Forms.Button btOpenFolder;
        private System.Windows.Forms.TextBox textBox2;
    }
}


namespace RoboCatch
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
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Box_Screen = new System.Windows.Forms.TextBox();
			this.Box_X = new System.Windows.Forms.TextBox();
			this.Box_Y = new System.Windows.Forms.TextBox();
			this.Box_Width = new System.Windows.Forms.TextBox();
			this.Box_Height = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(162, 215);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(106, 49);
			this.button1.TabIndex = 0;
			this.button1.Text = "Catch";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(27, 270);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(161, 148);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Screen";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "X";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Width";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Y";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Height";
			// 
			// Box_Screen
			// 
			this.Box_Screen.Location = new System.Drawing.Point(121, 47);
			this.Box_Screen.Name = "Box_Screen";
			this.Box_Screen.Size = new System.Drawing.Size(100, 20);
			this.Box_Screen.TabIndex = 6;
			this.Box_Screen.TextChanged += new System.EventHandler(this.Box_Screen_TextChanged);
			// 
			// Box_X
			// 
			this.Box_X.Location = new System.Drawing.Point(121, 79);
			this.Box_X.Name = "Box_X";
			this.Box_X.Size = new System.Drawing.Size(100, 20);
			this.Box_X.TabIndex = 6;
			this.Box_X.TextChanged += new System.EventHandler(this.Box_X_TextChanged);
			// 
			// Box_Y
			// 
			this.Box_Y.Location = new System.Drawing.Point(121, 109);
			this.Box_Y.Name = "Box_Y";
			this.Box_Y.Size = new System.Drawing.Size(100, 20);
			this.Box_Y.TabIndex = 6;
			this.Box_Y.TextChanged += new System.EventHandler(this.Box_Y_TextChanged);
			// 
			// Box_Width
			// 
			this.Box_Width.Location = new System.Drawing.Point(121, 143);
			this.Box_Width.Name = "Box_Width";
			this.Box_Width.Size = new System.Drawing.Size(100, 20);
			this.Box_Width.TabIndex = 6;
			this.Box_Width.TextChanged += new System.EventHandler(this.Box_Width_TextChanged);
			// 
			// Box_Height
			// 
			this.Box_Height.Location = new System.Drawing.Point(121, 169);
			this.Box_Height.Name = "Box_Height";
			this.Box_Height.Size = new System.Drawing.Size(100, 20);
			this.Box_Height.TabIndex = 6;
			this.Box_Height.TextChanged += new System.EventHandler(this.Box_Height_TextChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(27, 215);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(102, 49);
			this.button2.TabIndex = 7;
			this.button2.Text = "ShowBox";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(274, 58);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(504, 380);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(195, 328);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 63);
			this.button3.TabIndex = 9;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Box_Height);
			this.Controls.Add(this.Box_Width);
			this.Controls.Add(this.Box_Y);
			this.Controls.Add(this.Box_X);
			this.Controls.Add(this.Box_Screen);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "TextOnScreenCatcher";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Box_Screen;
		private System.Windows.Forms.TextBox Box_X;
		private System.Windows.Forms.TextBox Box_Y;
		private System.Windows.Forms.TextBox Box_Width;
		private System.Windows.Forms.TextBox Box_Height;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button3;
	}
}


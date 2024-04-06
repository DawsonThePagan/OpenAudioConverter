namespace OpenAudioConverter
{
	partial class Processing
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
			this.ProcessingText = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// ProcessingText
			// 
			this.ProcessingText.AutoSize = true;
			this.ProcessingText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ProcessingText.Location = new System.Drawing.Point(12, 9);
			this.ProcessingText.Name = "ProcessingText";
			this.ProcessingText.Size = new System.Drawing.Size(779, 32);
			this.ProcessingText.TabIndex = 0;
			this.ProcessingText.Text = "Your files are been processed... This window may seem be unresponsive\r\n";
			// 
			// pictureBox1
			// 
			this.pictureBox1.ImageLocation = "Img/Loading.gif";
			this.pictureBox1.Location = new System.Drawing.Point(209, 58);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(380, 380);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// Processing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.ProcessingText);
			this.Name = "Processing";
			this.Text = "Processing";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Processing_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label ProcessingText;
		private PictureBox pictureBox1;
	}
}
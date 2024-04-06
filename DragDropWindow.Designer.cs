namespace OpenAudioConverter
{
	partial class StartWindow
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
			this.DragDropText = new System.Windows.Forms.Label();
			this.DragDropImage = new System.Windows.Forms.PictureBox();
			this.StartButton = new System.Windows.Forms.Button();
			this.FileBox = new System.Windows.Forms.RichTextBox();
			this.audioOutSelect = new System.Windows.Forms.ComboBox();
			this.ConvertLabel = new System.Windows.Forms.Label();
			this.ClearButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DragDropImage)).BeginInit();
			this.SuspendLayout();
			// 
			// DragDropText
			// 
			this.DragDropText.AutoSize = true;
			this.DragDropText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DragDropText.Location = new System.Drawing.Point(12, 9);
			this.DragDropText.Name = "DragDropText";
			this.DragDropText.Size = new System.Drawing.Size(426, 30);
			this.DragDropText.TabIndex = 0;
			this.DragDropText.Text = "Drag and Drop your file(s) to be converted";
			// 
			// DragDropImage
			// 
			this.DragDropImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.DragDropImage.ImageLocation = "Img/dragDrop.png";
			this.DragDropImage.Location = new System.Drawing.Point(15, 42);
			this.DragDropImage.Name = "DragDropImage";
			this.DragDropImage.Size = new System.Drawing.Size(380, 380);
			this.DragDropImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.DragDropImage.TabIndex = 1;
			this.DragDropImage.TabStop = false;
			// 
			// StartButton
			// 
			this.StartButton.Enabled = false;
			this.StartButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.StartButton.Location = new System.Drawing.Point(507, 380);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(125, 67);
			this.StartButton.TabIndex = 2;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// FileBox
			// 
			this.FileBox.Location = new System.Drawing.Point(401, 42);
			this.FileBox.Name = "FileBox";
			this.FileBox.ReadOnly = true;
			this.FileBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.FileBox.Size = new System.Drawing.Size(232, 301);
			this.FileBox.TabIndex = 3;
			this.FileBox.TabStop = false;
			this.FileBox.Text = "";
			// 
			// audioOutSelect
			// 
			this.audioOutSelect.FormattingEnabled = true;
			this.audioOutSelect.Items.AddRange(new object[] {
            "MP3",
            "OGG",
            "WAV"});
			this.audioOutSelect.Location = new System.Drawing.Point(507, 351);
			this.audioOutSelect.Name = "audioOutSelect";
			this.audioOutSelect.Size = new System.Drawing.Size(126, 23);
			this.audioOutSelect.TabIndex = 1;
			// 
			// ConvertLabel
			// 
			this.ConvertLabel.AutoSize = true;
			this.ConvertLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ConvertLabel.Location = new System.Drawing.Point(401, 348);
			this.ConvertLabel.Name = "ConvertLabel";
			this.ConvertLabel.Size = new System.Drawing.Size(100, 25);
			this.ConvertLabel.TabIndex = 5;
			this.ConvertLabel.Text = "Convert to";
			// 
			// ClearButton
			// 
			this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ClearButton.Location = new System.Drawing.Point(401, 380);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(100, 67);
			this.ClearButton.TabIndex = 3;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// StartWindow
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 461);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.ConvertLabel);
			this.Controls.Add(this.audioOutSelect);
			this.Controls.Add(this.FileBox);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.DragDropImage);
			this.Controls.Add(this.DragDropText);
			this.Name = "StartWindow";
			this.Text = "OAC - Drag and Drop";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.StartWindow_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.StartWindow_DragEnter);
			((System.ComponentModel.ISupportInitialize)(this.DragDropImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label DragDropText;
		private PictureBox DragDropImage;
		private Button StartButton;
		private RichTextBox FileBox;
		private ComboBox audioOutSelect;
		private Label ConvertLabel;
		private Button ClearButton;
	}
}
namespace OpenAudioConverter
{
	partial class Finished
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finished));
			this.FinishedText = new System.Windows.Forms.Label();
			this.FailedBox = new System.Windows.Forms.RichTextBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.DoMore = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// FinishedText
			// 
			this.FinishedText.AutoSize = true;
			this.FinishedText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FinishedText.Location = new System.Drawing.Point(12, 9);
			this.FinishedText.Name = "FinishedText";
			this.FinishedText.Size = new System.Drawing.Size(552, 30);
			this.FinishedText.TabIndex = 0;
			this.FinishedText.Text = "Processing has finished. Find any failed files listed below";
			// 
			// FailedBox
			// 
			this.FailedBox.Location = new System.Drawing.Point(12, 42);
			this.FailedBox.Name = "FailedBox";
			this.FailedBox.ReadOnly = true;
			this.FailedBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.FailedBox.Size = new System.Drawing.Size(552, 396);
			this.FailedBox.TabIndex = 1;
			this.FailedBox.TabStop = false;
			this.FailedBox.Text = "";
			// 
			// closeButton
			// 
			this.closeButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.closeButton.Location = new System.Drawing.Point(570, 41);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(218, 60);
			this.closeButton.TabIndex = 2;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// DoMore
			// 
			this.DoMore.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DoMore.Location = new System.Drawing.Point(570, 107);
			this.DoMore.Name = "DoMore";
			this.DoMore.Size = new System.Drawing.Size(218, 60);
			this.DoMore.TabIndex = 3;
			this.DoMore.Text = "Convert more";
			this.DoMore.UseVisualStyleBackColor = true;
			this.DoMore.Click += new System.EventHandler(this.DoMore_Click);
			// 
			// Finished
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DoMore);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.FailedBox);
			this.Controls.Add(this.FinishedText);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Finished";
			this.Text = "Finished";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Finished_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label FinishedText;
		private RichTextBox FailedBox;
		private Button closeButton;
		private Button DoMore;
	}
}
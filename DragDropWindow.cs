namespace OpenAudioConverter
{
	public partial class StartWindow : Form
	{
		public StartWindow()
		{
			InitializeComponent();
			this.Text = this.Text + " - V" + Program.VERSION;

			foreach(string ext in Program.allowedExtension) // Loop through the array of allowed extensions
			{
				audioOutSelect.Items.Add(ext);
			}
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			Program.outputFormat = (string)audioOutSelect.Text;
			Program.startProcessing();
		}

		private void StartWindow_DragDrop(object sender, DragEventArgs? e)
		{
			string[]? items = (string[]?)e.Data.GetData(DataFormats.FileDrop);
			if (items == null || items.Length == 0)
			{
				MessageBox.Show("You did not drag any items","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			foreach (string item in items)
			{
				// Get file extension and name from the full path
				string extension = item.Substring(item.LastIndexOf(".")+1); 
				string file_name = item.Substring(item.LastIndexOf("\\")+1);
				// Check that the extension is recognised
				if (!Program.allowedExtension.Contains(extension.ToUpper()))
				{
					MessageBox.Show("File '" + file_name + "' has a extension that is not recognised", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					continue;
				}
				// Add file to list if its recognised
				Program.filesList.Add(item);
				FileBox.Text = FileBox.Text + file_name + "\n";
			}

			// Enable the start button if anything has been added
			if (Program.filesList.Count > 0)
			{
				StartButton.Enabled = true;
			}
		}

		private void StartWindow_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
		}

		public void selectAudioOut()
		{
			audioOutSelect.Select();
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			Program.filesList.Clear();
			Program.outputFormat = null;
			audioOutSelect.Text = "";
			FileBox.Text = "";
			StartButton.Enabled = false;
		}

		public void HideSelf()
		{
			this.Hide();
		}

		public void reset()
		{
			audioOutSelect.Text = "";
			FileBox.Text = "";
			StartButton.Enabled = false;
		}

		private void StartWindow_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
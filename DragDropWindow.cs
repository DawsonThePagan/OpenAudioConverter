namespace OpenAudioConverter
{
	public partial class StartWindow : Form
	{
		public StartWindow()
		{
			InitializeComponent();
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
				Program.filesList.Add(item);
				FileBox.Text = FileBox.Text + item.Substring(item.LastIndexOf("\\")) + "\n";
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
	}
}
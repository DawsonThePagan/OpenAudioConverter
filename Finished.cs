namespace OpenAudioConverter
{
	public partial class Finished : Form
	{
		public Finished()
		{
			InitializeComponent();
			foreach (string file in Program.failedFiles)
			{
				FailedBox.Text = FailedBox.Text + file + "\n";
			}
			
		}

		private void DoMore_Click(object sender, EventArgs e)
		{
			this.Hide();
			Program.restart();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}

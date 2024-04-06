namespace OpenAudioConverter
{
	public partial class Finished : Form
	{
		public Finished()
		{
			InitializeComponent();
		}

		private void DoMore_Click(object sender, EventArgs e)
		{
			this.Hide();
			Program.restart();
		}

		public void updateFails()
		{
			this.Text = this.Text + " - V" + Program.VERSION;
			foreach (string file in Program.failedFiles)
			{
				FailedBox.Text = FailedBox.Text + file + "\n";
			}
		}

		public void reset()
		{
			FailedBox.Text = "";
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Finished_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}

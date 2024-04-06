namespace OpenAudioConverter
{
	public partial class Processing : Form
	{
		public Processing()
		{
			InitializeComponent();
			this.Text = this.Text + " - V" + Program.VERSION;
		}

		public void hideSelf()
		{
			this.Hide();
		}
	}
}

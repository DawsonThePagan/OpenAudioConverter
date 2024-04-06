using FFMpegCore;
using System.Collections;

namespace OpenAudioConverter
{
	internal static class Program
	{
		// Form storage
		static StartWindow? dragDropWin;
		static Processing? processingWin;
		static Finished? finishedWin;
		// File list holder
		public static ArrayList filesList = new();
		public static string? outputFormat;

		public const string VERSION = "1.0";

		// Output info holders
		public static ArrayList failedFiles = new();

		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			dragDropWin = new();
			processingWin = new Processing();
			finishedWin = new Finished();
			Application.Run(dragDropWin);
		}

		static void startConv(string filePath, string output)
		{
			string outputPath = filePath.Substring(0, filePath.LastIndexOf('.')) + "." +output;
			Console.WriteLine(filePath + "  " + outputPath);
			if (!FFMpegArguments.FromFileInput(filePath).OutputToFile(outputPath).ProcessSynchronously())
			{
				failedFiles.Add(filePath.Substring(filePath.LastIndexOf("\\")));
			}
		}

		async static void handleList(ArrayList files, string output)
		{
			foreach (string file in files)
			{
				await Task.Run(() => startConv(file, output));
			}
			finishProcess();
		}

#pragma warning disable CS8602 // It will complain about dragDropWin been possible null here otherwise
		public static void startProcessing()
		{
			// Make sure everything has been selected correctly
			if(outputFormat== null)
			{
				MessageBox.Show("No audio format has been selected" , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				dragDropWin.selectAudioOut();
				return;
			}
			if (filesList.Count == 0)
			{
				MessageBox.Show("No files have been selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Start the processing
			dragDropWin.HideSelf();
			processingWin = new();
			processingWin.Show();
			handleList(filesList, outputFormat);
		}

		public static void finishProcess()
		{
			processingWin.hideSelf();
			finishedWin.Show();
		}

		public static void restart()
		{
			dragDropWin.Show();
			filesList.Clear();
			outputFormat = null;
			failedFiles.Clear();
			dragDropWin.reset();
		}
#pragma warning restore CS8602
	}
}
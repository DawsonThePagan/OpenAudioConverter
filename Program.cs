using FFMpegCore;
using System.Collections;
using System.Windows.Forms.VisualStyles;

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
		// Constants
		public const string VERSION = "1.0";
		public static string[] allowedExtension = { "WAV", "OGG", "MP3", "FLAC", "AIFF", "WMA", "AAC" };

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

		/// <summary>
		/// Converts a single file
		/// </summary>
		/// <param name="filePath">Path to file</param>
		/// <param name="output">Output format</param>
		static void startConv(string filePath, string output)
		{
			string outputPath = filePath.Substring(0, filePath.LastIndexOf('.')) + "." +output;
			Console.WriteLine(filePath + "  " + outputPath);
			if (!FFMpegArguments.FromFileInput(filePath).OutputToFile(outputPath).ProcessSynchronously(false))
			{
				failedFiles.Add(filePath.Substring(filePath.LastIndexOf("\\")));
			}
		}

		/// <summary>
		/// Inject the list and pass to file convert
		/// </summary>
		/// <param name="files">Files to convert</param>
		/// <param name="output">Output format</param>
		async static void handleList(ArrayList files, string output)
		{
			foreach (string file in files)
			{
				await Task.Run(() => startConv(file, output));
			}
			finishProcess();
		}

#pragma warning disable CS8602 // Stop warnings about null windows, they are not null

		/// <summary>
		/// Start processing the files
		/// </summary>
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

		/// <summary>
		/// Finished processing the files
		/// </summary>
		public static void finishProcess()
		{
			processingWin.hideSelf();
			finishedWin.Show();
			finishedWin.updateFails();
		}

		/// <summary>
		/// Restart the flow
		/// </summary>
		public static void restart()
		{
			dragDropWin.Show();
			filesList.Clear();
			outputFormat = null;
			failedFiles.Clear();
			dragDropWin.reset();
			finishedWin.reset();
		}
#pragma warning restore CS8602
	}
}
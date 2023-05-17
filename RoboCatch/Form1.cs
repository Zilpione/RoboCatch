using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace RoboCatch
{
	public partial class Form1 : Form
	{
		BoxClass Box;
		public Form1()
		{
			Box = new BoxClass(1, 250, 230, 1500, 300);
			InitializeComponent();

			UpdateFields();
		
			_loading = false;
		}
		private void UpdateFields()
		{
			_loading = true;
			Box_Screen.Text = Box.ScreenIndex.ToString();
			Box_X.Text = Box.X.ToString();
			Box_Y.Text = Box.Y.ToString();

			Box_Width.Text = Box.Width.ToString();
			Box_Height.Text = Box.Height.ToString();
			_loading = false;
			DrawScreenshotArea(1000);
		}
		private bool _loading = true;
		private void button1_Click(object sender, EventArgs e)
		{
			string filePath = "screenshot.png"; // Percorso del file in cui salvare l'immagine catturata

			//Stream
			//using (Bitmap screenshotBitmap = CaptureScreenshot(screenIndex, x, y, width, height))
			//{
			//	string extractedText = ExtractTextFromImage(screenshotBitmap);
			//	string cleanedText = CleanExtractedText(extractedText);

			//	MessageBox.Show(cleanedText, "Testo estratto");
			//}
			//DrawScreenshotArea();
			SaveScreenshotButton_Click(filePath);
			pictureBox1.ImageLocation = filePath;

			//string extractedText = "";
			string cleanedText = "";
			using (Bitmap screenshotBitmap = new Bitmap(filePath))
			{
				var extractedText = ExtractTextFromImage(screenshotBitmap);
				cleanedText = CleanExtractedText(extractedText);

				//MessageBox.Show(cleanedText, "Testo estratto");
			}
			richTextBox1.Text = cleanedText;
			return;
		}
		private bool SaveScreenshotButton_Click(string filePath)
		{
			return CaptureAndSaveScreenshot(filePath);
		}

		public void DrawScreenshotArea(int closeAfterMilliseconds)
		{
			Screen[] screens = Screen.AllScreens;
			if (Box.ScreenIndex < 0 || Box.ScreenIndex >= screens.Length)
			{
				throw new ArgumentOutOfRangeException(nameof(Box.ScreenIndex), "L'indice dello schermo specificato non è valido.");
			}
			Screen selectedScreen = screens[Box.ScreenIndex];

			Form screenshotArea = new Form
			{
				FormBorderStyle = FormBorderStyle.None,
				ShowInTaskbar = false,
				StartPosition = FormStartPosition.Manual,
				AutoScaleMode = AutoScaleMode.None,
				Location = new Point(selectedScreen.Bounds.X + Box.X, selectedScreen.Bounds.Y + Box.Y),
				Size = new Size(Box.Width, Box.Height),
				BackColor = Color.Magenta, // Impostare un colore non comune per il background
				TransparencyKey = Color.Magenta, // Lo stesso colore viene utilizzato come chiave di trasparenza
				TopMost = true, // Mantiene la finestra in primo piano
				ShowIcon = false
			};

			screenshotArea.Paint += (sender, e) =>
			{
				e.Graphics.DrawRectangle(new Pen(Color.Red, 2), new Rectangle(0, 0, screenshotArea.Width - 1, screenshotArea.Height - 1));
			};

			System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
			timer.Interval = closeAfterMilliseconds;
			timer.Tick += (s, e) =>
			{
				timer.Stop();
				screenshotArea.Close();
			};
			timer.Start();

			// Mostra la finestra di selezione dell'area dello screenshot
			screenshotArea.Show();
		}

		//private Bitmap CaptureScreenshot(int screenIndex, int x, int y, int width, int height)
		//{
		//	Screen[] screens = Screen.AllScreens;
		//	if (screenIndex < 0 || screenIndex >= screens.Length)
		//	{
		//		throw new ArgumentOutOfRangeException(nameof(screenIndex), "L'indice dello schermo specificato non è valido.");
		//	}
		//	Screen selectedScreen = screens[screenIndex];

		//	Bitmap screenshotBitmap = new Bitmap(width, height);

		//	using (Graphics graphics = Graphics.FromImage(screenshotBitmap))
		//	{
		//		graphics.CopyFromScreen(selectedScreen.Bounds.X + x, selectedScreen.Bounds.Y + y, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
		//	}

		//	return screenshotBitmap;
		//}
		private bool CaptureAndSaveScreenshot(string filePath)
		{
			try
			{
				// Ottieni informazioni sullo schermo specificato
				Screen[] screens = Screen.AllScreens;
				if (Box.ScreenIndex < 0 || Box.ScreenIndex >= screens.Length)
				{
					throw new ArgumentOutOfRangeException(nameof(Box.ScreenIndex), "L'indice dello schermo specificato non è valido.");
				}
				Screen selectedScreen = screens[Box.ScreenIndex];

				// Crea un nuovo bitmap con le dimensioni desiderate
				using (Bitmap screenshotBitmap = new Bitmap(Box.Width, Box.Height))
				{
					// Crea un oggetto Graphics dal bitmap
					using (Graphics graphics = Graphics.FromImage(screenshotBitmap))
					{
						// Copia l'immagine dello schermo nelle coordinate specificate nel bitmap
						graphics.CopyFromScreen(selectedScreen.Bounds.X + Box.X, selectedScreen.Bounds.Y + Box.Y, 0, 0, new Size(Box.Width, Box.Height), CopyPixelOperation.SourceCopy);

						// Salva l'immagine in un file
						screenshotBitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
					}
				}
				return true;
			}
			catch (Exception e)
			{
				return false;
			}

		}

		private string ExtractTextFromImage(Bitmap image)
		{
			string extractedText = "";

			// Inizializza l'engine Tesseract OCR
			using (var ocrEngine = new TesseractEngine("./tessdata", "eng", EngineMode.Default))
			{
				// Esegui OCR sull'immagine
				using (var page = ocrEngine.Process(image))
				{
					// Ottieni il testo estratto dall'immagine
					extractedText = page.GetText();
				}
			}

			return extractedText;
		}
		private string CleanExtractedText(string extractedText)
		{
			// Rimuovi gli spazi bianchi in eccesso e le righe vuote
			string[] lines = extractedText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < lines.Length; i++)
			{
				lines[i] = lines[i].Trim();
			}
			string cleanedText = string.Join(Environment.NewLine, lines);

			return cleanedText;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Box_Screen_TextChanged(object sender, EventArgs e)
		{
			Box.ScreenIndex = Box_Screen.SetValue(Box.ScreenIndex, sender) ?? Box.ScreenIndex;
			UpdateBox();
		}

		private void Box_X_TextChanged(object sender, EventArgs e)
		{
			Box.X = Box_X.SetValue(Box.X, sender) ?? Box.X;
			UpdateBox();
		}

		private void Box_Y_TextChanged(object sender, EventArgs e)
		{
			Box.Y = Box_Y.SetValue(Box.Y, sender) ?? Box.Y;
			UpdateBox();
		}

		private void Box_Width_TextChanged(object sender, EventArgs e)
		{
			Box.Width = Box_Width.SetValue(Box.Width, sender) ?? Box.Width;
			UpdateBox();
		}

		private void Box_Height_TextChanged(object sender, EventArgs e)
		{
			Box.Height = Box_Height.SetValue(Box.Height, sender) ?? Box.Height;
			UpdateBox();
		}


		void UpdateBox()
		{
			//return;
			if (_loading) return;
			DrawScreenshotArea(100);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DrawScreenshotArea(1000);
		}
		private Point startPoint;
		private bool isDragging;

		private void button3_Click(object sender, EventArgs e)
		{

		}
		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			startPoint = e.Location;
			isDragging = true;
		}
		private void MainForm_MouseUp(object sender, MouseEventArgs e)
		{
			isDragging = false;
			UpdateFields();
		}
		private void MainForm_Paint(object sender, PaintEventArgs e)
		{
			// Disegna il rettangolo di selezione sulla superficie del form
			using (Pen pen = new Pen(Color.Red, 2))
			{
				e.Graphics.DrawRectangle(pen, Box.X, Box.Y, Box.Width, Box.Height);
			}
		}
		private void MainForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (isDragging)
			{
				int x = Math.Min(startPoint.X, e.X);
				int y = Math.Min(startPoint.Y, e.Y);
				int width = Math.Abs(e.X - startPoint.X);
				int height = Math.Abs(e.Y - startPoint.Y);

				Box.ScreenIndex = 1; // Imposta l'indice dello schermo desiderato
				Box.X = x;
				Box.Y = y;
				Box.Width = width;
				Box.Height = height;

				// Puoi anche disegnare il rettangolo di selezione in modo visuale, ad esempio usando il metodo `Invalidate()` del form per richiamare il gestore dell'evento `Paint`

				// Esempio:
				Invalidate();
			}
		}
	}
}

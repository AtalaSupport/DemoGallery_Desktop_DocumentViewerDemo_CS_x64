using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Atalasoft.Imaging;
using Atalasoft.Imaging.ImageProcessing;
using Atalasoft.Imaging.WinControls;
using Atalasoft.Imaging.Codec;
using WinDemoHelperMethods;

namespace DocumentViewerDemo
{
	public class Form1 : System.Windows.Forms.Form
	{
		private string[] _imageSourceFileNames;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Atalasoft.Imaging.WinControls.DocumentViewer _viewer;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuFileAddFiles;
		private System.Windows.Forms.MenuItem menuFileAddFolder;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuFileRemove;
		private System.Windows.Forms.MenuItem menuFileClear;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuFileSave;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuProcessing;
		private System.Windows.Forms.MenuItem menuProcessingConvertToGrayscale;
		private System.Windows.Forms.MenuItem menuProcessingConvertToBinary;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuHelp;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private System.Windows.Forms.MenuItem menuProcessingInvert;
		private System.Windows.Forms.MenuItem menuProcessingMosaic;
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();

            HelperMethods.PopulateDecoders(RegisteredDecoders.Decoders);

			if (AtalaImage.Edition != LicenseEdition.Document)
			{
				MessageBox.Show("This demo requires a 'DotImage Document Imaging' license to save the files.", "Save Feature Disabled", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.menuFileSave.Enabled = false;
			}

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._viewer = new Atalasoft.Imaging.WinControls.DocumentViewer();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuFileAddFiles = new System.Windows.Forms.MenuItem();
			this.menuFileAddFolder = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuFileRemove = new System.Windows.Forms.MenuItem();
			this.menuFileClear = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuFileSave = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuProcessing = new System.Windows.Forms.MenuItem();
			this.menuProcessingConvertToBinary = new System.Windows.Forms.MenuItem();
			this.menuProcessingConvertToGrayscale = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuProcessingInvert = new System.Windows.Forms.MenuItem();
			this.menuProcessingMosaic = new System.Windows.Forms.MenuItem();
			this.menuHelp = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// _viewer
			// 
			this._viewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this._viewer.ImageControl.AntialiasDisplay = Atalasoft.Imaging.WinControls.AntialiasDisplayMode.ScaleToGray;
			this._viewer.ImageControl.BackColor = System.Drawing.SystemColors.Control;
			this._viewer.ImageControl.Centered = true;
			this._viewer.ImageControl.Cursor = System.Windows.Forms.Cursors.Default;
			this._viewer.ImageControl.Magnifier.BackColor = System.Drawing.Color.White;
			this._viewer.ImageControl.Magnifier.BorderColor = System.Drawing.Color.Black;
			this._viewer.ImageControl.Magnifier.Size = new System.Drawing.Size(100, 100);
			this._viewer.Location = new System.Drawing.Point(0, 0);
			this._viewer.Name = "_viewer";
			this._viewer.Separator.BackColor = System.Drawing.SystemColors.ControlLight;
			this._viewer.Separator.MinSize = 150;
			this._viewer.Separator.Mode = Atalasoft.Imaging.WinControls.ControlSeparator.Splitter;
			this._viewer.Size = new System.Drawing.Size(600, 382);
			this._viewer.TabIndex = 0;
			this._viewer.ThumbnailControl.AllowDrop = true;
			this._viewer.ThumbnailControl.AutoDragDrop = true;
			this._viewer.ThumbnailControl.BackColor = System.Drawing.SystemColors.Window;
			this._viewer.ThumbnailControl.Cursor = System.Windows.Forms.Cursors.Default;
			this._viewer.ThumbnailControl.DragSelectionColor = System.Drawing.Color.Chartreuse;
			this._viewer.ThumbnailControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._viewer.ThumbnailControl.ForeColor = System.Drawing.SystemColors.WindowText;
			this._viewer.ThumbnailControl.HighlightBackgroundColor = System.Drawing.SystemColors.Highlight;
			this._viewer.ThumbnailControl.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
			this._viewer.ThumbnailControl.Margins = new Atalasoft.Imaging.WinControls.Margin(4, 4, 4, 4);
			this._viewer.ThumbnailControl.SelectionMode = Atalasoft.Imaging.WinControls.ThumbnailSelectionMode.SingleSelect;
			this._viewer.ThumbnailControl.SelectionRectangleBackColor = System.Drawing.Color.Transparent;
			this._viewer.ThumbnailControl.SelectionRectangleDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
			this._viewer.ThumbnailControl.SelectionRectangleLineColor = System.Drawing.Color.Black;
			this._viewer.ThumbnailControl.ThumbnailOffset = new System.Drawing.Point(0, 0);
			this._viewer.ThumbnailControl.ThumbnailSize = new System.Drawing.Size(120, 120);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuFile,
																					  this.menuProcessing,
																					  this.menuHelp});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuFileAddFiles,
																					 this.menuFileAddFolder,
																					 this.menuItem4,
																					 this.menuFileRemove,
																					 this.menuFileClear,
																					 this.menuItem7,
																					 this.menuFileSave,
																					 this.menuItem9,
																					 this.menuFileExit});
			this.menuFile.Text = "&File";
			// 
			// menuFileAddFiles
			// 
			this.menuFileAddFiles.Index = 0;
			this.menuFileAddFiles.Text = "&Add Files";
			this.menuFileAddFiles.Click += new System.EventHandler(this.menuFileAddFiles_Click);
			// 
			// menuFileAddFolder
			// 
			this.menuFileAddFolder.Index = 1;
			this.menuFileAddFolder.Text = "Add Folder";
			this.menuFileAddFolder.Click += new System.EventHandler(this.menuFileAddFolder_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "-";
			// 
			// menuFileRemove
			// 
			this.menuFileRemove.Index = 3;
			this.menuFileRemove.Text = "&Remove Selected";
			this.menuFileRemove.Click += new System.EventHandler(this.menuFileRemove_Click);
			// 
			// menuFileClear
			// 
			this.menuFileClear.Index = 4;
			this.menuFileClear.Text = "&Clear All";
			this.menuFileClear.Click += new System.EventHandler(this.menuFileClear_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 5;
			this.menuItem7.Text = "-";
			// 
			// menuFileSave
			// 
			this.menuFileSave.Index = 6;
			this.menuFileSave.Text = "&Save";
			this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 7;
			this.menuItem9.Text = "-";
			// 
			// menuFileExit
			// 
			this.menuFileExit.Index = 8;
			this.menuFileExit.Text = "E&xit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// menuProcessing
			// 
			this.menuProcessing.Index = 1;
			this.menuProcessing.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.menuProcessingConvertToBinary,
																						   this.menuProcessingConvertToGrayscale,
																						   this.menuItem14,
																						   this.menuProcessingInvert,
																						   this.menuProcessingMosaic});
			this.menuProcessing.Text = "&Processing";
			// 
			// menuProcessingConvertToBinary
			// 
			this.menuProcessingConvertToBinary.Index = 0;
			this.menuProcessingConvertToBinary.Text = "Convert to Binary";
			this.menuProcessingConvertToBinary.Click += new System.EventHandler(this.menuProcessingConvertToBinary_Click);
			// 
			// menuProcessingConvertToGrayscale
			// 
			this.menuProcessingConvertToGrayscale.Index = 1;
			this.menuProcessingConvertToGrayscale.Text = "Convert to Grayscale";
			this.menuProcessingConvertToGrayscale.Click += new System.EventHandler(this.menuProcessingConvertToGrayscale_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 2;
			this.menuItem14.Text = "-";
			// 
			// menuProcessingInvert
			// 
			this.menuProcessingInvert.Index = 3;
			this.menuProcessingInvert.Text = "Invert";
			this.menuProcessingInvert.Click += new System.EventHandler(this.menuProcessingInvert_Click);
			// 
			// menuProcessingMosaic
			// 
			this.menuProcessingMosaic.Index = 4;
			this.menuProcessingMosaic.Text = "Mosaic";
			this.menuProcessingMosaic.Click += new System.EventHandler(this.menuProcessingMosaic_Click);
			// 
			// menuHelp
			// 
			this.menuHelp.Index = 2;
			this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuHelpAbout});
			this.menuHelp.Text = "&Help";
			// 
			// menuHelpAbout
			// 
			this.menuHelpAbout.Index = 0;
			this.menuHelpAbout.Text = "&About...";
			this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(600, 382);
			this.Controls.Add(this._viewer);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Atalasoft DocumentViewer Demo";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			Application.Run(new Form1());
		}

		#region File Menu

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuFileAddFiles_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = HelperMethods.CreateDialogFilter(true);
			dlg.Multiselect = true;

			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				LoadFiles(dlg.FileNames);
			}

			dlg.Dispose();
		}

		private void menuFileAddFolder_Click(object sender, System.EventArgs e)
		{
			FolderBrowserDialog dlg = new FolderBrowserDialog();
			dlg.ShowNewFolderButton = false;
			dlg.Description = "Select a folder containing images to load.";
			
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				string[] files = GetDirectoryFiles(dlg.SelectedPath);
				if (files != null) LoadFiles(files);
			}

			dlg.Dispose();
		}

		private void LoadFiles(string[] files)
		{
			int itemCount = _viewer.ThumbnailControl.Items.Count;

			foreach (string file in files)
			{
				_viewer.Add(file, -1, System.IO.Path.GetFileName(file), "");
			}

			// Select the first of the newly added images.
			if (_viewer.ThumbnailControl.Items.Count > 0)
			{
				_viewer.ClearSelection();
				_viewer.SelectThumbnail(itemCount);
				_viewer.EnsureVisible(itemCount);
			}
		}

		private string[] GetDirectoryFiles(string path)
		{
			ArrayList items = new ArrayList();

			string[] exts = new string[] { "*.jpg", "*.bmp", "*.png", "*.tif", "*.gif" };
			foreach (string ext in exts)
			{
				string[] files = System.IO.Directory.GetFiles(path, ext);
				if (files != null)
					items.AddRange(files);
			}

			return (string[])items.ToArray(typeof(string));
		}

		private void menuFileRemove_Click(object sender, System.EventArgs e)
		{
			_viewer.RemoveSelected();
		}

		private void menuFileClear_Click(object sender, System.EventArgs e)
		{
			_viewer.Clear();
		}

		private void menuFileSave_Click(object sender, System.EventArgs e)
		{
			if (_viewer.Count == 0) return;

			// Save all images to a single multipage TIFF.
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = HelperMethods.CreateDialogFilter(false);

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    this._viewer.Save(dlg.FileName, HelperMethods.GetImageEncoder(dlg.FilterIndex));
                }

            }
		}

		// This is called when a Thumbnail object is being created and needs to know its caption.
		// This action is setup in the LoadFiles method.
		private void OnCaptionRequested(object sender, ThumbnailCaptionRequestEventArgs e)
		{
			if (_imageSourceFileNames == null) return;
			if (e.Index < 0 || e.Index >= _imageSourceFileNames.Length) return;

			e.Caption = System.IO.Path.GetFileName(_imageSourceFileNames[e.Index]);
		}

		#endregion

		#region Processing Menu

		private void ProcessCommand(Atalasoft.Imaging.ImageProcessing.ImageCommand command)
		{
			if (_viewer.ImageControl.Image == null) return;

			try
			{
				_viewer.ApplyCommand(command);
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was an error processing the command.\r\n" + ex.Message, "Command Exception");
			}
		}

		private void menuProcessingConvertToBinary_Click(object sender, System.EventArgs e)
		{
			if (_viewer.ImageControl.Image == null || _viewer.ImageControl.Image.PixelFormat == PixelFormat.Pixel1bppIndexed) return;

			ProcessCommand(new ChangePixelFormatCommand(PixelFormat.Pixel1bppIndexed));
		}

		private void menuProcessingConvertToGrayscale_Click(object sender, System.EventArgs e)
		{
			if (_viewer.ImageControl.Image == null || _viewer.ImageControl.Image.PixelFormat == PixelFormat.Pixel8bppGrayscale) return;

			ProcessCommand(new ChangePixelFormatCommand(PixelFormat.Pixel8bppGrayscale));
		}

		private void menuProcessingInvert_Click(object sender, System.EventArgs e)
		{
			ProcessCommand(new Atalasoft.Imaging.ImageProcessing.Channels.InvertCommand());
		}

		private void menuProcessingMosaic_Click(object sender, System.EventArgs e)
		{
			ProcessCommand(new Atalasoft.Imaging.ImageProcessing.Effects.MosaicCommand(25));
		}

		#endregion

		#region Help Menu

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			AtalaDemos.AboutBox.About frm = new AtalaDemos.AboutBox.About("About ThumbnailWorkspaceViewer Demo", "ThumbnailWorkspaceViewer");
			frm.Description = "This demo uses the ThumbnailWorkspaceViewer control to quickly add the ability of synchronizing ThumbnailView and WorkspaceViewer controls together.  This means selecting a thumbnail will load the image into the WorkspaceViewer and applying a command to the loaded image will reflect its change in the thumbnail.";
			frm.ShowDialog(this);
			frm.Dispose();
		}

		#endregion

	}
}

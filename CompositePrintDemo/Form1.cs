using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Atalasoft.Imaging;
using Atalasoft.Imaging.WinControls;


namespace CompositePrintDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private string[] _imageFiles;
		private int _pages;
		private Atalasoft.Imaging.WinControls.ImageCompositePrintDocument imageCompositePrintDocument1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnSelectFolder;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnPageSetup;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button AboutBtn;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.comboBox1.SelectedIndex = 0;
			this.comboBox2.SelectedIndex = 0;
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
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.imageCompositePrintDocument1 = new Atalasoft.Imaging.WinControls.ImageCompositePrintDocument();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnSelectFolder = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnPageSetup = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.AboutBtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// printPreviewControl1
			// 
			this.printPreviewControl1.AutoZoom = false;
			this.printPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.printPreviewControl1.Location = new System.Drawing.Point(0, 40);
			this.printPreviewControl1.Name = "printPreviewControl1";
			this.printPreviewControl1.Size = new System.Drawing.Size(680, 321);
			this.printPreviewControl1.TabIndex = 1;
			this.printPreviewControl1.Zoom = 0.25;
			// 
			// pageSetupDialog1
			// 
			this.pageSetupDialog1.Document = this.imageCompositePrintDocument1;
			// 
			// imageCompositePrintDocument1
			// 
			this.imageCompositePrintDocument1.CaptionAlignment = System.Drawing.StringAlignment.Center;
			this.imageCompositePrintDocument1.CaptionColor = System.Drawing.Color.Black;
			this.imageCompositePrintDocument1.CaptionFont = new System.Drawing.Font("Arial", 8F);
			this.imageCompositePrintDocument1.PrintImage += new Atalasoft.Imaging.WinControls.PrintCompositeEventHandler(this.imageCompositePrintDocument1_PrintImage);
			this.imageCompositePrintDocument1.AfterPrintImage += new Atalasoft.Imaging.WinControls.PrintCompositeEventHandler(this.imageCompositePrintDocument1_AfterPrintImage);
			this.imageCompositePrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(imageCompositePrintDocument1_PrintPage);
			// 
			// printDialog1
			// 
			this.printDialog1.Document = this.imageCompositePrintDocument1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.AboutBtn);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.btnPrint);
			this.panel1.Controls.Add(this.btnSelectFolder);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.btnPageSetup);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(680, 40);
			this.panel1.TabIndex = 2;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(488, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Crop To Fit";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(224, 8);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.TabIndex = 2;
			this.btnPrint.Text = "Print";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnSelectFolder
			// 
			this.btnSelectFolder.Location = new System.Drawing.Point(8, 8);
			this.btnSelectFolder.Name = "btnSelectFolder";
			this.btnSelectFolder.Size = new System.Drawing.Size(80, 23);
			this.btnSelectFolder.TabIndex = 1;
			this.btnSelectFolder.Text = "Select Folder";
			this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
														   "Full Page",
														   "8 x 10 in",
														   "20 x 25 cm",
														   "5 x 7 in",
														   "13 x 18 cm",
														   "4 x 6 in",
														   "10 x 15 cm",
														   "4 x 6 in best fit",
														   "10 x 15 cm best fit",
														   "3.5 x 4 in",
														   "9 x 13 cm",
														   "Wallets",
														   "Contact Sheet"});
			this.comboBox1.Location = new System.Drawing.Point(96, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// btnPageSetup
			// 
			this.btnPageSetup.Location = new System.Drawing.Point(304, 8);
			this.btnPageSetup.Name = "btnPageSetup";
			this.btnPageSetup.TabIndex = 3;
			this.btnPageSetup.Text = "Page Setup";
			this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
														   "25%",
														   "50%",
														   "75%",
														   "100%",
														   "200%"});
			this.comboBox2.Location = new System.Drawing.Point(392, 8);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(80, 21);
			this.comboBox2.TabIndex = 3;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// AboutBtn
			// 
			this.AboutBtn.Location = new System.Drawing.Point(600, 8);
			this.AboutBtn.Name = "AboutBtn";
			this.AboutBtn.Size = new System.Drawing.Size(72, 24);
			this.AboutBtn.TabIndex = 5;
			this.AboutBtn.Text = "About ...";
			this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(680, 361);
			this.Controls.Add(this.printPreviewControl1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Composite Image Print Demo";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void imageCompositePrintDocument1_PrintImage(object sender, Atalasoft.Imaging.WinControls.PrintCompositeEventArgs e)
		{
			if (_imageFiles != null && _imageFiles.Length > e.ImageIndex)
			{
				try
				{
					e.Image = new AtalaImage(_imageFiles[e.ImageIndex]);
					e.Caption = System.IO.Path.GetFileName(_imageFiles[e.ImageIndex]);
				}
				catch
				{
				}
			}

			if (e.ImageIndex >= _imageFiles.Length - 1)
			{
				e.HasMorePages = false;
				this.printPreviewControl1.Rows = _pages;
			}
			else
				e.HasMorePages = true;
		}

		private void btnSelectFolder_Click(object sender, System.EventArgs e)
		{
			if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				_imageFiles = System.IO.Directory.GetFiles(this.folderBrowserDialog1.SelectedPath, "*.jpg");
				_pages = 0;
				//this.printPreviewControl1.Rows = _imageFiles.Length;
				this.printPreviewControl1.Document = this.imageCompositePrintDocument1;
				this.printPreviewControl1.InvalidatePreview();
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (_imageFiles != null)
			{
				_pages = 0;
				this.imageCompositePrintDocument1.Layout = (CompositePrintLayout)comboBox1.SelectedIndex;
				this.printPreviewControl1.InvalidatePreview();
			}
		}

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			if (this.printDialog1.ShowDialog(this) == DialogResult.OK)
			{
				this.imageCompositePrintDocument1.Print();
			}
		}

		private void btnPageSetup_Click(object sender, System.EventArgs e)
		{
			this.pageSetupDialog1.ShowDialog(this);
		}

		private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox2.SelectedIndex)
			{
				case 0:
					this.printPreviewControl1.Zoom = 0.25;
					break;
				case 1:
					this.printPreviewControl1.Zoom = 0.50;
					break;
				case 2:
					this.printPreviewControl1.Zoom = 0.75;
					break;
				case 3:
					this.printPreviewControl1.Zoom = 1.0;
					break;
				case 4:
					this.printPreviewControl1.Zoom = 2.0;
					break;
			}

		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.imageCompositePrintDocument1.CropImageToFit = checkBox1.Checked;
			this.printPreviewControl1.InvalidatePreview();
		}

		//handle this event to dispose the image that's no longer needed
		private void imageCompositePrintDocument1_AfterPrintImage(object sender, Atalasoft.Imaging.WinControls.PrintCompositeEventArgs e)
		{
			if (e.Image != null)
				e.Image.Dispose();
		}

		private void imageCompositePrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			_pages++;
		}

		private void AboutBtn_Click(object sender, System.EventArgs e)
		{
			AtalaDemos.AboutBox.About aboutBox = new AtalaDemos.AboutBox.About("About Atalasoft DotImage Composite Print Demo",
				"DotImage Composite Print Demo");
			aboutBox.Description = @"Demonstrates how to use the ImageCompositePrintDocument class to print multiple images on a single page.  This is useful for printing multiple photos or a photo collage.  It can be used to conserve expensive photo quality paper by efficiently orienting photos on the paper.";
			aboutBox.ShowDialog();
		}
	}
}

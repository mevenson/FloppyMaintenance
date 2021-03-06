//This code has been automatically generated by DudeLabs, LLC RCConverter
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FloppyMaintenance
{
	/// <summary>
	/// Summary description for frmDialogDiskParameters.
	/// </summary>

	partial class frmDialogDiskParameters : System.Windows.Forms.Form
		{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        private System.Windows.Forms.TextBox txtEditVolumeName;
        private System.Windows.Forms.RadioButton rdoRadioFlexFormat;
        private System.Windows.Forms.RadioButton rdoRadioOs9Format;
        private System.Windows.Forms.RadioButton rdoRadioUniflexFormat;
        private System.Windows.Forms.RadioButton rdoRadioControllerFd2;
        private System.Windows.Forms.RadioButton rdoRadioControllerDmaf2;
        private System.Windows.Forms.CheckBox chkCheckIncludeBootSector;
        private System.Windows.Forms.RadioButton rdoRadio35Track;
        private System.Windows.Forms.RadioButton rdoRadio40Track;
        private System.Windows.Forms.RadioButton rdoRadio80Track;
        private System.Windows.Forms.RadioButton rdoRadioUserDefined;
        private System.Windows.Forms.RadioButton rdoRadioSingleDensity;
        private System.Windows.Forms.RadioButton rdoRadioDoubleDensity;
        private System.Windows.Forms.RadioButton rdoRadioQuadDensity;
        private System.Windows.Forms.CheckBox chkCheckDoubleSided;
        private System.Windows.Forms.TextBox txtEditTracks;
        private System.Windows.Forms.TextBox txtEditSectors;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpStatic1;
        private System.Windows.Forms.GroupBox grpStatic2;
        private System.Windows.Forms.Label lblStatic3;
        private System.Windows.Forms.Label lblStatic4;
        private System.Windows.Forms.Label lblStatic5;
        private System.Windows.Forms.GroupBox grpStatic6;
        private System.Windows.Forms.GroupBox grpStatic7;





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

					#region DudeLabs LLC RCConverter generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.txtEditVolumeName = new System.Windows.Forms.TextBox();
            this.rdoRadioFlexFormat = new System.Windows.Forms.RadioButton();
            this.rdoRadioOs9Format = new System.Windows.Forms.RadioButton();
            this.rdoRadioUniflexFormat = new System.Windows.Forms.RadioButton();
            this.rdoRadioControllerFd2 = new System.Windows.Forms.RadioButton();
            this.rdoRadioControllerDmaf2 = new System.Windows.Forms.RadioButton();
            this.chkCheckIncludeBootSector = new System.Windows.Forms.CheckBox();
            this.rdoRadio35Track = new System.Windows.Forms.RadioButton();
            this.rdoRadio40Track = new System.Windows.Forms.RadioButton();
            this.rdoRadio80Track = new System.Windows.Forms.RadioButton();
            this.rdoRadioUserDefined = new System.Windows.Forms.RadioButton();
            this.rdoRadioSingleDensity = new System.Windows.Forms.RadioButton();
            this.rdoRadioDoubleDensity = new System.Windows.Forms.RadioButton();
            this.rdoRadioQuadDensity = new System.Windows.Forms.RadioButton();
            this.chkCheckDoubleSided = new System.Windows.Forms.CheckBox();
            this.txtEditTracks = new System.Windows.Forms.TextBox();
            this.txtEditSectors = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpStatic1 = new System.Windows.Forms.GroupBox();
            this.grpStatic2 = new System.Windows.Forms.GroupBox();
            this.lblStatic3 = new System.Windows.Forms.Label();
            this.lblStatic4 = new System.Windows.Forms.Label();
            this.lblStatic5 = new System.Windows.Forms.Label();
            this.grpStatic6 = new System.Windows.Forms.GroupBox();
            this.grpStatic7 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelSectorsTrackZero = new System.Windows.Forms.Label();
            this.txtEditSectors0 = new System.Windows.Forms.TextBox();
            this.checkBoxGoTekCompatible = new System.Windows.Forms.CheckBox();
            this.grpStatic1.SuspendLayout();
            this.grpStatic2.SuspendLayout();
            this.grpStatic6.SuspendLayout();
            this.grpStatic7.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEditVolumeName
            // 
            this.txtEditVolumeName.Location = new System.Drawing.Point(97, 16);
            this.txtEditVolumeName.Name = "txtEditVolumeName";
            this.txtEditVolumeName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtEditVolumeName.Size = new System.Drawing.Size(152, 20);
            this.txtEditVolumeName.TabIndex = 1;
            // 
            // rdoRadioFlexFormat
            // 
            this.rdoRadioFlexFormat.Location = new System.Drawing.Point(10, 17);
            this.rdoRadioFlexFormat.Name = "rdoRadioFlexFormat";
            this.rdoRadioFlexFormat.Size = new System.Drawing.Size(56, 17);
            this.rdoRadioFlexFormat.TabIndex = 2;
            this.rdoRadioFlexFormat.TabStop = true;
            this.rdoRadioFlexFormat.Text = "FLEX";
            this.rdoRadioFlexFormat.CheckedChanged += new System.EventHandler(this.rdoRadioFlexFormat_CheckedChanged);
            // 
            // rdoRadioOs9Format
            // 
            this.rdoRadioOs9Format.Location = new System.Drawing.Point(70, 17);
            this.rdoRadioOs9Format.Name = "rdoRadioOs9Format";
            this.rdoRadioOs9Format.Size = new System.Drawing.Size(51, 17);
            this.rdoRadioOs9Format.TabIndex = 3;
            this.rdoRadioOs9Format.Text = "OS9";
            this.rdoRadioOs9Format.CheckedChanged += new System.EventHandler(this.rdoRadioOs9Format_CheckedChanged);
            // 
            // rdoRadioUniflexFormat
            // 
            this.rdoRadioUniflexFormat.Location = new System.Drawing.Point(125, 17);
            this.rdoRadioUniflexFormat.Name = "rdoRadioUniflexFormat";
            this.rdoRadioUniflexFormat.Size = new System.Drawing.Size(72, 17);
            this.rdoRadioUniflexFormat.TabIndex = 4;
            this.rdoRadioUniflexFormat.Text = "UniFLEX";
            this.rdoRadioUniflexFormat.CheckedChanged += new System.EventHandler(this.rdoRadioUniflexFormat_CheckedChanged);
            // 
            // rdoRadioControllerFd2
            // 
            this.rdoRadioControllerFd2.Location = new System.Drawing.Point(10, 21);
            this.rdoRadioControllerFd2.Name = "rdoRadioControllerFd2";
            this.rdoRadioControllerFd2.Size = new System.Drawing.Size(50, 17);
            this.rdoRadioControllerFd2.TabIndex = 5;
            this.rdoRadioControllerFd2.TabStop = true;
            this.rdoRadioControllerFd2.Text = "FD2";
            // 
            // rdoRadioControllerDmaf2
            // 
            this.rdoRadioControllerDmaf2.Location = new System.Drawing.Point(70, 21);
            this.rdoRadioControllerDmaf2.Name = "rdoRadioControllerDmaf2";
            this.rdoRadioControllerDmaf2.Size = new System.Drawing.Size(66, 17);
            this.rdoRadioControllerDmaf2.TabIndex = 6;
            this.rdoRadioControllerDmaf2.TabStop = true;
            this.rdoRadioControllerDmaf2.Text = "DMAF2";
            // 
            // chkCheckIncludeBootSector
            // 
            this.chkCheckIncludeBootSector.Location = new System.Drawing.Point(18, 133);
            this.chkCheckIncludeBootSector.Name = "chkCheckIncludeBootSector";
            this.chkCheckIncludeBootSector.Size = new System.Drawing.Size(124, 17);
            this.chkCheckIncludeBootSector.TabIndex = 7;
            this.chkCheckIncludeBootSector.Text = "Include Boot Sector";
            // 
            // rdoRadio35Track
            // 
            this.rdoRadio35Track.Location = new System.Drawing.Point(10, 16);
            this.rdoRadio35Track.Name = "rdoRadio35Track";
            this.rdoRadio35Track.Size = new System.Drawing.Size(74, 17);
            this.rdoRadio35Track.TabIndex = 8;
            this.rdoRadio35Track.TabStop = true;
            this.rdoRadio35Track.Text = "35 Track";
            this.rdoRadio35Track.CheckedChanged += new System.EventHandler(this.rdoRadio35Track_CheckedChanged);
            // 
            // rdoRadio40Track
            // 
            this.rdoRadio40Track.Location = new System.Drawing.Point(10, 35);
            this.rdoRadio40Track.Name = "rdoRadio40Track";
            this.rdoRadio40Track.Size = new System.Drawing.Size(74, 17);
            this.rdoRadio40Track.TabIndex = 9;
            this.rdoRadio40Track.Text = "40 Track";
            this.rdoRadio40Track.CheckedChanged += new System.EventHandler(this.rdoRadio40Track_CheckedChanged);
            // 
            // rdoRadio80Track
            // 
            this.rdoRadio80Track.Location = new System.Drawing.Point(10, 56);
            this.rdoRadio80Track.Name = "rdoRadio80Track";
            this.rdoRadio80Track.Size = new System.Drawing.Size(74, 17);
            this.rdoRadio80Track.TabIndex = 10;
            this.rdoRadio80Track.Text = "80 Track";
            this.rdoRadio80Track.CheckedChanged += new System.EventHandler(this.rdoRadio80Track_CheckedChanged);
            // 
            // rdoRadioUserDefined
            // 
            this.rdoRadioUserDefined.Location = new System.Drawing.Point(10, 77);
            this.rdoRadioUserDefined.Name = "rdoRadioUserDefined";
            this.rdoRadioUserDefined.Size = new System.Drawing.Size(92, 17);
            this.rdoRadioUserDefined.TabIndex = 11;
            this.rdoRadioUserDefined.Text = "User Defined";
            this.rdoRadioUserDefined.CheckedChanged += new System.EventHandler(this.rdoRadioUserDefined_CheckedChanged);
            this.rdoRadioUserDefined.MouseHover += new System.EventHandler(this.rdoRadioUserDefined_MouseHover);
            // 
            // rdoRadioSingleDensity
            // 
            this.rdoRadioSingleDensity.Location = new System.Drawing.Point(8, 18);
            this.rdoRadioSingleDensity.Name = "rdoRadioSingleDensity";
            this.rdoRadioSingleDensity.Size = new System.Drawing.Size(98, 17);
            this.rdoRadioSingleDensity.TabIndex = 12;
            this.rdoRadioSingleDensity.TabStop = true;
            this.rdoRadioSingleDensity.Text = "Single Density";
            this.rdoRadioSingleDensity.CheckedChanged += new System.EventHandler(this.rdoRadioSingleDensity_CheckedChanged);
            // 
            // rdoRadioDoubleDensity
            // 
            this.rdoRadioDoubleDensity.Location = new System.Drawing.Point(8, 37);
            this.rdoRadioDoubleDensity.Name = "rdoRadioDoubleDensity";
            this.rdoRadioDoubleDensity.Size = new System.Drawing.Size(102, 17);
            this.rdoRadioDoubleDensity.TabIndex = 13;
            this.rdoRadioDoubleDensity.Text = "Double Density";
            this.rdoRadioDoubleDensity.CheckedChanged += new System.EventHandler(this.rdoRadioDoubleDensity_CheckedChanged);
            // 
            // rdoRadioQuadDensity
            // 
            this.rdoRadioQuadDensity.Location = new System.Drawing.Point(8, 56);
            this.rdoRadioQuadDensity.Name = "rdoRadioQuadDensity";
            this.rdoRadioQuadDensity.Size = new System.Drawing.Size(94, 17);
            this.rdoRadioQuadDensity.TabIndex = 14;
            this.rdoRadioQuadDensity.Text = "Quad Density";
            this.rdoRadioQuadDensity.CheckedChanged += new System.EventHandler(this.rdoRadioQuadDensity_CheckedChanged);
            // 
            // chkCheckDoubleSided
            // 
            this.chkCheckDoubleSided.Location = new System.Drawing.Point(142, 235);
            this.chkCheckDoubleSided.Name = "chkCheckDoubleSided";
            this.chkCheckDoubleSided.Size = new System.Drawing.Size(94, 17);
            this.chkCheckDoubleSided.TabIndex = 15;
            this.chkCheckDoubleSided.Text = "Double Sided";
            this.chkCheckDoubleSided.CheckedChanged += new System.EventHandler(this.chkCheckDoubleSided_CheckedChanged);
            this.chkCheckDoubleSided.MouseHover += new System.EventHandler(this.chkCheckDoubleSided_MouseHover);
            // 
            // txtEditTracks
            // 
            this.txtEditTracks.Location = new System.Drawing.Point(87, 272);
            this.txtEditTracks.Name = "txtEditTracks";
            this.txtEditTracks.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtEditTracks.Size = new System.Drawing.Size(34, 20);
            this.txtEditTracks.TabIndex = 16;
            // 
            // txtEditSectors
            // 
            this.txtEditSectors.Location = new System.Drawing.Point(183, 272);
            this.txtEditSectors.Name = "txtEditSectors";
            this.txtEditSectors.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtEditSectors.Size = new System.Drawing.Size(34, 20);
            this.txtEditSectors.TabIndex = 17;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Location = new System.Drawing.Point(51, 336);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 24);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "&Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(140, 335);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 24);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpStatic1
            // 
            this.grpStatic1.Controls.Add(this.rdoRadio35Track);
            this.grpStatic1.Controls.Add(this.rdoRadio40Track);
            this.grpStatic1.Controls.Add(this.rdoRadio80Track);
            this.grpStatic1.Controls.Add(this.rdoRadioUserDefined);
            this.grpStatic1.Location = new System.Drawing.Point(10, 147);
            this.grpStatic1.Name = "grpStatic1";
            this.grpStatic1.Size = new System.Drawing.Size(117, 112);
            this.grpStatic1.TabIndex = 20;
            this.grpStatic1.TabStop = false;
            // 
            // grpStatic2
            // 
            this.grpStatic2.Controls.Add(this.rdoRadioDoubleDensity);
            this.grpStatic2.Controls.Add(this.rdoRadioQuadDensity);
            this.grpStatic2.Controls.Add(this.rdoRadioSingleDensity);
            this.grpStatic2.Location = new System.Drawing.Point(134, 147);
            this.grpStatic2.Name = "grpStatic2";
            this.grpStatic2.Size = new System.Drawing.Size(112, 86);
            this.grpStatic2.TabIndex = 21;
            this.grpStatic2.TabStop = false;
            // 
            // lblStatic3
            // 
            this.lblStatic3.AutoSize = true;
            this.lblStatic3.Location = new System.Drawing.Point(42, 275);
            this.lblStatic3.Name = "lblStatic3";
            this.lblStatic3.Size = new System.Drawing.Size(40, 13);
            this.lblStatic3.TabIndex = 22;
            this.lblStatic3.Text = "Tracks";
            // 
            // lblStatic4
            // 
            this.lblStatic4.AutoSize = true;
            this.lblStatic4.Location = new System.Drawing.Point(138, 275);
            this.lblStatic4.Name = "lblStatic4";
            this.lblStatic4.Size = new System.Drawing.Size(43, 13);
            this.lblStatic4.TabIndex = 23;
            this.lblStatic4.Text = "Sectors";
            // 
            // lblStatic5
            // 
            this.lblStatic5.AutoSize = true;
            this.lblStatic5.Location = new System.Drawing.Point(18, 18);
            this.lblStatic5.Name = "lblStatic5";
            this.lblStatic5.Size = new System.Drawing.Size(73, 13);
            this.lblStatic5.TabIndex = 24;
            this.lblStatic5.Text = "Volume Name";
            // 
            // grpStatic6
            // 
            this.grpStatic6.Controls.Add(this.rdoRadioFlexFormat);
            this.grpStatic6.Controls.Add(this.rdoRadioOs9Format);
            this.grpStatic6.Controls.Add(this.rdoRadioUniflexFormat);
            this.grpStatic6.Location = new System.Drawing.Point(10, 34);
            this.grpStatic6.Name = "grpStatic6";
            this.grpStatic6.Size = new System.Drawing.Size(243, 49);
            this.grpStatic6.TabIndex = 25;
            this.grpStatic6.TabStop = false;
            this.grpStatic6.Text = "OS Format";
            // 
            // grpStatic7
            // 
            this.grpStatic7.Controls.Add(this.rdoRadioControllerDmaf2);
            this.grpStatic7.Controls.Add(this.rdoRadioControllerFd2);
            this.grpStatic7.Location = new System.Drawing.Point(10, 83);
            this.grpStatic7.Name = "grpStatic7";
            this.grpStatic7.Size = new System.Drawing.Size(243, 47);
            this.grpStatic7.TabIndex = 26;
            this.grpStatic7.TabStop = false;
            this.grpStatic7.Text = "FLEX Controller Boot Image";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // labelSectorsTrackZero
            // 
            this.labelSectorsTrackZero.AutoSize = true;
            this.labelSectorsTrackZero.Location = new System.Drawing.Point(5, 304);
            this.labelSectorsTrackZero.Name = "labelSectorsTrackZero";
            this.labelSectorsTrackZero.Size = new System.Drawing.Size(169, 13);
            this.labelSectorsTrackZero.TabIndex = 27;
            this.labelSectorsTrackZero.Text = "Number of Sectors on Track  Zero";
            this.labelSectorsTrackZero.MouseHover += new System.EventHandler(this.labelSectorsTrackZero_MouseHover);
            // 
            // txtEditSectors0
            // 
            this.txtEditSectors0.Location = new System.Drawing.Point(181, 300);
            this.txtEditSectors0.Name = "txtEditSectors0";
            this.txtEditSectors0.Size = new System.Drawing.Size(36, 20);
            this.txtEditSectors0.TabIndex = 28;
            // 
            // checkBoxGoTekCompatible
            // 
            this.checkBoxGoTekCompatible.AutoSize = true;
            this.checkBoxGoTekCompatible.Location = new System.Drawing.Point(31, 320);
            this.checkBoxGoTekCompatible.Name = "checkBoxGoTekCompatible";
            this.checkBoxGoTekCompatible.Size = new System.Drawing.Size(176, 17);
            this.checkBoxGoTekCompatible.TabIndex = 29;
            this.checkBoxGoTekCompatible.Text = "Make Image GoTek Compatible";
            this.checkBoxGoTekCompatible.UseVisualStyleBackColor = true;
            this.checkBoxGoTekCompatible.Visible = false;
            // 
            // frmDialogDiskParameters
            // 
            this.AcceptButton = this.btnStart;
            this.ClientSize = new System.Drawing.Size(272, 379);
            this.Controls.Add(this.checkBoxGoTekCompatible);
            this.Controls.Add(this.txtEditSectors0);
            this.Controls.Add(this.labelSectorsTrackZero);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkCheckDoubleSided);
            this.Controls.Add(this.chkCheckIncludeBootSector);
            this.Controls.Add(this.lblStatic3);
            this.Controls.Add(this.lblStatic4);
            this.Controls.Add(this.lblStatic5);
            this.Controls.Add(this.txtEditSectors);
            this.Controls.Add(this.txtEditTracks);
            this.Controls.Add(this.txtEditVolumeName);
            this.Controls.Add(this.grpStatic1);
            this.Controls.Add(this.grpStatic2);
            this.Controls.Add(this.grpStatic6);
            this.Controls.Add(this.grpStatic7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDialogDiskParameters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Format Virtual Floppy Diskette";
            this.Load += new System.EventHandler(this.frmDialogDiskParameters_Load);
            this.grpStatic1.ResumeLayout(false);
            this.grpStatic2.ResumeLayout(false);
            this.grpStatic6.ResumeLayout(false);
            this.grpStatic7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
		#endregion

        private BackgroundWorker backgroundWorker1;
        private Label labelSectorsTrackZero;
        private TextBox txtEditSectors0;
        private CheckBox checkBoxGoTekCompatible;
    }
}

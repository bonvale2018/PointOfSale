using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using DpSdkEngLib;
using DPSDKOPSLib;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
namespace _4PosBackOffice.NET
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class frmReportGroupList
	{
		#region "Windows Form Designer generated code "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmReportGroupList() : base()
		{
			FormClosed += frmReportGroupList_FormClosed;
			Load += frmReportGroupList_Load;
			KeyPress += frmReportGroupList_KeyPress;
			KeyDown += frmReportGroupList_KeyDown;
			//This call is required by the Windows Form Designer.
			InitializeComponent();
		}
//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool Disposing)
		{
			if (Disposing) {
				if ((components != null)) {
					components.Dispose();
				}
			}
			base.Dispose(Disposing);
		}
//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTip1;
		private System.Windows.Forms.Button withEventsField_cmdExit;
		public System.Windows.Forms.Button cmdExit {
			get { return withEventsField_cmdExit; }
			set {
				if (withEventsField_cmdExit != null) {
					withEventsField_cmdExit.Click -= cmdExit_Click;
				}
				withEventsField_cmdExit = value;
				if (withEventsField_cmdExit != null) {
					withEventsField_cmdExit.Click += cmdExit_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_txtSearch;
		public System.Windows.Forms.TextBox txtSearch {
			get { return withEventsField_txtSearch; }
			set {
				if (withEventsField_txtSearch != null) {
					withEventsField_txtSearch.Enter -= txtSearch_Enter;
					withEventsField_txtSearch.KeyDown -= txtSearch_KeyDown;
					withEventsField_txtSearch.KeyPress -= txtSearch_KeyPress;
				}
				withEventsField_txtSearch = value;
				if (withEventsField_txtSearch != null) {
					withEventsField_txtSearch.Enter += txtSearch_Enter;
					withEventsField_txtSearch.KeyDown += txtSearch_KeyDown;
					withEventsField_txtSearch.KeyPress += txtSearch_KeyPress;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_cmdNew;
		public System.Windows.Forms.Button cmdNew {
			get { return withEventsField_cmdNew; }
			set {
				if (withEventsField_cmdNew != null) {
					withEventsField_cmdNew.Click -= cmdNew_Click;
				}
				withEventsField_cmdNew = value;
				if (withEventsField_cmdNew != null) {
					withEventsField_cmdNew.Click += cmdNew_Click;
				}
			}
		}
		private myDataGridView withEventsField_DataList1;
		public myDataGridView DataList1 {
			get { return withEventsField_DataList1; }
			set {
				if (withEventsField_DataList1 != null) {
					withEventsField_DataList1.DoubleClick -= DataList1_DblClick;
					withEventsField_DataList1.KeyPress -= DataList1_KeyPress;
					withEventsField_DataList1.MouseDown -= DataList1_MouseDown;
				}
				withEventsField_DataList1 = value;
				if (withEventsField_DataList1 != null) {
					withEventsField_DataList1.DoubleClick += DataList1_DblClick;
					withEventsField_DataList1.KeyPress += DataList1_KeyPress;
					withEventsField_DataList1.MouseDown += DataList1_MouseDown;
				}
			}
		}
		public System.Windows.Forms.Label lbl;
//NOTE: The following procedure is required by the Windows Form Designer
//It can be modified using the Windows Form Designer.
//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmReportGroupList));
			this.components = new System.ComponentModel.Container();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(components);
			this.cmdExit = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.cmdNew = new System.Windows.Forms.Button();
			this.DataList1 = new myDataGridView();
			this.lbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.ToolTip1.Active = true;
			((System.ComponentModel.ISupportInitialize)this.DataList1).BeginInit();
			this.Text = "Select a Report Group";
			this.ClientSize = new System.Drawing.Size(256, 442);
			this.Location = new System.Drawing.Point(4, 23);
			this.ControlBox = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
			this.Enabled = true;
			this.KeyPreview = false;
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = true;
			this.HelpButton = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Name = "frmReportGroupList";
			this.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cmdExit.Text = "E&xit";
			this.cmdExit.Size = new System.Drawing.Size(97, 52);
			this.cmdExit.Location = new System.Drawing.Point(153, 384);
			this.cmdExit.TabIndex = 3;
			this.cmdExit.TabStop = false;
			this.cmdExit.BackColor = System.Drawing.SystemColors.Control;
			this.cmdExit.CausesValidation = true;
			this.cmdExit.Enabled = true;
			this.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdExit.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdExit.Name = "cmdExit";
			this.txtSearch.AutoSize = false;
			this.txtSearch.Size = new System.Drawing.Size(199, 19);
			this.txtSearch.Location = new System.Drawing.Point(51, 12);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.AcceptsReturn = true;
			this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
			this.txtSearch.CausesValidation = true;
			this.txtSearch.Enabled = true;
			this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSearch.HideSelection = true;
			this.txtSearch.ReadOnly = false;
			this.txtSearch.MaxLength = 0;
			this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSearch.Multiline = false;
			this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtSearch.TabStop = true;
			this.txtSearch.Visible = true;
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSearch.Name = "txtSearch";
			this.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cmdNew.Text = "&New";
			this.cmdNew.Size = new System.Drawing.Size(97, 52);
			this.cmdNew.Location = new System.Drawing.Point(6, 384);
			this.cmdNew.TabIndex = 0;
			this.cmdNew.TabStop = false;
			this.cmdNew.BackColor = System.Drawing.SystemColors.Control;
			this.cmdNew.CausesValidation = true;
			this.cmdNew.Enabled = true;
			this.cmdNew.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdNew.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdNew.Name = "cmdNew";
			//DataList1.OcxState = CType(resources.GetObject("'DataList1.OcxState"), System.Windows.Forms.AxHost.State)
			this.DataList1.Size = new System.Drawing.Size(244, 342);
			this.DataList1.Location = new System.Drawing.Point(8, 36);
			this.DataList1.TabIndex = 2;
			this.DataList1.Name = "DataList1";
			this.lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lbl.Text = "&Search :";
			this.lbl.Size = new System.Drawing.Size(40, 13);
			this.lbl.Location = new System.Drawing.Point(8, 15);
			this.lbl.TabIndex = 4;
			this.lbl.BackColor = System.Drawing.Color.Transparent;
			this.lbl.Enabled = true;
			this.lbl.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl.UseMnemonic = true;
			this.lbl.Visible = true;
			this.lbl.AutoSize = true;
			this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbl.Name = "lbl";
			this.Controls.Add(cmdExit);
			this.Controls.Add(txtSearch);
			this.Controls.Add(cmdNew);
			this.Controls.Add(DataList1);
			this.Controls.Add(lbl);
			((System.ComponentModel.ISupportInitialize)this.DataList1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		#endregion
	}
}
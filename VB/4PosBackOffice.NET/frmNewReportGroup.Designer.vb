<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmNewReportGroup
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents _txtFields_0 As System.Windows.Forms.TextBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents picButtons As System.Windows.Forms.Panel
	Public WithEvents _chkFields_0 As System.Windows.Forms.CheckBox
	Public WithEvents _lblLabels_38 As System.Windows.Forms.Label
	Public WithEvents _lbl_5 As System.Windows.Forms.Label
	Public WithEvents _Shape1_2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    'Public WithEvents chkFields As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
    'Public WithEvents lbl As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'Public WithEvents lblLabels As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'Public WithEvents txtFields As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents Shape1 As RectangleShapeArray
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmNewReportGroup))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me._txtFields_0 = New System.Windows.Forms.TextBox
		Me.picButtons = New System.Windows.Forms.Panel
		Me.cmdClose = New System.Windows.Forms.Button
		Me.cmdCancel = New System.Windows.Forms.Button
		Me._chkFields_0 = New System.Windows.Forms.CheckBox
		Me._lblLabels_38 = New System.Windows.Forms.Label
		Me._lbl_5 = New System.Windows.Forms.Label
		Me._Shape1_2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        'Me.chkFields = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
        'Me.lbl = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
        'Me.lblLabels = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
        'Me.txtFields = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.Shape1 = New RectangleShapeArray(components)
		Me.picButtons.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
        'CType(Me.chkFields, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.lbl, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.txtFields, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Maintain Report Group"
		Me.ClientSize = New System.Drawing.Size(424, 120)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ControlBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmNewReportGroup"
		Me._txtFields_0.AutoSize = False
		Me._txtFields_0.Size = New System.Drawing.Size(277, 17)
		Me._txtFields_0.Location = New System.Drawing.Point(122, 72)
		Me._txtFields_0.TabIndex = 0
		Me._txtFields_0.AcceptsReturn = True
		Me._txtFields_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFields_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtFields_0.CausesValidation = True
		Me._txtFields_0.Enabled = True
		Me._txtFields_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFields_0.HideSelection = True
		Me._txtFields_0.ReadOnly = False
		Me._txtFields_0.Maxlength = 0
		Me._txtFields_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFields_0.MultiLine = False
		Me._txtFields_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFields_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFields_0.TabStop = True
		Me._txtFields_0.Visible = True
		Me._txtFields_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._txtFields_0.Name = "_txtFields_0"
		Me.picButtons.Dock = System.Windows.Forms.DockStyle.Top
		Me.picButtons.BackColor = System.Drawing.Color.Blue
		Me.picButtons.Size = New System.Drawing.Size(424, 39)
		Me.picButtons.Location = New System.Drawing.Point(0, 0)
		Me.picButtons.TabIndex = 6
		Me.picButtons.TabStop = False
		Me.picButtons.CausesValidation = True
		Me.picButtons.Enabled = True
		Me.picButtons.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picButtons.Cursor = System.Windows.Forms.Cursors.Default
		Me.picButtons.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picButtons.Visible = True
		Me.picButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picButtons.Name = "picButtons"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "E&xit"
		Me.cmdClose.Size = New System.Drawing.Size(81, 25)
		Me.cmdClose.Location = New System.Drawing.Point(338, 4)
		Me.cmdClose.TabIndex = 1
		Me.cmdClose.TabStop = False
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.Name = "cmdClose"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "&Undo"
		Me.cmdCancel.Size = New System.Drawing.Size(81, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(5, 4)
		Me.cmdCancel.TabIndex = 2
		Me.cmdCancel.TabStop = False
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.Name = "cmdCancel"
		Me._chkFields_0.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me._chkFields_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me._chkFields_0.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me._chkFields_0.Text = "Disable This Report Group"
		Me._chkFields_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._chkFields_0.Size = New System.Drawing.Size(157, 19)
		Me._chkFields_0.Location = New System.Drawing.Point(242, 88)
		Me._chkFields_0.TabIndex = 4
		Me._chkFields_0.CausesValidation = True
		Me._chkFields_0.Enabled = True
		Me._chkFields_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFields_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFields_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFields_0.TabStop = True
		Me._chkFields_0.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFields_0.Visible = True
		Me._chkFields_0.Name = "_chkFields_0"
		Me._lblLabels_38.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._lblLabels_38.Text = "Report Group Name:"
		Me._lblLabels_38.Size = New System.Drawing.Size(98, 13)
		Me._lblLabels_38.Location = New System.Drawing.Point(18, 74)
		Me._lblLabels_38.TabIndex = 5
		Me._lblLabels_38.BackColor = System.Drawing.Color.Transparent
		Me._lblLabels_38.Enabled = True
		Me._lblLabels_38.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_38.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_38.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_38.UseMnemonic = True
		Me._lblLabels_38.Visible = True
		Me._lblLabels_38.AutoSize = True
		Me._lblLabels_38.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_38.Name = "_lblLabels_38"
		Me._lbl_5.BackColor = System.Drawing.Color.Transparent
		Me._lbl_5.Text = "&1. General"
		Me._lbl_5.Size = New System.Drawing.Size(60, 13)
		Me._lbl_5.Location = New System.Drawing.Point(4, 46)
		Me._lbl_5.TabIndex = 3
		Me._lbl_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_5.Enabled = True
		Me._lbl_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_5.UseMnemonic = True
		Me._lbl_5.Visible = True
		Me._lbl_5.AutoSize = True
		Me._lbl_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_5.Name = "_lbl_5"
		Me._Shape1_2.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me._Shape1_2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
		Me._Shape1_2.Size = New System.Drawing.Size(416, 49)
		Me._Shape1_2.Location = New System.Drawing.Point(4, 62)
		Me._Shape1_2.BorderColor = System.Drawing.SystemColors.WindowText
		Me._Shape1_2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._Shape1_2.BorderWidth = 1
		Me._Shape1_2.FillColor = System.Drawing.Color.Black
		Me._Shape1_2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me._Shape1_2.Visible = True
		Me._Shape1_2.Name = "_Shape1_2"
		Me.Controls.Add(_txtFields_0)
		Me.Controls.Add(picButtons)
		Me.Controls.Add(_chkFields_0)
		Me.Controls.Add(_lblLabels_38)
		Me.Controls.Add(_lbl_5)
		Me.ShapeContainer1.Shapes.Add(_Shape1_2)
		Me.Controls.Add(ShapeContainer1)
		Me.picButtons.Controls.Add(cmdClose)
		Me.picButtons.Controls.Add(cmdCancel)
        'Me.chkFields.SetIndex(_chkFields_0, CType(0, Short))
        'Me.lbl.SetIndex(_lbl_5, CType(5, Short))
        'Me.lblLabels.SetIndex(_lblLabels_38, CType(38, Short))
        'Me.txtFields.SetIndex(_txtFields_0, CType(0, Short))
		Me.Shape1.SetIndex(_Shape1_2, CType(2, Short))
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.txtFields, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.lbl, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.chkFields, System.ComponentModel.ISupportInitialize).EndInit()
		Me.picButtons.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class
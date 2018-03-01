<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblUnitsTitle = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblAverageDisplay = New System.Windows.Forms.Label()
        Me.tbUnits = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbDisplay = New System.Windows.Forms.TextBox()
        Me.averageUnitsShippedToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblUnitsTitle
        '
        Me.lblUnitsTitle.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblUnitsTitle.Location = New System.Drawing.Point(56, 28)
        Me.lblUnitsTitle.Name = "lblUnitsTitle"
        Me.lblUnitsTitle.Size = New System.Drawing.Size(31, 13)
        Me.lblUnitsTitle.TabIndex = 0
        Me.lblUnitsTitle.Text = "&Units"
        '
        'lblDay
        '
        Me.lblDay.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblDay.Location = New System.Drawing.Point(207, 28)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(36, 13)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "Day #"
        '
        'lblAverageDisplay
        '
        Me.lblAverageDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblAverageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverageDisplay.Location = New System.Drawing.Point(50, 190)
        Me.lblAverageDisplay.Name = "lblAverageDisplay"
        Me.lblAverageDisplay.Size = New System.Drawing.Size(196, 24)
        Me.lblAverageDisplay.TabIndex = 4
        Me.lblAverageDisplay.Text = "Average per day"
        Me.averageUnitsShippedToolTips.SetToolTip(Me.lblAverageDisplay, "Displays")
        '
        'tbUnits
        '
        Me.tbUnits.Location = New System.Drawing.Point(101, 28)
        Me.tbUnits.Name = "tbUnits"
        Me.tbUnits.Size = New System.Drawing.Size(100, 20)
        Me.tbUnits.TabIndex = 1
        Me.averageUnitsShippedToolTips.SetToolTip(Me.tbUnits, "User will enter in units shipped for current day")
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEnter.Location = New System.Drawing.Point(13, 226)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Tag = ""
        Me.btnEnter.Text = "&Enter"
        Me.averageUnitsShippedToolTips.SetToolTip(Me.btnEnter, "User will press enter button to enter in units per day")
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnReset.Location = New System.Drawing.Point(101, 226)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.averageUnitsShippedToolTips.SetToolTip(Me.btnReset, "User clicks reset to reset application")
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExit.Location = New System.Drawing.Point(197, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.averageUnitsShippedToolTips.SetToolTip(Me.btnExit, "Exit button closes the current application")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'tbDisplay
        '
        Me.tbDisplay.Enabled = False
        Me.tbDisplay.Location = New System.Drawing.Point(59, 54)
        Me.tbDisplay.Multiline = True
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.Size = New System.Drawing.Size(184, 133)
        Me.tbDisplay.TabIndex = 3
        Me.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.averageUnitsShippedToolTips.SetToolTip(Me.tbDisplay, "Outputs data to user ")
        Me.tbDisplay.WordWrap = False
        '
        'frmLab1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.tbDisplay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.tbUnits)
        Me.Controls.Add(Me.lblAverageDisplay)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblUnitsTitle)
        Me.Name = "frmLab1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnitsTitle As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblAverageDisplay As Label
    Friend WithEvents tbUnits As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbDisplay As TextBox
    Friend WithEvents averageUnitsShippedToolTips As ToolTip
End Class

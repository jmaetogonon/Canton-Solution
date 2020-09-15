<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblAsset = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lblSalValue = New System.Windows.Forms.Label()
        Me.txtSalvage = New System.Windows.Forms.TextBox()
        Me.lblUse = New System.Windows.Forms.Label()
        Me.lstLife = New System.Windows.Forms.ListBox()
        Me.grpScheds = New System.Windows.Forms.GroupBox()
        Me.lstDDB = New System.Windows.Forms.ListBox()
        Me.lstSYD = New System.Windows.Forms.ListBox()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpScheds.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAsset
        '
        Me.lblAsset.AutoSize = True
        Me.lblAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsset.Location = New System.Drawing.Point(131, 42)
        Me.lblAsset.Name = "lblAsset"
        Me.lblAsset.Size = New System.Drawing.Size(64, 15)
        Me.lblAsset.TabIndex = 0
        Me.lblAsset.Text = "Asset cost:"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(134, 68)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(83, 20)
        Me.txtCost.TabIndex = 1
        '
        'lblSalValue
        '
        Me.lblSalValue.AutoSize = True
        Me.lblSalValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalValue.Location = New System.Drawing.Point(220, 42)
        Me.lblSalValue.Name = "lblSalValue"
        Me.lblSalValue.Size = New System.Drawing.Size(86, 15)
        Me.lblSalValue.TabIndex = 2
        Me.lblSalValue.Text = "Salvage value:"
        '
        'txtSalvage
        '
        Me.txtSalvage.Location = New System.Drawing.Point(223, 68)
        Me.txtSalvage.Name = "txtSalvage"
        Me.txtSalvage.Size = New System.Drawing.Size(83, 20)
        Me.txtSalvage.TabIndex = 3
        '
        'lblUse
        '
        Me.lblUse.AutoSize = True
        Me.lblUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUse.Location = New System.Drawing.Point(312, 42)
        Me.lblUse.Name = "lblUse"
        Me.lblUse.Size = New System.Drawing.Size(64, 15)
        Me.lblUse.TabIndex = 4
        Me.lblUse.Text = "Useful life:"
        '
        'lstLife
        '
        Me.lstLife.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLife.FormattingEnabled = True
        Me.lstLife.ItemHeight = 16
        Me.lstLife.Location = New System.Drawing.Point(312, 68)
        Me.lstLife.Name = "lstLife"
        Me.lstLife.Size = New System.Drawing.Size(83, 68)
        Me.lstLife.TabIndex = 5
        '
        'grpScheds
        '
        Me.grpScheds.Controls.Add(Me.lstDDB)
        Me.grpScheds.Controls.Add(Me.lstSYD)
        Me.grpScheds.Controls.Add(Me.lblS)
        Me.grpScheds.Controls.Add(Me.lblD)
        Me.grpScheds.Location = New System.Drawing.Point(45, 245)
        Me.grpScheds.Name = "grpScheds"
        Me.grpScheds.Size = New System.Drawing.Size(425, 244)
        Me.grpScheds.TabIndex = 8
        Me.grpScheds.TabStop = False
        Me.grpScheds.Text = "Depreciation schedules"
        '
        'lstDDB
        '
        Me.lstDDB.FormattingEnabled = True
        Me.lstDDB.Location = New System.Drawing.Point(32, 75)
        Me.lstDDB.Name = "lstDDB"
        Me.lstDDB.Size = New System.Drawing.Size(165, 134)
        Me.lstDDB.TabIndex = 10
        '
        'lstSYD
        '
        Me.lstSYD.FormattingEnabled = True
        Me.lstSYD.Location = New System.Drawing.Point(227, 75)
        Me.lstSYD.Name = "lstSYD"
        Me.lstSYD.Size = New System.Drawing.Size(165, 134)
        Me.lstSYD.TabIndex = 12
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.Location = New System.Drawing.Point(224, 41)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(139, 15)
        Me.lblS.TabIndex = 11
        Me.lblS.Text = "Sum-of-the-years' digits:"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(29, 41)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(151, 15)
        Me.lblD.TabIndex = 9
        Me.lblD.Text = "Double-declining balance:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(134, 167)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(182, 35)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Display Depreciation Schedule"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(320, 167)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 529)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpScheds)
        Me.Controls.Add(Me.lstLife)
        Me.Controls.Add(Me.txtSalvage)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lblUse)
        Me.Controls.Add(Me.lblSalValue)
        Me.Controls.Add(Me.lblAsset)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                    Canton Manufacturing Company"
        Me.grpScheds.ResumeLayout(False)
        Me.grpScheds.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAsset As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents lblSalValue As Label
    Friend WithEvents txtSalvage As TextBox
    Friend WithEvents lblUse As Label
    Friend WithEvents lstLife As ListBox
    Friend WithEvents grpScheds As GroupBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblD As Label
    Friend WithEvents lblS As Label
    Friend WithEvents lstSYD As ListBox
    Friend WithEvents lstDDB As ListBox
End Class

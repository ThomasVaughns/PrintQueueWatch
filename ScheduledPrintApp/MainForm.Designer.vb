<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lstQueue = New System.Windows.Forms.ListBox()
        Me.btnChoosePrinter = New System.Windows.Forms.Button()
        Me.btnTestPrint = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.dtpSchedule = New System.Windows.Forms.DateTimePicker()
        Me.lblPrinter = New System.Windows.Forms.Label()
        Me.timerSchedule = New System.Windows.Forms.Timer(Me.components)
        Me.btnRescan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstQueue
        '
        Me.lstQueue.FormattingEnabled = True
        Me.lstQueue.Location = New System.Drawing.Point(12, 12)
        Me.lstQueue.Name = "lstQueue"
        Me.lstQueue.Size = New System.Drawing.Size(360, 199)
        Me.lstQueue.TabIndex = 0
        '
        'btnChoosePrinter
        '
        Me.btnChoosePrinter.Location = New System.Drawing.Point(378, 12)
        Me.btnChoosePrinter.Name = "btnChoosePrinter"
        Me.btnChoosePrinter.Size = New System.Drawing.Size(120, 23)
        Me.btnChoosePrinter.TabIndex = 1
        Me.btnChoosePrinter.Text = "Choose Printer"
        Me.btnChoosePrinter.UseVisualStyleBackColor = True
        '
        'btnTestPrint
        '
        Me.btnTestPrint.Location = New System.Drawing.Point(378, 41)
        Me.btnTestPrint.Name = "btnTestPrint"
        Me.btnTestPrint.Size = New System.Drawing.Size(120, 23)
        Me.btnTestPrint.TabIndex = 2
        Me.btnTestPrint.Text = "Test Print"
        Me.btnTestPrint.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(378, 99)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(120, 23)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'dtpSchedule
        '
        Me.dtpSchedule.CustomFormat = "MM/dd/yyyy HH:mm"
        Me.dtpSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSchedule.Location = New System.Drawing.Point(378, 70)
        Me.dtpSchedule.Name = "dtpSchedule"
        Me.dtpSchedule.Size = New System.Drawing.Size(200, 20)
        Me.dtpSchedule.TabIndex = 3
        '
        'lblPrinter
        '
        Me.lblPrinter.AutoSize = True
        Me.lblPrinter.Location = New System.Drawing.Point(375, 136)
        Me.lblPrinter.Name = "lblPrinter"
        Me.lblPrinter.Size = New System.Drawing.Size(39, 13)
        Me.lblPrinter.TabIndex = 5
        Me.lblPrinter.Text = "Printer"
        '
        'timerSchedule
        '
        Me.timerSchedule.Interval = 1000
        '
        'btnRescan
        '
        Me.btnRescan.Location = New System.Drawing.Point(378, 165)
        Me.btnRescan.Name = "btnRescan"
        Me.btnRescan.Size = New System.Drawing.Size(120, 23)
        Me.btnRescan.TabIndex = 6
        Me.btnRescan.Text = "Refresh Queue"
        Me.btnRescan.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 227)
        Me.Controls.Add(Me.btnRescan)
        Me.Controls.Add(Me.lblPrinter)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.dtpSchedule)
        Me.Controls.Add(Me.btnTestPrint)
        Me.Controls.Add(Me.btnChoosePrinter)
        Me.Controls.Add(Me.lstQueue)
        Me.Name = "MainForm"
        Me.Text = "Scheduled Print App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstQueue As System.Windows.Forms.ListBox
    Friend WithEvents btnChoosePrinter As System.Windows.Forms.Button
    Friend WithEvents btnTestPrint As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents dtpSchedule As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPrinter As System.Windows.Forms.Label
    Friend WithEvents timerSchedule As System.Windows.Forms.Timer
    Friend WithEvents btnRescan As System.Windows.Forms.Button
End Class

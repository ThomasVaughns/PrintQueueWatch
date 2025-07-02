Imports System.IO
Imports System.Diagnostics
Imports System.Media

Public Class MainForm

    Private queuePath As String
    Private printedPath As String
    Private selectedPrinter As String

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        queuePath = Path.Combine(Application.StartupPath, "Queue")
        printedPath = Path.Combine(Application.StartupPath, "Printed")
        Directory.CreateDirectory(queuePath)
        Directory.CreateDirectory(printedPath)
        LoadQueue()
        selectedPrinter = My.Settings.PrinterName
        If Not String.IsNullOrEmpty(selectedPrinter) Then
            lblPrinter.Text = selectedPrinter
        End If
    End Sub

    Private Sub LoadQueue()
        lstQueue.Items.Clear()
        For Each f In Directory.GetFiles(queuePath, "*.pdf")
            lstQueue.Items.Add(Path.GetFileName(f))
        Next
    End Sub

    Private Sub btnRescan_Click(sender As Object, e As EventArgs) Handles btnRescan.Click
        LoadQueue()
    End Sub

    Private Sub btnChoosePrinter_Click(sender As Object, e As EventArgs) Handles btnChoosePrinter.Click
        Using dlg As New PrintDialog()
            dlg.PrinterSettings = New Printing.PrinterSettings()
            If dlg.ShowDialog() = DialogResult.OK Then
                selectedPrinter = dlg.PrinterSettings.PrinterName
                My.Settings.PrinterName = selectedPrinter
                My.Settings.Save()
                lblPrinter.Text = selectedPrinter
            End If
        End Using
    End Sub

    Private Sub btnTestPrint_Click(sender As Object, e As EventArgs) Handles btnTestPrint.Click
        Dim testFile = Path.Combine(queuePath, "test.pdf")
        File.WriteAllText(testFile, "Test page")
        PrintFile(testFile)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        timerSchedule.Start()
        btnStart.Enabled = False
    End Sub

    Private Sub timerSchedule_Tick(sender As Object, e As EventArgs) Handles timerSchedule.Tick
        If DateTime.Now >= dtpSchedule.Value Then
            timerSchedule.Stop()
            PrintQueuedFiles()
            btnStart.Enabled = True
        End If
    End Sub

    Private Sub PrintQueuedFiles()
        LoadQueue()
        For Each item As String In lstQueue.Items
            Dim filePath = Path.Combine(queuePath, item)
            PrintFile(filePath)
            Dim dest = Path.Combine(printedPath, item)
            File.Move(filePath, dest)
        Next
        LoadQueue()
    End Sub

    Private Sub PrintFile(filePath As String)
        SystemSounds.Exclamation.Play()
        Dim psi As New ProcessStartInfo()
        psi.Verb = "print"
        psi.FileName = filePath
        psi.CreateNoWindow = True
        psi.WindowStyle = ProcessWindowStyle.Hidden
        If Not String.IsNullOrEmpty(selectedPrinter) Then
            psi.Arguments = Chr(34) & selectedPrinter & Chr(34)
        End If
        Process.Start(psi)
        Threading.Thread.Sleep(2000)
    End Sub
End Class

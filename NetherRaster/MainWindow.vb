Public Class MainWindow
    Dim FillColor As System.Drawing.Color
    Dim FillARGB As Integer
    Dim FillARGB_Hex As String
    Dim HexArray As New List(Of String)
    Dim FillA As Integer = 0
    Dim FillR As Integer = 0
    Dim FillG As Integer = 0
    Dim FillB As Integer = 0
    Dim SaveFileAsExt As String = "PNG"
    Dim MimeType As String = "image/png"

    Private Sub ColorBtn_Click(sender As Object, e As EventArgs) Handles ColorBtn.Click
        ColorPicker.ShowDialog()

        FillColor = ColorPicker.Color()
        Console.WriteLine(FillColor)

        ColorPreviewBox.BackColor = FillColor

        FillARGB = FillColor.ToArgb

        FillARGB_Hex = Hex(FillARGB)
        Console.WriteLine(FillARGB_Hex)

        For i As Integer = 0 To 7 Step 2
            HexArray.Add(FillARGB_Hex.Substring(i, 2))
        Next

        Console.WriteLine("A: " & HexArray(0) & " R: " & HexArray(1) & " G: " & HexArray(2) & " B: " & HexArray(3))

        FillA = Convert.ToInt32(HexArray(0), 16)
        FillR = Convert.ToInt32(HexArray(1), 16)
        FillG = Convert.ToInt32(HexArray(2), 16)
        FillB = Convert.ToInt32(HexArray(3), 16)

        Console.WriteLine("A: " & FillA & " R: " & FillR & " G: " & FillG & " B: " & FillB)
    End Sub

    Private Sub ColorPreviewBox_Click(sender As Object, e As EventArgs) Handles ColorPreviewBox.Click
        ColorBtn_Click(sender, e)
    End Sub

    Private Sub InputBrowseBtn_Click(sender As Object, e As EventArgs) Handles InputBrowseBtn.Click
        'InputFileDialog.InitialDirectory = Application.StartupPath 'App Directory Folder
        InputFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 'Desktop Folder
        If InputFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            InputPath.Text = InputFileDialog.FileName
        End If
    End Sub

    Private Sub OutputBrowseBtn_Click(sender As Object, e As EventArgs) Handles OutputBrowseBtn.Click
        OutputFileDialog.Filter = SaveFileAsExt & " Image|*." & SaveFileAsExt.ToLower
        OutputFileDialog.DefaultExt = SaveFileAsExt.ToLower
        'OutputFileDialog.InitialDirectory = Application.StartupPath 'App Directory Folder
        OutputFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 'Desktop Folder
        If OutputFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OutputPath.Text = OutputFileDialog.FileName
        End If
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SaveAsExtDrop.SelectedIndex = 0
    End Sub

    Private Sub SaveAsExtDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SaveAsExtDrop.SelectedIndexChanged
        Dim i As Integer = SaveAsExtDrop.SelectedIndex
        If i = 0 Then
            SaveFileAsExt = "PNG"
            MimeType = "image/png"
        ElseIf i = 1 Then
            SaveFileAsExt = "JPG"
            MimeType = "image/jpeg"
        ElseIf i = 2 Then
            SaveFileAsExt = "TIFF"
            MimeType = "image/tiff"
        End If
        OutputPath.Text = "C:\Test." & SaveFileAsExt.ToLower
    End Sub

    Private Sub RasterizeBtn_Click(sender As Object, e As EventArgs) Handles RasterizeBtn.Click
        Process.Start("Launch.vbs", " """ & InputPath.Text & """ """ & OutputText.Text & """ " & MimeType & " " & WidthInput.Text & " " & HeightInput.Text & " """ & FillA & ". " & FillR & ". " & FillG & ". " & FillB & """")
    End Sub
End Class

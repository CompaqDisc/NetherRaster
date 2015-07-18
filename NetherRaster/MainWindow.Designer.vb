<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.InputPath = New System.Windows.Forms.TextBox()
        Me.InputText = New System.Windows.Forms.Label()
        Me.InputBrowseBtn = New System.Windows.Forms.Button()
        Me.OutputPath = New System.Windows.Forms.TextBox()
        Me.OutputBrowseBtn = New System.Windows.Forms.Button()
        Me.RasterizeBtn = New System.Windows.Forms.Button()
        Me.SizeText = New System.Windows.Forms.Label()
        Me.OutputText = New System.Windows.Forms.Label()
        Me.WidthInput = New System.Windows.Forms.TextBox()
        Me.HeightInput = New System.Windows.Forms.TextBox()
        Me.HeightText = New System.Windows.Forms.Label()
        Me.WidthText = New System.Windows.Forms.Label()
        Me.SettingsText = New System.Windows.Forms.Label()
        Me.ColorPicker = New System.Windows.Forms.ColorDialog()
        Me.ColorBtn = New System.Windows.Forms.Button()
        Me.ColorText = New System.Windows.Forms.Label()
        Me.ColorPreviewBox = New System.Windows.Forms.PictureBox()
        Me.InputFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.OutputFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SaveAsExtDrop = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.ColorPreviewBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputPath
        '
        Me.InputPath.Location = New System.Drawing.Point(15, 25)
        Me.InputPath.Name = "InputPath"
        Me.InputPath.Size = New System.Drawing.Size(286, 20)
        Me.InputPath.TabIndex = 0
        Me.InputPath.Text = "C:\Test.svg"
        '
        'InputText
        '
        Me.InputText.AutoSize = True
        Me.InputText.Location = New System.Drawing.Point(12, 9)
        Me.InputText.Name = "InputText"
        Me.InputText.Size = New System.Drawing.Size(53, 13)
        Me.InputText.TabIndex = 1
        Me.InputText.Text = "Input File:"
        '
        'InputBrowseBtn
        '
        Me.InputBrowseBtn.Location = New System.Drawing.Point(307, 23)
        Me.InputBrowseBtn.Name = "InputBrowseBtn"
        Me.InputBrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.InputBrowseBtn.TabIndex = 1
        Me.InputBrowseBtn.Text = "Browse..."
        Me.InputBrowseBtn.UseVisualStyleBackColor = True
        '
        'OutputPath
        '
        Me.OutputPath.Location = New System.Drawing.Point(15, 77)
        Me.OutputPath.Name = "OutputPath"
        Me.OutputPath.Size = New System.Drawing.Size(286, 20)
        Me.OutputPath.TabIndex = 2
        Me.OutputPath.Text = "C:\Test.png"
        '
        'OutputBrowseBtn
        '
        Me.OutputBrowseBtn.Location = New System.Drawing.Point(307, 75)
        Me.OutputBrowseBtn.Name = "OutputBrowseBtn"
        Me.OutputBrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.OutputBrowseBtn.TabIndex = 3
        Me.OutputBrowseBtn.Text = "Browse..."
        Me.OutputBrowseBtn.UseVisualStyleBackColor = True
        '
        'RasterizeBtn
        '
        Me.RasterizeBtn.Location = New System.Drawing.Point(15, 423)
        Me.RasterizeBtn.Name = "RasterizeBtn"
        Me.RasterizeBtn.Size = New System.Drawing.Size(367, 35)
        Me.RasterizeBtn.TabIndex = 8
        Me.RasterizeBtn.Text = "Rasterize It!"
        Me.RasterizeBtn.UseVisualStyleBackColor = True
        '
        'SizeText
        '
        Me.SizeText.AutoSize = True
        Me.SizeText.Location = New System.Drawing.Point(12, 113)
        Me.SizeText.Name = "SizeText"
        Me.SizeText.Size = New System.Drawing.Size(30, 13)
        Me.SizeText.TabIndex = 10
        Me.SizeText.Text = "Size:"
        '
        'OutputText
        '
        Me.OutputText.AutoSize = True
        Me.OutputText.Location = New System.Drawing.Point(12, 61)
        Me.OutputText.Name = "OutputText"
        Me.OutputText.Size = New System.Drawing.Size(61, 13)
        Me.OutputText.TabIndex = 11
        Me.OutputText.Text = "Output File:"
        '
        'WidthInput
        '
        Me.WidthInput.Location = New System.Drawing.Point(71, 136)
        Me.WidthInput.Name = "WidthInput"
        Me.WidthInput.Size = New System.Drawing.Size(100, 20)
        Me.WidthInput.TabIndex = 4
        Me.WidthInput.Text = "512"
        '
        'HeightInput
        '
        Me.HeightInput.Location = New System.Drawing.Point(224, 136)
        Me.HeightInput.Name = "HeightInput"
        Me.HeightInput.Size = New System.Drawing.Size(100, 20)
        Me.HeightInput.TabIndex = 5
        Me.HeightInput.Text = "512"
        '
        'HeightText
        '
        Me.HeightText.AutoSize = True
        Me.HeightText.Location = New System.Drawing.Point(177, 139)
        Me.HeightText.Name = "HeightText"
        Me.HeightText.Size = New System.Drawing.Size(41, 13)
        Me.HeightText.TabIndex = 14
        Me.HeightText.Text = "Height:"
        '
        'WidthText
        '
        Me.WidthText.AutoSize = True
        Me.WidthText.Location = New System.Drawing.Point(27, 139)
        Me.WidthText.Name = "WidthText"
        Me.WidthText.Size = New System.Drawing.Size(38, 13)
        Me.WidthText.TabIndex = 15
        Me.WidthText.Text = "Width:"
        '
        'SettingsText
        '
        Me.SettingsText.AutoSize = True
        Me.SettingsText.Location = New System.Drawing.Point(12, 172)
        Me.SettingsText.Name = "SettingsText"
        Me.SettingsText.Size = New System.Drawing.Size(77, 13)
        Me.SettingsText.TabIndex = 17
        Me.SettingsText.Text = "Other Settings:"
        '
        'ColorBtn
        '
        Me.ColorBtn.Location = New System.Drawing.Point(307, 193)
        Me.ColorBtn.Name = "ColorBtn"
        Me.ColorBtn.Size = New System.Drawing.Size(75, 23)
        Me.ColorBtn.TabIndex = 6
        Me.ColorBtn.Text = "Pick..."
        Me.ColorBtn.UseVisualStyleBackColor = True
        '
        'ColorText
        '
        Me.ColorText.AutoSize = True
        Me.ColorText.Location = New System.Drawing.Point(27, 198)
        Me.ColorText.Name = "ColorText"
        Me.ColorText.Size = New System.Drawing.Size(95, 13)
        Me.ColorText.TabIndex = 20
        Me.ColorText.Text = "Background Color:"
        '
        'ColorPreviewBox
        '
        Me.ColorPreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColorPreviewBox.Location = New System.Drawing.Point(128, 193)
        Me.ColorPreviewBox.Name = "ColorPreviewBox"
        Me.ColorPreviewBox.Size = New System.Drawing.Size(173, 23)
        Me.ColorPreviewBox.TabIndex = 21
        Me.ColorPreviewBox.TabStop = False
        '
        'InputFileDialog
        '
        Me.InputFileDialog.DefaultExt = "svg"
        Me.InputFileDialog.Filter = "SVG Images|*.svg"
        '
        'OutputFileDialog
        '
        Me.OutputFileDialog.DefaultExt = "png"
        Me.OutputFileDialog.Filter = "PNG Images|*.png"
        '
        'SaveAsExtDrop
        '
        Me.SaveAsExtDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SaveAsExtDrop.FormattingEnabled = True
        Me.SaveAsExtDrop.Items.AddRange(New Object() {"*.png", "*.jpg", "*.tiff"})
        Me.SaveAsExtDrop.Location = New System.Drawing.Point(128, 221)
        Me.SaveAsExtDrop.Name = "SaveAsExtDrop"
        Me.SaveAsExtDrop.Size = New System.Drawing.Size(254, 21)
        Me.SaveAsExtDrop.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Save Image As:"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 470)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SaveAsExtDrop)
        Me.Controls.Add(Me.ColorPreviewBox)
        Me.Controls.Add(Me.ColorText)
        Me.Controls.Add(Me.ColorBtn)
        Me.Controls.Add(Me.SettingsText)
        Me.Controls.Add(Me.WidthText)
        Me.Controls.Add(Me.HeightText)
        Me.Controls.Add(Me.HeightInput)
        Me.Controls.Add(Me.WidthInput)
        Me.Controls.Add(Me.OutputText)
        Me.Controls.Add(Me.SizeText)
        Me.Controls.Add(Me.RasterizeBtn)
        Me.Controls.Add(Me.OutputBrowseBtn)
        Me.Controls.Add(Me.OutputPath)
        Me.Controls.Add(Me.InputBrowseBtn)
        Me.Controls.Add(Me.InputText)
        Me.Controls.Add(Me.InputPath)
        Me.Name = "MainWindow"
        Me.ShowIcon = False
        Me.Text = "NetherRaster - SVG Rasterizer"
        CType(Me.ColorPreviewBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputPath As System.Windows.Forms.TextBox
    Friend WithEvents InputText As System.Windows.Forms.Label
    Friend WithEvents InputBrowseBtn As System.Windows.Forms.Button
    Friend WithEvents OutputPath As System.Windows.Forms.TextBox
    Friend WithEvents OutputBrowseBtn As System.Windows.Forms.Button
    Friend WithEvents RasterizeBtn As System.Windows.Forms.Button
    Friend WithEvents SizeText As System.Windows.Forms.Label
    Friend WithEvents OutputText As System.Windows.Forms.Label
    Friend WithEvents WidthInput As System.Windows.Forms.TextBox
    Friend WithEvents HeightInput As System.Windows.Forms.TextBox
    Friend WithEvents HeightText As System.Windows.Forms.Label
    Friend WithEvents WidthText As System.Windows.Forms.Label
    Friend WithEvents SettingsText As System.Windows.Forms.Label
    Friend WithEvents ColorPicker As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorBtn As System.Windows.Forms.Button
    Friend WithEvents ColorText As System.Windows.Forms.Label
    Friend WithEvents ColorPreviewBox As System.Windows.Forms.PictureBox
    Friend WithEvents InputFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OutputFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveAsExtDrop As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class

Dim InFile
Set InFile = New WScript.Arguments.Item(0)
Dim OutFile
Set OutFile = WScript.Arguments.Item(1)
Dim MimeType
Set MimeType = WScript.Arguments.Item(2)
Dim Width
Set Width = WScript.Arguments.Item(3)
Dim Height
Set Height = WScript.Arguments.Item(4)
Dim BGColor
Set BGColor = WScript.Arguments.Item(5)

Dim Shell
Set Shell = WScript.CreateObject("WScript.Shell")
Shell.run "cmd.exe /C java -jar batik-1.8\batik-rasterizer-1.8.jar -d " & OutFile & " -m " & MimeType & " -w " & Width & " -h " & Height & " -bg " & BGColor & " " & InFile, 0
Set Shell = Nothing
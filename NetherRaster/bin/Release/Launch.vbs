Dim InFile As String
Set InFile = WScript.Arguments.Item(0)
Dim OutFile As String
Set OutFile = WScript.Arguments.Item(1)
Dim MimeType As String
Set MimeType = WScript.Arguments.Item(2)
Dim Width As String
Set Width = WScript.Arguments.Item(3)
Dim Height As String
Set Height = WScript.Arguments.Item(4)
Dim BGColor As String
Set BGColor = WScript.Arguments.Item(5)

Dim oShell
Set Shell = WScript.CreateObject("WScript.Shell")
Shell.run "cmd.exe /C java -jar batik-1.8\batik-rasterizer-1.8.jar -d " & OutFile & " -m " & MimeType & " -w " & Width & " -h " & Height & " -bg " & BGColor & " " & InFile, 0
Set Shell = Nothing
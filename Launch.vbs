Dim Args
Set Args = WScript.Arguments
Dim Arg0
Dim Arg1
Dim Arg2
Dim Arg3
Dim Arg4
Dim Arg5

Dim InFile
Set InFile = Args.Item(0)
Dim OutFile
Set OutFile = Args.Item(1)
Dim MimeType
Set MimeType = Args.Item(2)
Dim Width
Set Width = Args.Item(3)
Dim Height
Set Height = Args.Item(4)
Dim BGColor
Set BGColor = Args.Item(5)

Dim Shell
Set Shell = WScript.CreateObject("WScript.Shell")
Shell.run "cmd.exe /C java -jar batik-1.8\batik-rasterizer-1.8.jar -d " & OutFile & " -m " & MimeType & " -w " & Width & " -h " & Height & " -bg " & BGColor & " " & InFile, 0
Set Shell = Nothing
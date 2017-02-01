Imports SharpSvn
Imports System
Imports System.IO

Module Module1

    Sub Main()

        Dim wcPath As String = Directory.GetCurrentDirectory()                          'get directory
        Console.WriteLine(wcPath, Environment.NewLine)                                  'looks nice
        Console.WriteLine("Wait for update to finish!", Environment.NewLine)            'looks better
        Dim client As New SvnClient()                                                   'initialize svnclient
        client.CheckOut(New Uri("https://svn.riouxsvn.com/saiyajin3"), wcPath)          'now svn checkout this shit
        Console.WriteLine("Update Complete! press any Key...", Environment.NewLine)     'looks real good
        Console.ReadLine()                                                              'comments are so good <3
    End Sub

End Module

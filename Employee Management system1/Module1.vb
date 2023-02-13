Imports System.IO
Imports System.Security.Cryptography.X509Certificates

Module Module1

    Sub Main()
        Dim ArrayList1 As ArrayList = New ArrayList()
        Dim user As String
        Dim EmpDetails As Classemployee = New Classemployee
        Const userchoice As String = "CREATE,UPDATE,VIEW,DELETE,VIEWALL,QUIT"
        Console.WriteLine("Welcome to Employee Management System")
        Console.WriteLine("Please Enter any one : " + userchoice)


        user = Console.ReadLine()
        Select Case (user.ToUpper())
            Case "CREATE"
                ArrayList1.Add(EmpDetails.Create())
            Case "UPDATE"
                EmpDetails.Update()
            Case "DELETE"
                EmpDetails.delete()
            Case "VIEWALL"
                EmpDetails.viewall()
            Case "VIEWALL"
                EmpDetails.view()
            Case "QUIT"


        End Select

        Console.ReadKey()

    End Sub

End Module

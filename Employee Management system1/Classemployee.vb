Imports System.Security.Cryptography.X509Certificates

Public Class Classemployee
    Public id As Int16
    Public Name As String
    Public DateOfBirth As DateTime
    Public salary As Double
    Public Active As Boolean
    Dim i As Object


    Public Function Create()
        Dim EmpDetails1 As Classemployee = New Classemployee


        Console.WriteLine("Enter id: ")
        EmpDetails1.id = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Enter Name: ")
        EmpDetails1.Name = Console.ReadLine

        Console.WriteLine("Enter DOB: ")
        EmpDetails1.DateOfBirth = Console.ReadLine()

        Console.WriteLine("Enter Salary: ")
        EmpDetails1.salary = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Enter Employee Active(Y/N)" + vbCrLf)
        Dim UserInput As String = Console.ReadLine()
        If UserInput.ToUpper = "Y" Then
            Active = True
        Else
            Active = False
        End If
        Console.WriteLine("Employee created with given examples")
        Return EmpDetails1

    End Function
    Public Sub Update(ByRef array1 As ArrayList)
        Dim EmployeeExists As Boolean = False
        Dim Empolyee1 As Classemployee = New Classemployee
        Console.WriteLine("Enter Emp Id to update: ")
        Empolyee1.id = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter Emp new salary:")
        Empolyee1.salary = Console.ReadLine()
        For Each Classemployee1 As Classemployee In array1
            If Classemployee1.id = Empolyee1.id Then
                EmployeeExists = True

                If (EmployeeExists) Then
                    Console.WriteLine("Employee details is updated")
                Else
                    Console.WriteLine("Employee details not found")
                End If
            End If
        Next

    End Sub
    Public Sub view(ByRef array1 As ArrayList)
        Dim EmployeeExists As Boolean = False
        Dim Empolyee1 As Classemployee = New Classemployee

    End Sub

    Public Sub viewall(ByRef array1 As ArrayList)

    End Sub

    Public Sub delete(ByRef array1 As ArrayList)

    End Sub

    Public Sub quit(ByRef array1 As ArrayList)

    End Sub




End Class


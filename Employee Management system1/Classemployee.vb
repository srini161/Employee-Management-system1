Public Class Classemployee
    Public id As Int16
    Public Name As String
    Public DateOfBirth As String
    Public Active As Boolean
    Public abc As Double
    Public ArrayList As ArrayList = New ArrayList()
    Dim i As Object

    Public Sub Create()
        While abc <= 5
            Console.WriteLine("Enter id: ")
            id = Convert.ToInt32(Console.ReadLine())
        ArrayList.Add(id)
        Console.WriteLine("Enter Name: ")
        Name = Console.ReadLine
        ArrayList.Add(Name)
        Console.WriteLine("Enter DOB: ")
        DateOfBirth = Console.ReadLine()
        ArrayList.Add(DateOfBirth)
            Console.WriteLine("Enter Active" + vbCrLf)
            Active = Console.ReadLine()
        ArrayList.Add(Active)

            For Each i In ArrayList
                Console.WriteLine("Employees details are: {0}", i)
            Next i
        Console.WriteLine()
            Console.ReadKey()
        End While
    End Sub
End Class


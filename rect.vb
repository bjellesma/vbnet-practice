Imports System
Public Class Rectangle
    Private length As Double
    Private width As Double

    'Public methods
    Public Sub AcceptDetails()
        length = 4.5
        width = 3.5
    End Sub
    'Functions are to return values while subroutines do not
    Public Function GetArea() As Double
        GetArea = length * width
    End Function
    Public Sub Display()
        Console.WriteLine("Length: {0}", length)
        Console.WriteLine("Width: {0}", width)
        Console.WriteLine("Area: {0}", GetArea())

    End Sub
    'Sub main indicates the start of a program
    'Shared means that we do not have to create an object of the class
    Shared Sub Main()
        Dim r As New Rectangle()
        'The following line prints a visual basic constant for a carriage return
        Console.WriteLine(vbCrLf)
        'The following line prints a visual basic constant for a tab character
        Console.WriteLine(vbTab)
        r.Acceptdetails()
        r.Display()
        Console.ReadLine()
    End Sub
End Class
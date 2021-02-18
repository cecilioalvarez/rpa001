Imports System

Module Program
    Sub Main(args As String())
        Console.Write("por favor introduce la nota:")

        Dim nota As Decimal = Console.ReadLine()

        If nota > 0.0 And nota < 3.3 Then
            Console.WriteLine("muy deficiente")
        ElseIf nota >= 3 And nota < 5 Then
            Console.WriteLine("insuficiente")
        Else
            Console.WriteLine("has aprobado no pidas mas")

        End If



    End Sub
End Module

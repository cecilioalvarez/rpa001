Imports System

Module Program
    Sub Main(args As String())

        Dim numero As Integer = 5
        If numero > 0 And numero < 5 Then
            Console.WriteLine("has suspendido")
        ElseIf numero = 5 Then
            Console.WriteLine("has aprobado justo")
        Else
            Console.WriteLine("has hecho un buen examen")

        End If



    End Sub
End Module

Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine("introduce un importe")
        Dim importe As String = Console.ReadLine()
        Dim iva1 As Decimal = 1.21
        Dim iva2 As Decimal = 1.1
        Dim importeFinal As Decimal

        Dim importeNumerico As Decimal = Convert.ToDecimal(importe)

        If importeNumerico >= 100 Then

            importeFinal = importeNumerico * iva1
        Else
            importeFinal = importeNumerico * iva2

        End If

        Console.WriteLine("importe final es " & importeFinal)





    End Sub
End Module

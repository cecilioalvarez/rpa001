Imports System

Module Program
	Sub Main(args As String())

		Console.WriteLine("Hola mundo")
		Console.WriteLine("hola otra vez")
		Dim numero As Decimal
		numero = 3
		Console.WriteLine(numero)
		numero = 5
		Console.WriteLine(numero)
		Dim numero2 As Decimal
		numero2 = 6
		Dim suma As Decimal
		suma = numero + numero2
		Console.WriteLine(suma)
		' hola esto es un comentario
		Dim multiplicar As Decimal
		multiplicar = numero * numero2
		Console.WriteLine(multiplicar)
		Dim dividir As Decimal
		dividir = numero / numero2
		Console.WriteLine(dividir)
	End Sub
End Module

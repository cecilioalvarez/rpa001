Imports System

Module Program2
	Sub Main(args As String())

		Console.WriteLine("hola de desde visual studio")
		' String define una variable como una cadena de texto
		Dim cadena As String
		cadena = "hola"

		Console.WriteLine(cadena)

		Dim cadena2 As String
		cadena2 = " que tal"

		Dim cadenaTotal As String
		cadenaTotal = cadena & cadena2
		Console.WriteLine(cadenaTotal)



	End Sub
End Module

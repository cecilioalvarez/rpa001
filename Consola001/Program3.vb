Imports System

Module Program3

	Sub Main(args As String())

		'Dim numero As Integer = 6
		Console.WriteLine("introduce una nota")
		'la nota es lo que estoy leyendo
		' sea el valor con el que comparo
		Dim nota As String = Console.ReadLine()
		Console.WriteLine(nota)

		'esto usa un componente para 
		' convertir un valor que es string
		' en una variable que es un numero
		Dim valorNota As Integer = Convert.ToInt32(nota)


		'Console.WriteLine(numero)
		If valorNota >= 5 Then
			Console.WriteLine("has aprobado")
		Else
			Console.WriteLine("has suspendido")

		End If



	End Sub
End Module

Imports System

Module Program
    Sub Main(args As String())

#Region "COMO MOSTRAR UN MENSAJE EN VB"
        Console.WriteLine("Hola mundo")
        Console.ReadLine()
#End Region

        Dim Nombre As String
        Dim Edad As Integer
        Console.WriteLine("Ingrese su nombre por favor")
        Nombre = Console.ReadLine
        Console.WriteLine("Ingrese su edad por favor")
        Edad = Integer.Parse(Console.ReadLine())
        If (Edad >= 18) Then
            Console.WriteLine("Usted es mayor de edad")
        Else
            Console.WriteLine("Usted es menor de edad")
        End If
        Console.ReadLine()



    End Sub
End Module

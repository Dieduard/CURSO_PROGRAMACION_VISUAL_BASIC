Imports System

Module Program
    Sub Main(args As String())

        'COMO MOSTRAR UN MENSAJE EN VB
        'Console.WriteLine("Hola mundo")
        'Console.ReadLine()
        '-----------------------------------------------------------------------------------------------------
        '''VARIABLES DE TIPO NUMERICAS 
        'Dim Edad As Byte
        'Dim Numero As Short
        'Dim Edad2 As Integer
        'Dim Num As Long
        'Dim sueldo As Double
        'Dim Aguinaldo As Decimal
        '-----------------------------------------------------------------------------------------------------
        '''VARIABLES DE TIPO TEXTO
        'Dim a As Char
        'Dim Nombre As String
        '-----------------------------------------------------------------------------------------------------
        '''OTRO TIPO DE VARIABLE
        'Dim falso As Boolean
        'Dim Fecha As Date
        'Dim Objeto As Object
        '-----------------------------------------------------------------------------------------------------
        '''OPERADORES ARITMETICOS EN VB
        'SUMA = +
        'RESTA = -
        'Multi = *
        'DIVICION = /
        'EXPONENTE = ^

        'EJEMPLO DE OPERADORES ARITMETICOS
        'Dim Num1, Num2, Suma, Resta, Multi, Divi As Double
        'Num1 = 15
        'Num2 = 10
        'Suma = Num1 + Num2
        'Resta = Num1 - Num2
        'Multi = Num1 * Num2
        'Divi = Num1 / Num2
        'Console.WriteLine("La Suma es : " & Suma)
        'Console.WriteLine("La resta es : " & Resta)
        'Console.WriteLine("La multi es: " & Multi)
        'Console.WriteLine("La Divicion es :" & Divi)
        'Console.ReadLine()
        '-----------------------------------------------------------------------------------------------------
        'COMO HACER UN ARREGLOS EN VB
        'ARREGLO STRING
        'Dim arreglo(3) As String
        'arreglo(0) = "Hola"
        'arreglo(1) = "Codigo"
        'arreglo(2) = "Facilito"
        'Console.WriteLine(arreglo(0) + " " + arreglo(1) + " " + arreglo(2))
        ''ARREGLO INTEGER
        'Dim arreglo2() As Integer
        'arreglo2 = New Integer() {1, 2, 3}
        'Console.WriteLine(arreglo2(0).ToString + " " + arreglo2(1).ToString + " " + arreglo2(2).ToString)
        ''COMO HACER UNA MATRIZ
        'Dim Matriz(,) As Integer = {{1, 2, 3}, {4, 5, 6}}
        'Console.WriteLine(Matriz(1, 1).ToString)
        'Console.ReadLine()

        '-----------------------------------------------------------------------------------------------------
        '' OPERADORES RELACIONALES >
        'Dim NumUno, NumDos As Integer
        'Console.ForegroundColor = ConsoleColor.White
        'Console.WriteLine("Ingrese el Primer Numero")
        'NumUno = Integer.Parse(Console.ReadLine)

        'Console.WriteLine("Ingrese el Segundo Numero")
        'NumDos = Integer.Parse(Console.ReadLine)
        'Console.ForegroundColor = ConsoleColor.Yellow
        'If NumUno > NumDos Then
        '    Console.WriteLine("El Primer Numero es Mayor")
        'Else
        '    Console.WriteLine("El Segundo Numero es Mayor")
        'End If
        'Console.ReadLine()
        '-----------------------------------------------------------------------------------------------------
        'Dim nombres(9) As String
        'Console.ForegroundColor = ConsoleColor.White
        'Console.WriteLine("   !!!  Ingrese el nombre de 10 personas: !!! ")
        'For i = 0 To 9
        '    Dim n As String
        '    n = Console.ReadLine
        '    nombres(i) = n
        'Next
        'Console.WriteLine()
        'Console.ForegroundColor = ConsoleColor.Magenta
        'Console.WriteLine(" !! sus nombres son: !!  ")
        'For i = 0 To 9
        '    Console.WriteLine(nombres(i))
        'Next
        'Console.ReadLine()
        '-----------------------------------------------------------------------------------------------------
        '''COMO USAR LO QUE ES EL TRY CATCH
        'Try
        '    Console.WriteLine("Ingrese su Nombre")
        '    dim nombre As string = Console.ReadLine()

        '    Console.WriteLine("Ingrese su Edad")
        '    Dim edad As Integer = Integer.Parse(Console.ReadLine())

        '    If edad >= 18 Then
        '        Console.WriteLine(nombre + " " + "Usted es mayor de Edad")
        '    Else
        '        Console.WriteLine(nombre + " " + "Usted es menor de Edad")
        '    End If
        'Catch ex As Exception
        '    Console.WriteLine("Error en Ingresar MAL los Datos ")
        'End Try
        'Console.ReadLine()
        '-----------------------------------------------------------------------------------------------------
        '''USO DEL SHITCH CASE 
        'Dim num1, num2, Suma, Resta, Multi, Divi As Double
        'Dim Opcion As Integer

        'Console.WriteLine("*******************************************")
        'Console.WriteLine("LAS OPCIONES DEL MENÚ SON :")
        'Console.WriteLine("Realizar una Suma   ---->(1)")
        'Console.WriteLine("Realizar una Resta  ---->(2)")
        'Console.WriteLine("Realizar una Multi  ---->(3)")
        'Console.WriteLine("Realizar una Divi   ---->(4)")
        'Console.WriteLine("*******************************************")
        'Console.WriteLine("Ingrese la Opcion que desea Realizar ?")
        'Opcion = Integer.Parse(Console.ReadLine())
        'Console.WriteLine("*******************************************")
        'Select Case Opcion
        '    Case 1
        '        Console.WriteLine("Ingrese el Primer Numero")
        '        num1 = Integer.Parse(Console.ReadLine())

        '        Console.WriteLine("Ingrese el Segundo Numero")
        '        num2 = Integer.Parse(Console.ReadLine())
        '        Console.WriteLine("*******************************************")
        '        Suma = num1 + num2
        '        Console.WriteLine("El Resultado de la Suma es de :" & Suma)

        '    Case 2
        '        Console.WriteLine("Ingrese el Primer Numero")
        '        num1 = Integer.Parse(Console.ReadLine())

        '        Console.WriteLine("Ingrese el Segundo Numero")
        '        num2 = Integer.Parse(Console.ReadLine())
        '        Console.WriteLine("*******************************************")
        '        Resta = num1 - num2
        '        Console.WriteLine("El Resultado de la Suma es de :" & Resta)
        '    Case 3
        '        Console.WriteLine("Ingrese el Primer Numero")
        '        num1 = Integer.Parse(Console.ReadLine())

        '        Console.WriteLine("Ingrese el Segundo Numero")
        '        num2 = Integer.Parse(Console.ReadLine())
        '        Console.WriteLine("*******************************************")
        '        Multi = num1 * num2
        '        Console.WriteLine("El Resultado de la Suma es de :" & Multi)
        '    Case 4
        '        Console.WriteLine("Ingrese el Primer Numero")
        '        num1 = Integer.Parse(Console.ReadLine())

        '        Console.WriteLine("Ingrese el Segundo Numero")
        '        num2 = Integer.Parse(Console.ReadLine())
        '        Console.WriteLine("*******************************************")
        '        Divi = num1 / num2
        '        Console.WriteLine("El Resultado de la Suma es de :" & Divi)
        '    Case Else
        '        Console.WriteLine(" El Numero que Ingreso esta Fuera de los Limites ")

        '        Console.WriteLine("*******************************************")
        'End Select
        'Console.ReadLine()
        '-----------------------------------------------------------------------------------------------------
        ''USO DEL CICLO FOR
        'Dim numero As Integer
        'Console.WriteLine("Ingrese el numero de la tabla a multiplicar")
        'numero = Integer.Parse(Console.ReadLine)
        'For i = 1 To 10
        '    Console.WriteLine(numero & "X" & i & "=" & i * numero)
        'Next
        'Console.ReadLine()
        '-----------------------------------------------------------------------------------------------------
        'Hola como estas

    End Sub
End Module

﻿'Rudy Earnest
'Spring 2025
'RCET 2265
'Operators Example
'https://github.com/rc-earnest/OperatorsExample.git

Option Compare Text

Module OperatorsExample

    Sub Main()

        'sum operator
        Console.Write("5 + 3 = ") 'print a string
        Console.WriteLine(5 + 3) 'print the sum
        Console.WriteLine()

        'difference operator
        Console.Write("5 - 3 = ") 'print a string
        Console.WriteLine(5 - 3) 'print the difference
        Console.WriteLine()

        'product operator
        Console.Write("5 * 3 = ") 'print a string
        Console.WriteLine(5 * 3) 'print the product
        Console.WriteLine()

        'floating point quotient operator
        Console.Write("5 / 3 = ") 'print a string
        Console.WriteLine(5 / 3) 'print the floating point quotient
        Console.WriteLine()

        'integer quotient operator
        Console.Write("5 \ 3 = ") 'print a string
        Console.WriteLine(5 \ 3) 'print the integer quotient
        Console.WriteLine()

        'modulus operator
        Console.Write("5 mod 3 = ") 'print a string
        Console.WriteLine(5 Mod 3) 'print the remainder
        Console.WriteLine()

        'exponent operator
        Console.Write("5 ^ 3 = ") 'print a string
        Console.WriteLine(5 ^ 3) 'print exponent
        Console.WriteLine()

        'concatination operator
        Console.WriteLine("5" & " " & "+" & " " & "3" & " " & "=" & " " & "8") 'print a string
        Console.WriteLine()
        Console.WriteLine("wake up neo..." & vbNewLine & "follow the white rabbit...")
        Console.WriteLine(StrDup(100, "*"))

        'Compare
        Console.Write("5 > 3 = ") 'print a string
        Console.WriteLine(5 > 3) 'print comparison
        Console.WriteLine()

        Console.Write("5 < 3 = ") 'print a string
        Console.WriteLine(5 < 3) 'print comparison
        Console.WriteLine()

        Console.Write("5 = 3 ? ") 'print a string
        Console.WriteLine(5 = 3) 'print comparison
        Console.WriteLine()

        Console.Write("5 not equal to 3 = ") 'print a string
        Console.WriteLine(5 <> 3) 'print comparison
        Console.WriteLine()

        Console.Write("A > B = ") 'print a string
        Console.WriteLine("A" > "B") 'print comparison
        Console.WriteLine()

        Console.Write("A = a ? ") 'print a string
        Console.WriteLine("A" = "a") 'print comparison
        Console.WriteLine()

    End Sub

End Module

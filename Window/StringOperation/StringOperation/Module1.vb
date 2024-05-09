Module Module1

    Sub Main()
        Dim str1, str2, str3 As String
        Dim l As Integer
        Do
            System.Console.WriteLine("")
            System.Console.WriteLine("")
            System.Console.WriteLine("Enter String1:")
            str1 = Console.ReadLine()
            System.Console.WriteLine("1.Legnth:")
            System.Console.WriteLine("2.Comparision:")
            System.Console.WriteLine("3.UpperCase And LowerCase:")
            System.Console.WriteLine("4.Character From Left and Right:")
            System.Console.WriteLine("5.String Replacing:")
            System.Console.WriteLine("")
            System.Console.WriteLine("Enter the Choice:")
            Dim ch As Integer
            ch = Integer.Parse(Console.ReadLine())
            Select Case ch
                Case "1"
                    System.Console.WriteLine("")
                    Dim leng As Integer
                    leng = Len(str1)
                    System.Console.WriteLine("Length of the String:")
                    System.Console.WriteLine(leng)
                Case "2"
                    System.Console.WriteLine("String Comparsion..")
                    System.Console.WriteLine("")
                    System.Console.WriteLine("Enter String2:")
                    str2 = Console.ReadLine()
                    If (str1.CompareTo(str2) = False) Then
                        System.Console.WriteLine("Both Strings Are Equal")
                    Else
                        System.Console.WriteLine("Both Strings Are Not Equal")
                    End If

                Case "3"
                    System.Console.WriteLine("")
                    System.Console.WriteLine("String Uppercase:" + str1.ToUpper() + " " + "And LowerCase:" + str1.ToLower)
                Case "4"
                    Dim n As Integer
                    System.Console.WriteLine("")
                    System.Console.WriteLine("Enter the Index:")
                    System.Console.WriteLine("")
                    n = Integer.Parse(Console.ReadLine())
                    System.Console.WriteLine("Left Side Characters:" + Left(str1, n))
                    System.Console.WriteLine("Right Side Characters:" + Right(str1, n))
                Case "5"
                    System.Console.WriteLine("")
                    System.Console.WriteLine("String Replace")
                    System.Console.WriteLine("In Which Part..")
                    str2 = Console.ReadLine()
                    System.Console.WriteLine("")
                    System.Console.WriteLine("Replace String:")
                    str3 = Console.ReadLine()
                    System.Console.WriteLine("After Replacing:" + Replace(str1, str2, str3))
                    Exit Select
            End Select
            System.Console.WriteLine("Do you want to Continue press 1 or Exit Press 0..")
            l = Integer.Parse(Console.ReadLine())
        Loop While l > 0

        System.Console.ReadLine()
    End Sub

End Module

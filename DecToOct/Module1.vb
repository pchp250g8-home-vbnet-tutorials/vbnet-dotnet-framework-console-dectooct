Module Module1

    Sub Main()
        Const MAX_INT = UInteger.MaxValue
        Dim uNumber As UInteger
        Console.WriteLine("Input an unsigned integer number")
        Dim bIsRightNumber = (UInteger.TryParse(Console.ReadLine(), uNumber)) AndAlso
                     (uNumber <= MAX_INT)
        If (Not bIsRightNumber) Then
            Console.WriteLine("Invalid number format or number too big")
            Console.Read()
            Return
        End If
        Dim strOctNum = ""
        Dim uTempVal = uNumber
        Do While (uTempVal > 0)
            strOctNum = CUInt(uTempVal Mod 8).ToString() + strOctNum
            uTempVal \= 8
        Loop
        If (strOctNum.Length = 0) Then
            strOctNum = "0"
        End If
        Console.WriteLine _
        (
            "The octal equivalent of the decimal number {0} is: {1}",
            uNumber, strOctNum
        )
        Console.Read()
    End Sub

End Module

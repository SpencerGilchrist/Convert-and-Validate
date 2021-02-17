

'Spencer Gilchrist
'RCET 0265
'ValidateandConvert
'2-13-21
Module ConvertValidate

    Sub Main()
        Dim Message As String
        Dim Number As Integer
        Console.WriteLine("type a number.")
        Message = Console.ReadLine()
        Console.WriteLine(ConvertValidate.ValidateAndConvert(Message, Number))
        Console.Read()

    End Sub
    Private Function ValidateAndConvert(ByVal ThisString As String, ByRef ThisInteger As Integer)
        Dim Message As String

        Try
            ThisInteger = Convert.ToInt32(ThisString)
            Message = "conversion complete"
        Catch ex As Exception
            If ThisString = "" Then
                Console.WriteLine("Is Empty")
                Console.Read()
            Else
                Message = "Must contain only numbers."
            End If
        End Try

        Return Message$

    End Function

End Module

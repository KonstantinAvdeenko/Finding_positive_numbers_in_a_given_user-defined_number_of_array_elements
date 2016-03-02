Module Module1
    Sub Main()
        Dim i, n, k, r As Integer
        Dim a() As Integer = {-1, 1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6, 7, -7, 8, -8, 9, -9, 10, -10, 11, -11, 12, -12, 13, 18, 14, -14, 15, 16, 0}
        Console.WriteLine("Введите количество элементов массива для счета не больше 29")
        n = Convert.ToInt32(Console.ReadLine())
        For i = 0 To n
            If a(i) > 0 Then k = k + 1
        Next i
        Console.WriteLine("количество положительных элементов" & "   " & k)
        'Изменение размерности массива для суммирования всех присвоенных массиву элементов'
        ReDim Preserve a(0 To 29)
        For i = 0 To 29
            r = r + a(i)
        Next
        Console.WriteLine("сумма элементов массива после 0" & "   " & r)
        Console.ReadLine()
    End Sub
End Module

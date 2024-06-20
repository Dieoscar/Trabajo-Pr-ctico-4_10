Public Class Form1
    Dim MatrizPrincipal(6, 6) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtvMatrizPrincipal.ColumnCount = 7
        dtvMatrizPrincipal.Rows.Add(7)
        For i = 0 To 6
            dtvMatrizPrincipal.Columns(i).Width = 40
        Next


        dtvNuevaMatriz.ColumnCount = 4
        dtvNuevaMatriz.Rows.Add(3)
        For i = 0 To 3
            dtvNuevaMatriz.Columns(i).Width = 40

        Next
        dtvVector.ColumnCount = 7
        dtvVector.Rows.Add(1)
        For i = 0 To 6
            dtvVector.Columns(i).Width = 40

        Next
    End Sub

    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim a As Integer
        Dim c As Integer
        Dim contador As Integer
        Dim f As Integer
        Dim i As Integer
        Dim indice As Integer
        Dim mayor As Integer

        Dim Vector(6) As Integer
        Dim NuevaMatriz(2, 3) As Integer


        mayor = MatrizPrincipal(0, 6)
        For f = 0 To 6
            For c = 0 To 6
                If MatrizPrincipal(f, 6 - f) > mayor Then
                    mayor = MatrizPrincipal(f, 6 - f)
                End If
            Next c
        Next f

        txtMayor.Text = mayor
        contador = 4
        indice = 0

        For c = 0 To 6
            For f = 0 To 6
                If f = contador Then
                    If indice = 2 Then
                        Vector(indice) = MatrizPrincipal(f, c)
                        indice = indice + 1
                        contador = -1
                    Else
                        Vector(indice) = MatrizPrincipal(f, c)
                        indice = indice + 1
                    End If
                End If
            Next f
            contador = contador + 1
        Next c

        For i = 0 To 6
            dtvVector.Item(i, 0).Value = Vector(i)
        Next i
        a = 1

        For f = 0 To 2
            For c = 0 To 3
                NuevaMatriz(f, c) = MatrizPrincipal(f + 2, c + a)
                dtvNuevaMatriz.Item(c, f).Value = NuevaMatriz(f, c)
            Next c
            a = a + 1

        Next f
    End Sub

    Private Sub cmdCargarMatriz_Click(sender As Object, e As EventArgs) Handles cmdCargarMatriz.Click
        For f = 0 To 6
            For c = 0 To 6
                MatrizPrincipal(f, c) = New Random().Next(100)
                dtvMatrizPrincipal.Item(c, f).Value = MatrizPrincipal(f, c)
            Next c

        Next f
    End Sub
End Class

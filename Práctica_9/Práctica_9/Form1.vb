Public Class Form1


    Dim vis(8) As Boolean
    Dim clicked(8) As Boolean
    Dim contador As Integer


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        vis(0) = PictureBox1.Visible
        vis(1) = PictureBox2.Visible
        vis(2) = PictureBox3.Visible
        vis(3) = PictureBox4.Visible
        vis(4) = PictureBox5.Visible
        vis(5) = PictureBox6.Visible
        vis(6) = PictureBox7.Visible
        vis(7) = PictureBox8.Visible
        vis(8) = PictureBox9.Visible

        Randomize()
        Dim value1 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value1) = 0
        Randomize()
        Dim value2 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value2) = 0
        Randomize()
        Dim value3 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value3) = 0
        Randomize()
        Dim value4 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value4) = 1

        Randomize()
        Dim value5 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value5) = 1

        Randomize()
        Dim value6 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value6) = 1

        PictureBox1.Visible = vis(0)
        PictureBox2.Visible = vis(1)
        PictureBox3.Visible = vis(2)
        PictureBox4.Visible = vis(3)
        PictureBox5.Visible = vis(4)
        PictureBox6.Visible = vis(5)
        PictureBox7.Visible = vis(6)
        PictureBox8.Visible = vis(7)
        PictureBox9.Visible = vis(8)


        If (clicked(0) = False) Then
            contador = contador + 1
            clicked(0) = True
        End If

        If (contador = 8) Then
            MsgBox("Has ganado")
        End If

    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        vis(0) = PictureBox1.Visible
        vis(1) = PictureBox2.Visible
        vis(2) = PictureBox3.Visible
        vis(3) = PictureBox4.Visible
        vis(4) = PictureBox5.Visible
        vis(5) = PictureBox6.Visible
        vis(6) = PictureBox7.Visible
        vis(7) = PictureBox8.Visible
        vis(8) = PictureBox9.Visible

        Randomize()
        Dim value1 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value1) = 0
        Randomize()
        Dim value2 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value2) = 0
        Randomize()
        Dim value3 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value3) = 0
        Randomize()
        Dim value4 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value4) = 1

        Randomize()
        Dim value5 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value5) = 1

        Randomize()
        Dim value6 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value6) = 1

        PictureBox1.Visible = vis(0)
        PictureBox2.Visible = vis(1)
        PictureBox3.Visible = vis(2)
        PictureBox4.Visible = vis(3)
        PictureBox5.Visible = vis(4)
        PictureBox6.Visible = vis(5)
        PictureBox7.Visible = vis(6)
        PictureBox8.Visible = vis(7)
        PictureBox9.Visible = vis(8)


        If (clicked(1) = False) Then
            contador = contador + 1
            clicked(1) = True
        End If

        If (contador = 8) Then
            MsgBox("Has ganado")
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        vis(0) = PictureBox1.Visible
        vis(1) = PictureBox2.Visible
        vis(2) = PictureBox3.Visible
        vis(3) = PictureBox4.Visible
        vis(4) = PictureBox5.Visible
        vis(5) = PictureBox6.Visible
        vis(6) = PictureBox7.Visible
        vis(7) = PictureBox8.Visible
        vis(8) = PictureBox9.Visible

        Randomize()
        Dim value1 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value1) = 0
        Randomize()
        Dim value2 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value2) = 0
        Randomize()
        Dim value3 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value3) = 0
        Randomize()
        Dim value4 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value4) = 1

        Randomize()
        Dim value5 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value5) = 1

        Randomize()
        Dim value6 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value6) = 1

        PictureBox1.Visible = vis(0)
        PictureBox2.Visible = vis(1)
        PictureBox3.Visible = vis(2)
        PictureBox4.Visible = vis(3)
        PictureBox5.Visible = vis(4)
        PictureBox6.Visible = vis(5)
        PictureBox7.Visible = vis(6)
        PictureBox8.Visible = vis(7)
        PictureBox9.Visible = vis(8)


        If (clicked(2) = False) Then
            contador = contador + 1
            clicked(2) = True
        End If

        If (contador = 8) Then
            MsgBox("Has ganado")
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        vis(0) = PictureBox1.Visible
        vis(1) = PictureBox2.Visible
        vis(2) = PictureBox3.Visible
        vis(3) = PictureBox4.Visible
        vis(4) = PictureBox5.Visible
        vis(5) = PictureBox6.Visible
        vis(6) = PictureBox7.Visible
        vis(7) = PictureBox8.Visible
        vis(8) = PictureBox9.Visible

        Randomize()
        Dim value1 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value1) = 0
        Randomize()
        Dim value2 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value2) = 0
        Randomize()
        Dim value3 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value3) = 0
        Randomize()
        Dim value4 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value4) = 1

        Randomize()
        Dim value5 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value5) = 1

        Randomize()
        Dim value6 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value6) = 1

        PictureBox1.Visible = vis(0)
        PictureBox2.Visible = vis(1)
        PictureBox3.Visible = vis(2)
        PictureBox4.Visible = vis(3)
        PictureBox5.Visible = vis(4)
        PictureBox6.Visible = vis(5)
        PictureBox7.Visible = vis(6)
        PictureBox8.Visible = vis(7)
        PictureBox9.Visible = vis(8)


        If (clicked(3) = False) Then
            contador = contador + 1
            clicked(3) = True
        End If

        If (contador = 8) Then
            MsgBox("Has ganado")
        End If

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        vis(0) = PictureBox1.Visible
        vis(1) = PictureBox2.Visible
        vis(2) = PictureBox3.Visible
        vis(3) = PictureBox4.Visible
        vis(4) = PictureBox5.Visible
        vis(5) = PictureBox6.Visible
        vis(6) = PictureBox7.Visible
        vis(7) = PictureBox8.Visible
        vis(8) = PictureBox9.Visible

        Randomize()
        Dim value1 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value1) = 0
        Randomize()
        Dim value2 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value2) = 0
        Randomize()
        Dim value3 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value3) = 0
        Randomize()
        Dim value4 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value4) = 1

        Randomize()
        Dim value5 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value5) = 1

        Randomize()
        Dim value6 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value6) = 1

        PictureBox1.Visible = vis(0)
        PictureBox2.Visible = vis(1)
        PictureBox3.Visible = vis(2)
        PictureBox4.Visible = vis(3)
        PictureBox5.Visible = vis(4)
        PictureBox6.Visible = vis(5)
        PictureBox7.Visible = vis(6)
        PictureBox8.Visible = vis(7)
        PictureBox9.Visible = vis(8)


        If (clicked(4) = False) Then
            contador = contador + 1
            clicked(4) = True
        End If

        If (contador = 8) Then
            MsgBox("Has ganado")
        End If

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        vis(0) = PictureBox1.Visible
        vis(1) = PictureBox2.Visible
        vis(2) = PictureBox3.Visible
        vis(3) = PictureBox4.Visible
        vis(4) = PictureBox5.Visible
        vis(5) = PictureBox6.Visible
        vis(6) = PictureBox7.Visible
        vis(7) = PictureBox8.Visible
        vis(8) = PictureBox9.Visible

        Randomize()
        Dim value1 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value1) = 0
        Randomize()
        Dim value2 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value2) = 0
        Randomize()
        Dim value3 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value3) = 0
        Randomize()
        Dim value4 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value4) = 1

        Randomize()
        Dim value5 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value5) = 1

        Randomize()
        Dim value6 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value6) = 1

        PictureBox1.Visible = vis(0)
        PictureBox2.Visible = vis(1)
        PictureBox3.Visible = vis(2)
        PictureBox4.Visible = vis(3)
        PictureBox5.Visible = vis(4)
        PictureBox6.Visible = vis(5)
        PictureBox7.Visible = vis(6)
        PictureBox8.Visible = vis(7)
        PictureBox9.Visible = vis(8)


        If (clicked(5) = False) Then
            contador = contador + 1
            clicked(5) = True
        End If

        If (contador = 8) Then
            MsgBox("Has ganado")
        End If

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

        vis(0) = PictureBox1.Visible
        vis(1) = PictureBox2.Visible
        vis(2) = PictureBox3.Visible
        vis(3) = PictureBox4.Visible
        vis(4) = PictureBox5.Visible
        vis(5) = PictureBox6.Visible
        vis(6) = PictureBox7.Visible
        vis(7) = PictureBox8.Visible
        vis(8) = PictureBox9.Visible

        Randomize()
        Dim value1 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value1) = 0
        Randomize()
        Dim value2 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value2) = 0
        Randomize()
        Dim value3 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value3) = 0
        Randomize()
        Dim value4 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value4) = 1

        Randomize()
        Dim value5 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value5) = 1

        Randomize()
        Dim value6 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value6) = 1

        PictureBox1.Visible = vis(0)
        PictureBox2.Visible = vis(1)
        PictureBox3.Visible = vis(2)
        PictureBox4.Visible = vis(3)
        PictureBox5.Visible = vis(4)
        PictureBox6.Visible = vis(5)
        PictureBox7.Visible = vis(6)
        PictureBox8.Visible = vis(7)
        PictureBox9.Visible = vis(8)


        If (clicked(6) = False) Then
            contador = contador + 1
            clicked(6) = True
        End If

        If (contador = 8) Then
            MsgBox("Has ganado")
        End If

    End Sub

    Private Sub PictureBox8Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

        vis(0) = PictureBox1.Visible
        vis(1) = PictureBox2.Visible
        vis(2) = PictureBox3.Visible
        vis(3) = PictureBox4.Visible
        vis(4) = PictureBox5.Visible
        vis(5) = PictureBox6.Visible
        vis(6) = PictureBox7.Visible
        vis(7) = PictureBox8.Visible
        vis(8) = PictureBox9.Visible

        Randomize()
        Dim value1 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value1) = 0
        Randomize()
        Dim value2 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value2) = 0
        Randomize()
        Dim value3 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value3) = 0
        Randomize()
        Dim value4 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value4) = 1

        Randomize()
        Dim value5 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value5) = 1

        Randomize()
        Dim value6 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value6) = 1

        PictureBox1.Visible = vis(0)
        PictureBox2.Visible = vis(1)
        PictureBox3.Visible = vis(2)
        PictureBox4.Visible = vis(3)
        PictureBox5.Visible = vis(4)
        PictureBox6.Visible = vis(5)
        PictureBox7.Visible = vis(6)
        PictureBox8.Visible = vis(7)
        PictureBox9.Visible = vis(8)


        If (clicked(7) = False) Then
            contador = contador + 1
            clicked(7) = True
        End If

        If (contador = 8) Then
            MsgBox("Has ganado")
        End If

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        vis(0) = PictureBox1.Visible
        vis(1) = PictureBox2.Visible
        vis(2) = PictureBox3.Visible
        vis(3) = PictureBox4.Visible
        vis(4) = PictureBox5.Visible
        vis(5) = PictureBox6.Visible
        vis(6) = PictureBox7.Visible
        vis(7) = PictureBox8.Visible
        vis(8) = PictureBox9.Visible

        Randomize()
        Dim value1 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value1) = 0
        Randomize()
        Dim value2 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value2) = 0
        Randomize()
        Dim value3 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value3) = 0
        Randomize()
        Dim value4 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value4) = 1

        Randomize()
        Dim value5 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value5) = 1

        Randomize()
        Dim value6 As Integer = CInt(Int((8 * Rnd()) + 0))

        vis(value6) = 1

        PictureBox1.Visible = vis(0)
        PictureBox2.Visible = vis(1)
        PictureBox3.Visible = vis(2)
        PictureBox4.Visible = vis(3)
        PictureBox5.Visible = vis(4)
        PictureBox6.Visible = vis(5)
        PictureBox7.Visible = vis(6)
        PictureBox8.Visible = vis(7)
        PictureBox9.Visible = vis(8)


        If (clicked(8) = False) Then
            contador = contador + 1
            clicked(8) = True
        End If

        If (contador = 8) Then
            MsgBox("Has ganado")
        End If

    End Sub

End Class

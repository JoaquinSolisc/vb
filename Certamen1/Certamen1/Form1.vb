Public Class Form1
    Dim lab As Label()
    Dim posY, posX As Integer
    Dim a As Integer
    Dim u, d, t, c As Integer
    Dim u2, d2, t2, c2 As Integer
    Dim k As Integer
    Dim cd As Integer
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label252.Click
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label251.Click
        If k = 1 Then
            lab(u2).BackColor = Color.White
            lab(d2).BackColor = Color.White
            lab(t2).BackColor = Color.White
            lab(c2).BackColor = Color.White
        End If
        u = 5
        d = 15
        t = 25
        c = 35
        If k = 1 Then
            lab(u).BackColor = Color.Red
            lab(d).BackColor = Color.Red
            lab(t).BackColor = Color.Red
            lab(c).BackColor = Color.Red
        End If
        u2 = u
        d2 = d
        t2 = t
        c2 = c
        cd = 5
        If k = 0 Then
            crear_label()

        End If

        k = 1

        Timer1.Start()

    End Sub

    Private Sub crear_label()
        a = 0
        posY = 100
        posX = 420
        lab = New Label(250) {}

        For i = 1 To 25
            posY += 20
            posX = 420
            For j = 1 To 10
                a = a + 1
                lab(a) = New Label()
                lab(a).AutoSize = False
                lab(a).Size = New Size(20, 20)
                lab(a).Location = New Point(posX, posY)
                lab(a).BorderStyle = BorderStyle.FixedSingle
                If a = 5 Or a = 15 Or a = 25 Or a = 35 Then
                    lab(a).BackColor = Color.Red
                Else
                    lab(a).BackColor = Color.White
                End If
                Me.Controls.Add(lab(a))
                posX += 20
            Next
        Next


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lab(u2).BackColor = Color.White
        lab(d2).BackColor = Color.White
        lab(t2).BackColor = Color.White
        lab(c2).BackColor = Color.White
        u += 10
        d += 10
        t += 10
        c += 10
        u2 = u
        d2 = d
        t2 = t
        c2 = c

        lab(u).BackColor = Color.Red
        lab(d).BackColor = Color.Red
        lab(t).BackColor = Color.Red
        lab(c).BackColor = Color.Red
        If c > 240 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        u = 5
        d = 15
        t = 25
        c = 35
        k = 0
        cd = 5

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 37
                If cd > 1 Then
                    u -= 1
                    d -= 1
                    t -= 1
                    c -= 1
                    cd = cd - 1
                End If
            Case 39
                If cd < 10 Then
                    u += 1
                    d += 1
                    t += 1
                    c += 1
                    cd = cd + 1
                End If
            Case Keys.Escape
                End

        End Select

    End Sub
End Class

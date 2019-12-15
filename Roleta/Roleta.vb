Public Class Roleta
    Dim sorteado As Boolean = False
    Dim NumeroSorteado As Integer

    Private Sub btnGirar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGirar.Click
        'Randomize()
        'Dim numero As Integer

        'btn1.Text = CDec(Int(Rnd() * 10))
        lblInformacao.Text = "SORTEIO EM ANDAMENTO"
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        btnGirar.Enabled = False
        Timer1.Enabled = True
        Randomize()

        If sorteado = False Then
            NumeroSorteado = CDec(Int(Rnd() * 50))
            If NumeroSorteado = 0 Then
                Label1.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 1 Then
                Label2.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 2 Then
                Label3.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 3 Then
                Label4.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 4 Then
                Label5.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 5 Then
                Label6.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 6 Then
                Label7.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 7 Then
                Label8.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 8 Then
                Label9.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 9 Then
                Label10.BackColor = Color.Chocolate
            End If

            If NumeroSorteado = 10 Then
                Label11.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 11 Then
                Label12.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 12 Then
                Label13.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 13 Then
                Label14.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 14 Then
                Label15.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 15 Then
                Label16.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 16 Then
                Label17.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 17 Then
                Label18.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 18 Then
                Label19.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 19 Then
                Label20.BackColor = Color.Chocolate
            End If

            If NumeroSorteado = 20 Then
                Label21.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 21 Then
                Label22.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 22 Then
                Label23.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 23 Then
                Label24.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 24 Then
                Label25.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 25 Then
                Label26.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 26 Then
                Label27.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 27 Then
                Label28.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 28 Then
                Label29.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 29 Then
                Label30.BackColor = Color.Chocolate
            End If

            If NumeroSorteado = 30 Then
                Label31.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 31 Then
                Label32.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 32 Then
                Label33.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 33 Then
                Label34.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 34 Then
                Label35.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 35 Then
                Label36.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 36 Then
                Label37.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 37 Then
                Label38.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 38 Then
                Label39.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 39 Then
                Label40.BackColor = Color.Chocolate
            End If

            If NumeroSorteado = 40 Then
                Label41.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 41 Then
                Label42.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 42 Then
                Label43.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 43 Then
                Label44.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 44 Then
                Label45.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 45 Then
                Label46.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 46 Then
                Label47.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 47 Then
                Label48.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 48 Then
                Label49.BackColor = Color.Chocolate
            ElseIf NumeroSorteado = 49 Then
                Label50.BackColor = Color.Chocolate
            End If
            sorteado = True
        End If



        If Label1.BackColor = Color.Chocolate Then
            Label2.BackColor = Color.Chocolate
            Label1.BackColor = Color.Cyan
        ElseIf Label2.BackColor = Color.Chocolate Then
            Label3.BackColor = Color.Chocolate
            Label2.BackColor = Color.Cyan
        ElseIf Label3.BackColor = Color.Chocolate Then
            Label4.BackColor = Color.Chocolate
            Label3.BackColor = Color.Cyan
        ElseIf Label4.BackColor = Color.Chocolate Then
            Label5.BackColor = Color.Chocolate
            Label4.BackColor = Color.Cyan
        ElseIf Label5.BackColor = Color.Chocolate Then
            Label6.BackColor = Color.Chocolate
            Label5.BackColor = Color.Cyan
        ElseIf Label6.BackColor = Color.Chocolate Then
            Label7.BackColor = Color.Chocolate
            Label6.BackColor = Color.Cyan
        ElseIf Label7.BackColor = Color.Chocolate Then
            Label8.BackColor = Color.Chocolate
            Label7.BackColor = Color.Cyan
        ElseIf Label8.BackColor = Color.Chocolate Then
            Label9.BackColor = Color.Chocolate
            Label8.BackColor = Color.Cyan
        ElseIf Label9.BackColor = Color.Chocolate Then
            Label10.BackColor = Color.Chocolate
            Label9.BackColor = Color.Cyan
        ElseIf Label10.BackColor = Color.Chocolate Then
            Label11.BackColor = Color.Chocolate
            Label10.BackColor = Color.Cyan
        ElseIf Label11.BackColor = Color.Chocolate Then
            Label12.BackColor = Color.Chocolate
            Label11.BackColor = Color.Cyan
        ElseIf Label12.BackColor = Color.Chocolate Then
            Label13.BackColor = Color.Chocolate
            Label12.BackColor = Color.Cyan
        ElseIf Label13.BackColor = Color.Chocolate Then
            Label14.BackColor = Color.Chocolate
            Label13.BackColor = Color.Cyan
        ElseIf Label14.BackColor = Color.Chocolate Then
            Label15.BackColor = Color.Chocolate
            Label14.BackColor = Color.Cyan
        ElseIf Label15.BackColor = Color.Chocolate Then
            Label16.BackColor = Color.Chocolate
            Label15.BackColor = Color.Cyan
        ElseIf Label16.BackColor = Color.Chocolate Then
            Label17.BackColor = Color.Chocolate
            Label16.BackColor = Color.Cyan
        ElseIf Label17.BackColor = Color.Chocolate Then
            Label18.BackColor = Color.Chocolate
            Label17.BackColor = Color.Cyan
        ElseIf Label18.BackColor = Color.Chocolate Then
            Label19.BackColor = Color.Chocolate
            Label18.BackColor = Color.Cyan
        ElseIf Label19.BackColor = Color.Chocolate Then
            Label20.BackColor = Color.Chocolate
            Label19.BackColor = Color.Cyan
        ElseIf Label20.BackColor = Color.Chocolate Then
            Label21.BackColor = Color.Chocolate
            Label20.BackColor = Color.Cyan
        ElseIf Label21.BackColor = Color.Chocolate Then
            Label22.BackColor = Color.Chocolate
            Label21.BackColor = Color.Cyan
        ElseIf Label22.BackColor = Color.Chocolate Then
            Label23.BackColor = Color.Chocolate
            Label22.BackColor = Color.Cyan
        ElseIf Label23.BackColor = Color.Chocolate Then
            Label24.BackColor = Color.Chocolate
            Label23.BackColor = Color.Cyan
        ElseIf Label24.BackColor = Color.Chocolate Then
            Label25.BackColor = Color.Chocolate
            Label24.BackColor = Color.Cyan
        ElseIf Label25.BackColor = Color.Chocolate Then
            Label26.BackColor = Color.Chocolate
            Label25.BackColor = Color.Cyan
        ElseIf Label26.BackColor = Color.Chocolate Then
            Label27.BackColor = Color.Chocolate
            Label26.BackColor = Color.Cyan
        ElseIf Label27.BackColor = Color.Chocolate Then
            Label28.BackColor = Color.Chocolate
            Label27.BackColor = Color.Cyan
        ElseIf Label28.BackColor = Color.Chocolate Then
            Label29.BackColor = Color.Chocolate
            Label28.BackColor = Color.Cyan
        ElseIf Label29.BackColor = Color.Chocolate Then
            Label30.BackColor = Color.Chocolate
            Label29.BackColor = Color.Cyan
        ElseIf Label30.BackColor = Color.Chocolate Then
            Label31.BackColor = Color.Chocolate
            Label30.BackColor = Color.Cyan
        ElseIf Label31.BackColor = Color.Chocolate Then
            Label32.BackColor = Color.Chocolate
            Label31.BackColor = Color.Cyan
        ElseIf Label32.BackColor = Color.Chocolate Then
            Label33.BackColor = Color.Chocolate
            Label32.BackColor = Color.Cyan
        ElseIf Label33.BackColor = Color.Chocolate Then
            Label34.BackColor = Color.Chocolate
            Label33.BackColor = Color.Cyan
        ElseIf Label34.BackColor = Color.Chocolate Then
            Label35.BackColor = Color.Chocolate
            Label34.BackColor = Color.Cyan
        ElseIf Label35.BackColor = Color.Chocolate Then
            Label36.BackColor = Color.Chocolate
            Label35.BackColor = Color.Cyan
        ElseIf Label36.BackColor = Color.Chocolate Then
            Label37.BackColor = Color.Chocolate
            Label36.BackColor = Color.Cyan
        ElseIf Label37.BackColor = Color.Chocolate Then
            Label38.BackColor = Color.Chocolate
            Label37.BackColor = Color.Cyan
        ElseIf Label38.BackColor = Color.Chocolate Then
            Label39.BackColor = Color.Chocolate
            Label38.BackColor = Color.Cyan
        ElseIf Label39.BackColor = Color.Chocolate Then
            Label40.BackColor = Color.Chocolate
            Label39.BackColor = Color.Cyan
        ElseIf Label40.BackColor = Color.Chocolate Then
            Label41.BackColor = Color.Chocolate
            Label40.BackColor = Color.Cyan
        ElseIf Label41.BackColor = Color.Chocolate Then
            Label42.BackColor = Color.Chocolate
            Label41.BackColor = Color.Cyan
        ElseIf Label42.BackColor = Color.Chocolate Then
            Label43.BackColor = Color.Chocolate
            Label42.BackColor = Color.Cyan
        ElseIf Label43.BackColor = Color.Chocolate Then
            Label44.BackColor = Color.Chocolate
            Label43.BackColor = Color.Cyan
        ElseIf Label44.BackColor = Color.Chocolate Then
            Label45.BackColor = Color.Chocolate
            Label44.BackColor = Color.Cyan
        ElseIf Label45.BackColor = Color.Chocolate Then
            Label46.BackColor = Color.Chocolate
            Label45.BackColor = Color.Cyan
        ElseIf Label46.BackColor = Color.Chocolate Then
            Label47.BackColor = Color.Chocolate
            Label46.BackColor = Color.Cyan
        ElseIf Label47.BackColor = Color.Chocolate Then
            Label48.BackColor = Color.Chocolate
            Label47.BackColor = Color.Cyan
        ElseIf Label48.BackColor = Color.Chocolate Then
            Label49.BackColor = Color.Chocolate
            Label48.BackColor = Color.Cyan
        ElseIf Label49.BackColor = Color.Chocolate Then
            Label50.BackColor = Color.Chocolate
            Label49.BackColor = Color.Cyan
        ElseIf Label50.BackColor = Color.Chocolate Then
            Label1.BackColor = Color.Chocolate
            Label50.BackColor = Color.Cyan

        End If

        If Timer1.Interval = 1000 Then
            Timer1.Stop()
        End If

        If Timer1.Interval <= 30 Then
            Timer1.Interval = Timer1.Interval + 1
        ElseIf Timer1.Interval < 200 Then
            Timer1.Interval = Timer1.Interval + 5
        ElseIf Timer1.Interval < 500 Then
            Timer1.Interval = Timer1.Interval + 10
        ElseIf Timer1.Interval < 800 Then
            Timer1.Interval = Timer1.Interval + 16
        Else
            Timer1.Interval = Timer1.Interval + 24
        End If

        If Timer1.Interval >= 1000 Then
            lblInformacao.Text = "O SORTEIO TERMINOU"
            Timer1.Stop()
            btnGirar.Enabled = True
            Timer1.Interval = 1
            sorteado = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.facebook.com/pages/Dr-Hardware/385320148204842?bookmark_t=page")
    End Sub
End Class
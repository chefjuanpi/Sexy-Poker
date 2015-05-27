Public Class frmPoker

    '''<sumary>
    ''' PROGRAM SEXY POKER
    ''' TP 3 de P34 fait par Pablo Aguilar-Lliguin   1336287
    ''' 
    ''' date de creation: 24 Fevrier 2014
    ''' 
    ''' date de revition: 04 Mars 2014
    ''' 
    ''' frmPoker
    ''' Fénetre principal du jeu, ici nous van a jouer le POKER!!
    ''' </sumary>

    Public Paquet(51) As Integer      'Paquet de 52 cartes
    Public main(4) As String           'main de 5 cartes
    Public carte_a_changer As Integer 'Combien cartes sont changés
    Public cartes_joue As Integer      'cartes deja sorti du paquet
    Public jeu As Integer               ' moment dans le jeu
    Private result As Byte          'cartes gagnant

    Private Sub frmPoker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initilise le fenetre avec l'info du module et metre tout a zero
        lblNom.Text = nom
        txtCredits.Text = credits
        Tourner_cartes()
        Debloquer_cartes(False)
        Melanger_Paquet()
    End Sub

    Private Sub Tourner_cartes()
        ' Metre toutes les cartes dans la meme image, et efface les messages existant
        For Each i In panCartes.Controls()
            For Each carte In i.Controls()
                If (carte.Tag = "carte") Then
                    carte.Image = My.Resources.Resources.back
                End If
            Next
        Next
        For i = 0 To 4
            main(i) = ""
        Next
        result = 0
        lblResult.Text = ""
        lblWow.Text = ""
        lblstMsg.Text = ""
        PanWinner.Visible = False
        panPrix.Visible = False
        panMise.Enabled = True
        cmdJouer.Text = "Donner Cartes"
    End Sub

    Private Sub Debloquer_cartes(op As Boolean)
        'Bloquer et debloquer les cartes
        For Each i In panCartes.Controls()
            i.Enabled = op
        Next
    End Sub

    Private Sub Melanger_Paquet()
        'initialicer Paquet
        For i = 0 To Paquet.GetUpperBound(0)
            Paquet(i) = i
        Next
        ' Initialiser compteur du paquet
        cartes_joue = 0
        'melanger Paquet
        Dim un As New Random
        Dim change, change2, temp As Integer
        For i = 0 To 5000
            change = un.Next(52)
            change2 = un.Next(52)
            temp = Paquet(change)
            Paquet(change) = Paquet(change2)
            Paquet(change2) = temp
        Next
    End Sub

    Private Sub cmdJouer_Click(sender As Object, e As EventArgs) Handles cmdJouer.Click

        If cartes_joue > 41 Then
            'controle si reste suffisantes cartes dans le paquet pour continuer de jouer
            'demande melanger de nouveau ou sortir du jeu
            If (MsgBox(" Les Cartes sont terminer, Voulez-vous mélanger le paquet ?", MsgBoxStyle.YesNo, "Confirmation") _
                        = MsgBoxResult.No) Then
                cmdQuitter.PerformClick()
                Exit Sub
            Else
                Melanger_Paquet()
            End If
        End If
        If (valider_Argent() = False) Then  'controle les credits d'utilisateur
            Exit Sub
        End If

        repartir_cartes()    ' Donner les cartes et jouer

    End Sub

    Private Function valider_Argent() As Boolean
        ' valide combien Argent reste, aussi si l'utilisateur avez suffisante argen pour le 
        ' Mise selectionnée

        If (Pont.credits < 1) Then
            If (MsgBox("Vouz n'avez pas de credits, Voulez_vous acheter ?", MsgBoxStyle.YesNo, _
                       "pobreté") = MsgBoxResult.Yes) Then
                frmWellcome.Show()
                Me.Close()
            End If
            valider_Argent = False
            Exit Function
        End If

        If (valeur_mise() = 0) Then
            MsgBox("selectioner un valeur Mise pour jouer")
            valider_Argent = False
            Exit Function
        End If

        If (valeur_mise() > Pont.credits) Then
            MsgBox("Vous n'avez pas suffisante argent, selectionez un valeur plus petit")
            valider_Argent = False
            Exit Function
        End If
        valider_Argent = True
    End Function

    Private Function valeur_mise() As Integer
        ' Dtermine le valeur de mise pour Jouer
        Dim i As Integer
        For Each x In panMise.Controls()
            If (x.Checked = True) Then
                i = Convert.ToInt32(x.Text)
            End If
        Next
        Return i
    End Function

    Private Sub repartir_cartes()
        Select Case jeu
            Case 0          ' repartir 5 cartes
                Pont.credits = Pont.credits - valeur_mise()
                txtCredits.Text = Pont.credits
                For Each i In panCartes.Controls()
                    For Each carte In i.Controls()
                        If (carte.Tag = "carte") Then
                            ' Prend un carte du imagelist et le affiche a l'écran
                            carte.Image = Cartes.Images(Paquet(cartes_joue))
                            'Garder le nom du carte joue
                            carte.Image.Tag = Cartes.Images.Keys(Paquet(cartes_joue))
                            'coupe le tag pour garder seulement l'information importante
                            carte.Image.Tag = carte.Image.Tag.Substring(0, 3)
                            ' Marquer les cartes deja joue du paquet
                            cartes_joue += 1
                        End If
                    Next
                Next
                jeu = 1
                cmdJouer.Text = "Changer Cartes"
                panMise.Enabled = False
                Debloquer_cartes(True)
            Case 1          'repartir les cartes selectionées
                For Each i In panCartes.Controls()
                    If (i.BackColor = Color.DarkRed) Then
                        i.BackColor = Color.DarkGreen
                        For Each carte In i.Controls()
                            If (carte.Tag = "carte") Then
                                ' Prend un carte du imagelist et le affiche a l'écran
                                carte.Image = Cartes.Images(Paquet(cartes_joue))
                                ' garde dans le tag de l'image son nom
                                carte.Image.Tag = Cartes.Images.Keys(Paquet(cartes_joue))
                                'coupe le tag pour garder seulement l'information importante
                                carte.Image.Tag = carte.Image.Tag.Substring(0, 3)
                                ' Marquer les cartes deja joue du paquet
                                cartes_joue += 1
                            Else
                                carte.Text = ""
                            End If
                        Next
                    End If
                Next
                Debloquer_cartes(False)
                'obtien le valeur des cartes du jeu
                Obtenir_Ma_Main()
                ' compare les cartes pour determiner jeu gagnant
                chercher_jeu_Gagnant()
                ' affiche a l'écran le jeu gagnat
                Afficher_Gagnant()
                'Calcule et garde le prix gagne
                calculer_Prix()
                'marque le jeu pour recomencer
                jeu = 2
                cmdJouer.Text = "Nouvelles Cartes"
            Case 2
                'recomence le jeu
                Tourner_cartes()
                jeu = 0
        End Select
    End Sub

    Private Sub carte_Click(sender As Object, e As EventArgs) Handles pic5.Click, pic4.Click, pic3.Click, pic2.Click, pic1.Click
        'marque les cartes a changer du paquet
        For Each i In panCartes.Controls()
            If (i.Controls.Contains(sender)) Then
                For Each label In i.Controls()
                    If (label.Tag = "lbl") Then
                        If (label.Text = "Changer") Then
                            label.Text = ""
                            carte_a_changer -= 1
                        Else
                            label.Text = "Changer"
                            carte_a_changer += 1
                        End If
                    End If
                Next
                If (i.BackColor = Color.DarkRed) Then
                    i.BackColor = Color.DarkGreen
                Else
                    i.BackColor = Color.DarkRed
                End If
            End If
        Next
    End Sub

    Private Sub Obtenir_Ma_Main()
        'determiner le main avec les tag de chacque image
        Dim x As Byte
        For Each y In panCartes.Controls()
            For Each carte In y.Controls()
                If (carte.Tag = "carte") Then
                    main(x) = carte.Image.Tag
                    x += 1
                End If
            Next
        Next
        ' metre en orden les cartes
        Array.Sort(main)
    End Sub

    Private Sub chercher_jeu_Gagnant()
        'paser la main pour diferentes filtres pour determiner le jeu gagnant
        pair()
        deuxpaires_brelan_full_carre()
        outres_jeu()
    End Sub

    Private Sub pair()
        'determiner si existe un pair
        Dim X, Y, un, deux As Integer
        For X = 0 To 3
            un = Convert.ToInt32(main(X).Substring(0, 2))
            deux = Convert.ToInt32(main(X + 1).Substring(0, 2))

            If ((un > 10 Or un = 1) And un = deux) Then
                Y = Y + 1
            End If
        Next X
        If Y = 1 Then
            result = 1
        End If
    End Sub

    Private Sub deuxpaires_brelan_full_carre()
        Dim a, b, c, d, f As Integer

        a = Convert.ToInt32(main(0).Substring(0, 2))
        b = Convert.ToInt32(main(1).Substring(0, 2))
        c = Convert.ToInt32(main(2).Substring(0, 2))
        d = Convert.ToInt32(main(3).Substring(0, 2))
        f = Convert.ToInt32(main(4).Substring(0, 2))

        ' recherche deux paires
        If (a = b) And (c = d) And (b <> c) And (d <> f) Then
            result = 2
        End If
        If (b = c) And (d = f) And (a <> b) And (c <> d) Then
            result = 2
        End If
        If (a = b) And (d = f) And (c <> d) And (b <> c) Then
            result = 2
        End If

        'recherche brelan
        If (a = b) And (b = c) And (c <> d) And (d <> f) Then
            result = 3
        End If
        If (b = c) And (c = d) And (a <> b) And (d <> f) Then
            result = 3
        End If
        If (c = d) And (d = f) And (a <> b) And (b <> c) Then
            result = 3
        End If

        'Recherche carré
        If (a = b) And (b = c) And (c = d) Then
            result = 7
        End If
        If (b = c) And (c = d) And (d = f) Then
            result = 7
        End If

        'recherche full
        If (a = b) And (b = c) And (d = f) Then
            result = 6
        End If
        If (a = b) And (c = d) And (d = f) Then
            result = 6
        End If
    End Sub

    Private Sub outres_jeu()
        Dim couleur = Tester_Couleur()
        Dim a, b, c, d, f As Integer
        a = Convert.ToInt32(main(0).Substring(0, 2))
        b = Convert.ToInt32(main(1).Substring(0, 2))
        c = Convert.ToInt32(main(2).Substring(0, 2))
        d = Convert.ToInt32(main(3).Substring(0, 2))
        f = Convert.ToInt32(main(4).Substring(0, 2))

        ' Recherche Quinte
        If couleur <> 4 Then
            If (b = a + 1) And (c = a + 2) And (d = a + 3) And (f = a + 4) Then
                result = 4
            End If
            If (a = 1) And (b = 10) And (c = 11) And (d = 12) And (f = 13) Then
                result = 4
            End If
        Else
            'tous les cartes de meme couleur est le jeu couleur
            result = 5
            'recherche flush
            If (b = a + 1) And (c = a + 2) And (d = a + 3) And (f = a + 4) Then
                result = 8
            End If
            'recherche flush royale
            If (a = 1) And (b = 10) And (c = 11) And (d = 12) And (f = 13) Then
                result = 9
            End If
        End If
    End Sub

    Private Function Tester_Couleur() As Integer
        'recherche si les cartes sont du meme couleur or non
        Dim X, Y As Integer
        Dim un, deux As String
        For X = 0 To 3
            un = main(X).Substring(2, 1)
            deux = main(X + 1).Substring(2, 1)

            If (un = deux) Then
                Y = Y + 1
            End If
        Next
        Return Y
    End Function

    Private Sub Afficher_Gagnant()
        'montrer a l'écran les mesages du Gagnant
        PanWinner.Visible = True

        Select Case result
            Case 0
                PanWinner.Visible = False
                lblstMsg.Text = "ohh... La prochaine fois"
            Case 1
                lblWow.Text = "WOW !!!!"
                lblResult.Text = "PAIR"
            Case 2
                lblWow.Text = "WOW !!!!"
                lblResult.Text = "DEUX PAIRES"
            Case 3
                lblWow.Text = "WOW !!!!"
                lblResult.Text = "BRELAN"
            Case 4
                lblWow.Text = "WOW !!!!"
                lblResult.Text = "QUINTE"
            Case 5
                lblWow.Text = "WOW !!!!"
                lblResult.Text = "COULEUR"
            Case 6
                lblWow.Text = "WOW !!!!"
                lblResult.Text = "FULL"
            Case 7
                lblWow.Text = "WOW !!!!"
                lblResult.Text = "CARRÉ"
            Case 8
                lblWow.Text = "WOW !!!!"
                lblResult.Text = "QUINTE FLUSH"
            Case 9
                lblWow.Text = "WOW !!!!"
                lblResult.Text = "QUINTE FLUSH ROYALE"
        End Select
    End Sub

    Private Sub calculer_Prix()
        'Determiner Prix et le adicioner aux crèdits
        Dim prix As Integer
        Select Case result
            Case 0
                Exit Sub
            Case 1
                prix = valeur_mise() * 1
                Pont.credits = Pont.credits + prix
                txtCredits.Text = Pont.credits
                panPrix.Visible = True
                txtGain.Text = prix.ToString()
            Case 2
                prix = valeur_mise() * 3
                Pont.credits = Pont.credits + prix
                txtCredits.Text = Pont.credits
                panPrix.Visible = True
                txtGain.Text = prix.ToString()
            Case 3
                prix = valeur_mise() * 5
                Pont.credits = Pont.credits + prix
                txtCredits.Text = Pont.credits
                panPrix.Visible = True
                txtGain.Text = prix.ToString()
            Case 4
                prix = valeur_mise() * 10
                Pont.credits = Pont.credits + prix
                txtCredits.Text = Pont.credits
                panPrix.Visible = True
                txtGain.Text = prix.ToString()
            Case 5
                prix = valeur_mise() * 15
                Pont.credits = Pont.credits + prix
                txtCredits.Text = Pont.credits
                panPrix.Visible = True
                txtGain.Text = prix.ToString()
            Case 6
                prix = valeur_mise() * 20
                Pont.credits = Pont.credits + prix
                txtCredits.Text = Pont.credits
                panPrix.Visible = True
                txtGain.Text = prix.ToString()
            Case 7
                prix = valeur_mise() * 25
                Pont.credits = Pont.credits + prix
                txtCredits.Text = Pont.credits
                panPrix.Visible = True
                txtGain.Text = prix.ToString()
            Case 8
                prix = valeur_mise() * 50
                Pont.credits = Pont.credits + prix
                txtGain.Text = prix.ToString()
                panPrix.Visible = True
                txtCredits.Text = Pont.credits
            Case 9
                prix = valeur_mise() * 100
                Pont.credits = Pont.credits + prix
                txtCredits.Text = Pont.credits
                panPrix.Visible = True
                txtGain.Text = prix.ToString()
        End Select
    End Sub

    Private Sub cmdQuitter_Click(sender As Object, e As EventArgs) Handles cmdQuitter.Click
        'Sortit d'laplication
        Pont.sortir()
    End Sub

    Private Sub cmdReglement_Click(sender As Object, e As EventArgs) Handles cmdReglement.Click
        'affiche le fenetre reglement
        Me.Cursor = Cursors.Default
        Dim reg = New frmReglement
        reg.ShowDialog()
    End Sub

    Private Sub frmPoker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'ferme le programme
        If (e.CloseReason.ToString() = "ApplicationExitCall") Then Return
        'dialog pour confirmer la fermeture du programe
        If (MsgBox("voulez-vous sortir ?", MsgBoxStyle.YesNo, "Attention") _
               = MsgBoxResult.No) Then
            e.Cancel = True
        Else
            Application.Exit()
        End If
    End Sub

End Class

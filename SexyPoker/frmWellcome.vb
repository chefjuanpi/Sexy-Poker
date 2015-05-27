Public Class frmWellcome
    '''<sumary>
    ''' PROGRAM SEXY POKER
    ''' TP 3 de P34 fait par Pablo Aguilar-Lliguin   1336287
    ''' 
    ''' date de creation: 24 Fevrier 2014
    ''' 
    ''' date de revition: 04 Mars 2014
    ''' 
    ''' frmWELLCOME:
    ''' Premier fenetre du jeu sexy poker, essay de creer une interaction entre
    ''' l'utilisateur et machine plus conviviale a l'aide d'un Timer
    ''' obtien le nom d'utilisateur et les crédits pour jouer
    ''' </sumary>

    Dim elle As Byte 'Comteur de actions Machine
    Dim toi As Byte   'Compteur actions du usager  

    Private Sub timAuto_Tick(sender As Object, e As EventArgs) Handles timAuto.Tick
        Select Case elle
            Case 0
                'obtenir le nom du Usager
                elle = 1
                lblElle.Text = "Votre nom ?"
                stlAlert.Text = "Écrivez votre nom et appuyez sur ENTER..."
                stBar.BackColor = Color.Green
                panToi.Visible = True
                txtToi.Focus()
                timAuto.Interval = 8000
                toi = 1
            Case 1
                'alert si l'utilisateur ne continue pas les actions
                lblElle.Text = "Êtes-vous là ?"
            Case 2
                'Obtenit les crédits pour Jouer
                timAuto.Interval = 8000
                elle = 1
                lblElle.Text = "Combien de crédits vous achetez ? ..."
                grpCase.Visible = True
                cbCredits.Focus()
                stBar.BackColor = Color.Yellow
                stlAlert.Text = "Sélectionez les crédits et appuyez sur ENTER pour continuer"
            Case Is = 3
                'ferme cette fenetre et passe L'action a le fenetre principale
                timAuto.Enabled = False
                Dim frm As New frmPoker
                frm.Show()
                toi = 11
                Me.Close()
        End Select
    End Sub

    Private Sub cmdEnter_Click_1(sender As Object, e As EventArgs) Handles cmdEnter.Click
        Select Case toi
            Case 1
                'Salue a l'utilisateur avec son Nom
                If txtToi.Text = "" Then
                    lblElle.Text = "Quel est votre nom ?"
                    Exit Sub
                End If
                toi = 2
                lblElle.Text = "Salut" + " " + txtToi.Text.Trim().ToUpper()
                nom = txtToi.Text.Trim().ToUpper()
                timAuto.Interval = 2000
                stlAlert.Text = ""
                elle = 2
            Case 2
                'faire le comprobation si le nom et crédits sont corrects
                If (cbCredits.SelectedItem = "") Then
                    MsgBox("Sélectionez combien de crédits")
                    Exit Sub
                End If
                If (MsgBox(" Votre nom et les crédits désirés sont-ils exacts ?", MsgBoxStyle.YesNo, "Confirmation") _
                        = MsgBoxResult.No) Then
                    elle = 0
                    timAuto_Tick(sender, e)
                    Exit Sub
                End If
                'si tout est correct montre le mesaje de change de fenetre
                elle = 3
                timAuto.Interval = 1500
                toi = 0
                credits = cbCredits.SelectedItem
                lblElle.Text = "Parfait!!  Allez jouer"
        End Select
    End Sub

    Private Sub frmWellcome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason.ToString() = "ApplicationExitCall") Then Exit Sub
        'dialog pour confirmer la fermeture du programe
        If (toi = 11) Then Exit Sub
        If (MsgBox("voulez-vous sortir ?", MsgBoxStyle.YesNo, "Attention") _
               = MsgBoxResult.No) Then
            e.Cancel = True
        Else
            Application.Exit()
        End If
    End Sub
End Class
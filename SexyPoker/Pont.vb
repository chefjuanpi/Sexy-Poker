Module Pont

    '''<sumary>
    ''' PROGRAM SEXY POKER
    ''' TP 3 de P34 fait par Pablo Aguilar-Lliguin   1336287
    ''' 
    ''' date de creation: 24 Fevrier 2014
    ''' 
    ''' date de revition: 04 Mars 2014
    ''' 
    ''' Pont.vb
    ''' est le module qui permet, créer fenetres independants, partager functions et
    ''' partager variables entre les fenetres
    ''' </sumary>

    'ici je fais la création d'un MAIN
    Public Sub Main()
        'méthode qui permet de démarrer l'application
        'Application.Run(New Form1) 'fenetre dépendante
        Dim frm As New frmWellcome
        frm.Show()
        Application.Run()
    End Sub

    'Function partaje pour fermer les fenetres
    Public Sub sortir()
        If (MsgBox(" Voulez-vous sortir ?", MsgBoxStyle.YesNo, "ATTENTION") = MsgBoxResult.No) Then Exit Sub
        Application.Exit()
    End Sub

    'variable globale qui permet transporter le nom du joueur
    Public nom As String = "hola Bruno"
    'variable globale qui permet Transporter les crédits du joueur
    Public credits As Integer = 100
End Module

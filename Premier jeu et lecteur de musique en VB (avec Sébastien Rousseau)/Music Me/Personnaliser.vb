Public Class frmPersonnaliser
    Public opaciteFormulaire As Integer = 100
    Public couleurDeFond As Color
    Public couleurDeFondDesListes As Color
    Public couleurPolice As Color
    Public imageDeFondPersonnalisee As Bitmap
    Public cheminImageDeFond As String


    Dim btnArretActive As Boolean
    Dim champsInformationActive As Boolean
    Dim MusicZActive As Boolean
    Dim trackbarMusique As Boolean
    Dim sourceVolume As Boolean


    Private Sub btnAdvancedColor_Click(sender As Object, e As EventArgs) Handles btnCouleurAvance.Click
        dialogueDeCouleur.ShowDialog()
        Procedures.DonnerCouleurFond(dialogueDeCouleur.Color)
        Procedures.ChargerProprieteFormulaire()
    End Sub


    Private Sub btnForeColorAdvanced_Click(sender As Object, e As EventArgs) Handles btnCouleurPoliceAvance.Click
        dialogueDeCouleur.ShowDialog()
        Procedures.DonnerCouleurPolice(dialogueDeCouleur.Color)
        Procedures.ChargerProprieteFormulaire()
    End Sub

    Private Sub btnImportPicture_Click(sender As Object, e As EventArgs) Handles btnImporterImage.Click
        ouvrirFichierDialogue.Title = "Ouvrir une image"
        ouvrirFichierDialogue.ShowDialog()
        Try
            cheminImageDeFond = ouvrirFichierDialogue.FileName.ToString
            imageDeFondPersonnalisee = New Bitmap(ouvrirFichierDialogue.FileName)
            frmMusicMe.BackgroundImageLayout = ImageLayout.Stretch
            frmMusicMe.BackgroundImage = imageDeFondPersonnalisee
        Catch ex As Exception
            MsgBox("Le fichier que vous avez choisi n'est pas compatible avec l'application" & vbCrLf & "Veuillez choisir un fichier image." & vbCrLf & "par exemple: *.jpeg ou*.png")
        End Try
        Procedures.SauvegarderProprieteVersFichier()
        Procedures.ChargerProprieteFormulaire()
    End Sub

    Private Sub btnNoPicture_Click(sender As Object, e As EventArgs) Handles btnEffacerImage.Click
        Dim effacerImageResultat As DialogResult

        If IsNothing(frmMusicMe.BackgroundImage) Then
            MsgBox("Il n'y a aucune image de fond")
        Else
            effacerImageResultat = MessageBox.Show("Ce bouton enlève l'image de fond." & vbCrLf & vbCrLf & "Êtes-vous sûr de vouloir l'enlever?" & vbCrLf, "Enlever l'image de fond", MessageBoxButtons.YesNo)

            If effacerImageResultat = Windows.Forms.DialogResult.Yes Then
                cheminImageDeFond = ""
                frmMusicMe.BackgroundImage = Nothing
            End If
            Procedures.SauvegarderProprieteVersFichier()
        End If
    End Sub

    Private Sub btnFontName_Click(sender As Object, e As EventArgs) Handles btnPolice.Click
        policeDialog.ShowDialog()
        Me.Font = policeDialog.Font
        frmMusicMe.Font = policeDialog.Font
        frmMusicMe.mmBarreDeMenu.Font = policeDialog.Font
    End Sub


    '***********************************************************
    '      Background color
    '***********************************************************                                'faire une procédure pour l'améliorer
    Private Sub picRed_Click(sender As Object, e As EventArgs) Handles picRouge.Click
        DonnerCouleurFond(picRouge.BackColor)
    End Sub

    Private Sub picOrange_Click(sender As Object, e As EventArgs) Handles picOrange.Click
        DonnerCouleurFond(picOrange.BackColor)
    End Sub

    Private Sub picYellow_Click(sender As Object, e As EventArgs) Handles picJaune.Click
        DonnerCouleurFond(picJaune.BackColor)
    End Sub

    Private Sub picGreen_Click(sender As Object, e As EventArgs) Handles picVert.Click
        DonnerCouleurFond(picVert.BackColor)
    End Sub

    Private Sub picCyan_Click(sender As Object, e As EventArgs) Handles picCyan.Click
        DonnerCouleurFond(picCyan.BackColor)
    End Sub

    Private Sub picBlue_Click(sender As Object, e As EventArgs) Handles picBleu.Click
        DonnerCouleurFond(picBleu.BackColor)
    End Sub

    Private Sub picPink_Click(sender As Object, e As EventArgs) Handles picRose.Click
        DonnerCouleurFond(picRose.BackColor)
    End Sub

    Private Sub picWhite_Click(sender As Object, e As EventArgs) Handles picBlanc.Click
        DonnerCouleurFond(picBlanc.BackColor)
    End Sub

    Private Sub picGrey1_Click(sender As Object, e As EventArgs) Handles picGris1.Click
        DonnerCouleurFond(picGris1.BackColor)
    End Sub

    Private Sub picGrey2_Click(sender As Object, e As EventArgs) Handles picGris2.Click
        DonnerCouleurFond(picGris2.BackColor)
    End Sub

    Private Sub picGrey3_Click(sender As Object, e As EventArgs) Handles picGris3.Click
        DonnerCouleurFond(picGris3.BackColor)
    End Sub

    Private Sub picGrey4_Click(sender As Object, e As EventArgs) Handles picGris4.Click
        DonnerCouleurFond(picGris4.BackColor)
    End Sub

    Private Sub picBlack_Click(sender As Object, e As EventArgs) Handles picNoir.Click
        DonnerCouleurFond(picNoir.BackColor)
    End Sub

    Private Sub picTransparent_Click(sender As Object, e As EventArgs) Handles picTransparent.Click
        opaciteFormulaire = CInt(InputBox("Écrivez un nombre entre 0 et 100" & vbCrLf & "pour le niveau de transparence", "Transparent"))
        Select Case opaciteFormulaire
            Case 0 To 100
                frmMusicMe.Opacity = CSng(opaciteFormulaire / 100)
            Case Is > 100
                frmMusicMe.Opacity = 1
            Case Is < 0
                frmMusicMe.Opacity = 0
                'Case Else is impossible to get to
        End Select
        Procedures.SauvegarderProprieteVersFichier()
        Procedures.ChargerProprieteFormulaire()

    End Sub



    '***********************************************************
    '      Font color (foreColor)
    '***********************************************************

    Private Sub picFontRed_Click(sender As Object, e As EventArgs) Handles picPoliceRouge.Click
        Procedures.DonnerCouleurPolice(picPoliceRouge.BackColor)
    End Sub

    Private Sub picFontOrange_Click(sender As Object, e As EventArgs) Handles picPoliceOrange.Click
        Procedures.DonnerCouleurPolice(picPoliceOrange.BackColor)
    End Sub

    Private Sub picFontYellow_Click(sender As Object, e As EventArgs) Handles picPoliceJaune.Click
        Procedures.DonnerCouleurPolice(picPoliceJaune.BackColor)
    End Sub

    Private Sub picFontGreen_Click(sender As Object, e As EventArgs) Handles picPoliceVert.Click
        Procedures.DonnerCouleurPolice(picPoliceVert.BackColor)
    End Sub

    Private Sub picFontCyan_Click(sender As Object, e As EventArgs) Handles picPoliceCyan.Click
        Procedures.DonnerCouleurPolice(picPoliceCyan.BackColor)
    End Sub

    Private Sub picFontBlue_Click(sender As Object, e As EventArgs) Handles picPoliceBleu.Click
        Procedures.DonnerCouleurPolice(picPoliceBleu.BackColor)
    End Sub

    Private Sub picFontPink_Click(sender As Object, e As EventArgs) Handles picPoliceRose.Click
        Procedures.DonnerCouleurPolice(picPoliceRose.BackColor)
    End Sub

    Private Sub picFontWhite_Click(sender As Object, e As EventArgs) Handles picPoliceBlanc.Click
        Procedures.DonnerCouleurPolice(picPoliceBlanc.BackColor)
    End Sub

    Private Sub picFontGrey1_Click(sender As Object, e As EventArgs) Handles picPoliceGris1.Click
        Procedures.DonnerCouleurPolice(picPoliceGris1.BackColor)
    End Sub

    Private Sub picFontGrey2_Click(sender As Object, e As EventArgs) Handles picPoliceGris2.Click
        Procedures.DonnerCouleurPolice(picPoliceGris2.BackColor)
    End Sub

    Private Sub picFontGrey3_Click(sender As Object, e As EventArgs) Handles picPoliceGris3.Click
        Procedures.DonnerCouleurPolice(picPoliceGris3.BackColor)
    End Sub

    Private Sub picFontGrey4_Click(sender As Object, e As EventArgs) Handles picPoliceGris4.Click
        Procedures.DonnerCouleurPolice(picPoliceGris4.BackColor)
    End Sub

    Private Sub picFontBlack_Click(sender As Object, e As EventArgs) Handles picPoliceNoir.Click
        Procedures.DonnerCouleurPolice(picPoliceNoir.BackColor)
    End Sub

    Private Sub picFontDarkGreen_Click(sender As Object, e As EventArgs) Handles picPoliceVertFonce.Click
        Procedures.DonnerCouleurPolice(picPoliceVertFonce.BackColor)
    End Sub

    Private Sub btnSavePersonnaliser_Click(sender As Object, e As EventArgs) Handles btnSavePersonnaliser.Click
        Dim texteAEcrire As String = ""
        Dim ecriveurFichier As New System.IO.StreamWriter(".\properties.txt")

        texteAEcrire = "fond d'écran:" & cheminImageDeFond & vbCrLf & _
                      "hauteur du bouton play/pause:" & txtShowPlayHeight.Text & vbCrLf & _
                      "Largeur du bouton play/pause:" & txtShowPlayWidth.Text & vbCrLf & _
                      "hauteur du bouton stop:" & txtShowStopHeight.Text & vbCrLf & _
                      "largeur du bouton stop:" & txtShowStopWidth.Text & vbCrLf & _
                      "hauteur de la barre de menu:" & txtShowMenuBarHeight.Text & vbCrLf & _
                      "largeur de la barre de menu:" & txtShowMenuBarWidth.Text & vbCrLf & _
                      "hauteur de la liste de listes de Music:" & txtShowPlaylistHeight.Text & vbCrLf & _
                      "largeur de la liste de listes de Music:" & txtShowPlaylistWidth.Text & vbCrLf & _
                      "hauteur de la liste de Music:" & txtShowlisteMusiqueHeight.Text & vbCrLf & _
                      "largeur de la liste de Music:" & txtShowlisteMusiqueWidth.Text & vbCrLf & _
                      "hauteur du champs d'information:" & txtShowSongInfoHeight.Text & vbCrLf & _
                      "largeur du champs d'information:" & txtShowSongInfoWidth.Text & vbCrLf & _
                      "hauteur du trackbar de la Music:" & txtShowTrackbarProgressHeight.Text & vbCrLf & _
                      "largeur du trackbar de la Music:" & txtShowTrackbarProgressWidth.Text & vbCrLf & _
                      "hauteur du trackbar du volume:" & txtShowTrackbarVolumeHeight.Text & vbCrLf & _
                      "largeur du trackbar du volume:" & txtShowTrackbarVolumeWidth.Text & vbCrLf & _
                      "afficher bouton stop:" & btnArretActive.ToString & vbCrLf & _
                      "afficher champs d'information:" & champsInformationActive.ToString & vbCrLf & _
                      "afficher Music Z:" & MusicZActive.ToString & vbCrLf & _
                      "afficher trackbar de la Music:" & trackbarMusique.ToString & vbCrLf & _
                      "volume (true=application, false=windows):" & sourceVolume.ToString


        ecriveurFichier.Flush()
        ecriveurFichier.Write(texteAEcrire)
        ecriveurFichier.Close()
        Me.Close()

    End Sub

    Private Sub picListRed_Click(sender As Object, e As EventArgs) Handles picListeRouge.Click
        frmMusicMe.lstMusique.BackColor = picListeRouge.BackColor
        frmMusicMe.lstlisteMusique.BackColor = picListeRouge.BackColor
    End Sub

    Private Sub picListOrange_Click(sender As Object, e As EventArgs) Handles picListeOrange.Click
        frmMusicMe.lstMusique.BackColor = picListeOrange.BackColor
        frmMusicMe.lstlisteMusique.BackColor = picListeOrange.BackColor
    End Sub

    Private Sub picListYellow_Click(sender As Object, e As EventArgs) Handles picListeJaune.Click
        frmMusicMe.lstMusique.BackColor = picListeJaune.BackColor
        frmMusicMe.lstlisteMusique.BackColor = picListeJaune.BackColor
    End Sub

    Private Sub picListGreen_Click(sender As Object, e As EventArgs) Handles picListeVert.Click
        frmMusicMe.lstMusique.BackColor = picListeVert.BackColor
        frmMusicMe.lstlisteMusique.BackColor = picListeVert.BackColor
    End Sub

    Private Sub picListCyan_Click(sender As Object, e As EventArgs) Handles picListeCyan.Click
        frmMusicMe.lstMusique.BackColor = picListeCyan.BackColor
        frmMusicMe.lstlisteMusique.BackColor = picListeCyan.BackColor
    End Sub

    Private Sub picListBlue_Click(sender As Object, e As EventArgs) Handles picListeBleu.Click
        frmMusicMe.lstMusique.BackColor = picListeBleu.BackColor
        frmMusicMe.lstlisteMusique.BackColor = picListeBleu.BackColor
    End Sub

    Private Sub picListPink_Click(sender As Object, e As EventArgs) Handles picListeRose.Click
        frmMusicMe.lstMusique.BackColor = picListeRose.BackColor
        frmMusicMe.lstlisteMusique.BackColor = picListeRose.BackColor
    End Sub

    Private Sub picListWhite_Click(sender As Object, e As EventArgs) Handles picListeBlanc.Click
        frmMusicMe.lstMusique.BackColor = picListeBlanc.BackColor()
        frmMusicMe.lstlisteMusique.BackColor = picListeBlanc.BackColor
    End Sub

    Private Sub picListGrey1_Click(sender As Object, e As EventArgs) Handles picListeGris1.Click
        frmMusicMe.lstMusique.BackColor = picListeGris1.BackColor
        frmMusicMe.lstlisteMusique.BackColor = picListeGris1.BackColor
    End Sub

    Private Sub picListGrey2_Click(sender As Object, e As EventArgs) Handles picListeGris2.Click
        frmMusicMe.lstMusique.BackColor = picListeGris2.BackColor
        frmMusicMe.lstlisteMusique.BackColor = picListeGris2.BackColor
    End Sub

    Private Sub picListGrey3_Click(sender As Object, e As EventArgs) Handles picListeGris3.Click
        frmMusicMe.lstMusique.BackColor = picListeGris3.BackColor
        frmMusicMe.lstlisteMusique.BackColor = picListeGris3.BackColor
    End Sub

    Private Sub picListGrey4_Click(sender As Object, e As EventArgs) Handles picListeGris4.Click
        frmMusicMe.lstMusique.BackColor = picListeGris4.BackColor
        frmMusicMe.lstlisteMusique.BackColor = picListeGris4.BackColor
    End Sub

    Private Sub picListBlack_Click(sender As Object, e As EventArgs) Handles picListeNoir.Click
        frmMusicMe.lstMusique.BackColor = picListeNoir.BackColor
        frmMusicMe.lstlisteMusique.BackColor = picListeNoir.BackColor
    End Sub

    Private Sub picListDarkGreen_Click(sender As Object, e As EventArgs) Handles picListeVertFonce.Click
        frmMusicMe.lstMusique.BackColor = picListeVertFonce.BackColor
        frmMusicMe.lstlisteMusique.BackColor = picListeVertFonce.BackColor
    End Sub

    Private Sub btnCustomButton_Click(sender As Object, e As EventArgs) Handles btnCouleurPersonnaliser.Click
        dialogueDeCouleur.ShowDialog()
        Procedures.DonnerCouleurFondListe(dialogueDeCouleur.Color)
        couleurDeFondDesListes = dialogueDeCouleur.Color
        Procedures.SauvegarderProprieteVersFichier()
        Procedures.ChargerProprieteFormulaire()
    End Sub

    Private Sub btnAutomaticColor_Click(sender As Object, e As EventArgs) Handles btnCouleurAutomatique.Click
        frmMusicMe.lstMusique.BackColor = Procedures.RetournerArgbFonce(frmMusicMe.lstMusique.Parent.BackColor.R, frmMusicMe.lstMusique.Parent.BackColor.G, frmMusicMe.lstMusique.Parent.BackColor.B)
        frmMusicMe.lstlisteMusique.BackColor = Procedures.RetournerArgbFonce(frmMusicMe.lstMusique.Parent.BackColor.R, frmMusicMe.lstMusique.Parent.BackColor.G, frmMusicMe.lstMusique.Parent.BackColor.B)
        couleurDeFondDesListes = frmMusicMe.lstMusique.BackColor
        Procedures.SauvegarderProprieteVersFichier()
        Procedures.ChargerProprieteFormulaire()
    End Sub

End Class
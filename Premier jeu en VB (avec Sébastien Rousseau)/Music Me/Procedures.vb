Imports Microsoft.DirectX
Imports Microsoft.DirectX.AudioVideoPlayback
Imports System.Drawing.Imaging
Imports System.IO

Module Procedures

    Public fichierCouleurFond As String
    Public fichierPolice As String
    Public fichierCouleurPolice As String
    Public listeMusique As New List(Of String)
    Public listeMusiqueNomSeulement As New List(Of String)

    'Procédures pour modifier les propriétés des contrôles et du formulaire

    Public Sub ChargerProprieteFormulaire()
        Dim ecriveurFichier As System.IO.StreamWriter

        'Préparation et variables
        ImporterProprieteDuFichier()

        If Not File.Exists(".\Music") Then
            Directory.CreateDirectory(".\Music")
        End If
        If Not System.IO.File.Exists(".\Dossiers.adv") Then
            ecriveurFichier = File.CreateText(".\Dossiers.adv")
            ecriveurFichier.WriteLine(".\Music,Dossier et sous-dossiers")
            ecriveurFichier.Close()
        End If
        If Not System.IO.Directory.Exists(".\listeDeLecture") Then
            System.IO.Directory.CreateDirectory(".\listeDeLecture")
        End If

        If frmPersonnaliser.optBoutonStopOn.Checked Then         'Le bouton stop est activé

            frmMusicMe.picArret.Visible = True    'le bouton stop est visible
            frmMusicMe.picArret.Enabled = True    'le bouton stop est disponible

            frmMusicMe.picJouerPause.Location = New Point(52, 47)    'Position du bouton play/pause
            frmMusicMe.picBoutonPrecedent.Location = New Point(11, 56)  'Position du bouton précédent
            frmMusicMe.picBoutonSuivant.Location = New Point(164, 56)   'position du bouton suivant
            frmMusicMe.picArret.Location = New Point(108, 47)


        Else                                                     'Le bouton stop est désactivé

            frmMusicMe.picArret.Visible = False     'le bouton stop est invisible
            frmMusicMe.picArret.Enabled = False     'le bouton stop est annulé

            frmMusicMe.picJouerPause.Location = New Point(CInt(CInt(frmMusicMe.trkVolume.Location.X + frmMusicMe.trkVolume.Width / 2) - frmMusicMe.picJouerPause.Width / 2), 47)   'Position bouton play/pause
            frmMusicMe.picBoutonPrecedent.Location = New Point(frmMusicMe.picJouerPause.Location.X - frmMusicMe.picBoutonPrecedent.Width, 56)                                     'Position bouton précédent
            frmMusicMe.picBoutonSuivant.Location = New Point(frmMusicMe.picJouerPause.Location.X + frmMusicMe.picJouerPause.Width, 56)                                             'Position bouton suivant

        End If
        'Traitements

        frmMusicMe.picJouerPause.BackgroundImage = My.Resources.PlayButton
        frmMusicMe.lblInformationMusique.TextAlign = ContentAlignment.MiddleCenter
        frmMusicMe.mmBarreDeMenu.BackColor = Color.FromArgb(75, Color.Black)
        frmMusicMe.lblInformationMusique.BackColor = Color.FromArgb(30, frmMusicMe.mmBarreDeMenu.BackColor)
        frmPersonnaliser.picTransparent.BackgroundImage = My.Resources.red_not_sign_transparent_md
        frmMusicMe.trkProgresMusique.BackColor = frmMusicMe.trkProgresMusique.Parent.BackColor
        frmMusicMe.trkVolume.BackColor = frmMusicMe.trkVolume.Parent.BackColor

        frmMusicMe.Width = Screen.PrimaryScreen.Bounds.Width
        frmMusicMe.Height = Screen.PrimaryScreen.Bounds.Height
        frmMusicMe.Location = New Point(0, 0)

    End Sub

    'Procédures pour importer et exporter (listes et Musics)

    Public Sub ImporterMusiqueParDossier()
        Dim chemin As String
        Dim optionRechercheText As String
        Dim optionRecherche As System.IO.SearchOption

        For Each dossier In System.IO.File.ReadLines(".\Dossiers.adv")
            chemin = dossier.Substring(0, dossier.IndexOf(","))
            optionRechercheText = dossier.Substring(dossier.IndexOf(",") + 1)
            If optionRechercheText = "Dossier seulement" Then
                optionRecherche = IO.SearchOption.TopDirectoryOnly
            ElseIf optionRechercheText = "Dossier et sous-dossiers" Then
                optionRecherche = IO.SearchOption.AllDirectories
            End If
            Procedures.ImporterListesMusique(chemin, optionRecherche)
        Next

        Try
            frmMusicMe.lstlisteMusique.SetSelected(0, True)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ImporterMusique()

        For Each cheminMusique As String In listeMusique
            listeMusiqueNomSeulement.Add(cheminMusique.Substring(cheminMusique.LastIndexOf("\") + 1, cheminMusique.LastIndexOf(".") - cheminMusique.LastIndexOf("\") - 1))
        Next

        frmMusicMe.lstMusique.DataSource = listeMusiqueNomSeulement


        Try
            frmMusicMe.lstMusique.SetSelected(0, True)
            frmMusicMe.musique = New Microsoft.DirectX.AudioVideoPlayback.Audio(listeMusique(frmMusicMe.lstMusique.SelectedIndex))
            frmMusicMe.cheminMusiqueMemoire = listeMusique(frmMusicMe.lstMusique.SelectedIndex)
        Catch ex As Exception
            MsgBox("Il n'y a pas de Music")
        End Try

    End Sub

    Public Sub ImporterListesMusique(ByVal dossier As String, ByVal optionRecherche As System.IO.SearchOption)


        Dim informationDirectoire As New IO.DirectoryInfo(dossier)
        Dim prendreFichier As IO.FileInfo() = informationDirectoire.GetFiles("*.*", optionRecherche)
        Dim fichiers As IO.FileInfo
        Dim touteMaMusique As System.IO.StreamWriter


        If (Not System.IO.Directory.Exists(dossier)) Then   'Crée un dossier s'il n'existe pas
            System.IO.Directory.CreateDirectory(dossier)
        End If


        For Each fichiers In prendreFichier
            Select Case fichiers.Extension
                Case ".mp3", ".wav", ".ogg", ".mid", ".aiff", ".flac", ".aac", ".wma"
                    listeMusique.Add(fichiers.FullName)
            End Select
        Next

        touteMaMusique = File.CreateText(".\listeDeLecture\TouteMaMusique.playlist")
        For Each cheminMusique In listeMusique
            touteMaMusique.WriteLine(cheminMusique)
        Next
        touteMaMusique.Close()

    End Sub

    Public Sub SauvegarderProprieteVersFichier()
        Try
            Dim ecriveurFichier As System.IO.StreamWriter
            ecriveurFichier = My.Computer.FileSystem.OpenTextFileWriter(".\properties.txt", False)
            ecriveurFichier.WriteLine("fond d'écran:" & frmPersonnaliser.cheminImageDeFond)
            ecriveurFichier.Close()
        Catch ex As Exception
        End Try

        My.Settings.listBackColor = frmPersonnaliser.couleurDeFondDesListes
        My.Settings.BackColor = frmMusicMe.BackColor
        My.Settings.Font = frmMusicMe.Font
        My.Settings.ForeColor = frmMusicMe.ForeColor
        My.Settings.Opacity = frmMusicMe.Opacity
        My.Settings.Save()
    End Sub

    Public Sub ImporterProprieteDuFichier()
        Try
            Dim lecteurFichier As System.IO.StreamReader
            lecteurFichier = My.Computer.FileSystem.OpenTextFileReader(".\properties.txt")
            Dim memoireImageDeFond As String = lecteurFichier.ReadLine
            frmMusicMe.BackgroundImage = Image.FromFile(memoireImageDeFond.Substring(memoireImageDeFond.IndexOf(":") + 1))
            lecteurFichier.Close()
        Catch ex As Exception

        End Try


        frmMusicMe.BackgroundImageLayout = ImageLayout.Stretch
        frmMusicMe.BackColor = My.Settings.BackColor

        frmMusicMe.Opacity = My.Settings.Opacity
        If frmMusicMe.Opacity <> 1 Then
            Dim resultat As DialogResult = MessageBox.Show("Voulez-vous garder la transparence?", "Transparent", MessageBoxButtons.YesNo)
            If resultat = DialogResult.No Then
                frmMusicMe.Opacity = 1
                SauvegarderProprieteVersFichier()
            End If
        End If


        frmMusicMe.ForeColor = My.Settings.ForeColor
        frmMusicMe.mmBarreDeMenu.ForeColor = My.Settings.ForeColor
        frmMusicMe.FICHIERToolStripMenuItem1.ForeColor = My.Settings.ForeColor
        frmMusicMe.lstlisteMusique.ForeColor = My.Settings.ForeColor
        frmMusicMe.lstMusique.ForeColor = My.Settings.ForeColor
        frmMusicMe.lblInformationMusique.ForeColor = My.Settings.ForeColor

        frmMusicMe.lstMusique.BackColor = My.Settings.listBackColor
        frmMusicMe.lstlisteMusique.BackColor = My.Settings.listBackColor

        frmMusicMe.Font = My.Settings.Font
        frmMusicMe.mmBarreDeMenu.Font = My.Settings.Font
        frmMusicMe.lstMusique.Font = My.Settings.Font
        frmMusicMe.lstlisteMusique.Font = My.Settings.Font
        frmMusicMe.lblInformationMusique.Font = My.Settings.Font
    End Sub

    'Procédures pour les boutons de Musique

    Public Sub CliquerBoutonJouer()

        Try

            If frmMusicMe.musique.State = StateFlags.Running And Not frmMusicMe.lstMusique.SelectedItem.ToString.Equals(frmMusicMe.cheminMusiqueMemoire) Then 'Si la Music est en marche, mais que l'utilisateur à cliqué sur une autre Music, joue l'autre Music
                frmMusicMe.musique.Stop()
                frmMusicMe.musique = New Microsoft.DirectX.AudioVideoPlayback.Audio(listeMusique(frmMusicMe.lstMusique.SelectedIndex))
                frmMusicMe.musique.Play()
            ElseIf frmMusicMe.musique.State = StateFlags.Running And frmMusicMe.lstMusique.SelectedItem.ToString.Equals(frmMusicMe.cheminMusiqueMemoire) Then 'Si la Music marche et que la Music sélectionnée est celle qui est joué, fait pause
                frmMusicMe.musique.Pause()
            ElseIf frmMusicMe.musique.State = StateFlags.Paused And frmMusicMe.lstMusique.SelectedItem.ToString.Equals(frmMusicMe.cheminMusiqueMemoire) Then 'Si il est sur pause et que tu veux repartir la Music à la même position
                frmMusicMe.musique.Play()
            ElseIf frmMusicMe.musique.State = StateFlags.Paused And Not frmMusicMe.lstMusique.SelectedItem.ToString.Equals(frmMusicMe.cheminMusiqueMemoire) Then 'Si il est a pause, mais la Music selectionnée est changé, alors joue la nouvelle Music
                frmMusicMe.musique.Stop()
                frmMusicMe.musique = New Microsoft.DirectX.AudioVideoPlayback.Audio(listeMusique(frmMusicMe.lstMusique.SelectedIndex))
                frmMusicMe.musique.Play()
            ElseIf frmMusicMe.musique.State = StateFlags.Stopped Then 'Si la Music est completement arretée et que je veux la faire jouer
                frmMusicMe.musique = New Microsoft.DirectX.AudioVideoPlayback.Audio(listeMusique(frmMusicMe.lstMusique.SelectedIndex))
                frmMusicMe.musique.Play()
            End If

            If frmMusicMe.musique.State = StateFlags.Running Then
                frmMusicMe.picJouerPause.BackgroundImage = My.Resources.PauseButton
            Else
                frmMusicMe.picJouerPause.BackgroundImage = My.Resources.PlayButton
            End If
            frmMusicMe.cheminMusiqueMemoire = listeMusiqueNomSeulement(frmMusicMe.lstMusique.SelectedIndex)
            frmMusicMe.tmrTrackbarMusique.Interval = CInt(frmMusicMe.musique.Duration)
            frmMusicMe.trkProgresMusique.Maximum = CInt(frmMusicMe.musique.Duration)
            frmMusicMe.tmrTrackbarMusique.Start()
            frmMusicMe.tmrChangerInformationMusique.Start()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub CliquerBoutonPause()
        If frmMusicMe.cheminMusiqueMemoire = listeMusique(frmMusicMe.lstMusique.SelectedIndex) Then
            frmMusicMe.musique.Pause()
            frmMusicMe.picJouerPause.BackgroundImage = My.Resources.PlayButton
        Else
            frmMusicMe.musique.Stop()
            frmMusicMe.musique = New Microsoft.DirectX.AudioVideoPlayback.Audio(listeMusique(frmMusicMe.lstMusique.SelectedIndex))
            frmMusicMe.cheminMusiqueMemoire = listeMusique(frmMusicMe.lstMusique.SelectedIndex)
            frmMusicMe.musique.Play()
        End If
    End Sub

    Public Sub CliquerBoutonArret()
        frmMusicMe.musique.Stop()
        frmMusicMe.cheminMusiqueMemoire = ""
    End Sub

    Public Sub ChangerChanson(ByVal NombreDeChanson As Integer)
        If frmMusicMe.lstMusique.SelectedIndex <> -1 Then
            frmMusicMe.musique.Stop()
            frmMusicMe.lstMusique.SetSelected(listeMusique.FindIndex(Function(p) p.Contains(frmMusicMe.cheminMusiqueMemoire)), True) 'Resélectionne la Music qui est en marche
            frmMusicMe.lstMusique.SetSelected(frmMusicMe.lstMusique.SelectedIndex + NombreDeChanson, True) 'Sélectionne la Music suivante
            frmMusicMe.musique = New Microsoft.DirectX.AudioVideoPlayback.Audio(listeMusique(frmMusicMe.lstMusique.SelectedIndex))
            frmMusicMe.cheminMusiqueMemoire = listeMusiqueNomSeulement(frmMusicMe.lstMusique.SelectedIndex)
            frmMusicMe.trkProgresMusique.Value = 0 'Réinitialise le trackbar à 0
            CliquerBoutonJouer()
        End If
    End Sub

    'Procedures pour les changements de couleur

    Public Sub DonnerCouleurFond(ByVal backColor As Color)
        frmMusicMe.Opacity = 1
        frmMusicMe.BackColor = backColor
        fichierCouleurFond = backColor.ToArgb.ToString
        SauvegarderProprieteVersFichier()
        ChargerProprieteFormulaire()
    End Sub

    Public Sub DonnerCouleurFondListe(ByVal listBackColor As Color)

        frmMusicMe.lstMusique.BackColor = listBackColor
        frmMusicMe.lstlisteMusique.BackColor = listBackColor
        SauvegarderProprieteVersFichier()
        ChargerProprieteFormulaire()

    End Sub

    Public Sub DonnerCouleurPolice(ByVal fontColor As Color)
        frmMusicMe.ForeColor = fontColor
        frmMusicMe.mmBarreDeMenu.ForeColor = fontColor
        frmMusicMe.lstMusique.ForeColor = fontColor
        frmMusicMe.lstlisteMusique.ForeColor = fontColor
        SauvegarderProprieteVersFichier()
        ChargerProprieteFormulaire()
    End Sub

    Public Function RetournerArgbFonce(ByVal R As Integer, ByVal G As Integer, ByVal B As Integer) As Color
        Dim retourneCouleurRGB As Color
        Dim listeCouleurRGB() As Integer = {R, G, B}
        Const TauxChangementCouleur As Integer = 100

        If R <= 255 - TauxChangementCouleur Then
            R += TauxChangementCouleur
        Else
            R -= TauxChangementCouleur
        End If
        If G <= 255 - TauxChangementCouleur Then
            G += TauxChangementCouleur
        Else
            G -= TauxChangementCouleur
        End If
        If B <= 255 - TauxChangementCouleur Then
            B += TauxChangementCouleur
        Else
            B -= TauxChangementCouleur
        End If

        retourneCouleurRGB = Color.FromArgb(R, G, B)
        Return retourneCouleurRGB
    End Function

End Module

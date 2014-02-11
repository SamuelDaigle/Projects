Imports Microsoft.DirectX
Imports Microsoft.DirectX.AudioVideoPlayback
Imports System.Runtime.InteropServices

Public Class frmMusicMe

    Public musique As Microsoft.DirectX.AudioVideoPlayback.Audio
    Public cheminMusiqueMemoire As String = ""
    Dim compteurTemps As Integer
    Dim changeInformationChanson As Boolean

    '****************************************************************
    'AU DÉMARRAGE DE L'APPLICATION
    '****************************************************************

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Procedures.ChargerProprieteFormulaire() 'Initialise le programme selon les options choisis précédemment
        Procedures.ImporterMusiqueParDossier() 'Importe les listes de lecture selon des dossiers ajoutés précédemment et ajoute les musiques dans la liste de lecture principale
        DemarrerTout()
    End Sub

    Private Sub DemarrerTout()
        Dim directoire As New IO.DirectoryInfo(".\listeDeLecture")
        Dim importerListeDeLecture As IO.FileInfo() = directoire.GetFiles()
        Dim listeDeLecture As IO.FileInfo


        For Each listeDeLecture In importerListeDeLecture
            If listeDeLecture.Extension = ".playlist" Then
                lstlisteMusique.Items.Add(listeDeLecture.ToString.Substring(0, listeDeLecture.ToString.LastIndexOf(".")))
            End If
        Next
        Try
            lstlisteMusique.SetSelected(0, True)
        Catch ex As Exception

        End Try

        Procedures.ImporterMusique() 'Importe les musiques selon les listes de lecture

    End Sub 'Procédure très relié au démarrage de l'application (Load)


    '****************************************************************
    '                   PROCEDURES AND FUNCTIONS
    '****************************************************************

    'contrôles pour faire jouer la musique
    Private Sub picPlayPause_Click(sender As Object, e As EventArgs) Handles picJouerPause.Click
        Procedures.CliquerBoutonJouer() 'Actionne le bouton Lecture (Play)
    End Sub

    Private Sub picBoutonPrecedent_Click(sender As Object, e As EventArgs) Handles picBoutonPrecedent.Click
        ChangerChanson(-1) 'Bouton précédent
    End Sub

    Private Sub picStop_Click(sender As Object, e As EventArgs) Handles picArret.Click
        CliquerBoutonArret() 'Arrete completement la musique, différent de pause
    End Sub

    Private Sub picBoutonSuivant_Click(sender As Object, e As EventArgs) Handles picBoutonSuivant.Click
        ChangerChanson(1) 'Bouton suivant
    End Sub

    'contrôles de la barre de menu
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click 'PersonnaliserToolStripItem plutôt, Il refuse de changer de nom
        frmPersonnaliser.Show() 'Ouvre le formulaire pour personnaliser l'application
    End Sub

    Private Sub picRefresh_Click(sender As Object, e As EventArgs) Handles picRafraichir.Click
        DemarrerTout() 'Réinitialiser tout et importer tout à nouveau
    End Sub

    Private Sub AddPlayList(sender As Object, e As EventArgs) Handles AjouterUneListeDeLectureToolStripMenuItem1.Click
        frmNouvelleListe.ShowDialog() 'Affiche le formulaire pour avoir une nouvelle liste de lecture
        If System.IO.File.Exists(".\listeDeLecture\" & frmNouvelleListe.lblTitreNouvelleListe.Text & ".playlist") Then
            lstlisteMusique.Items.Add(frmNouvelleListe.lblTitreNouvelleListe.Text) 'Ajoute la liste à la listbox
        End If
    End Sub

    Private Sub picMusicZ_Click(sender As Object, e As EventArgs) Handles picMusicZ.Click
        Try
            frmMusicZ.Show()  'Affiche le jeu
        Catch ex As Exception
            frmMusicZ.Close()
        End Try

    End Sub

    Private Sub QuitterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem1.Click
        Procedures.SauvegarderProprieteVersFichier()  'Sauvegarde tout et quitte
        Me.Close()
    End Sub

    Private Sub AjouterUnDossierToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AjouterUnDossierToolStripMenuItem1.Click
        Ajouter_Un_Dossier.ShowDialog()
    End Sub

    Private Sub SUPPORTToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SUPPORTToolStripMenuItem2.Click
        Dim MESSAGE_SUPPORT As String
        MESSAGE_SUPPORT = "En cas de problème avec Music ME," & vbCrLf & _
                          "veuillez contacter le support de Purity à l'aide d'une des informations suivantes:" & vbCrLf & vbCrLf & _
                          "Téléphone : x-xxx-xxx-xxxx" & vbCrLf & _
                          "Courriel: support.purity@support.com" & vbCrLf & _
                          "Adresse: 9999 boul. Pure, J2L 8U0, Californie, US"
        MsgBox(MESSAGE_SUPPORT, MsgBoxStyle.OkOnly, "Support")
    End Sub

    Private Sub VERSIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERSIONToolStripMenuItem.Click
        Dim MESSAGE_VERSION As String
        MESSAGE_VERSION = "La version de Music ME est:" & vbCrLf & _
                          Me.ProductVersion.ToString & vbCrLf & _
                          Me.CompanyName & vbCrLf & _
                          "2013"
        MsgBox(MESSAGE_VERSION, MsgBoxStyle.OkOnly, "Version")
    End Sub

    'événements sur le formulaire
    Private Sub frmMusicMe_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        '********************************************
        'Gérer l'affichage (vrai ou faux)
        '********************************************
        'Affichage du bouton arret
        If frmPersonnaliser.optBoutonStopOff.Checked = False Then
            If Me.Height >= CInt(frmPersonnaliser.txtShowStopHeight.Text) Then
                If Me.Width >= CInt(frmPersonnaliser.txtShowStopWidth.Text) Then     'Le bouton "Stop" apparaît
                    picArret.Visible = True
                    picArret.Enabled = True
                Else                                                                  'Le bouton "Stop" disparaît
                    picArret.Visible = False
                    picArret.Enabled = False
                End If
            End If
        End If

        'Affichage du trackbar du progrès de la musique
        If Me.Height <= CInt(frmPersonnaliser.txtShowTrackbarProgressHeight.Text) Or Me.Width <= CInt(frmPersonnaliser.txtShowTrackbarProgressWidth.Text) Then
            trkProgresMusique.Visible = False    'Fait disparaître la trackbar de la musique
        Else
            trkProgresMusique.Visible = True     'Fait apparaître la trackbar de la musique
        End If

        If Me.Height <= CInt(frmPersonnaliser.txtShowTrackbarVolumeHeight.Text) Or Me.Width <= CInt(frmPersonnaliser.txtShowTrackbarVolumeWidth.Text) Then
            trkVolume.Visible = False           'Fait disparaître la trackbar du volume
        Else
            trkVolume.Visible = True            'Fait apparaître la trackbar du volume
        End If

        If Me.Height <= CInt(frmPersonnaliser.txtShowlisteMusiqueHeight.Text) Or Me.Width <= CInt(frmPersonnaliser.txtShowlisteMusiqueWidth.Text) Then
            lstMusique.Visible = False            'Fait disparaître la liste de musique
        Else
            lstMusique.Visible = True             'Fait apparaître la liste de musique
        End If

        If Me.Height <= CInt(frmPersonnaliser.txtShowPlaylistHeight.Text) Or Me.Width <= CInt(frmPersonnaliser.txtShowPlaylistWidth.Text) Then
            lstlisteMusique.Visible = False          'Fait disparaître la liste de liste de lecture
        Else
            lstlisteMusique.Visible = True           'Fait apparaître la liste de liste de lecture
        End If

        If lblInformationMusique.Width < 300 Then
            lblInformationMusique.Visible = False   'Fait disparaître le label d'information
        Else
            lblInformationMusique.Visible = True    'Fait apparaître le label d'information
        End If

        If Me.Width >= 700 Then         'Fais apparaître les boutons
            picMusicZ.Visible = True
            picRafraichir.Visible = True
        Else                             'Fais disparaître les boutons
            picMusicZ.Visible = False
            picRafraichir.Visible = False
        End If

        '********************************************
        'Gérer la dimention de tout
        '********************************************
        If Me.Height <= CInt(frmPersonnaliser.txtShowPlayHeight.Text) Then  'garder la hauteur minimale
            Me.Height = CInt(frmPersonnaliser.txtShowPlayHeight.Text)
        End If

        If Me.Width >= picRafraichir.Location.X Then 'Fait bouger les boutons avec le mouvement du form, les nombres ne signifient rien de particulier, ils ne font qu'alligner les zones correctement.
            picRafraichir.Left = Me.Width - picRafraichir.Width - 19
            picMusicZ.Left = picRafraichir.Left - picMusicZ.Width - 5
            lblInformationMusique.Width = picMusicZ.Left - 500
        End If

        If Me.Width >= lstMusique.Location.X Then   'Fait bouger la liste selon le bord du form
            lstMusique.Width = Me.Width - 250
        End If

        If Me.Height >= lstMusique.Location.Y Then   'Fait bouger la liste selon le bord du form
            lstMusique.Height = Me.Height - 195
        End If

        If Me.Height >= lstlisteMusique.Location.Y Then   'Fait bouger la liste selon le bord du form
            lstlisteMusique.Height = Me.Height - 255
        End If

        If Me.Width >= trkProgresMusique.Location.X Then   'Fait bouger la trackbar de la musique selon le bord du form
            trkProgresMusique.Width = Me.Width - 250
        End If






    End Sub

    'contrôle des listes
    Private Sub lstMusic_DoubleClick(sender As Object, e As EventArgs) Handles lstMusique.DoubleClick
        Procedures.CliquerBoutonJouer() 'Fait Play si on double clique sur un item de la listbox de la musique
    End Sub

    Private Sub lstPlaylist_MouseClick(sender As Object, e As MouseEventArgs) Handles lstlisteMusique.MouseClick
        Dim lecteurFichier As System.IO.StreamReader
        lecteurFichier = My.Computer.FileSystem.OpenTextFileReader(".\listeDeLecture\" & lstlisteMusique.SelectedItem.ToString & ".playlist")
        Dim cheminMusique As String

        'Les trois lignes suivantes effacent les musiques de la liste de musique
        lstMusique.DataSource = New List(Of String)()
        Procedures.listeMusique.Clear()
        Procedures.listeMusiqueNomSeulement.Clear()

        Do Until lecteurFichier.EndOfStream 'Ajoute tous les musiques jusqu'à la fin du fichier .playlist
            cheminMusique = lecteurFichier.ReadLine()
            Procedures.listeMusique.Add(cheminMusique)
            Procedures.listeMusiqueNomSeulement.Add(cheminMusique.Substring(cheminMusique.LastIndexOf("\") + 1, cheminMusique.LastIndexOf(".") - cheminMusique.LastIndexOf("\") - 1))
        Loop

        lecteurFichier.Close()

        'Tout remmettre en fonction:
        lstMusique.DataSource = Procedures.listeMusiqueNomSeulement
        lstMusique.Refresh()

    End Sub

    'autres contrôles (chronomètre, trackbar)
    Private Sub tmrTrackbarMusique_Tick(sender As Object, e As EventArgs) Handles tmrTrackbarMusique.Tick
        trkProgresMusique.Value = CInt(musique.CurrentPosition) 'Augmente le trackbar de la position de la musique
        If lstMusique.SelectedIndex.Equals(lstMusique.Items.Count - 1) And trkProgresMusique.Value = trkProgresMusique.Maximum Then ' Si la dernière musiques de la liste, et qu'elle est finie, fait jouer la première Music
            lstMusique.SetSelected(0, True)
            musique = New Audio(listeMusique(lstMusique.SelectedIndex))
            CliquerBoutonJouer()
        ElseIf trkProgresMusique.Value = trkProgresMusique.Maximum Then ' Si la musique est finie, change pour la suivante et fait la jouer
            ChangerChanson(1)

        End If

        If Not lstMusique.SelectedItem.ToString.Equals(cheminMusiqueMemoire) Then 'Si on sélectionne une autre musique, change l'image pour Play pour pouvoir partir la nouvelle musique choisie
            picJouerPause.BackgroundImage = My.Resources.PlayButton
        End If
    End Sub

    Private Sub trkProgresMusique_Scroll(sender As Object, e As EventArgs) Handles trkProgresMusique.Scroll
        Try
            tmrTrackbarMusique.Stop()                             'Arrete le trackbar de la position de la musique pour nous permettre de la modifier aisémenttempsRestantMusic
            musique.CurrentPosition = trkProgresMusique.Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub trkProgresMusique_MouseLeave(sender As Object, e As EventArgs) Handles trkProgresMusique.MouseLeave
        Try
            If musique.Playing Then
                tmrTrackbarMusique.Start() 'Repart le trackbar de la position de la musique (car on peut l'avoir arrêté pour changer la position manuellement)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub trkVolume_Scroll(sender As Object, e As EventArgs) Handles trkVolume.Scroll
        Try
            If trkVolume.Value <> 0 Then  ' Le trackbar de la musique fonctionne de -10 000 à 0  dont -10 000 est la sourdine et 0 est le plus fort
                musique.Volume = CInt((Math.Abs(trkVolume.Value) ^ 3) * -1) 'Change le volume, de façon exponentielle, pour avoir plus de précision dans les volumes élevés
            ElseIf trkVolume.Value <= -6000 Then 'Si le sont est très bas, applique une sourdine
                musique.Volume = -10000
            Else
                musique.Volume = trkVolume.Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tmrLabelChange_Tick(sender As Object, e As EventArgs) Handles tmrChangerInformationMusique.Tick
        Dim tempsRestantMusique As String
        tempsRestantMusique = CStr(CLng(CInt(musique.Duration - musique.CurrentPosition)) \ 60 & ":" & CInt(musique.Duration - musique.CurrentPosition) Mod 60)  'Sert à calculer le temps restant de la musique en minutes et en seconde (les jours et années seront calculé dans les minutes)

        'À chaque intervalle de temps, change du nom de la chanson au temps restant de la musique
        compteurTemps += 1
        If compteurTemps Mod 40 = 0 Then 'Intervalle de 40 ticks
            If changeInformationChanson Then
                changeInformationChanson = False
            Else
                changeInformationChanson = True
            End If
        End If
        If Not changeInformationChanson Then
            lblInformationMusique.Text = cheminMusiqueMemoire.ToString 'Nom de la chanson
        Else
            lblInformationMusique.Text = tempsRestantMusique 'Temps restant de la chanson
        End If
    End Sub


End Class

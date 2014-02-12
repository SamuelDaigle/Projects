Public Class frmNouvelleListe

    Private Sub NouvelleListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNomNouvelleListe.Text = ""
        txtNomNouvelleListe.Focus()
        txtNomNouvelleListe.SelectAll()
        lstMusiqueCategorie.Items.Clear()

        For Each musique In System.IO.File.ReadLines(".\listeDeLecture\TouteMaMusique.playlist")   'Met TOUTES les musiques dans la liste de droite, pour qu'on puisse les ajouter dans la nouvelle liste
            lstToutesLesMusiques.Items.Add(musique.Substring(musique.LastIndexOf("\") + 1))
        Next

        lstToutesLesMusiques.SelectedIndex = -1 'déselectionner tout

    End Sub

    Private Sub btnMettreDansPlaylist_Click(sender As Object, e As EventArgs) Handles btnMettreDansPlaylist.Click
        For i As Integer = 0 To lstToutesLesMusiques.SelectedItems.Count - 1 'Met tous les musiques sélectionnées dans la nouvelle playlist
            lstMusiqueCategorie.Items.Add(lstToutesLesMusiques.SelectedItems.Item(i))
        Next
        lstToutesLesMusiques.SelectedIndex = -1 'déselectionner tout
    End Sub

    Private Sub txtNomNouvelleListe_TextChanged(sender As Object, e As EventArgs) Handles txtNomNouvelleListe.TextChanged
        lblTitreNouvelleListe.Text = txtNomNouvelleListe.Text
    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        Dim ecriveurFichier As System.IO.StreamWriter
        Dim listeValide As Boolean = True
        If Not System.IO.Directory.Exists(".\listeDeLecture") Then
            System.IO.Directory.CreateDirectory(".\listeDeLecture")
        End If


        'Validation
        If txtNomNouvelleListe.Text = "" Then
            MsgBox("Veuillez entrer un nom pour votre liste de lecture", MsgBoxStyle.OkOnly, "Erreur liste sans nom")
            listeValide = False
        ElseIf txtNomNouvelleListe.Text = "null" Or txtNomNouvelleListe.Text = Nothing Then
            MsgBox("Veuillez choisir un autre nom pour votre liste de lecture", MsgBoxStyle.OkOnly, "Erreur liste sans nom valide")
            listeValide = False
        ElseIf lstMusiqueCategorie.Items.Count = 0 Then
            MsgBox("Veuillez choisir minimalement une musique et l'ajouter à l'aide du bouton du centre", MsgBoxStyle.OkOnly, "Erreur liste sans musique")
            listeValide = False
        ElseIf txtNomNouvelleListe.Text.Length >= 200 Then
            MsgBox("Veuillez avoir un nom de votre liste de lecture plus court", MsgBoxStyle.OkOnly, "Erreur nom trop long")
            listeValide = False
            txtNomNouvelleListe.Focus()
            txtNomNouvelleListe.SelectAll()
        Else
            For Each liste In frmMusicMe.lstlisteMusique.Items
                If txtNomNouvelleListe.Text = liste.ToString Then
                    MsgBox("Veuillez choisir un autre nom pour votre liste de lecture" & vbCrLf & "La liste est déjà existante" & vbCrLf & "(Pour modifier une liste, veuillez faire un clique droit sur la liste)", MsgBoxStyle.OkOnly, "Erreur liste déjà existante")
                    listeValide = False
                End If
            Next
        End If

        If listeValide = False Then
            Exit Sub
        End If

        'End Validation

        If System.IO.File.Exists(txtNomNouvelleListe.Text & ".playlist") Then
            ecriveurFichier = My.Computer.FileSystem.OpenTextFileWriter(txtNomNouvelleListe.Text & ".playlist", False)
        Else
            ecriveurFichier = System.IO.File.CreateText(".\listeDeLecture\" & txtNomNouvelleListe.Text & ".playlist")
        End If

        For Each songs In lstMusiqueCategorie.Items
            For Each songsPath In Procedures.listeMusique
                If songsPath.Contains(songs.ToString) Then
                    ecriveurFichier.WriteLine(songsPath)
                End If
            Next
        Next

        ecriveurFichier.Close()
        Me.Close()
    End Sub

End Class

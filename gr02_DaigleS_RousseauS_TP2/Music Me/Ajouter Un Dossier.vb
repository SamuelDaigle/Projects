Public Class Ajouter_Un_Dossier

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNaviguer.Click
        fbdNaviguer.ShowDialog()
        txtCheminDossier.Text = fbdNaviguer.SelectedPath
    End Sub

    Private Sub Ajouter_Un_Dossier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbOptionRecherche.SelectedIndex = 0
    End Sub

    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click
        Dim ecriveurFichier As System.IO.StreamWriter

        If System.IO.Directory.Exists(txtCheminDossier.Text) Then
            ecriveurFichier = My.Computer.FileSystem.OpenTextFileWriter(".\Dossiers.adv", True)
            ecriveurFichier.WriteLine(txtCheminDossier.Text & "," & cbbOptionRecherche.Text)
            ecriveurFichier.Close()
            Procedures.ImporterMusiqueParDossier()
        Else
            MsgBox("Le dossier choisi n'existe pas.", vbOKOnly, "Dossier n'existe pas")
        End If

        Me.Close()
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNouvelleListe
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNouvelleListe = New System.Windows.Forms.Label()
        Me.txtNomNouvelleListe = New System.Windows.Forms.TextBox()
        Me.lblTitreNouvelleListe = New System.Windows.Forms.Label()
        Me.lstMusiqueCategorie = New System.Windows.Forms.ListBox()
        Me.lstToutesLesMusiques = New System.Windows.Forms.ListBox()
        Me.btnMettreDansPlaylist = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNouvelleListe
        '
        Me.lblNouvelleListe.AutoSize = True
        Me.lblNouvelleListe.Location = New System.Drawing.Point(10, 11)
        Me.lblNouvelleListe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNouvelleListe.Name = "lblNouvelleListe"
        Me.lblNouvelleListe.Size = New System.Drawing.Size(74, 13)
        Me.lblNouvelleListe.TabIndex = 0
        Me.lblNouvelleListe.Text = "Nouvelle Liste"
        '
        'txtNomNouvelleListe
        '
        Me.txtNomNouvelleListe.Location = New System.Drawing.Point(9, 27)
        Me.txtNomNouvelleListe.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNomNouvelleListe.Name = "txtNomNouvelleListe"
        Me.txtNomNouvelleListe.Size = New System.Drawing.Size(139, 20)
        Me.txtNomNouvelleListe.TabIndex = 1
        '
        'lblTitreNouvelleListe
        '
        Me.lblTitreNouvelleListe.AutoSize = True
        Me.lblTitreNouvelleListe.Location = New System.Drawing.Point(35, 59)
        Me.lblTitreNouvelleListe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitreNouvelleListe.Name = "lblTitreNouvelleListe"
        Me.lblTitreNouvelleListe.Size = New System.Drawing.Size(0, 13)
        Me.lblTitreNouvelleListe.TabIndex = 2
        '
        'lstMusiqueCategorie
        '
        Me.lstMusiqueCategorie.FormattingEnabled = True
        Me.lstMusiqueCategorie.Location = New System.Drawing.Point(12, 76)
        Me.lstMusiqueCategorie.Margin = New System.Windows.Forms.Padding(2)
        Me.lstMusiqueCategorie.Name = "lstMusiqueCategorie"
        Me.lstMusiqueCategorie.Size = New System.Drawing.Size(136, 212)
        Me.lstMusiqueCategorie.TabIndex = 3
        '
        'lstToutesLesMusiques
        '
        Me.lstToutesLesMusiques.FormattingEnabled = True
        Me.lstToutesLesMusiques.Location = New System.Drawing.Point(206, 76)
        Me.lstToutesLesMusiques.Margin = New System.Windows.Forms.Padding(2)
        Me.lstToutesLesMusiques.Name = "lstToutesLesMusiques"
        Me.lstToutesLesMusiques.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstToutesLesMusiques.Size = New System.Drawing.Size(242, 212)
        Me.lstToutesLesMusiques.TabIndex = 4
        '
        'btnMettreDansPlaylist
        '
        Me.btnMettreDansPlaylist.Location = New System.Drawing.Point(152, 161)
        Me.btnMettreDansPlaylist.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMettreDansPlaylist.Name = "btnMettreDansPlaylist"
        Me.btnMettreDansPlaylist.Size = New System.Drawing.Size(50, 34)
        Me.btnMettreDansPlaylist.TabIndex = 5
        Me.btnMettreDansPlaylist.Text = "<"
        Me.btnMettreDansPlaylist.UseVisualStyleBackColor = True
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Location = New System.Drawing.Point(370, 292)
        Me.btnEnregistrer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(76, 24)
        Me.btnEnregistrer.TabIndex = 6
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'frmNouvelleListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 324)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Controls.Add(Me.btnMettreDansPlaylist)
        Me.Controls.Add(Me.lstToutesLesMusiques)
        Me.Controls.Add(Me.lstMusiqueCategorie)
        Me.Controls.Add(Me.lblTitreNouvelleListe)
        Me.Controls.Add(Me.txtNomNouvelleListe)
        Me.Controls.Add(Me.lblNouvelleListe)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmNouvelleListe"
        Me.Text = "NouvelleListe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNouvelleListe As System.Windows.Forms.Label
    Friend WithEvents txtNomNouvelleListe As System.Windows.Forms.TextBox
    Friend WithEvents lblTitreNouvelleListe As System.Windows.Forms.Label
    Friend WithEvents lstMusiqueCategorie As System.Windows.Forms.ListBox
    Friend WithEvents lstToutesLesMusiques As System.Windows.Forms.ListBox
    Friend WithEvents btnMettreDansPlaylist As System.Windows.Forms.Button
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajouter_Un_Dossier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCheminDossier = New System.Windows.Forms.TextBox()
        Me.btnNaviguer = New System.Windows.Forms.Button()
        Me.cbbOptionRecherche = New System.Windows.Forms.ComboBox()
        Me.fbdNaviguer = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnSauvegarder = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCheminDossier
        '
        Me.txtCheminDossier.Location = New System.Drawing.Point(26, 69)
        Me.txtCheminDossier.Name = "txtCheminDossier"
        Me.txtCheminDossier.Size = New System.Drawing.Size(373, 20)
        Me.txtCheminDossier.TabIndex = 0
        '
        'btnNaviguer
        '
        Me.btnNaviguer.Location = New System.Drawing.Point(405, 67)
        Me.btnNaviguer.Name = "btnNaviguer"
        Me.btnNaviguer.Size = New System.Drawing.Size(101, 23)
        Me.btnNaviguer.TabIndex = 1
        Me.btnNaviguer.Text = "Naviguer"
        Me.btnNaviguer.UseVisualStyleBackColor = True
        '
        'cbbOptionRecherche
        '
        Me.cbbOptionRecherche.FormattingEnabled = True
        Me.cbbOptionRecherche.Items.AddRange(New Object() {"Dossier seulement", "Dossier et sous-dossiers"})
        Me.cbbOptionRecherche.Location = New System.Drawing.Point(87, 133)
        Me.cbbOptionRecherche.Name = "cbbOptionRecherche"
        Me.cbbOptionRecherche.Size = New System.Drawing.Size(263, 21)
        Me.cbbOptionRecherche.TabIndex = 2
        '
        'btnSauvegarder
        '
        Me.btnSauvegarder.Location = New System.Drawing.Point(128, 300)
        Me.btnSauvegarder.Name = "btnSauvegarder"
        Me.btnSauvegarder.Size = New System.Drawing.Size(97, 23)
        Me.btnSauvegarder.TabIndex = 3
        Me.btnSauvegarder.Text = "Sauvegarder"
        Me.btnSauvegarder.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(251, 300)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 4
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'Ajouter_Un_Dossier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(536, 341)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnSauvegarder)
        Me.Controls.Add(Me.cbbOptionRecherche)
        Me.Controls.Add(Me.btnNaviguer)
        Me.Controls.Add(Me.txtCheminDossier)
        Me.Name = "Ajouter_Un_Dossier"
        Me.Text = "Ajouter_Un_Dossier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCheminDossier As System.Windows.Forms.TextBox
    Friend WithEvents btnNaviguer As System.Windows.Forms.Button
    Friend WithEvents cbbOptionRecherche As System.Windows.Forms.ComboBox
    Friend WithEvents fbdNaviguer As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnSauvegarder As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
End Class

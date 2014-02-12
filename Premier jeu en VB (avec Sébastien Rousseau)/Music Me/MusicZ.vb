Imports System.Drawing
Imports System.Math
Imports Microsoft.DirectX
Imports Microsoft.DirectX.AudioVideoPlayback


Public Class frmMusicZ
    'VARIABLES SUR LE MATÉRIEL DE L'UTILISATEUR
    Public intResolutionLargeur As Integer = Screen.PrimaryScreen.Bounds.Size.Width
    Public intResolutionHauteur As Integer = Screen.PrimaryScreen.Bounds.Size.Height

    ' VARIABLES GRAPHIQUE
    Dim G As Graphics 'Graphique
    Dim BBG As Graphics 'Memoire tampon graphique
    Dim BB As Bitmap 'Memoire tampon
    Public rectanglePersonnage As Rectangle 'Rectangle du personnage
    Public rectangleZombie As Rectangle 'Rectangle des zombies
    Dim policeDeCaracteres As Font
    Dim versionCarte As Bitmap

    'CONTRÔLE (qui se créent dynamiquement)
    Dim picQuitter As PictureBox
    Dim picJouer As PictureBox

    'FONCTIONNEMENT DU JEU
    Dim blnJeuEnMarche As Boolean

    'VARIABLE DE LA SOURIS
    'variables utilées pour rotationner le joueur
    'La différence entre nouvel angle et ancien angle pour rotationner
    Dim dblAncienAngleSouris As Double
    Dim dblNouvelAngleSouris As Double

    'VARIABLES DU JOUEUR
    Dim bmpJoueur As Bitmap
    Public posCentreJoueur As Point
    Dim intVitesseDeplacement As Integer
    Dim deplacementDirection As Short
    Dim derniereDirection As Short
    Dim listeTouchesAppuyees() As Short
    Dim mat As Drawing2D.Matrix 'matrice pour rotationner les images bitmaps
    Dim intMunitionJoueur As Integer
    Dim intSanteVieJoueur As Integer
    Dim intCompteurSiMort As Integer

    'VARIABLES DES ENNEMIS
    Dim bmpZombie As Bitmap
    Public posZombiesCentre As List(Of Point)
    Dim sngAncienAngleZombieJoueur As Single
    Dim sngNouvelAngleZombieJoueur As Single
    Dim intDommageZombie As Integer
    Dim intVitesseZombies As Integer

    'VARIABLES DE LA MUSIQUE
    Dim sonNature As Audio
    Dim sonCoeur As Audio
    Dim sonRecharger As Audio

    Private Sub frmMiniJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiserValiables() 'Voir à la fin; met les variables par défaut
        ChargerLeFormulaireEtLesProprietesGraphiques() 'Voir à la fin; chargement musique, grandeur du formulaire et quelques autres propriétés
    End Sub





    '=========================================================================================================
    '*********************************************************************************************************
    '                                         BOUCLE DU JEU
    '*********************************************************************************************************
    '=========================================================================================================

    Private Sub DeplacerJoueur(ByVal direction As Array)

        For i = 0 To listeTouchesAppuyees.Count - 1

            mat.Reset()
            Select Case listeTouchesAppuyees(i)
                'Case 0
                '    Do Nothing
                Case 1 'North
                    posCentreJoueur.Y -= intVitesseDeplacement
                Case 2 'West
                    posCentreJoueur.X -= intVitesseDeplacement
                Case 3 'South
                    posCentreJoueur.Y += intVitesseDeplacement
                Case 4 'East
                    posCentreJoueur.X += intVitesseDeplacement
            End Select
            mat.RotateAt(CSng(dblNouvelAngleSouris), posCentreJoueur)

        Next
    End Sub

    Private Sub ChangerOrientationJoueur()
        dblNouvelAngleSouris = Atan2(MousePosition.Y - posCentreJoueur.Y, MousePosition.X - posCentreJoueur.X) * 180 / Math.PI

        mat.RotateAt(CSng(dblNouvelAngleSouris - dblAncienAngleSouris), posCentreJoueur)
        G.Transform = mat

        dblAncienAngleSouris = dblNouvelAngleSouris
    End Sub



    '********************************
    'Détecter les données entrées par l'utilisateur (clavier et souris)
    '********************************


    Private Sub DetecterEntreeUtilisateur(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.W
                deplacementDirection = 1  'North
                listeTouchesAppuyees(0) = 1
            Case Keys.S
                deplacementDirection = 3  'South
                listeTouchesAppuyees(1) = 3
            Case Keys.D
                deplacementDirection = 4  'East
                listeTouchesAppuyees(2) = 4
            Case Keys.A
                deplacementDirection = 2  'West
                listeTouchesAppuyees(3) = 2
            Case Keys.Y
                intSanteVieJoueur -= 5
            Case Else
                deplacementDirection = 0
        End Select

        derniereDirection = deplacementDirection
    End Sub

    Private Sub MiniJeu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Dim toucheRelache As Keys
        toucheRelache = e.KeyData
        Select Case toucheRelache
            Case Keys.W
                deplacementDirection = 1  'North
                listeTouchesAppuyees(0) = 0
            Case Keys.S
                deplacementDirection = 3  'South
                listeTouchesAppuyees(1) = 0
            Case Keys.D
                deplacementDirection = 4  'East
                listeTouchesAppuyees(2) = 0
            Case Keys.A
                deplacementDirection = 2  'West
                listeTouchesAppuyees(3) = 0
        End Select
    End Sub

    '***********************************
    'Faire fonctionner l'intelligence artificielle
    '***********************************

    Private Sub ApparitionEnnemies()
        Dim tauxDApparition As Integer = Abs(frmMusicMe.trkVolume.Value)
        Dim nombreAleatoire As Integer
        Dim locationApparitionZombies As Point


        If tauxDApparition >= 0 And tauxDApparition > 15 Then
            tauxDApparition = 15
        End If
        nombreAleatoire = CInt(Math.Floor((tauxDApparition * 100 + 1) * Rnd()))
        rectangleZombie = New Rectangle(0, 0, 25, 25)
        'If posZombiesCentre.Count < 20 Then  'Maximum de 20 zombies
        '    posZombiesCentre.Add(CInt(Math.Floor((intResolutionLargeur + 1) * Rnd())) + 0) 'Position au hasard en x
        '    yPosZombiesCentre.Add(CInt(Math.Floor((intResolutionHauteur - 1) * Rnd())) + 0) 'Position au hasard en y
        'End If

        Select Case nombreAleatoire
            Case 1, 5, 9 'Apparition côté gauche, hors jeu
                locationApparitionZombies = New Point((CInt(Math.Floor((-50 + 1) * Rnd())) + 0), (CInt(Math.Floor((intResolutionHauteur + 1) * Rnd())) + 0))
                posZombiesCentre.Add(locationApparitionZombies)
            Case 2, 6, 10 'Apparition en haut, hors jeu
                locationApparitionZombies = New Point((CInt(Math.Floor((intResolutionLargeur + 1) * Rnd())) + 0), (CInt(Math.Floor((-50 + 1) * Rnd())) + 0))
                posZombiesCentre.Add(locationApparitionZombies)
            Case 3, 7, 11 'Apparition côté droit, hors jeu
                locationApparitionZombies = New Point((CInt(Math.Floor((50 + 1) * Rnd())) + intResolutionLargeur), (CInt(Math.Floor((intResolutionHauteur + 1) * Rnd())) + 0))
                posZombiesCentre.Add(locationApparitionZombies)
            Case 4, 8, 12 'Apparition en bas, hors jeu
                locationApparitionZombies = New Point((CInt(Math.Floor((intResolutionLargeur + 1) * Rnd())) + 0), (CInt(Math.Floor((50) * Rnd())) + intResolutionHauteur))
                posZombiesCentre.Add(locationApparitionZombies)
        End Select



    End Sub

    Private Sub ActualiserPositionEnemies()
        Dim pointCentreZombie As Point
        Dim angleZombieJoueurRadian As Double

        For i = 0 To posZombiesCentre.Count - 1 'Compte le nombre de zombie
            pointCentreZombie = New Point(posZombiesCentre(i).X, posZombiesCentre(i).Y)
            mat.Reset()
            sngNouvelAngleZombieJoueur = CSng(Atan2(posZombiesCentre(i).Y - posCentreJoueur.Y, posZombiesCentre(i).X - posCentreJoueur.X) * 180 / Math.PI)
            angleZombieJoueurRadian = sngNouvelAngleZombieJoueur * (Math.PI / 180)

            posZombiesCentre(i) -= New Size(CInt(Cos(angleZombieJoueurRadian) * intVitesseZombies), CInt(Sin(angleZombieJoueurRadian) * intVitesseZombies))

            mat.RotateAt(sngNouvelAngleZombieJoueur, pointCentreZombie)
            G.Transform = mat
            G.DrawImage(bmpZombie, CInt(posZombiesCentre(i).X - rectangleZombie.Width / 2), CInt(posZombiesCentre(i).Y - rectangleZombie.Height / 2), rectangleZombie, GraphicsUnit.Pixel)
            G.ResetTransform()

        Next


    End Sub

    '*****************************
    'Créer les collisions
    '*****************************
    Private Sub CreerCollisions()
        Collisions.CollisionsCentreCommercial(posCentreJoueur.X, posCentreJoueur.Y, rectanglePersonnage)
        Collisions.CollisionsMaison(posCentreJoueur.X, posCentreJoueur.Y, rectanglePersonnage)
        Collisions.CollisionBar(posCentreJoueur.X, posCentreJoueur.Y, rectanglePersonnage)
        Collisions.CollisionsStationnement(posCentreJoueur.X, posCentreJoueur.Y, rectanglePersonnage)
        Collisions.CollisionsContourEcran(posCentreJoueur.X, posCentreJoueur.Y, rectanglePersonnage)
        Collisions.AttribuerCollisionObjet(Collisions.deplacementX, Collisions.deplacementY, rectanglePersonnage)
        For i As Integer = 0 To posZombiesCentre.Count - 1
            If posZombiesCentre.Count <> -1 Then
                Collisions.CollisionsCentreCommercial(posZombiesCentre(i).X, posZombiesCentre(i).Y, rectangleZombie, i)
                Collisions.CollisionsMaison(posZombiesCentre(i).X, posZombiesCentre(i).Y, rectangleZombie, i)
                Collisions.CollisionBar(posZombiesCentre(i).X, posZombiesCentre(i).Y, rectangleZombie, i)
                Collisions.CollisionsStationnement(posZombiesCentre(i).X, posZombiesCentre(i).Y, rectangleZombie, i)
                Collisions.CollisionsContourEcran(posZombiesCentre(i).X, posZombiesCentre(i).Y, rectangleZombie, i)
                CollisionsZombieJoueur(posZombiesCentre(i).X, posZombiesCentre(i).Y, i)
                Collisions.AttribuerCollisionObjet(Collisions.deplacementX, Collisions.deplacementY, rectangleZombie, i)
            End If
        Next


    End Sub

    Private Sub CollisionsZombieJoueur(ByVal ObjetsEnMouvementX As Integer, ByVal ObjetsEnMouvementY As Integer, Optional numeroZombie As Integer = -1)

        'Collision entre le personnage et un zombie (la collision se fait durant la boucle For du Zombie)

        'Collision sur le côté droit du personnage 
        If ObjetsEnMouvementX <= posCentreJoueur.X + rectanglePersonnage.Width / 2 AndAlso ObjetsEnMouvementX >= posCentreJoueur.X AndAlso ObjetsEnMouvementY >= posCentreJoueur.Y AndAlso ObjetsEnMouvementY <= posCentreJoueur.Y + rectanglePersonnage.Height / 2 Then
            intSanteVieJoueur -= intDommageZombie

            'Collision sur le côté gauche du personnage
        ElseIf ObjetsEnMouvementX >= posCentreJoueur.X - rectanglePersonnage.Width / 2 AndAlso ObjetsEnMouvementX <= posCentreJoueur.X AndAlso ObjetsEnMouvementY >= posCentreJoueur.Y AndAlso ObjetsEnMouvementY <= posCentreJoueur.Y + rectanglePersonnage.Height / 2 Then
            intSanteVieJoueur -= intDommageZombie

            'Collision sur le côté bas du personnage
        ElseIf ObjetsEnMouvementY <= posCentreJoueur.Y + rectanglePersonnage.Height / 2 AndAlso ObjetsEnMouvementY >= posCentreJoueur.Y AndAlso ObjetsEnMouvementX >= posCentreJoueur.X AndAlso ObjetsEnMouvementX <= posCentreJoueur.X + rectanglePersonnage.Width / 2 Then
            intSanteVieJoueur -= intDommageZombie

            'Collision sur le côté haut du personnage
        ElseIf ObjetsEnMouvementY >= posCentreJoueur.Y - rectanglePersonnage.Height / 2 AndAlso ObjetsEnMouvementY <= posCentreJoueur.Y AndAlso ObjetsEnMouvementX >= posCentreJoueur.X AndAlso ObjetsEnMouvementX < posCentreJoueur.X + rectanglePersonnage.Width / 2 Then
            intSanteVieJoueur -= intDommageZombie
        End If

    End Sub

    '***********************************
    'Dessiner les graphiques
    '***********************************

    Private Sub DessinerGraphiques()
        Dim noirTransparent As Color = Color.FromArgb(50, Color.Black)
        Dim penNoirTransparent As Pen = New Pen(noirTransparent)
        Dim rectNoirTransparent As New Rectangle(0, 0, intResolutionLargeur, intResolutionHauteur)
        Dim fumeeCamionRectangle As New Rectangle(0, 0, My.Resources.Fumée_Camion.Width, My.Resources.Fumée_Camion.Height)
        Dim fumeeVoitureRectangle As New Rectangle(0, 0, My.Resources.Fumée_Voiture_droite.Width, My.Resources.Fumée_Voiture_droite.Height)
        Dim arbreRectangle As New Rectangle(0, 0, My.Resources.Arbre.Width, My.Resources.Arbre.Height)
        rectanglePersonnage = New Rectangle(0, 0, 24, 24)

        ' Affiche une copy de l'image actuelle
        BBG = Me.CreateGraphics
        BBG.DrawImage(BB, 0, 0, intResolutionLargeur, intResolutionHauteur)

        'Assigne l'image actuelle à la variable G (pour graphique)
        G = Graphics.FromImage(BB)

        ' FIX OVERDRAW / fixer les dessins s'ajoutent l'un sur l'autre, redessinne à partir de zero en commençant par la carte
        G.DrawImage(versionCarte, 0, 0, intResolutionLargeur, intResolutionHauteur)




        'Dessine le joueur
        ChangerOrientationJoueur()
        G.DrawImage(bmpJoueur, CInt(posCentreJoueur.X - rectanglePersonnage.Width / 2), CInt(posCentreJoueur.Y - rectanglePersonnage.Height / 2), rectanglePersonnage, GraphicsUnit.Pixel)



        G.ResetTransform() 'Ceci empêche les objets suivant de suivre la rotation du joueur

        'Draw Enemies
        ActualiserPositionEnemies()

        'Dessine les arbres
        For i = 40 To 640 Step 150  'Dessine les arbres sur le coté gauche de la route gauche verticale
            G.DrawImage(My.Resources.Arbre, -15, i, arbreRectangle, GraphicsUnit.Pixel)
        Next
        G.DrawImage(My.Resources.Arbre, 800, 680, arbreRectangle, GraphicsUnit.Pixel)
        G.DrawImage(My.Resources.Arbre, 970, 400, arbreRectangle, GraphicsUnit.Pixel)
        G.DrawImage(My.Resources.Arbre, 1270, 730, arbreRectangle, GraphicsUnit.Pixel)

        'Dessine la fumée
        G.DrawImage(My.Resources.Fumée_Camion, -30, intResolutionHauteur - fumeeCamionRectangle.Height - 80, fumeeCamionRectangle, GraphicsUnit.Pixel)
        G.DrawImage(My.Resources.Fumée_Voiture_droite, intResolutionLargeur - fumeeVoitureRectangle.Width, 250, fumeeVoitureRectangle, GraphicsUnit.Pixel)


        'Draw ammo/health
        G.FillRectangle(Brushes.Red, 60, intResolutionHauteur - 60, intSanteVieJoueur * 2, 30)


        Select Case intMunitionJoueur
            Case 0 To 9
                G.DrawString(CStr(intMunitionJoueur), policeDeCaracteres, Brushes.OrangeRed, intResolutionLargeur - 60, intResolutionHauteur - 70)
            Case 10 To 99
                G.DrawString(CStr(intMunitionJoueur), policeDeCaracteres, Brushes.OrangeRed, intResolutionLargeur - 90, intResolutionHauteur - 70)
            Case Is >= 100
                G.DrawString(CStr(intMunitionJoueur), policeDeCaracteres, Brushes.OrangeRed, intResolutionLargeur - 120, intResolutionHauteur - 70)
        End Select

        'MORT, ceci est lorsque le joueur n'a plus de vie
        If intSanteVieJoueur <= 0 Then
            Me.Cursor = Cursors.Default
            G.FillRectangle(New SolidBrush(Color.FromArgb(200, Color.Black)), rectNoirTransparent) 'Nuit ou transparence de noir


            With picQuitter 'Donne les propriétés du bouton quitter
                .Size = New Size(My.Resources.MusicMe_logo.Width, My.Resources.MusicMe_logo.Height)
                .Location = New Point(CInt(intResolutionLargeur / 2 - picQuitter.Size.Width / 2), CInt(intResolutionHauteur / 2 - picQuitter.Height / 2))
                .BackgroundImage = My.Resources.MusicMe_logo
                .Visible = True
            End With
            AddHandler picQuitter.Click, AddressOf picQuitter_Click 'Donne au bouton un gestionnaire d'évènement
            Me.Controls.Add(picQuitter) 'Ajoute le bouton au formulaire (jeu)

            intCompteurSiMort += 1
        End If

        If intCompteurSiMort = 5 Then
            blnJeuEnMarche = False
        End If

    End Sub


    '*****************************
    'Jouer la musique
    '*****************************
    Private Sub JouerMusique()
        Try 'Version lâche d'éviter des erreurs
            sonNature.Volume = -1000
            sonCoeur.Volume = CInt((intSanteVieJoueur ^ 2) * -1) '100 de vie (max) = -10 000 = silence
        Catch ex As Exception

        End Try
    End Sub


    '=========================================================================================================
    '*********************************************************************************************************
    '                                        FIN BOUCLE DU JEU
    '*********************************************************************************************************
    '=========================================================================================================

    '*****************************
    'fonctions, procédures et gestionnaires d'événements
    '*****************************

    Private Sub InitialiserValiables()
        'Met les valeurs par défaut des variables
        policeDeCaracteres = New Font("Arial", 40)
        versionCarte = My.Resources.MAP_TP2
        intDommageZombie = 16
        picQuitter = New PictureBox
        picJouer = New PictureBox
        blnJeuEnMarche = True
        dblAncienAngleSouris = 0
        dblNouvelAngleSouris = Nothing
        sngAncienAngleZombieJoueur = 0
        sngNouvelAngleZombieJoueur = Nothing
        posCentreJoueur = New Point(32, 32)
        intVitesseDeplacement = 8
        intVitesseZombies = 6
        deplacementDirection = 0
        derniereDirection = 4
        listeTouchesAppuyees = {0, 0, 0, 0}
        mat = New Drawing2D.Matrix
        intSanteVieJoueur = 100
        intMunitionJoueur = 50
        intCompteurSiMort = 0
        posZombiesCentre = New List(Of Point)
    End Sub

    Private Sub ChargerLeFormulaireEtLesProprietesGraphiques()

        'Déclaration de la musique et des propriétés de la musique
        sonNature = New Audio(".\bin\natureSounds.ogg", True)
        sonCoeur = New Audio(".\bin\heartBeat.ogg", True)
        sonCoeur.Volume = -10000

        'Changement des propriétés du formulaire
        Me.Height = Screen.PrimaryScreen.Bounds.Size.Height
        Me.Width = Screen.PrimaryScreen.Bounds.Size.Width
        Me.Focus()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.TopMost = True
        Me.WindowState = FormWindowState.Maximized

        'Déclaration des variables graphiques/bitmaps
        G = Me.CreateGraphics
        BB = New Bitmap(intResolutionLargeur, intResolutionHauteur)
        bmpJoueur = New Bitmap(My.Resources.PERSONNAGE_TP2)
        bmpZombie = New Bitmap(My.Resources.ZOMBIE_TP_2)

        'Déclaration variable initiale pour la rotation du joueur
        dblAncienAngleSouris = Atan2(MousePosition.Y - posCentreJoueur.Y, MousePosition.X - posCentreJoueur.X) * 180 / Math.PI + 6.5

        'Débuter la musique
        frmMusicMe.musique = New Audio(".\bin\zombieSong.mp3", True)
        frmMusicMe.musique.CurrentPosition = 121

        'Charger l'image de fond et crée un contrôle pour commencer à jouer
        Me.BackgroundImage = My.Resources.MAP_TP2___Titre
        Me.BackgroundImageLayout = ImageLayout.Stretch
        With picJouer 'Donne les propriétés du bouton quitter
            .Size = New Size(My.Resources.MusicZ_logo.Width, My.Resources.MusicZ_logo.Height)
            .Location = New Point(CInt(intResolutionLargeur / 2 - picJouer.Size.Width / 2), CInt(intResolutionHauteur / 2 - picJouer.Height / 2))
            .BackgroundImage = My.Resources.MusicZ_logo
            .Visible = True
        End With
        AddHandler picJouer.Click, AddressOf picJouer_Click 'Donne au bouton un gestionnaire d'évènement
        Me.Controls.Add(picJouer) 'Ajoute le bouton au formulaire (jeu)



    End Sub

    Private Sub CommencerBoucleJeu()
        While blnJeuEnMarche

            Application.DoEvents() 'Très important, permet d'activer les événements, sinon gel de l'application

            'Détecter les données entrées par l'utilisateur (clavier et souris)
            DeplacerJoueur(listeTouchesAppuyees)

            'Faire fonctionner l'intelligence artificielle
            ApparitionEnnemies()

            'Créer les collisions
            mat.RotateAt(CSng(-dblNouvelAngleSouris), posCentreJoueur) 'Remet les valeurs x et y par défaut pour avoir les bonnes valeurs
            CreerCollisions()
            mat.RotateAt(CSng(dblNouvelAngleSouris), posCentreJoueur) 'Remet l'ancienne rotation pour le dessiner correctement plus tard

            'Dessiner les graphiques
            DessinerGraphiques()

            'Jouer la musique
            JouerMusique()
        End While
    End Sub ' <------------- BOUCLE DU JEU ------------------

    Private Sub picQuitter_Click(sender As Object, e As EventArgs)
        QuitterJeu()
    End Sub

    Private Sub picJouer_Click(sender As Object, e As EventArgs)
        picJouer.Visible = False
        'frmMusicMe.musique.Stop() 'À enlever le commentaire si on ne veut pas de musique lors du jeu (après le menu)
        CommencerBoucleJeu()
    End Sub

    Private Sub QuitterJeu()
        Me.Width = 0
        Me.Height = 0
        frmMusicMe.musique.Stop()
        sonCoeur.Stop()
        sonNature.Stop()
        Me.Close()
        frmMusicMe.Focus()
    End Sub

End Class
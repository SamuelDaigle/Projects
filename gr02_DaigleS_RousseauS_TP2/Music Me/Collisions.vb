Module Collisions


    'TOUTES LES CONSTANTES SONT SÉPARÉES DANS CES RÉGIONS
#Region "Constantes Centre Commercial"
    'CONSTANTES CENTRE COMMERCIAL
    'constantes pour le tour de la bâtisse
    Const BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_X As Integer = 395
    Const BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_Y As Integer = 40
    Const BATISSE_CENTRE_COIN_INFERIEUR_GAUCHE_X As Integer = 395
    Const BATISSE_CENTRE_COIN_INFERIEUR_GAUCHE_Y As Integer = 340
    Const BATISSE_CENTRE_COIN_SUPERIEUR_DROIT_X As Integer = 1220
    Const BATISSE_CENTRE_COIN_SUPERIEUR_DROIT_Y As Integer = 40
    Const BATISSE_CENTRE_COIN_GAUCHE_PORTE_BAS_X As Integer = 625
    Const BATISSE_CENTRE_COIN_GAUCHE_PORTE_BAS_Y As Integer = 340
    Const BATISSE_CENTRE_COIN_DROIT_PORTE_BAS_X As Integer = 725
    Const BATISSE_CENTRE_COIN_DROIT_PORTE_BAS_Y As Integer = 340
    Const BATISSE_CENTRE_COIN_INFERIEUR_DROIT_X As Integer = 1220
    Const BATISSE_CENTRE_COIN_INFERIEUR_DROIT_Y As Integer = 340
    Const BATISSE_CENTRE_COIN_BAS_PORTE_DROITE_X As Integer = 1220
    Const BATISSE_CENTRE_COIN_BAS_PORTE_DROITE_Y As Integer = 165
    Const BATISSE_CENTRE_COIN_HAUT_PORTE_DROITE_X As Integer = 1220
    Const BATISSE_CENTRE_COIN_HAUT_PORTE_DROITE_Y As Integer = 140

    'constantes pour les étagères
    'Étagère 1
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_1_X As Integer = 445
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_1_Y As Integer = 71
    Const COIN_SUPERIEUR_DROIT_ETAGERE_1_X As Integer = 470
    Const COIN_SUPERIEUR_DROIT_ETAGERE_1_Y As Integer = 71
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_1_X As Integer = 445
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_1_Y As Integer = 267
    Const COIN_INFERIEUR_DROIT_ETAGERE_1_X As Integer = 470
    Const COIN_INFERIEUR_DROIT_ETAGERE_1_Y As Integer = 267
    'Étagère 2
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_2_X As Integer = 500
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_2_Y As Integer = 71
    Const COIN_SUPERIEUR_DROIT_ETAGERE_2_X As Integer = 525
    Const COIN_SUPERIEUR_DROIT_ETAGERE_2_Y As Integer = 71
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_2_X As Integer = 500
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_2_Y As Integer = 267
    Const COIN_INFERIEUR_DROIT_ETAGERE_2_X As Integer = 525
    Const COIN_INFERIEUR_DROIT_ETAGERE_2_Y As Integer = 267
    'Étagère 3
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_3_X As Integer = 553
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_3_Y As Integer = 71
    Const COIN_SUPERIEUR_DROIT_ETAGERE_3_X As Integer = 750
    Const COIN_SUPERIEUR_DROIT_ETAGERE_3_Y As Integer = 71
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_3_X As Integer = 553
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_3_Y As Integer = 95
    Const COIN_INFERIEUR_DROIT_ETAGERE_3_X As Integer = 750
    Const COIN_INFERIEUR_DROIT_ETAGERE_3_Y As Integer = 95
    'Étagère 4
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_4_X As Integer = 553
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_4_Y As Integer = 120
    Const COIN_SUPERIEUR_DROIT_ETAGERE_4_X As Integer = 750
    Const COIN_SUPERIEUR_DROIT_ETAGERE_4_Y As Integer = 120
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_4_X As Integer = 553
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_4_Y As Integer = 145
    Const COIN_INFERIEUR_DROIT_ETAGERE_4_X As Integer = 750
    Const COIN_INFERIEUR_DROIT_ETAGERE_4_Y As Integer = 145
    'Étagère 5
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_5_X As Integer = 553
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_5_Y As Integer = 175
    Const COIN_SUPERIEUR_DROIT_ETAGERE_5_X As Integer = 750
    Const COIN_SUPERIEUR_DROIT_ETAGERE_5_Y As Integer = 175
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_5_X As Integer = 553
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_5_Y As Integer = 200
    Const COIN_INFERIEUR_DROIT_ETAGERE_5_X As Integer = 750
    Const COIN_INFERIEUR_DROIT_ETAGERE_5_Y As Integer = 200
    'Étagère 6
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_6_X As Integer = 788
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_6_Y As Integer = 71
    Const COIN_SUPERIEUR_DROIT_ETAGERE_6_X As Integer = 985
    Const COIN_SUPERIEUR_DROIT_ETAGERE_6_Y As Integer = 71
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_6_X As Integer = 788
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_6_Y As Integer = 95
    Const COIN_INFERIEUR_DROIT_ETAGERE_6_X As Integer = 985
    Const COIN_INFERIEUR_DROIT_ETAGERE_6_Y As Integer = 95
    'Étagère 7
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_7_X As Integer = 788
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_7_Y As Integer = 120
    Const COIN_SUPERIEUR_DROIT_ETAGERE_7_X As Integer = 985
    Const COIN_SUPERIEUR_DROIT_ETAGERE_7_Y As Integer = 120
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_7_X As Integer = 788
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_7_Y As Integer = 145
    Const COIN_INFERIEUR_DROIT_ETAGERE_7_X As Integer = 985
    Const COIN_INFERIEUR_DROIT_ETAGERE_7_Y As Integer = 145
    'Étagère 8
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_8_X As Integer = 788
    Const COIN_SUPERIEUR_GAUCHE_ETAGERE_8_Y As Integer = 175
    Const COIN_SUPERIEUR_DROIT_ETAGERE_8_X As Integer = 985
    Const COIN_SUPERIEUR_DROIT_ETAGERE_8_Y As Integer = 175
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_8_X As Integer = 788
    Const COIN_INFERIEUR_GAUCHE_ETAGERE_8_Y As Integer = 200
    Const COIN_INFERIEUR_DROIT_ETAGERE_8_X As Integer = 985
    Const COIN_INFERIEUR_DROIT_ETAGERE_8_Y As Integer = 200

    'constantes pour les caisses
    'Caisse 1
    Const COIN_SUPERIEUR_GAUCHE_CAISSE_1_X As Integer = 700
    Const COIN_SUPERIEUR_GAUCHE_CAISSE_1_Y As Integer = 237
    Const COIN_INFERIEUR_GAUCHE_CAISSE_1_X As Integer = 700
    Const COIN_INFERIEUR_GAUCHE_CAISSE_1_Y As Integer = 315
    Const COIN_SUPERIEUR_DROIT_CAISSE_1_X As Integer = 725
    Const COIN_SUPERIEUR_DROIT_CAISSE_1_Y As Integer = 237
    Const COIN_INFERIEUR_DROIT_CAISSE_1_X As Integer = 725
    Const COIN_INFERIEUR_DROIT_CAISSE_1_Y As Integer = 315
    'Caisse 2
    Const COIN_SUPERIEUR_GAUCHE_CAISSE_2_X As Integer = 753
    Const COIN_SUPERIEUR_GAUCHE_CAISSE_2_Y As Integer = 237
    Const COIN_INFERIEUR_GAUCHE_CAISSE_2_X As Integer = 753
    Const COIN_INFERIEUR_GAUCHE_CAISSE_2_Y As Integer = 315
    Const COIN_SUPERIEUR_DROIT_CAISSE_2_X As Integer = 780
    Const COIN_SUPERIEUR_DROIT_CAISSE_2_Y As Integer = 237
    Const COIN_INFERIEUR_DROIT_CAISSE_2_X As Integer = 780
    Const COIN_INFERIEUR_DROIT_CAISSE_2_Y As Integer = 315
    'Caisse 3
    Const COIN_SUPERIEUR_GAUCHE_CAISSE_3_X As Integer = 808
    Const COIN_SUPERIEUR_GAUCHE_CAISSE_3_Y As Integer = 237
    Const COIN_INFERIEUR_GAUCHE_CAISSE_3_X As Integer = 808
    Const COIN_INFERIEUR_GAUCHE_CAISSE_3_Y As Integer = 315
    Const COIN_SUPERIEUR_DROIT_CAISSE_3_X As Integer = 835
    Const COIN_SUPERIEUR_DROIT_CAISSE_3_Y As Integer = 237
    Const COIN_INFERIEUR_DROIT_CAISSE_3_X As Integer = 835
    Const COIN_INFERIEUR_DROIT_CAISSE_3_Y As Integer = 315
    'Caisse 4
    Const COIN_SUPERIEUR_GAUCHE_CAISSE_4_X As Integer = 1111
    Const COIN_SUPERIEUR_GAUCHE_CAISSE_4_Y As Integer = 120
    Const COIN_INFERIEUR_GAUCHE_CAISSE_4_X As Integer = 1111
    Const COIN_INFERIEUR_GAUCHE_CAISSE_4_Y As Integer = 145
    Const COIN_SUPERIEUR_DROIT_CAISSE_4_X As Integer = 1190
    Const COIN_SUPERIEUR_DROIT_CAISSE_4_Y As Integer = 120
    Const COIN_INFERIEUR_DROIT_CAISSE_4_X As Integer = 1190
    Const COIN_INFERIEUR_DROIT_CAISSE_4_Y As Integer = 145

    'constantes pour les bacs
    'Bac 1
    Const COIN_SUPERIEUR_GAUCHE_BAC_1_X As Integer = 575
    Const COIN_SUPERIEUR_GAUCHE_BAC_1_Y As Integer = 235
    Const COIN_INFERIEUR_GAUCHE_BAC_1_X As Integer = 575
    Const COIN_INFERIEUR_GAUCHE_BAC_1_Y As Integer = 290
    Const COIN_SUPERIEUR_DROIT_BAC_1_X As Integer = 650
    Const COIN_SUPERIEUR_DROIT_BAC_1_Y As Integer = 235
    Const COIN_INFERIEUR_DROIT_BAC_1_X As Integer = 650
    Const COIN_INFERIEUR_DROIT_BAC_1_Y As Integer = 290
    'Bac 2
    Const COIN_SUPERIEUR_GAUCHE_BAC_2_X As Integer = 953
    Const COIN_SUPERIEUR_GAUCHE_BAC_2_Y As Integer = 232
    Const COIN_INFERIEUR_GAUCHE_BAC_2_X As Integer = 953
    Const COIN_INFERIEUR_GAUCHE_BAC_2_Y As Integer = 284
    Const COIN_SUPERIEUR_DROIT_BAC_2_X As Integer = 1026
    Const COIN_SUPERIEUR_DROIT_BAC_2_Y As Integer = 232
    Const COIN_INFERIEUR_DROIT_BAC_2_X As Integer = 1026
    Const COIN_INFERIEUR_DROIT_BAC_2_Y As Integer = 284
    'Bac 3
    Const COIN_SUPERIEUR_GAUCHE_BAC_3_X As Integer = 1062
    Const COIN_SUPERIEUR_GAUCHE_BAC_3_Y As Integer = 230
    Const COIN_INFERIEUR_GAUCHE_BAC_3_X As Integer = 1062
    Const COIN_INFERIEUR_GAUCHE_BAC_3_Y As Integer = 280
    Const COIN_SUPERIEUR_DROIT_BAC_3_X As Integer = 1134
    Const COIN_SUPERIEUR_DROIT_BAC_3_Y As Integer = 230
    Const COIN_INFERIEUR_DROIT_BAC_3_X As Integer = 1134
    Const COIN_INFERIEUR_DROIT_BAC_3_Y As Integer = 280

    'constantes pour le comptoir
    Const COIN_SUPERIEUR_EXTREMITE_GAUCHE_X As Integer = 885
    Const COIN_SUPERIEUR_EXTREMITE_GAUCHE_Y As Integer = 314
    Const COIN_INFERIEUR_EXTREMITE_GAUCHE_Y As Integer = 350
    Const COIN_MILIEU_COMPTOIR_X As Integer = 1176
    Const COIN_MILIEU_COMPTOIR_Y As Integer = 312
    Const COIN_GAUCHE_EXTREMITE_DROITE_X As Integer = 1176
    Const COIN_GAUCHE_EXTREMiTE_DROITE_Y As Integer = 214
    Const COIN_DROIT_EXTREMITE_DROIT_X = 1220

    'constantes pour la toilette
    'salle de bain
    Const COIN_SUPERIEUR_GAUCHE_CABINE_X As Integer = 1064
    Const COIN_SUPERIEUR_GAUCHE_CABINE_Y As Integer = 40
    Const COIN_SUPERIEUR_PORTE_CABINE_Y As Integer = 53
    Const COIN_INFERIEUR_PORTE_CABINE_X As Integer = 1064
    Const COIN_INFERIEUR_PORTE_CABINE_Y As Integer = 75
    Const COIN_INFERIEUR_GAUCHE_CABINE_X As Integer = 1064
    Const COIN_INFERIEUR_GAUCHE_CABINE_Y As Integer = 95
    Const COIN_INFERIEUR_DROIT_CABINE_X As Integer = 1220
    Const COIN_INFERIEUR_DROIT_CABINE_Y As Integer = 95

    'Évier
    Const COIN_SUPERIEUR_GAUCHE_EVIER_X As Integer = 1130
    Const COIN_SUPERIEUR_GAUCHE_EVIER_Y As Integer = 40
    Const COIN_INFERIEUR_GAUCHE_EVIER_X As Integer = 1130
    Const COIN_INFERIEUR_GAUCHE_EVIER_Y As Integer = 56
    Const COIN_INFERIEUR_DROIT_EVIER_X As Integer = 1154
    Const COIN_INFERIEUR_DROIT_EVIER_Y As Integer = 56
    Const COIN_SUPERIEUR_DROIT_EVIER_Y As Integer = 40

    'Toilette
    Const COIN_SUPERIEUR_GAUCHE_TOILETTE_X As Integer = 1190
    Const COIN_SUPERIEUR_GAUCHE_TOILETTE_Y As Integer = 40
    Const COIN_INFERIEUR_GAUCHE_TOILETTE_X As Integer = 1190
    Const COIN_INFERIEUR_GAUCHE_TOILETTE_Y As Integer = 77
    Const COIN_INFERIEUR_DROIT_TOILETTE_X As Integer = 1220
    Const COIN_INFERIEUR_DROIT_TOILETTE_Y As Integer = 77
    Const COIN_SUPERIEUR_DROIT_TOILETTE_X As Integer = 1220
#End Region
#Region "Constantes Bar"
    'CONSTANTES BAR
    'constantes pour le tour de la bâtisse
    Const BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_X As Integer = 461
    Const BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_Y As Integer = 456
    Const BATISSE_BAR_COIN_INFERIEUR_GAUCHE_X As Integer = 461
    Const BATISSE_BAR_COIN_INFERIEUR_GAUCHE_Y As Integer = 825
    Const BATISSE_BAR_COIN_SUPERIEUR_DROIT_X As Integer = 750
    Const BATISSE_BAR_COIN_SUPERIEUR_DROIT_Y As Integer = 456
    Const BATISSE_BAR_COIN_GAUCHE_PORTE_BAS_X As Integer = 592
    Const BATISSE_BAR_COIN_GAUCHE_PORTE_BAS_Y As Integer = 825
    Const BATISSE_BAR_COIN_DROIT_PORTE_BAS_X As Integer = 620
    Const BATISSE_BAR_COIN_DROIT_PORTE_BAS_Y As Integer = 825
    Const BATISSE_BAR_COIN_INFERIEUR_DROIT_Y As Integer = 825

    'constantes pour les tables
    'Table 1
    Const COIN_SUPERIEUR_GAUCHE_TABLE_1_X As Integer = 488
    Const COIN_SUPERIEUR_GAUCHE_TABLE_1_Y As Integer = 758
    Const COIN_INFERIEUR_GAUCHE_TABLE_1_X As Integer = 488
    Const COIN_INFERIEUR_GAUCHE_TABLE_1_Y As Integer = 795
    Const COIN_SUPERIEUR_DROIT_TABLE_1_X As Integer = 548
    Const COIN_SUPERIEUR_DROIT_TABLE_1_Y As Integer = 758
    Const COIN_INFERIEUR_DROIT_TABLE_1_X As Integer = 548
    Const COIN_INFERIEUR_DROIT_TABLE_1_Y As Integer = 795
    'Table 2
    Const COIN_SUPERIEUR_GAUCHE_TABLE_2_X As Integer = 488
    Const COIN_SUPERIEUR_GAUCHE_TABLE_2_Y As Integer = 678
    Const COIN_INFERIEUR_GAUCHE_TABLE_2_X As Integer = 488
    Const COIN_INFERIEUR_GAUCHE_TABLE_2_Y As Integer = 717
    Const COIN_SUPERIEUR_DROIT_TABLE_2_X As Integer = 548
    Const COIN_SUPERIEUR_DROIT_TABLE_2_Y As Integer = 678
    Const COIN_INFERIEUR_DROIT_TABLE_2_X As Integer = 548
    Const COIN_INFERIEUR_DROIT_TABLE_2_Y As Integer = 717
    'Table 3
    Const COIN_SUPERIEUR_GAUCHE_TABLE_3_X As Integer = 580
    Const COIN_SUPERIEUR_GAUCHE_TABLE_3_Y As Integer = 563
    Const COIN_INFERIEUR_GAUCHE_TABLE_3_X As Integer = 580
    Const COIN_INFERIEUR_GAUCHE_TABLE_3_Y As Integer = 602
    Const COIN_SUPERIEUR_DROIT_TABLE_3_X As Integer = 641
    Const COIN_SUPERIEUR_DROIT_TABLE_3_Y As Integer = 563
    Const COIN_INFERIEUR_DROIT_TABLE_3_X As Integer = 641
    Const COIN_INFERIEUR_DROIT_TABLE_3_Y As Integer = 602
    'Table de billard
    Const COIN_SUPERIEUR_GAUCHE_TABLE_BILLARD_X As Integer = 660
    Const COIN_SUPERIEUR_GAUCHE_TABLE_BILLARD_Y As Integer = 645
    Const COIN_INFERIEUR_GAUCHE_TABLE_BILLARD_X As Integer = 660
    Const COIN_INFERIEUR_GAUCHE_TABLE_BILLARD_Y As Integer = 735
    Const COIN_SUPERIEUR_DROIT_TABLE_BILLARD_X As Integer = 717
    Const COIN_SUPERIEUR_DROIT_TABLE_BILLARD_Y As Integer = 645
    Const COIN_INFERIEUR_DROIT_TABLE_BILLARD_X As Integer = 717
    Const COIN_INFERIEUR_DROIT_TABLE_BILLARD_Y As Integer = 735
    'Table de PinBall
    Const COIN_SUPERIEUR_GAUCHE_TABLE_PINBALL_X As Integer = 710
    Const COIN_SUPERIEUR_GAUCHE_TABLE_PINBALL_Y As Integer = 790
    Const COIN_INFERIEUR_GAUCHE_TABLE_PINBALL_X As Integer = 710
    Const COIN_INFERIEUR_GAUCHE_TABLE_PINBALL_Y As Integer = 825
    Const COIN_SUPERIEUR_DROIT_TABLE_PINBALL_X As Integer = 750
    Const COIN_SUPERIEUR_DROIT_TABLE_PINBALL_Y As Integer = 790
    Const COIN_INFERIEUR_DROIT_TABLE_PINBALL_X As Integer = 750
    Const COIN_INFERIEUR_DROIT_TABLE_PINBALL_Y As Integer = 825

    'constantes pour le comptoir
    Const COIN_SUPERIEUR_GAUCHE_COMPTOIR_BAR_X As Integer = 488
    Const COIN_SUPERIEUR_GAUCHE_COMPTOIR_BAR_Y As Integer = 456
    Const COIN_SUPERIEUR_DROIT_COMPTOIR_BAR_Y As Integer = 456
    Const COIN_INFERIEUR_GAUCHE_COMPTOIR_BAR_X As Integer = 483
    Const COIN_INFERIEUR_DROIT_COMPTOIR_BAR_X As Integer = 526
    Const COIN_INFERIEUR_DROIT_COMPTOIR_BAR_Y As Integer = 617
    Const MILIEU_COMPTOIR_BAR_COIN_INFERIEUR_GAUCHE_X As Integer = 488
    Const MILIEU_COMPTOIR_BAR_COIN_INFERIEUR_GAUCHE_Y As Integer = 610
    Const MILIEU_COMPTOIR_BAR_COIN_INFERIEUR_DROIT_X As Integer = 493
    Const MILIEU_COMPTOIR_BAR_COIN_INFERIEUR_DROIT_Y As Integer = 610
    Const MILIEU_COMPTOIR_BAR_COIN_SUPERIEUR_GAUCHE_X As Integer = 526
    Const MILIEU_COMPTOIR_BAR_COIN_SUPERIEUR_GAUCHE_Y As Integer = 492
    Const MILIEU_COMPTOIR_BAR_COIN_SUPERIEUR_DROIT_Y As Integer = 492

    'constantes pour la batterie
    Const COIN_SUPERIEUR_GAUCHE_BATTERIE_X As Integer = 665
    Const COIN_SUPERIEUR_GAUCHE_BATTERIE_Y As Integer = 456
    Const COIN_INFERIEUR_GAUCHE_BATTERIE_X As Integer = 665
    Const COIN_INFERIEUR_GAUCHE_BATTERIE_Y As Integer = 495
    Const COIN_SUPERIEUR_DROIT_BATTERIE_X As Integer = 730
    Const COIN_SUPERIEUR_DROIT_BATTERIE_Y As Integer = 456
    Const COIN_INFERIEUR_DROIT_BATTERIE_X As Integer = 730
    Const COIN_INFERIEUR_DROIT_BATTERIE_Y As Integer = 495
#End Region
#Region "Constantes Stationnement"
    'CONSTANTES stationnement / RUE
    'constantes pour les voitures
    'Voiture 1
    Const COIN_SUPERIEUR_GAUCHE_VOITURE_1_X As Integer = 1350
    Const COIN_SUPERIEUR_GAUCHE_VOITURE_1_Y As Integer = 100
    Const COIN_INFERIEUR_GAUCHE_VOITURE_1_X As Integer = 1350
    Const COIN_INFERIEUR_GAUCHE_VOITURE_1_Y As Integer = 165
    Const COIN_SUPERIEUR_DROIT_VOITURE_1_X As Integer = 1388
    Const COIN_SUPERIEUR_DROIT_VOITURE_1_Y As Integer = 100
    Const COIN_INFERIEUR_DROIT_VOITURE_1_X As Integer = 1388
    Const COIN_INFERIEUR_DROIT_VOITURE_1_Y As Integer = 165
    'Voiture 2
    Const COIN_SUPERIEUR_GAUCHE_VOITURE_2_X As Integer = 1410
    Const COIN_SUPERIEUR_GAUCHE_VOITURE_2_Y As Integer = 223
    Const COIN_INFERIEUR_GAUCHE_VOITURE_2_X As Integer = 1410
    Const COIN_INFERIEUR_GAUCHE_VOITURE_2_Y As Integer = 290
    Const COIN_SUPERIEUR_DROIT_VOITURE_2_X As Integer = 1450
    Const COIN_SUPERIEUR_DROIT_VOITURE_2_Y As Integer = 223
    Const COIN_INFERIEUR_DROIT_VOITURE_2_X As Integer = 1450
    Const COIN_INFERIEUR_DROIT_VOITURE_2_Y As Integer = 290
    'Voiture 3
    Const COIN_SUPERIEUR_GAUCHE_VOITURE_3_X As Integer = 1524
    Const COIN_SUPERIEUR_GAUCHE_VOITURE_3_Y As Integer = 97
    Const COIN_INFERIEUR_GAUCHE_VOITURE_3_X As Integer = 1524
    Const COIN_INFERIEUR_GAUCHE_VOITURE_3_Y As Integer = 167
    Const COIN_SUPERIEUR_DROIT_VOITURE_3_X As Integer = 1580
    Const COIN_SUPERIEUR_DROIT_VOITURE_3_Y As Integer = 97
    Const COIN_INFERIEUR_DROIT_VOITURE_3_X As Integer = 1580
    Const COIN_INFERIEUR_DROIT_VOITURE_3_Y As Integer = 167
    'Voiture 4
    Const COIN_SUPERIEUR_GAUCHE_VOITURE_4_X As Integer = 1540
    Const COIN_SUPERIEUR_GAUCHE_VOITURE_4_Y As Integer = 220
    Const COIN_INFERIEUR_GAUCHE_VOITURE_4_X As Integer = 1540
    Const COIN_INFERIEUR_GAUCHE_VOITURE_4_Y As Integer = 286
    Const COIN_SUPERIEUR_DROIT_VOITURE_4_X As Integer = 1580
    Const COIN_SUPERIEUR_DROIT_VOITURE_4_Y As Integer = 220
    Const COIN_INFERIEUR_DROIT_VOITURE_4_X As Integer = 1580
    Const COIN_INFERIEUR_DROIT_VOITURE_4_Y As Integer = 286
    'Voiture 5
    Const COIN_SUPERIEUR_GAUCHE_VOITURE_5_X As Integer = 1713
    Const COIN_SUPERIEUR_GAUCHE_VOITURE_5_Y As Integer = 97
    Const COIN_INFERIEUR_GAUCHE_VOITURE_5_X As Integer = 1713
    Const COIN_INFERIEUR_GAUCHE_VOITURE_5_Y As Integer = 165
    Const COIN_SUPERIEUR_DROIT_VOITURE_5_X As Integer = 1754
    Const COIN_SUPERIEUR_DROIT_VOITURE_5_Y As Integer = 97
    Const COIN_INFERIEUR_DROIT_VOITURE_5_X As Integer = 1754
    Const COIN_INFERIEUR_DROIT_VOITURE_5_Y As Integer = 165
    'Voiture 6
    Const COIN_SUPERIEUR_GAUCHE_VOITURE_6_X As Integer = 1857
    Const COIN_SUPERIEUR_GAUCHE_VOITURE_6_Y As Integer = 252
    Const COIN_INFERIEUR_GAUCHE_VOITURE_6_X As Integer = 1857
    Const COIN_INFERIEUR_GAUCHE_VOITURE_6_Y As Integer = 322
    Const COIN_SUPERIEUR_DROIT_VOITURE_6_X As Integer = 1907
    Const COIN_SUPERIEUR_DROIT_VOITURE_6_Y As Integer = 252
    Const COIN_INFERIEUR_DROIT_VOITURE_6_X As Integer = 1907
    Const COIN_INFERIEUR_DROIT_VOITURE_6_Y As Integer = 322
    'Compartiment du camion
    Const COIN_SUPERIEUR_GAUCHE_COMPARTIMENT_X As Integer = 214
    Const COIN_SUPERIEUR_GAUCHE_COMPARTIMENT_Y As Integer = 546
    Const COIN_INFERIEUR_GAUCHE_COMPARTIMENT_X As Integer = 214
    Const COIN_INFERIEUR_GAUCHE_COMPARTIMENT_Y As Integer = 876
    Const COIN_SUPERIEUR_DROIT_COMPARTIMENT_X As Integer = 280
    Const COIN_SUPERIEUR_DROIT_COMPARTIMENT_Y As Integer = 546
    Const COIN_INFERIEUR_DROIT_COMPARTIMENT_X As Integer = 280
    Const COIN_INFERIEUR_DROIT_COMPARTIMENT_Y As Integer = 876
    'Cabine des passagers du camion
    Const COIN_SUPERIEUR_GAUCHE_CAMION_X As Integer = 191
    Const COIN_SUPERIEUR_GAUCHE_CAMION_Y As Integer = 876
    Const COIN_INFERIEUR_GAUCHE_CAMION_X As Integer = 191
    Const COIN_INFERIEUR_GAUCHE_CAMION_Y As Integer = 955
    Const COIN_SUPERIEUR_DROIT_CAMION_X As Integer = 270
    Const COIN_SUPERIEUR_DROIT_CAMION_Y As Integer = 876
    Const COIN_INFERIEUR_DROIT_CAMION_X As Integer = 270
    Const COIN_INFERIEUR_DROIT_CAMION_Y As Integer = 955
#End Region
#Region "Constantes Maison"
    'CONSTANTES POUR LA MAISON
    'Tour de la bâtisse
    Const BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X As Integer = 1444
    Const BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_Y As Integer = 431
    Const BATISSE_MAISON_COIN_INFERIEUR_GAUCHE_X As Integer = 1444
    Const BATISSE_MAISON_COIN_INFERIEUR_GAUCHE_Y As Integer = 801
    Const BATISSE_MAISON_COIN_SUPERIEUR_DROIT_X As Integer = 1737
    Const BATISSE_MAISON_COIN_SUPERIEUR_DROIT_Y As Integer = 431
    Const BATISSE_MAISON_COIN_SUPERIEUR_PORTE_GAUCHE_Y As Integer = 575
    Const BATISSE_MAISON_COIN_INFERIEUR_PORTE_GAUCHE_Y As Integer = 622
    Const BATISSE_MAISON_COIN_SUPERIEUR_PORTE_DROITE_X As Integer = 1737
    Const BATISSE_MAISON_COIN_SUPERIEUR_PORTE_DROITE_Y As Integer = 512
    Const BATISSE_MAISON_COIN_INFERIEUR_PORTE_DROITE_Y As Integer = 534
    Const BATISSE_MAISON_COIN_INFERIEUR_DROIT_X As Integer = 1737
    Const BATISSE_MAISON_COIN_INFERIEUR_DROIT_Y As Integer = 801

    'constantes pour l'escalier
    Const COIN_SUPERIEUR_GAUCHE_ESCALIER_X As Integer = 1447
    Const COIN_SUPERIEUR_GAUCHE_ESCALIER_Y As Integer = 433
    Const COIN_INFERIEUR_GAUCHE_ESCALIER_X As Integer = 1447
    Const COIN_INFERIEUR_GAUCHE_ESCALIER_Y As Integer = 476
    Const COIN_SUPERIEUR_DROIT_ESCALIER_X As Integer = 1579
    Const COIN_SUPERIEUR_DROIT_ESCALIER_Y As Integer = 433
    Const COIN_INFERIEUR_DROIT_ESCALIER_X As Integer = 1579
    Const COIN_INFERIEUR_DROIT_ESCALIER_Y As Integer = 476
    Const COIN_MILIEU_ESCALIER_X As Integer = 1520

    'constantes pour la table
    Const COIN_SUPERIEUR_GAUCHE_TABLE_X As Integer = 1489
    Const COIN_SUPERIEUR_GAUCHE_TABLE_Y As Integer = 515
    Const COIN_INFERIEUR_GAUCHE_TABLE_X As Integer = 1489
    Const COIN_INFERIEUR_GAUCHE_TABLE_Y As Integer = 552
    Const COIN_SUPERIEUR_DROIT_TABLE_X As Integer = 1548
    Const COIN_SUPERIEUR_DROIT_TABLE_Y As Integer = 515
    Const COIN_INFERIEUR_DROIT_TABLE_X As Integer = 1548
    Const COIN_INFERIEUR_DROIT_TABLE_Y As Integer = 552

    'constantes pour le contour du salon
    Const BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_X As Integer = 1587
    Const BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y As Integer = 648
    Const BATISSE_SALON_COIN_INFERIEUR_GAUCHE_X As Integer = 1587
    Const BATISSE_SALON_COIN_INFERIEUR_GAUCHE_Y As Integer = 801
    Const BATISSE_SALON_COIN_SUPERIEUR_DROIT_X As Integer = 1739
    Const BATISSE_SALON_COIN_INFERIEUR_DROIT_Y As Integer = 801
    Const BATISSE_SALON_COIN_SUPERIEUR_DROIT_Y As Integer = 648
    Const BATISSE_SALON_COIN_INFERIEUR_DROIT_X As Integer = 1739
    Const BATISSE_SALON_COIN_GAUCHE_PORTE_X As Integer = 1644
    Const BATISSE_SALON_COIN_DROIT_PORTE_X As Integer = 1670


    'constantes pour le divan
    Const COIN_SUPERIEUR_GAUCHE_DIVAN_X As Integer = 1621
    Const COIN_SUPERIEUR_GAUCHE_DIVAN_Y As Integer = 711
    Const COIN_INFERIEUR_GAUCHE_DIVAN_X As Integer = 1621
    Const COIN_INFERIEUR_GAUCHE_DIVAN_Y As Integer = 739
    Const COIN_SUPERIEUR_DROIT_DIVAN_X As Integer = 1703
    Const COIN_SUPERIEUR_DROIT_DIVAN_Y As Integer = 711
    Const COIN_INFERIEUR_DROIT_DIVAN_X As Integer = 1703
    Const COIN_INFERIEUR_DROIT_DIVAN_Y As Integer = 739

    'constantes pour la télévision
    Const COIN_SUPERIEUR_GAUCHE_TELEVISION_X As Integer = 1623
    Const COIN_SUPERIEUR_GAUCHE_TELEVISION_Y As Integer = 773
    Const COIN_INFERIEUR_GAUCHE_TELEVISION_X As Integer = 1623
    Const COIN_INFERIEUR_GAUCHE_TELEVISION_Y As Integer = 801
    Const COIN_SUPERIEUR_DROIT_TELEVISION_X As Integer = 1698
    Const COIN_SUPERIEUR_DROIT_TELEVISION_Y As Integer = 773
    Const COIN_INFERIEUR_DROIT_TELEVISION_X As Integer = 1698
    Const COIN_INFERIEUR_DROIT_TELEVISION_Y As Integer = 801

    'constantes pour le comptoir
    Const COIN_SUPERIEUR_GAUCHE_COMPTOIR_MAISON_X As Integer = 1444
    Const COIN_SUPERIEUR_GAUCHE_COMPTOIR_MAISON_Y As Integer = 673
    Const COIN_SUPERIEUR_DROIT_COMPTOIR_MAISON_X As Integer = 1463
    Const COIN_SUPERIEUR_DROIT_COMPTOIR_MAISON_Y As Integer = 673
    Const COIN_MILIEU_COMPTOIR_MAISON_X As Integer = 1463
    Const COIN_MILIEU_COMPTOIR_MAISON_Y As Integer = 782
    Const COIN_INFERIEUR_DROIT_COMPTOIR_MAISON_X As Integer = 1586
    Const COIN_INFERIEUR_DROIT_COMPTOIR_MAISON_Y As Integer = 801
    Const COIN_SUPERIEUR_DROIT_DROIT_COMPTOIR_MAISON_X As Integer = 1586
    Const COIN_SUPERIEUR_DROIT_DROIT_COMPTOIR_MAISON_Y As Integer = 782
#End Region

    Public deplacementX As Integer
    Public deplacementY As Integer

    'Attention: les collisions ne fonctionnent qu'avec un ordinateur avec une résolution de 1920x1080
    'Afin de résoudre ce problème, veuillez changer toutes les constantes pour des variables (en modifiant les noms de variable)
    'exemple:

    'Private Function ChangerResolutionConstante(ByVal constanteCollision As Integer, ByVal largeurOuHauteur As String) As Integer
    '    Dim ratioResolution As Integer
    '    Dim valeurRetour As Integer

    '    If largeurOuHauteur = "largeur" Then
    '        ratioResolution = CInt(Screen.PrimaryScreen.Bounds.Width / 1920)
    '    Else
    '        ratioResolution = CInt(Screen.PrimaryScreen.Bounds.Height / 1080)
    '    End If
    '    valeurRetour = CInt(constanteCollision * ratioResolution)

    '    Return valeurRetour

    'End Function

    Public Sub CollisionsCentreCommercial(ByVal ObjetsEnMouvementX As Integer, ByVal ObjetsEnMouvementY As Integer, ByVal recRectangle As Rectangle, Optional numeroZombie As Integer = -1)
        Dim collision As Boolean = False
        deplacementX = ObjetsEnMouvementX
        deplacementY = ObjetsEnMouvementY
        '===========================================
        '   CENTRE COMMERCIAL
        '===========================================
        '--------------------TOUR DE LA BÂTISSE----------------------
        'Mur gauche du centre commercial à partir de l'extérieur
        If ObjetsEnMouvementX >= (BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= (BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_X) AndAlso ObjetsEnMouvementY >= BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_Y AndAlso ObjetsEnMouvementY <= BATISSE_CENTRE_COIN_INFERIEUR_GAUCHE_Y Then
            deplacementX = CInt(BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_X - recRectangle.Width / 2)

        End If

        'Mur gauche du centre commercial à partir de l'intérieur
        If ObjetsEnMouvementX <= (BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= (BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_X) AndAlso ObjetsEnMouvementY >= BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_Y AndAlso ObjetsEnMouvementY <= BATISSE_CENTRE_COIN_INFERIEUR_GAUCHE_Y Then
            deplacementX = CInt(BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_X + recRectangle.Width / 2)

        End If

        'Mur haut du centre commercial à partir de l'extérieur
        If ObjetsEnMouvementY >= (BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= (BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_Y) AndAlso ObjetsEnMouvementX >= BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_CENTRE_COIN_SUPERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_Y - (recRectangle.Height / 2))

        End If

        'Mur haut du centre commercial à partir de l'intérieur
        If ObjetsEnMouvementY <= (BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= (BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_Y) AndAlso ObjetsEnMouvementX >= BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_CENTRE_COIN_SUPERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_CENTRE_COIN_SUPERIEUR_GAUCHE_Y + recRectangle.Height / 2) + 1

        End If

        'Mur Bas du centre commercial à partir du mur gauche vers la porte de l'extérieur
        If ObjetsEnMouvementY <= (BATISSE_CENTRE_COIN_GAUCHE_PORTE_BAS_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY > BATISSE_CENTRE_COIN_GAUCHE_PORTE_BAS_Y AndAlso ObjetsEnMouvementX >= BATISSE_CENTRE_COIN_INFERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_CENTRE_COIN_GAUCHE_PORTE_BAS_X Then
            deplacementY = CInt(BATISSE_CENTRE_COIN_GAUCHE_PORTE_BAS_Y + recRectangle.Height / 2) + 1

        End If

        'Mur Bas du centre commercial à partir du mur gauche vers la porte de l'intérieur
        If ObjetsEnMouvementY >= (BATISSE_CENTRE_COIN_GAUCHE_PORTE_BAS_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= BATISSE_CENTRE_COIN_GAUCHE_PORTE_BAS_Y AndAlso ObjetsEnMouvementX >= BATISSE_CENTRE_COIN_INFERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_CENTRE_COIN_GAUCHE_PORTE_BAS_X Then
            deplacementY = CInt(BATISSE_CENTRE_COIN_GAUCHE_PORTE_BAS_Y - recRectangle.Height / 2)

        End If

        'Mur Bas du centre commercial à partir de la porte vers le mur droit de l'extérieur
        If ObjetsEnMouvementY <= (BATISSE_CENTRE_COIN_DROIT_PORTE_BAS_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY > BATISSE_CENTRE_COIN_DROIT_PORTE_BAS_Y AndAlso ObjetsEnMouvementX >= BATISSE_CENTRE_COIN_DROIT_PORTE_BAS_X AndAlso ObjetsEnMouvementX <= BATISSE_CENTRE_COIN_SUPERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_CENTRE_COIN_DROIT_PORTE_BAS_Y + recRectangle.Height / 2) + 1

        End If

        'Mur bas du centre commercial à partir de la porte vers le mur droit de l'intérieur
        If ObjetsEnMouvementY >= (BATISSE_CENTRE_COIN_DROIT_PORTE_BAS_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= BATISSE_CENTRE_COIN_DROIT_PORTE_BAS_Y AndAlso ObjetsEnMouvementX >= BATISSE_CENTRE_COIN_DROIT_PORTE_BAS_X AndAlso ObjetsEnMouvementX <= BATISSE_CENTRE_COIN_SUPERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_CENTRE_COIN_DROIT_PORTE_BAS_Y - recRectangle.Height / 2)

        End If

        'Mur droit du centre commercial à partir du mur du bas vers la porte de l'Extérieur
        If ObjetsEnMouvementX <= (BATISSE_CENTRE_COIN_INFERIEUR_DROIT_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX > BATISSE_CENTRE_COIN_INFERIEUR_DROIT_X AndAlso ObjetsEnMouvementY <= BATISSE_CENTRE_COIN_INFERIEUR_DROIT_Y AndAlso ObjetsEnMouvementY >= BATISSE_CENTRE_COIN_BAS_PORTE_DROITE_Y Then
            deplacementX = CInt(BATISSE_CENTRE_COIN_BAS_PORTE_DROITE_X + recRectangle.Width / 2)

        End If

        'Mur droit du centre commercial à partir du mur du bas vers la porte de l'intérieur
        If ObjetsEnMouvementX >= (BATISSE_CENTRE_COIN_INFERIEUR_DROIT_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= BATISSE_CENTRE_COIN_INFERIEUR_DROIT_X AndAlso ObjetsEnMouvementY <= BATISSE_CENTRE_COIN_INFERIEUR_DROIT_Y AndAlso ObjetsEnMouvementY >= BATISSE_CENTRE_COIN_BAS_PORTE_DROITE_Y Then
            deplacementX = CInt(BATISSE_CENTRE_COIN_BAS_PORTE_DROITE_X - recRectangle.Width / 2)

        End If

        'Mur droit du centre commercial à partir de la porte vers le mur du haut de l'extérieur
        If ObjetsEnMouvementX <= (BATISSE_CENTRE_COIN_SUPERIEUR_DROIT_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= BATISSE_CENTRE_COIN_SUPERIEUR_DROIT_X AndAlso ObjetsEnMouvementY <= BATISSE_CENTRE_COIN_HAUT_PORTE_DROITE_Y AndAlso ObjetsEnMouvementY >= BATISSE_CENTRE_COIN_SUPERIEUR_DROIT_Y Then
            deplacementX = CInt(BATISSE_CENTRE_COIN_HAUT_PORTE_DROITE_X + recRectangle.Width / 2)

        End If

        'Mur droit du centre commercial à partir de la porte vers le mur du haut de l'intérieur
        If ObjetsEnMouvementX >= (BATISSE_CENTRE_COIN_SUPERIEUR_DROIT_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX < BATISSE_CENTRE_COIN_SUPERIEUR_DROIT_X AndAlso ObjetsEnMouvementY <= BATISSE_CENTRE_COIN_HAUT_PORTE_DROITE_Y AndAlso ObjetsEnMouvementY >= BATISSE_CENTRE_COIN_SUPERIEUR_DROIT_Y Then
            deplacementX = CInt(BATISSE_CENTRE_COIN_HAUT_PORTE_DROITE_X - recRectangle.Width / 2)

        End If

        '------------------TOUTES LES ÉTAGÈRES--------------------------
        'Première étagère sur la gauche, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_1_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_ETAGERE_1_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_ETAGERE_1_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_ETAGERE_1_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_1_X - (recRectangle.Width / 2))

        End If

        'Première étagère sur la gauche, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_1_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_ETAGERE_1_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_ETAGERE_1_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_ETAGERE_1_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_1_Y - (recRectangle.Height / 2))

        End If

        'Première étagère sur la gauche, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_ETAGERE_1_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_ETAGERE_1_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_ETAGERE_1_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_ETAGERE_1_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_ETAGERE_1_Y + recRectangle.Height / 2)

        End If

        'Première étagère sur la gauche, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_ETAGERE_1_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_ETAGERE_1_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_ETAGERE_1_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_ETAGERE_1_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_ETAGERE_1_X + recRectangle.Width / 2)

        End If

        'Deuxième étagère sur la gauche, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_2_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_ETAGERE_2_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_ETAGERE_2_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_ETAGERE_2_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_2_X - (recRectangle.Width / 2))

        End If

        'Deuxième étagère sur la gauche, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_2_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_ETAGERE_2_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_ETAGERE_2_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_ETAGERE_2_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_2_Y - (recRectangle.Height / 2))

        End If

        'Deuxième étagère sur la gauche, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_ETAGERE_2_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_ETAGERE_2_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_ETAGERE_2_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_ETAGERE_2_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_ETAGERE_2_Y + recRectangle.Height / 2)

        End If

        'Deuixième étagère sur la gauche, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_ETAGERE_2_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_ETAGERE_2_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_ETAGERE_2_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_ETAGERE_2_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_ETAGERE_2_X + recRectangle.Width / 2)

        End If

        'Première étagère du haut de la colonne de gauche, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_3_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_ETAGERE_3_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_ETAGERE_3_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_ETAGERE_3_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_3_X - (recRectangle.Width / 2))

        End If

        'Première étagère du haut de la colonne de gauche, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_3_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_ETAGERE_3_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_ETAGERE_3_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_ETAGERE_3_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_3_Y - (recRectangle.Height / 2))

        End If

        'Première étagère du haut de la colonne de gauche, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_ETAGERE_3_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_ETAGERE_3_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_ETAGERE_3_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_ETAGERE_3_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_ETAGERE_3_Y + recRectangle.Height / 2)

        End If

        'Première étagère du haut de la colonne de gauche, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_ETAGERE_3_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_ETAGERE_3_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_ETAGERE_3_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_ETAGERE_3_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_ETAGERE_3_X + recRectangle.Width / 2)

        End If

        'Deuxième étagère du haut de la colonne de gauche, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_4_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_ETAGERE_4_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_ETAGERE_4_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_ETAGERE_4_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_4_X - (recRectangle.Width / 2))

        End If

        'Deuxième étagère du haut de la colonne de gauche, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_4_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_ETAGERE_4_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_ETAGERE_4_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_ETAGERE_4_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_4_Y - (recRectangle.Height / 2))

        End If

        'Deuxième étagère du haut de la colonne de gauche, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_ETAGERE_4_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_ETAGERE_4_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_ETAGERE_4_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_ETAGERE_4_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_ETAGERE_4_Y + recRectangle.Height / 2)

        End If

        'Deuxième étagère du haut de la colonne de gauche, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_ETAGERE_4_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_ETAGERE_4_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_ETAGERE_4_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_ETAGERE_4_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_ETAGERE_4_X + recRectangle.Width / 2)

        End If

        'Troisième étagère du haut de la colonne de gauche, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_5_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_ETAGERE_5_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_ETAGERE_5_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_ETAGERE_5_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_5_X - (recRectangle.Width / 2))

        End If

        'Troisième étagère du haut de la colonne de gauche, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_5_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_ETAGERE_5_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_ETAGERE_5_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_ETAGERE_5_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_5_Y - (recRectangle.Height / 2))

        End If

        'Troisième étagère du haut de la colonne de gauche, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_ETAGERE_5_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_ETAGERE_5_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_ETAGERE_5_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_ETAGERE_5_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_ETAGERE_5_Y + recRectangle.Height / 2)

        End If

        'Troisième étagère du haut de la colonne de gauche, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_ETAGERE_5_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_ETAGERE_5_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_ETAGERE_5_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_ETAGERE_5_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_ETAGERE_5_X + recRectangle.Width / 2)

        End If

        'Première étagère du haut de la colonne de droite, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_6_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_ETAGERE_6_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_ETAGERE_6_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_ETAGERE_6_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_6_X - (recRectangle.Width / 2))

        End If

        'Première étagère du haut de la colonne de droite, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_6_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_ETAGERE_6_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_ETAGERE_6_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_ETAGERE_6_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_6_Y - (recRectangle.Height / 2))

        End If

        'Première étagère du haut de la colonne de droite, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_ETAGERE_6_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_ETAGERE_6_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_ETAGERE_6_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_ETAGERE_6_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_ETAGERE_6_Y + recRectangle.Height / 2)

        End If

        'Première étagère du haut de la colonne de droite, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_ETAGERE_6_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_ETAGERE_6_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_ETAGERE_6_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_ETAGERE_6_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_ETAGERE_6_X + recRectangle.Width / 2)

        End If

        'Deuxième étagère du haut de la colonne de droite, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_7_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_ETAGERE_7_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_ETAGERE_7_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_ETAGERE_7_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_7_X - (recRectangle.Width / 2))

        End If

        'Deuxième étagère du haut de la colonne de droite, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_7_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_ETAGERE_7_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_ETAGERE_7_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_ETAGERE_7_X Then
            ObjetsEnMouvementY = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_7_Y - (recRectangle.Height / 2))

        End If

        'Deuxième étagère du haut de la colonne de droite, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_ETAGERE_7_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_ETAGERE_7_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_ETAGERE_7_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_ETAGERE_7_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_ETAGERE_7_Y + recRectangle.Height / 2)

        End If

        'Deuxième étagère du haut de la colonne de droite, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_ETAGERE_7_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_ETAGERE_7_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_ETAGERE_7_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_ETAGERE_7_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_ETAGERE_7_X + recRectangle.Width / 2)

        End If

        'Troisième étagère du haut de la colonne de droite, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_8_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_ETAGERE_8_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_ETAGERE_8_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_ETAGERE_8_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_8_X - (recRectangle.Width / 2))

        End If

        'Troisième étagère du haut de la colonne de droite, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_ETAGERE_8_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_ETAGERE_8_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_ETAGERE_8_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_ETAGERE_8_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_ETAGERE_8_Y - (recRectangle.Height / 2))

        End If

        'Troisième étagère du haut de la colonne de droite, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_ETAGERE_8_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_ETAGERE_8_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_ETAGERE_8_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_ETAGERE_8_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_ETAGERE_8_Y + recRectangle.Height / 2)

        End If

        'Troisième étagère du haut de la colonne de droite, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_ETAGERE_8_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_ETAGERE_8_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_ETAGERE_8_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_ETAGERE_8_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_ETAGERE_8_X + recRectangle.Width / 2)

        End If

        '---------------------CAISSES--------------
        'Première caisse sur la gauche, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_CAISSE_1_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_CAISSE_1_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_CAISSE_1_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_CAISSE_1_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_CAISSE_1_X - (recRectangle.Width / 2))

        End If

        'Première caisse sur la gauche, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_CAISSE_1_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_CAISSE_1_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_CAISSE_1_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_CAISSE_1_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_CAISSE_1_Y - (recRectangle.Height / 2))

        End If

        'Première caisse sur la gauche, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_CAISSE_1_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_CAISSE_1_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_CAISSE_1_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_CAISSE_1_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_CAISSE_1_Y + recRectangle.Height / 2)

        End If

        'Première caisse sur la gauche, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_CAISSE_1_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_CAISSE_1_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_CAISSE_1_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_CAISSE_1_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_CAISSE_1_X + recRectangle.Width / 2)

        End If

        'Deuxième caisse sur la gauche, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_CAISSE_2_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_CAISSE_2_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_CAISSE_2_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_CAISSE_2_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_CAISSE_2_X - (recRectangle.Width / 2))

        End If

        'Deuxième caisse sur la gauche, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_CAISSE_2_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_CAISSE_2_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_CAISSE_2_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_CAISSE_2_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_CAISSE_2_Y - (recRectangle.Height / 2))

        End If

        'Deuxième caisse sur la gauche, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_CAISSE_2_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_CAISSE_2_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_CAISSE_2_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_CAISSE_2_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_CAISSE_2_Y + recRectangle.Height / 2)

        End If

        'Deuxième caisse sur la gauche, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_CAISSE_2_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_CAISSE_2_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_CAISSE_2_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_CAISSE_2_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_CAISSE_2_X + recRectangle.Width / 2)

        End If

        'Troisième caisse sur la gauche, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_CAISSE_3_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_CAISSE_3_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_CAISSE_3_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_CAISSE_3_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_CAISSE_3_X - (recRectangle.Width / 2))

        End If

        'Troisième caisse sur la gauche, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_CAISSE_3_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_CAISSE_3_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_CAISSE_3_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_CAISSE_3_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_CAISSE_3_Y - (recRectangle.Height / 2))

        End If

        'Troisième caisse sur la gauche, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_CAISSE_3_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_CAISSE_3_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_CAISSE_3_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_CAISSE_3_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_CAISSE_3_Y + recRectangle.Height / 2)

        End If

        'Troisième caisse sur la gauche, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_CAISSE_3_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_CAISSE_3_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_CAISSE_3_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_CAISSE_3_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_CAISSE_3_X + recRectangle.Width / 2)

        End If

        'Caisse à droite, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_CAISSE_4_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_CAISSE_4_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_CAISSE_4_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_CAISSE_4_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_CAISSE_4_X - (recRectangle.Width / 2))

        End If

        'Caisse à droite, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_CAISSE_4_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_CAISSE_4_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_CAISSE_4_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_CAISSE_4_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_CAISSE_4_Y - (recRectangle.Height / 2))

        End If

        'Caisse à droite, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_CAISSE_4_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_CAISSE_4_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_CAISSE_4_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_CAISSE_4_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_CAISSE_4_Y + recRectangle.Height / 2)

        End If

        'Caisse à droite, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_CAISSE_4_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_CAISSE_4_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_CAISSE_4_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_CAISSE_4_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_CAISSE_4_X + recRectangle.Width / 2)

        End If

        '--------------BAC---------------
        'Premier bac sur la gauche, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_BAC_1_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_BAC_1_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_BAC_1_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_BAC_1_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_BAC_1_X - (recRectangle.Width / 2))

        End If

        'Premier bac sur la gauche, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_BAC_1_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_BAC_1_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_BAC_1_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_BAC_1_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_BAC_1_Y - (recRectangle.Height / 2))

        End If

        'Premier bac sur la gauche, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_BAC_1_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_BAC_1_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_BAC_1_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_BAC_1_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_BAC_1_Y + recRectangle.Height / 2)

        End If

        'Premier bac sur la gauche, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_BAC_1_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_BAC_1_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_BAC_1_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_BAC_1_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_BAC_1_X + recRectangle.Width / 2)

        End If

        'Premier bac sur la droite, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_BAC_2_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_BAC_2_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_BAC_2_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_BAC_2_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_BAC_2_X - (recRectangle.Width / 2))

        End If

        'Premier bac sur la droite, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_BAC_2_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_BAC_2_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_BAC_2_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_BAC_2_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_BAC_2_Y - (recRectangle.Height / 2))

        End If

        'Premier bac sur la droite, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_BAC_2_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_BAC_2_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_BAC_2_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_BAC_2_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_BAC_2_Y + recRectangle.Height / 2)

        End If

        'Premier bac sur la droite, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_BAC_2_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_BAC_2_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_BAC_2_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_BAC_2_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_BAC_2_X + recRectangle.Width / 2)

        End If

        'Deuxième bac sur la gauche, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_BAC_3_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_BAC_3_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_BAC_3_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_BAC_3_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_BAC_3_X - (recRectangle.Width / 2))

        End If

        'Deuxième bac sur la gauche, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_BAC_3_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_BAC_3_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_BAC_3_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_BAC_3_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_BAC_3_Y - (recRectangle.Height / 2))

        End If

        'Deuxième bac sur la gauche, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_BAC_3_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_BAC_3_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_BAC_3_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_BAC_3_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_BAC_3_Y + recRectangle.Height / 2)

        End If

        'Deuxième bac sur la gauche, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_BAC_3_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_BAC_3_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_BAC_3_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_BAC_3_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_BAC_3_X + recRectangle.Width / 2)

        End If

        '----------COMPTOIR-------------
        'Côté gauche du comptoir de l'extrémité gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_EXTREMITE_GAUCHE_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_EXTREMITE_GAUCHE_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_EXTREMITE_GAUCHE_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_EXTREMITE_GAUCHE_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_EXTREMITE_GAUCHE_X - (recRectangle.Width / 2))

        End If

        'Côté haut du comptoir de l'extrémité gauche
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_EXTREMITE_GAUCHE_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_EXTREMITE_GAUCHE_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_EXTREMITE_GAUCHE_X AndAlso ObjetsEnMouvementX <= COIN_MILIEU_COMPTOIR_X Then
            deplacementY = CInt(COIN_SUPERIEUR_EXTREMITE_GAUCHE_Y - (recRectangle.Height / 2))

        End If


        'Côté gauche du comptoir de l'extémité droit
        If ObjetsEnMouvementX >= (COIN_GAUCHE_EXTREMITE_DROITE_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_GAUCHE_EXTREMITE_DROITE_X AndAlso ObjetsEnMouvementY >= COIN_GAUCHE_EXTREMiTE_DROITE_Y AndAlso ObjetsEnMouvementY <= COIN_MILIEU_COMPTOIR_Y Then
            deplacementX = CInt(COIN_GAUCHE_EXTREMITE_DROITE_X - (recRectangle.Width / 2))

        End If

        'Côté haut du comptoir de l'extrémité droit
        If ObjetsEnMouvementY >= (COIN_GAUCHE_EXTREMiTE_DROITE_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_GAUCHE_EXTREMiTE_DROITE_Y AndAlso ObjetsEnMouvementX >= COIN_GAUCHE_EXTREMITE_DROITE_X AndAlso ObjetsEnMouvementX <= COIN_DROIT_EXTREMITE_DROIT_X Then
            deplacementY = CInt(COIN_GAUCHE_EXTREMiTE_DROITE_Y - (recRectangle.Height / 2))
        End If
        '------------TOILETTE--------------
        'Mur de gauche de la cabine, du mur du haut vers la porte, collision extérieure
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_CABINE_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX < COIN_SUPERIEUR_GAUCHE_CABINE_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_CABINE_Y AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_PORTE_CABINE_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_CABINE_X - recRectangle.Width / 2)

        End If

        'Mur de gauche de la cabine du mur du haut vers la porte, collision intérieure
        If ObjetsEnMouvementX <= (COIN_SUPERIEUR_GAUCHE_CABINE_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_CABINE_X) AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_CABINE_Y AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_PORTE_CABINE_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_CABINE_X + recRectangle.Width / 2)

        End If

        'Mur de gauche de la cabine, du mur du bas vers la porte, collision extérieure
        If ObjetsEnMouvementX >= (COIN_INFERIEUR_PORTE_CABINE_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX < COIN_INFERIEUR_PORTE_CABINE_X AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_PORTE_CABINE_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_CABINE_Y Then
            deplacementX = CInt(COIN_INFERIEUR_PORTE_CABINE_X - recRectangle.Width / 2)

        End If

        'Mur de gauche de la cabine du mur du bas vers la porte, collision intérieure
        If ObjetsEnMouvementX <= (COIN_SUPERIEUR_GAUCHE_CABINE_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_CABINE_X) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_PORTE_CABINE_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_CABINE_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_CABINE_X + recRectangle.Width / 2)

        End If

        'Mur bas de la cabine de l'extérieur
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_GAUCHE_CABINE_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY > COIN_INFERIEUR_GAUCHE_CABINE_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_CABINE_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_CABINE_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_CABINE_Y + recRectangle.Height / 2) + 1

        End If

        'Mur bas de la cabine de l'intérieur
        If ObjetsEnMouvementY >= (COIN_INFERIEUR_DROIT_CABINE_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_CABINE_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_CABINE_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_CABINE_X Then
            deplacementY = CInt(COIN_INFERIEUR_DROIT_CABINE_Y - recRectangle.Height / 2)

        End If

        'Collision sur le côté gauche de l'évier
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_EVIER_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_EVIER_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_EVIER_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_EVIER_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_EVIER_X - (recRectangle.Width / 2))

        End If

        'Collision sur le côté bas de l'évier
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_EVIER_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_EVIER_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_EVIER_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_EVIER_X Then
            deplacementY = CInt(COIN_INFERIEUR_DROIT_EVIER_Y + recRectangle.Height / 2) + 1

        End If

        'Collision sur le côté droit de l'évier
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_EVIER_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_EVIER_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_EVIER_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_EVIER_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_EVIER_X + recRectangle.Width / 2)

        End If

        'Collision sur le côté gauche de la toilette
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_TOILETTE_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_TOILETTE_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_TOILETTE_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_TOILETTE_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_TOILETTE_X - (recRectangle.Width / 2))

        End If

        'Collision sur le côté haut de la toilette
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_TOILETTE_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_TOILETTE_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_TOILETTE_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_TOILETTE_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_TOILETTE_Y - (recRectangle.Height / 2))

        End If

        'Collision sur le côté bas de la toilette
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_TOILETTE_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_TOILETTE_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_TOILETTE_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_TOILETTE_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_TOILETTE_Y + recRectangle.Height / 2)

        End If


    End Sub

    Public Sub CollisionBar(ByVal ObjetsEnMouvementX As Integer, ByVal ObjetsEnMouvementY As Integer, ByVal recRectangle As Rectangle, Optional numeroZombie As Integer = -1)
        Dim collision As Boolean = False


        '===================================
        '             B A R
        '===================================
        '--------Tour de la bâtisse-------------
        'Mur gauche du bar à partir de l'extérieur
        If ObjetsEnMouvementX >= (BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= (BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_X) AndAlso ObjetsEnMouvementY >= BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_Y AndAlso ObjetsEnMouvementY <= BATISSE_BAR_COIN_INFERIEUR_GAUCHE_Y Then
            deplacementX = CInt(BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_X - recRectangle.Width / 2)

        End If

        'Mur gauche du bar à partir de l'intérieur
        If ObjetsEnMouvementX <= (BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= (BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_X) AndAlso ObjetsEnMouvementY >= BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_Y AndAlso ObjetsEnMouvementY <= BATISSE_BAR_COIN_INFERIEUR_GAUCHE_Y Then
            deplacementX = CInt(BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_X + recRectangle.Width / 2)

        End If

        'Mur haut du bar à partir de l'extérieur
        If ObjetsEnMouvementY >= (BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= (BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_Y) AndAlso ObjetsEnMouvementX >= BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_BAR_COIN_SUPERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_Y - (recRectangle.Height / 2))

        End If

        'Mur haut du bar à partir de l'intérieur
        If ObjetsEnMouvementY <= (BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= (BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_Y) AndAlso ObjetsEnMouvementX >= BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_BAR_COIN_SUPERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_BAR_COIN_SUPERIEUR_GAUCHE_Y + recRectangle.Height / 2) + 1

        End If

        'Mur Bas du bar à partir du mur gauche vers la porte de l'extérieur
        If ObjetsEnMouvementY <= (BATISSE_BAR_COIN_GAUCHE_PORTE_BAS_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY > BATISSE_BAR_COIN_GAUCHE_PORTE_BAS_Y AndAlso ObjetsEnMouvementX >= BATISSE_BAR_COIN_INFERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_BAR_COIN_GAUCHE_PORTE_BAS_X Then
            deplacementY = CInt(BATISSE_BAR_COIN_GAUCHE_PORTE_BAS_Y + recRectangle.Height / 2) + 1

        End If

        'Mur Bas du bar à partir du mur gauche vers la porte de l'intérieur
        If ObjetsEnMouvementY >= (BATISSE_BAR_COIN_GAUCHE_PORTE_BAS_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= BATISSE_BAR_COIN_GAUCHE_PORTE_BAS_Y AndAlso ObjetsEnMouvementX >= BATISSE_BAR_COIN_INFERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_BAR_COIN_GAUCHE_PORTE_BAS_X Then
            deplacementY = CInt(BATISSE_BAR_COIN_GAUCHE_PORTE_BAS_Y - recRectangle.Height / 2)

        End If

        'Mur Bas du bar à partir de la porte vers le mur droit de l'extérieur
        If ObjetsEnMouvementY <= (BATISSE_BAR_COIN_DROIT_PORTE_BAS_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY > BATISSE_BAR_COIN_DROIT_PORTE_BAS_Y AndAlso ObjetsEnMouvementX >= BATISSE_BAR_COIN_DROIT_PORTE_BAS_X AndAlso ObjetsEnMouvementX <= BATISSE_BAR_COIN_SUPERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_BAR_COIN_DROIT_PORTE_BAS_Y + recRectangle.Height / 2) + 1

        End If

        'Mur bas du bar à partir de la porte vers le mur droit de l'intérieur
        If ObjetsEnMouvementY >= (BATISSE_BAR_COIN_DROIT_PORTE_BAS_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= BATISSE_BAR_COIN_DROIT_PORTE_BAS_Y AndAlso ObjetsEnMouvementX >= BATISSE_BAR_COIN_DROIT_PORTE_BAS_X AndAlso ObjetsEnMouvementX <= BATISSE_BAR_COIN_SUPERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_BAR_COIN_DROIT_PORTE_BAS_Y - recRectangle.Height / 2)

        End If

        'Mur droit du bar à partir de la porte vers le mur du haut de l'extérieur
        If ObjetsEnMouvementX <= (BATISSE_BAR_COIN_SUPERIEUR_DROIT_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= BATISSE_BAR_COIN_SUPERIEUR_DROIT_X AndAlso ObjetsEnMouvementY <= BATISSE_BAR_COIN_INFERIEUR_DROIT_Y AndAlso ObjetsEnMouvementY >= BATISSE_BAR_COIN_SUPERIEUR_DROIT_Y Then
            deplacementX = CInt(BATISSE_BAR_COIN_SUPERIEUR_DROIT_X + recRectangle.Width / 2)

        End If

        'Mur droit du bar à partir de la porte vers le mur du haut de l'intérieur
        If ObjetsEnMouvementX >= (BATISSE_BAR_COIN_SUPERIEUR_DROIT_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX < BATISSE_BAR_COIN_SUPERIEUR_DROIT_X AndAlso ObjetsEnMouvementY <= BATISSE_BAR_COIN_INFERIEUR_DROIT_Y AndAlso ObjetsEnMouvementY >= BATISSE_BAR_COIN_SUPERIEUR_DROIT_Y Then
            deplacementX = CInt(BATISSE_BAR_COIN_SUPERIEUR_DROIT_X - recRectangle.Width / 2)

        End If

        '----------Tables-----------
        'Première table sur la gauche à partir du bas, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_TABLE_1_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_TABLE_1_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_TABLE_1_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_TABLE_1_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_TABLE_1_X - (recRectangle.Width / 2))

        End If

        'Première table sur la gauche à partir du bas, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_TABLE_1_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_TABLE_1_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_TABLE_1_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_TABLE_1_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_TABLE_1_Y - (recRectangle.Height / 2))

        End If

        'Première table sur la gauche à partir du bas, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_TABLE_1_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_TABLE_1_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_TABLE_1_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_TABLE_1_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_TABLE_1_Y + recRectangle.Height / 2)

        End If

        'Première table sur la gauche à partir du bas, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_TABLE_1_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_TABLE_1_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_TABLE_1_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_TABLE_1_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_TABLE_1_X + recRectangle.Width / 2)

        End If

        'Deuxième table sur la gauche à partir du bas, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_TABLE_2_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_TABLE_2_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_TABLE_2_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_TABLE_2_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_TABLE_2_X - (recRectangle.Width / 2))

        End If

        'Deuxième table sur la gauche à partir du bas, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_TABLE_2_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_TABLE_2_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_TABLE_2_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_TABLE_2_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_TABLE_2_Y - (recRectangle.Height / 2))

        End If

        'Deuxième table sur la gauche à partir du bas, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_TABLE_2_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_TABLE_2_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_TABLE_2_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_TABLE_2_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_TABLE_2_Y + recRectangle.Height / 2)

        End If

        'Deuxième table sur la gauche à partir du bas, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_TABLE_2_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_TABLE_2_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_TABLE_2_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_TABLE_2_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_TABLE_2_X + recRectangle.Width / 2)

        End If

        'Table du centre, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_TABLE_3_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_TABLE_3_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_TABLE_3_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_TABLE_3_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_TABLE_3_X - (recRectangle.Width / 2))

        End If

        'Table du centre, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_TABLE_3_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_TABLE_3_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_TABLE_3_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_TABLE_3_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_TABLE_3_Y - (recRectangle.Height / 2))

        End If

        'Table du centre, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_TABLE_3_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_TABLE_3_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_TABLE_3_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_TABLE_3_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_TABLE_3_Y + recRectangle.Height / 2)

        End If

        'Table du centre, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_TABLE_3_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_TABLE_3_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_TABLE_3_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_TABLE_3_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_TABLE_3_X + recRectangle.Width / 2)

        End If

        'Table de billard, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_TABLE_BILLARD_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_TABLE_BILLARD_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_TABLE_BILLARD_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_TABLE_BILLARD_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_TABLE_BILLARD_X - (recRectangle.Width / 2))

        End If

        'Table de billard, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_TABLE_BILLARD_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_TABLE_BILLARD_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_TABLE_BILLARD_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_TABLE_BILLARD_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_TABLE_BILLARD_Y - (recRectangle.Height / 2))

        End If

        'Table de billard, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_TABLE_BILLARD_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_TABLE_BILLARD_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_TABLE_BILLARD_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_TABLE_BILLARD_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_TABLE_BILLARD_Y + recRectangle.Height / 2)

        End If

        'Table de billard, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_TABLE_BILLARD_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_TABLE_BILLARD_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_TABLE_BILLARD_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_TABLE_BILLARD_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_TABLE_BILLARD_X + recRectangle.Width / 2)

        End If

        ''Table de pinBall, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_TABLE_PINBALL_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_TABLE_PINBALL_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_TABLE_PINBALL_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_TABLE_PINBALL_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_TABLE_PINBALL_X - (recRectangle.Width / 2))

        End If

        'Table de pinBall, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_TABLE_PINBALL_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_TABLE_PINBALL_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_TABLE_PINBALL_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_TABLE_PINBALL_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_TABLE_PINBALL_Y - (recRectangle.Height / 2))

        End If

        'Table de pinBall, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_TABLE_PINBALL_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_TABLE_PINBALL_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_TABLE_PINBALL_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_TABLE_PINBALL_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_TABLE_PINBALL_Y + recRectangle.Height / 2)

        End If

        'Table de pinBall, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_TABLE_PINBALL_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_TABLE_PINBALL_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_TABLE_PINBALL_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_TABLE_PINBALL_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_TABLE_PINBALL_X + recRectangle.Width / 2)

        End If

        'collision pour le comptoir
        'collision pour le côté supérieur gauche du comptoir
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_COMPTOIR_BAR_X - recRectangle.Width / 2) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_COMPTOIR_BAR_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_COMPTOIR_BAR_Y AndAlso ObjetsEnMouvementY <= MILIEU_COMPTOIR_BAR_COIN_INFERIEUR_DROIT_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_COMPTOIR_BAR_X - recRectangle.Width / 2)

        End If

        'collision pour le côté inférieur gauche du comptoir
        If ObjetsEnMouvementX >= (MILIEU_COMPTOIR_BAR_COIN_INFERIEUR_GAUCHE_X - recRectangle.Width / 2) AndAlso ObjetsEnMouvementX <= MILIEU_COMPTOIR_BAR_COIN_INFERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementY >= MILIEU_COMPTOIR_BAR_COIN_INFERIEUR_GAUCHE_Y And ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_COMPTOIR_BAR_Y Then
            deplacementX = CInt(MILIEU_COMPTOIR_BAR_COIN_INFERIEUR_GAUCHE_X - recRectangle.Width / 2)

        End If

        'collision pour le côté inférieur haut du comptoir
        If ObjetsEnMouvementY >= ((MILIEU_COMPTOIR_BAR_COIN_INFERIEUR_DROIT_Y) - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= MILIEU_COMPTOIR_BAR_COIN_INFERIEUR_DROIT_Y AndAlso ObjetsEnMouvementX >= MILIEU_COMPTOIR_BAR_COIN_INFERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= MILIEU_COMPTOIR_BAR_COIN_INFERIEUR_DROIT_X Then
            deplacementY = CInt(MILIEU_COMPTOIR_BAR_COIN_INFERIEUR_DROIT_Y - (recRectangle.Height / 2))

        End If

        'collision pour le côté inférieur bas du comptoir
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_COMPTOIR_BAR_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_COMPTOIR_BAR_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_COMPTOIR_BAR_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_COMPTOIR_BAR_X Then
            deplacementY = CInt(COIN_INFERIEUR_DROIT_COMPTOIR_BAR_Y + recRectangle.Height / 2)

        End If

        'collision pour le côté inférieur droit du comptoir
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_COMPTOIR_BAR_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_COMPTOIR_BAR_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_COMPTOIR_BAR_Y AndAlso ObjetsEnMouvementY >= MILIEU_COMPTOIR_BAR_COIN_SUPERIEUR_DROIT_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_COMPTOIR_BAR_X + recRectangle.Width / 2)

        End If

        'collision pour le côté supérieur droit du comptoir
        If ObjetsEnMouvementX <= (MILIEU_COMPTOIR_BAR_COIN_SUPERIEUR_GAUCHE_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= MILIEU_COMPTOIR_BAR_COIN_SUPERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementY <= MILIEU_COMPTOIR_BAR_COIN_SUPERIEUR_GAUCHE_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_COMPTOIR_BAR_Y Then
            deplacementX = CInt(MILIEU_COMPTOIR_BAR_COIN_SUPERIEUR_GAUCHE_X + recRectangle.Width / 2)

        End If

        'collision pour la batterie
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_BATTERIE_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_BATTERIE_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_BATTERIE_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_BATTERIE_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_BATTERIE_X - (recRectangle.Width / 2))

        End If

        'Table de pinBall, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_BATTERIE_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_BATTERIE_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_BATTERIE_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_BATTERIE_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_BATTERIE_Y - (recRectangle.Height / 2))

        End If

        'Table de pinBall, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_BATTERIE_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_BATTERIE_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_BATTERIE_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_BATTERIE_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_BATTERIE_Y + recRectangle.Height / 2)

        End If

        'Table de pinBall, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_BATTERIE_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_BATTERIE_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_BATTERIE_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_BATTERIE_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_BATTERIE_X + recRectangle.Width / 2)

        End If

    End Sub

    Public Sub CollisionsStationnement(ByVal ObjetsEnMouvementX As Integer, ByVal ObjetsEnMouvementY As Integer, ByVal recRectangle As Rectangle, Optional numeroZombie As Integer = -1)
        Dim collision As Boolean = False


        '===============================
        '       stationnement
        '===============================
        'Première voiture du stationnement, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_VOITURE_1_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_VOITURE_1_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_VOITURE_1_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_VOITURE_1_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_VOITURE_1_X - (recRectangle.Width / 2))

        End If

        'Première voiture du stationnement, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_VOITURE_1_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_VOITURE_1_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_VOITURE_1_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_VOITURE_1_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_VOITURE_1_Y - (recRectangle.Height / 2))

        End If

        'Première voiture du stationnement, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_VOITURE_1_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_VOITURE_1_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_VOITURE_1_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_VOITURE_1_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_VOITURE_1_Y + recRectangle.Height / 2)

        End If

        'Première voiture du stationnement, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_VOITURE_1_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_VOITURE_1_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_VOITURE_1_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_VOITURE_1_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_VOITURE_1_X + recRectangle.Width / 2)

        End If

        'Deuxième voiture du stationnement, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_VOITURE_2_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_VOITURE_2_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_VOITURE_2_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_VOITURE_2_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_VOITURE_2_X - (recRectangle.Width / 2))

        End If

        'Deuxième voiture du stationnement, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_VOITURE_2_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_VOITURE_2_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_VOITURE_2_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_VOITURE_2_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_VOITURE_2_Y - (recRectangle.Height / 2))

        End If

        'Deuxième voiture du stationnement, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_VOITURE_2_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_VOITURE_2_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_VOITURE_2_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_VOITURE_2_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_VOITURE_2_Y + recRectangle.Height / 2)

        End If

        'Deuxième voiture du stationnement, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_VOITURE_2_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_VOITURE_2_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_VOITURE_2_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_VOITURE_2_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_VOITURE_2_X + recRectangle.Width / 2)

        End If

        'Troisième voiture du stationnement, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_VOITURE_3_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_VOITURE_3_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_VOITURE_3_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_VOITURE_3_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_VOITURE_3_X - (recRectangle.Width / 2))

        End If

        'Troisième voiture du stationnement, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_VOITURE_3_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_VOITURE_3_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_VOITURE_3_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_VOITURE_3_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_VOITURE_3_Y - (recRectangle.Height / 2))

        End If

        'Troisième voiture du stationnement, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_VOITURE_3_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_VOITURE_3_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_VOITURE_3_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_VOITURE_3_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_VOITURE_3_Y + recRectangle.Height / 2)

        End If

        'Troisième voiture du stationnement, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_VOITURE_3_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_VOITURE_3_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_VOITURE_3_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_VOITURE_3_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_VOITURE_3_X + recRectangle.Width / 2)

        End If

        'Quatrième voiture du stationnement, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_VOITURE_4_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_VOITURE_4_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_VOITURE_4_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_VOITURE_4_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_VOITURE_4_X - (recRectangle.Width / 2))

        End If

        'Quatrième voiture du stationnement, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_VOITURE_4_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_VOITURE_4_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_VOITURE_4_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_VOITURE_4_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_VOITURE_4_Y - (recRectangle.Height / 2))

        End If

        'Quatrième voiture du stationnement, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_VOITURE_4_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_VOITURE_4_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_VOITURE_4_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_VOITURE_4_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_VOITURE_4_Y + recRectangle.Height / 2)

        End If

        'Quatrième voiture du stationnement, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_VOITURE_4_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_VOITURE_4_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_VOITURE_4_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_VOITURE_4_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_VOITURE_4_X + recRectangle.Width / 2)

        End If

        'Cinquième voiture du stationnement, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_VOITURE_5_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_VOITURE_5_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_VOITURE_5_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_VOITURE_5_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_VOITURE_5_X - (recRectangle.Width / 2))

        End If

        'Cinquième voiture du stationnement, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_VOITURE_5_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_VOITURE_5_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_VOITURE_5_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_VOITURE_5_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_VOITURE_5_Y - (recRectangle.Height / 2))

        End If

        'Cinquième voiture du stationnement, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_VOITURE_5_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_VOITURE_5_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_VOITURE_5_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_VOITURE_5_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_VOITURE_5_Y + recRectangle.Height / 2)

        End If

        'Cinquième voiture du stationnement, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_VOITURE_5_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_VOITURE_5_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_VOITURE_5_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_VOITURE_5_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_VOITURE_5_X + recRectangle.Width / 2)

        End If

        'Voiture dans la rue de droite, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_VOITURE_6_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_VOITURE_6_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_VOITURE_6_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_VOITURE_6_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_VOITURE_6_X - (recRectangle.Width / 2))

        End If

        'Voiture dans la rue de droite, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_VOITURE_6_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_VOITURE_6_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_VOITURE_6_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_VOITURE_6_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_VOITURE_6_Y - (recRectangle.Height / 2))

        End If

        'Voiture dans la rue de droite, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_VOITURE_6_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_VOITURE_6_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_VOITURE_6_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_VOITURE_6_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_VOITURE_6_Y + recRectangle.Height / 2)

        End If

        'Voiture dans la rue de droite, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_VOITURE_6_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_VOITURE_6_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_VOITURE_6_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_VOITURE_6_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_VOITURE_6_X + recRectangle.Width / 2)
        End If

        'Compartiment du camion, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_COMPARTIMENT_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_COMPARTIMENT_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_COMPARTIMENT_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_COMPARTIMENT_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_COMPARTIMENT_X - (recRectangle.Width / 2))

        End If

        'Compartiment du camion, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_COMPARTIMENT_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_COMPARTIMENT_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_COMPARTIMENT_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_COMPARTIMENT_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_COMPARTIMENT_Y - (recRectangle.Height / 2))

        End If

        'Compartiment du camion, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_COMPARTIMENT_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_COMPARTIMENT_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_COMPARTIMENT_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_COMPARTIMENT_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_COMPARTIMENT_Y + recRectangle.Height / 2)

        End If

        'Compartiment du camion, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_COMPARTIMENT_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_COMPARTIMENT_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_COMPARTIMENT_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_COMPARTIMENT_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_COMPARTIMENT_X + recRectangle.Width / 2)
        End If

        'Cabine du camion, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_CAMION_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_CAMION_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_CAMION_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_CAMION_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_CAMION_X - (recRectangle.Width / 2))

        End If

        'Cabine du camion, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_CAMION_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_CAMION_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_CAMION_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_CAMION_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_CAMION_Y - (recRectangle.Height / 2))

        End If

        'Cabine du camion, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_CAMION_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_CAMION_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_CAMION_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_CAMION_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_CAMION_Y + recRectangle.Height / 2)

        End If

        'Cabine du camion, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_CAMION_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_CAMION_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_CAMION_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_CAMION_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_CAMION_X + recRectangle.Width / 2)

        End If

    End Sub

    Public Sub CollisionsMaison(ByVal ObjetsEnMouvementX As Integer, ByVal ObjetsEnMouvementY As Integer, ByVal recRectangle As Rectangle, Optional numeroZombie As Integer = -1)
        Dim collision As Boolean = False



        '================================================
        '               MAISON
        '================================================
        '------------TOUR DE LA BÂTISSE--------------
        'Mur gauche de la maison à partir de l'extérieur, à partir du haut à la porte
        If ObjetsEnMouvementX >= (BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= (BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X) AndAlso ObjetsEnMouvementY >= BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_Y AndAlso ObjetsEnMouvementY <= BATISSE_MAISON_COIN_SUPERIEUR_PORTE_GAUCHE_Y Then
            deplacementX = CInt(BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X - recRectangle.Width / 2)

        End If

        'Mur gauche de la maison à partir de l'intérieur, à partir du haut à la porte
        If ObjetsEnMouvementX <= (BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= (BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X) AndAlso ObjetsEnMouvementY >= BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_Y AndAlso ObjetsEnMouvementY <= BATISSE_MAISON_COIN_SUPERIEUR_PORTE_GAUCHE_Y Then
            deplacementX = CInt(BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X + recRectangle.Width / 2)

        End If

        'Mur gauche de la maison à partir de l'extérieur, à partir de la porte vers le bas
        If ObjetsEnMouvementX >= (BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= (BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X) AndAlso ObjetsEnMouvementY >= BATISSE_MAISON_COIN_INFERIEUR_PORTE_GAUCHE_Y AndAlso ObjetsEnMouvementY <= BATISSE_MAISON_COIN_INFERIEUR_GAUCHE_Y Then
            deplacementX = CInt(BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X - recRectangle.Width / 2)

        End If

        'Mur gauche de la maison à partir de l'intérieur, à partir de la porte vers le bas
        If ObjetsEnMouvementX <= (BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= (BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X) AndAlso ObjetsEnMouvementY >= BATISSE_MAISON_COIN_INFERIEUR_PORTE_GAUCHE_Y AndAlso ObjetsEnMouvementY <= BATISSE_MAISON_COIN_INFERIEUR_GAUCHE_Y Then
            deplacementX = CInt(BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X + recRectangle.Width / 2)

        End If

        'Mur haut de la maison à partir de l'extérieur
        If ObjetsEnMouvementY >= (BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= (BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_Y) AndAlso ObjetsEnMouvementX >= BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_MAISON_COIN_SUPERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_Y - (recRectangle.Height / 2))

        End If

        'Mur haut de la maison à partir de l'intérieur
        If ObjetsEnMouvementY <= (BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= (BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_Y) AndAlso ObjetsEnMouvementX >= BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_MAISON_COIN_SUPERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_MAISON_COIN_SUPERIEUR_GAUCHE_Y + recRectangle.Height / 2) + 1

        End If

        'Mur Bas de la maison à partir du mur gauche vers la porte de l'extérieur
        If ObjetsEnMouvementY <= (BATISSE_MAISON_COIN_INFERIEUR_GAUCHE_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY > BATISSE_MAISON_COIN_INFERIEUR_GAUCHE_Y AndAlso ObjetsEnMouvementX >= BATISSE_MAISON_COIN_INFERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_MAISON_COIN_INFERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_MAISON_COIN_INFERIEUR_GAUCHE_Y + recRectangle.Height / 2) + 1

        End If

        'Mur Bas de la maison à partir du mur gauche vers la porte de l'intérieur
        If ObjetsEnMouvementY >= (BATISSE_MAISON_COIN_INFERIEUR_GAUCHE_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= BATISSE_MAISON_COIN_INFERIEUR_GAUCHE_Y AndAlso ObjetsEnMouvementX >= BATISSE_MAISON_COIN_INFERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_MAISON_COIN_INFERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_MAISON_COIN_INFERIEUR_GAUCHE_Y - recRectangle.Height / 2)

        End If

        'Mur droit de la maison à partir de la porte vers le mur du haut de l'extérieur
        If ObjetsEnMouvementX <= (BATISSE_MAISON_COIN_SUPERIEUR_DROIT_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= BATISSE_MAISON_COIN_SUPERIEUR_DROIT_X AndAlso ObjetsEnMouvementY <= BATISSE_MAISON_COIN_SUPERIEUR_PORTE_DROITE_Y AndAlso ObjetsEnMouvementY >= BATISSE_MAISON_COIN_SUPERIEUR_DROIT_Y Then
            deplacementX = CInt(BATISSE_MAISON_COIN_SUPERIEUR_DROIT_X + recRectangle.Width / 2)

        End If

        'Mur droit de la maison à partir de la porte vers le mur du haut de l'intérieur
        If ObjetsEnMouvementX >= (BATISSE_MAISON_COIN_SUPERIEUR_DROIT_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX < BATISSE_MAISON_COIN_SUPERIEUR_DROIT_X AndAlso ObjetsEnMouvementY <= BATISSE_MAISON_COIN_SUPERIEUR_PORTE_DROITE_Y AndAlso ObjetsEnMouvementY >= BATISSE_MAISON_COIN_SUPERIEUR_DROIT_Y Then
            deplacementX = CInt(BATISSE_MAISON_COIN_SUPERIEUR_DROIT_X - recRectangle.Width / 2)

        End If

        'Mur droit de la maison à partir de la porte vers le mur du bas de l'extérieur
        If ObjetsEnMouvementX <= (BATISSE_MAISON_COIN_SUPERIEUR_DROIT_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= BATISSE_MAISON_COIN_SUPERIEUR_PORTE_DROITE_X AndAlso ObjetsEnMouvementY <= BATISSE_MAISON_COIN_INFERIEUR_DROIT_Y AndAlso ObjetsEnMouvementY >= BATISSE_MAISON_COIN_INFERIEUR_PORTE_DROITE_Y Then
            deplacementX = CInt(BATISSE_MAISON_COIN_SUPERIEUR_DROIT_X + recRectangle.Width / 2)

        End If

        'Mur droit de la maison à partir de la porte vers le mur du bas de l'intérieur
        If ObjetsEnMouvementX >= (BATISSE_MAISON_COIN_SUPERIEUR_DROIT_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX < BATISSE_MAISON_COIN_SUPERIEUR_PORTE_DROITE_X AndAlso ObjetsEnMouvementY <= BATISSE_MAISON_COIN_INFERIEUR_DROIT_Y AndAlso ObjetsEnMouvementY >= BATISSE_MAISON_COIN_INFERIEUR_PORTE_DROITE_Y Then
            deplacementX = CInt(BATISSE_MAISON_COIN_SUPERIEUR_DROIT_X - recRectangle.Width / 2)
        End If

        '----------------ESCALIER------------------
        'Escalier, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_ESCALIER_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_ESCALIER_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_ESCALIER_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_ESCALIER_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_ESCALIER_X - (recRectangle.Width / 2))

        End If

        'Escalier,, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_ESCALIER_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_ESCALIER_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_ESCALIER_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_ESCALIER_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_ESCALIER_Y - (recRectangle.Height / 2))

        End If

        'Escalier,, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_ESCALIER_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_ESCALIER_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_ESCALIER_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_ESCALIER_X Then
            deplacementY = CInt(COIN_INFERIEUR_DROIT_ESCALIER_Y + recRectangle.Height / 2)

        End If

        'Escalier,, collision du côté bas
        If ObjetsEnMouvementY >= (COIN_INFERIEUR_DROIT_ESCALIER_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_ESCALIER_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_ESCALIER_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_ESCALIER_X Then
            deplacementY = CInt(COIN_INFERIEUR_DROIT_ESCALIER_Y - recRectangle.Height / 2) - 1

        End If

        'Escalier,, collision sur les armoires
        If ObjetsEnMouvementX <= (COIN_MILIEU_ESCALIER_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_MILIEU_ESCALIER_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_ESCALIER_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_ESCALIER_Y Then
            deplacementX = CInt(COIN_MILIEU_ESCALIER_X + recRectangle.Width / 2)

        End If


        '--------------------TABLE-----------------
        'Cabine du TABLE, collision du côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_TABLE_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_TABLE_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_TABLE_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_TABLE_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_TABLE_X - (recRectangle.Width / 2))

        End If

        'Cabine du TABLE, collision du côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_TABLE_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_TABLE_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_TABLE_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_TABLE_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_TABLE_Y - (recRectangle.Height / 2))

        End If

        'Cabine du TABLE, collision du côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_TABLE_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_TABLE_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_TABLE_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_TABLE_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_TABLE_Y + recRectangle.Height / 2)

        End If

        'Cabine du TABLE, collision du côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_TABLE_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_TABLE_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_TABLE_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_TABLE_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_TABLE_X + recRectangle.Width / 2)

        End If

        '----------------Salon--------------------
        'Mur gauche de la maison à partir de l'extérieur, à partir de la porte vers le bas
        If ObjetsEnMouvementX >= (BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= (BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_X) AndAlso ObjetsEnMouvementY >= BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y AndAlso ObjetsEnMouvementY <= BATISSE_SALON_COIN_INFERIEUR_GAUCHE_Y Then
            deplacementX = CInt(BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_X - recRectangle.Width / 2)

        End If

        'Mur gauche de la maison à partir de l'intérieur, à partir de la porte vers le bas
        If ObjetsEnMouvementX <= (BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= (BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_X) AndAlso ObjetsEnMouvementY >= BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y AndAlso ObjetsEnMouvementY <= BATISSE_SALON_COIN_INFERIEUR_GAUCHE_Y Then
            deplacementX = CInt(BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_X + recRectangle.Width / 2)

        End If

        'Mur haut du salon à partir de l'extérieur, de la gauche vers la porte
        If ObjetsEnMouvementY >= (BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= (BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y) AndAlso ObjetsEnMouvementX >= BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_SALON_COIN_GAUCHE_PORTE_X Then
            deplacementY = CInt(BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y - (recRectangle.Height / 2))

        End If

        'Mur haut du salon à partir de l'intérieur, de la gauche vers la porte
        If ObjetsEnMouvementY <= (BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= (BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y) AndAlso ObjetsEnMouvementX >= BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_SALON_COIN_GAUCHE_PORTE_X Then
            deplacementY = CInt(BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y + recRectangle.Height / 2) + 1

        End If

        'Mur haut du salon à partir de l'extérieur, de la porte vers le mur droit
        If ObjetsEnMouvementY >= (BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= (BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y) AndAlso ObjetsEnMouvementX >= BATISSE_SALON_COIN_DROIT_PORTE_X AndAlso ObjetsEnMouvementX <= BATISSE_SALON_COIN_SUPERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y - (recRectangle.Height / 2))

        End If

        'Mur haut du salon à partir de l'intérieur, de la porte vers le mur droit
        If ObjetsEnMouvementY <= (BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= (BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y) AndAlso ObjetsEnMouvementX >= BATISSE_SALON_COIN_DROIT_PORTE_X AndAlso ObjetsEnMouvementX <= BATISSE_SALON_COIN_SUPERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_SALON_COIN_SUPERIEUR_GAUCHE_Y + recRectangle.Height / 2) + 1

        End If

        'Mur Bas du salon à partir du mur gauche vers la porte de l'extérieur
        If ObjetsEnMouvementY <= (BATISSE_SALON_COIN_INFERIEUR_GAUCHE_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY > BATISSE_SALON_COIN_INFERIEUR_GAUCHE_Y AndAlso ObjetsEnMouvementX >= BATISSE_SALON_COIN_INFERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_SALON_COIN_INFERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_SALON_COIN_INFERIEUR_GAUCHE_Y + recRectangle.Height / 2) + 1

        End If

        'Mur Bas du salon à partir du mur gauche vers la porte de l'intérieur
        If ObjetsEnMouvementY >= (BATISSE_SALON_COIN_INFERIEUR_GAUCHE_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= BATISSE_SALON_COIN_INFERIEUR_GAUCHE_Y AndAlso ObjetsEnMouvementX >= BATISSE_SALON_COIN_INFERIEUR_GAUCHE_X AndAlso ObjetsEnMouvementX <= BATISSE_SALON_COIN_INFERIEUR_DROIT_X Then
            deplacementY = CInt(BATISSE_SALON_COIN_INFERIEUR_GAUCHE_Y - recRectangle.Height / 2)

        End If

        'Mur droit du salon à partir de la porte vers le mur du haut de l'intérieur
        If ObjetsEnMouvementX >= (BATISSE_SALON_COIN_SUPERIEUR_DROIT_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX < BATISSE_SALON_COIN_SUPERIEUR_DROIT_X AndAlso ObjetsEnMouvementY <= BATISSE_SALON_COIN_INFERIEUR_DROIT_Y AndAlso ObjetsEnMouvementY >= BATISSE_SALON_COIN_SUPERIEUR_DROIT_Y Then
            deplacementX = CInt(BATISSE_SALON_COIN_SUPERIEUR_DROIT_X - recRectangle.Width / 2)

        End If
        '-----------Télévision----------
        'Télévision, collision sur le côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_TELEVISION_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_TELEVISION_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_TELEVISION_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_TELEVISION_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_TELEVISION_X - (recRectangle.Width / 2))

        End If

        'Télévision, collision sur le côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_TELEVISION_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_TELEVISION_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_TELEVISION_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_TELEVISION_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_TELEVISION_Y - (recRectangle.Height / 2))

        End If

        'Télévision, collision sur le côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_TELEVISION_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_TELEVISION_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_TELEVISION_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_TELEVISION_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_TELEVISION_Y + recRectangle.Height / 2)

        End If

        'Télévision, collision sur le côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_TELEVISION_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_TELEVISION_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_TELEVISION_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_TELEVISION_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_TELEVISION_X + recRectangle.Width / 2)

        End If

        '------------Divan--------------
        'Divan, collision sur le côté gauche
        If ObjetsEnMouvementX >= (COIN_SUPERIEUR_GAUCHE_DIVAN_X - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_GAUCHE_DIVAN_X AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_GAUCHE_DIVAN_Y AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_GAUCHE_DIVAN_Y Then
            deplacementX = CInt(COIN_SUPERIEUR_GAUCHE_DIVAN_X - (recRectangle.Width / 2))

        End If

        'Divan, collision sur le côté haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_DIVAN_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= COIN_SUPERIEUR_GAUCHE_DIVAN_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_DIVAN_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_DIVAN_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_DIVAN_Y - (recRectangle.Height / 2))

        End If

        'Divan, collision sur le côté bas
        If ObjetsEnMouvementY <= (COIN_INFERIEUR_DROIT_DIVAN_Y + (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY >= COIN_INFERIEUR_DROIT_DIVAN_Y AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_GAUCHE_DIVAN_X AndAlso ObjetsEnMouvementX <= COIN_INFERIEUR_DROIT_DIVAN_X Then
            deplacementY = CInt(COIN_INFERIEUR_GAUCHE_DIVAN_Y + recRectangle.Height / 2)

        End If

        'Divan, collision sur le côté droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_DIVAN_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_DIVAN_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_DIVAN_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_DIVAN_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_DIVAN_X + recRectangle.Width / 2)

        End If

        '--------Comptoir Maison------------
        'Collision sur le côté supérieur haut
        If ObjetsEnMouvementY >= (COIN_SUPERIEUR_GAUCHE_COMPTOIR_MAISON_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY < COIN_SUPERIEUR_GAUCHE_COMPTOIR_MAISON_Y AndAlso ObjetsEnMouvementX >= COIN_SUPERIEUR_GAUCHE_COMPTOIR_MAISON_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_COMPTOIR_MAISON_X Then
            deplacementY = CInt(COIN_SUPERIEUR_GAUCHE_COMPTOIR_MAISON_Y - (recRectangle.Height / 2)) - 1

        End If

        'Collision sur le côté inférieur haut
        If ObjetsEnMouvementY >= (COIN_MILIEU_COMPTOIR_MAISON_Y - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY < COIN_MILIEU_COMPTOIR_MAISON_Y AndAlso ObjetsEnMouvementX >= COIN_MILIEU_COMPTOIR_MAISON_X AndAlso ObjetsEnMouvementX <= COIN_SUPERIEUR_DROIT_DROIT_COMPTOIR_MAISON_X Then
            deplacementY = CInt(COIN_MILIEU_COMPTOIR_MAISON_Y - (recRectangle.Height / 2)) - 1

        End If

        'Collision sur le côté supérieur droit
        If ObjetsEnMouvementX <= (COIN_MILIEU_COMPTOIR_MAISON_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_MILIEU_COMPTOIR_MAISON_X AndAlso ObjetsEnMouvementY <= COIN_MILIEU_COMPTOIR_MAISON_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_COMPTOIR_MAISON_Y Then
            deplacementX = CInt(COIN_MILIEU_COMPTOIR_MAISON_X + recRectangle.Width / 2)

        End If

        'Collision sur le côté inférieur droit
        If ObjetsEnMouvementX <= (COIN_INFERIEUR_DROIT_COMPTOIR_MAISON_X + (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX >= COIN_INFERIEUR_DROIT_COMPTOIR_MAISON_X AndAlso ObjetsEnMouvementY <= COIN_INFERIEUR_DROIT_COMPTOIR_MAISON_Y AndAlso ObjetsEnMouvementY >= COIN_SUPERIEUR_DROIT_DROIT_COMPTOIR_MAISON_Y Then
            deplacementX = CInt(COIN_INFERIEUR_DROIT_COMPTOIR_MAISON_X + recRectangle.Width / 2)

        End If

    End Sub

    Public Sub CollisionsContourEcran(ByVal ObjetsEnMouvementX As Integer, ByVal ObjetsEnMouvementY As Integer, recRectangle As Rectangle, Optional numeroZombie As Integer = -1)
        'À gauche
        If ObjetsEnMouvementX <= recRectangle.Width / 2 AndAlso ObjetsEnMouvementX >= 0 AndAlso ObjetsEnMouvementY >= 0 AndAlso ObjetsEnMouvementY <= frmMusicZ.intResolutionHauteur Then
            deplacementX = CInt(recRectangle.Width / 2)
        End If
        'En haut
        If ObjetsEnMouvementY <= recRectangle.Height / 2 AndAlso ObjetsEnMouvementY >= 0 AndAlso ObjetsEnMouvementX >= 0 AndAlso ObjetsEnMouvementX <= frmMusicZ.intResolutionLargeur Then
            deplacementY = CInt(recRectangle.Height / 2)
        End If
        'En bas
        If ObjetsEnMouvementY >= (frmMusicZ.intResolutionHauteur - (recRectangle.Height / 2)) AndAlso ObjetsEnMouvementY <= frmMusicZ.intResolutionHauteur AndAlso ObjetsEnMouvementX >= 0 AndAlso ObjetsEnMouvementX <= frmMusicZ.intResolutionLargeur Then
            deplacementY = CInt(frmMusicZ.intResolutionHauteur - recRectangle.Height / 2)
        End If
        'À droite
        If ObjetsEnMouvementX >= (frmMusicZ.intResolutionLargeur - (recRectangle.Width / 2)) AndAlso ObjetsEnMouvementX < frmMusicZ.intResolutionLargeur AndAlso ObjetsEnMouvementY <= frmMusicZ.intResolutionLargeur AndAlso ObjetsEnMouvementY >= 0 Then
            deplacementX = CInt(frmMusicZ.intResolutionLargeur - recRectangle.Width / 2)
        End If

    End Sub

    Public Sub AttribuerCollisionObjet(ByVal ObjetsEnMouvementX As Integer, ByVal ObjetsEnMouvementY As Integer, ByVal recRectangle As Rectangle, Optional ByVal numeroZombie As Integer = -1)

        'La collision s'effectuera seulement sur les personnages prédéfinies par l'appel de la procédure
        'Par exemple, si on appel rectangleZombie qui est le rectangle contenant l'image du zombie, la collision ne sera pas attribuée au personnage
        'seulement au zombie en question

        If recRectangle = frmMusicZ.rectanglePersonnage Then
            frmMusicZ.posCentreJoueur.X = ObjetsEnMouvementX
            frmMusicZ.posCentreJoueur.Y = ObjetsEnMouvementY
        ElseIf recRectangle = frmMusicZ.rectangleZombie Then
            frmMusicZ.posZombiesCentre(numeroZombie) = New Point(ObjetsEnMouvementX, ObjetsEnMouvementY)
        End If
    End Sub

End Module

# Jeu – Survie en Terre Inconnue

## Contexte du projet
Projet académique réalisé dans le cadre d'un TP.
Projet effectué en binôme.
Conception et implémentation réalisé conjointement.

## Objectif du jeu
Réaliser une carte 2D.
L'utilisateur doit pouvoir parcourir cette carte en collectant des ressources qui lui permettront de construire une maison avant l'arrivée de l'hiver.

## Technologies utilisées
-Langage: C#
-IDE: Visual Studio 2022
-Outils: Git, GitHub (Github Classroom)

## fonctionnalités principales
-Gestion d'une liste d'éléments via un menu console
-Validation des entrées de l'utillisateur
-Sauvegarde des données

## Consignes du TP
Les instructions complètes du TP sont conservées ci-dessous.
Contenu fourni par l'enseignant.

# Travail pratique (15%)

## Directives :
1.	Ce travail doit être fait en équipe de deux, sauf sur approbation préalable du professeur.
2.	La date de remise est lundi le 8 décembre à la fin de la journée
3. 	Prenez bien soin de respecter les standards de présentation du code.
4. 	Un exemple du jeu de base est disponible dans le dossier démonstration

# Jeu – Survie en Terre Inconnue
 
## Objectifs :
- Utilisation des listes 
- Utilisation de la modularité (namespace > classe > propriété et méthode)
- Validation des entrées 
- Utilisation de la sérialisation

## Consignes
Dans un monde inconnu, le personnage principal survit à un accident d’avion. Se retrouvant seul dans un environnement sauvage et diversifié, avec l’hiver qui approche rapidement. Pour survivre, le personnage doit construire une maison avant l’arrivée de l’hiver.

L’objectif principal du jeu est de construire une maison au point de départ (c’est-à-dire, la position [0,0]). Pour cela, le personnage doit collecter des ressources et les transformer en matériaux de construction.

### Ressources
- Montagne : Le personnage peut extraire du fer de la montagne, qui peut être utilisé pour fabriquer des outils.
- Rivière : En fouillant dans la rivière, le personnage peut trouver du silex, utile pour créer des outils tranchants ou du feu.
- Forêt : La forêt fournit du bois, une ressource essentielle pour la construction de la maison.
- Marais : Les marais sont une source d’argile, qui peut être utilisée pour fabriquer des briques.
- Prairie : La prairie fournit de l’herbe, qui peut être utilisée pour fabriquer divers éléments tels que de l’isolant.
- Désert : Le désert fournit du sable, qui peut être transformé en verre.
 
### Matériaux

Dans ce monde inconnu, le personnage principal doit non seulement collecter des ressources, mais aussi les transformer en matériaux utiles pour construire une maison. 
Voici comment cela fonctionne :
- Feu : Le personnage peut produire du feu en utilisant 1 bois et 1 silex. Le feu est essentiel pour se réchauffer, cuisiner et transformer certaines ressources en matériaux utiles.
- Hache : Avec 1 bois et 1 fer, le personnage peut fabriquer une hache. Cet outil est indispensable pour faire des planches de bois pour la maison.
- Vitre : En combinant 1 sable et 1 feu, le personnage peut créer une vitre. Les vitres sont nécessaires pour les fenêtres de la maison.
- Planche de bois : En utilisant 1 bois et 1 hache, le personnage peut produire une planche de bois. Les planches de bois sont un matériau de construction essentiel.
- Brique : Avec 1 argile et 1 feu, le personnage peut fabriquer 1 brique. Les briques sont utiles pour construire des murs solides.
- Isolant : En collectant 3 herbes, le personnage peut créer un isolant. L’isolant est nécessaire pour garder la maison chaude pendant l’hiver.
- Maison : Pour construire une maison, le personnage a besoin de 4 planches, 4 briques, 4 isolants et 2 vitres.

Avec ces matériaux et outils, le personnage a tout ce dont il a besoin pour construire une maison. Cependant, la collecte des ressources et la transformation de ces ressources en matériaux nécessitent du temps et de l’énergie. Dépêchez-vous, l’hiver approche…

### Informations générales :
Votre programme devra :
1. Avoir un menu principal :
   - L’option 1, démarre la partie.
   - Les options 2 et 3 permettent de sauvegarder et charger une partie.  Vous n’avez pas besoin de conserver plus d’une partie à la fois en mémoire.
   - L’option 4 affiche vos noms ainsi qu’une description des éléments additionnels que vous aurez choisis.
   - L’option 5 quitte le jeu
2. Déroulement du jeu: 
   - Lors d’un tour, Le joueur peut se déplacer de haut, bas, gauche ou droite ce qui fait modifier sa position
   - Si le joueur arrive sur une nouvelle position, un type de terrain doit être généré aléatoirement et remplacer la tuile (inconnue).
   - La position [0,0] représente la base du joueur, ce terrain est le seul de type : « Base ». 
   - Une carte 2D représentant le monde doit être visible en tout temps.  Chaque type de terrain doit avoir une couleur différente et les tuiles inconnues doivent être noir.
   - La carte à une taille fixe (ex. 10 x 10)
3. Le joueur peut collecter des ressources. 
4. Pour chaque action « collectée », une ressource sera ajoutée dans l’inventaire. 
   - Il n’y a pas de limite aux ressources collectées dans chacune des zones.
5. Le joueur doit être en mesure de consulter sans difficulté son inventaire tout au long du jeu.
6. Lors que le joueur est à la base. Il doit pouvoir consulter un menu pour fabriquer des matériaux
   - Les ressources utilisées sont effacées de l’inventaire 
   - Le nouveau matériel doit être ajouté dans l’inventaire
7. Fin du jeu
   - Le jeu se termine lorsque le joueur construit une maison pour se protéger de l’hiver dans la zone de départ [0,0].
 
### Instruction additionnelle
Vous devez découper votre code en plusieurs classes selon les bonnes pratiques vue en classe. 
- Vue : Regroupe tout ce qui s’occupe des Console.WriteLine() et Console.ReadLine()
- Contrôleur: Regroupe toutes les boucles de contrôle. Boucle du menu principale, boucle de jeu, etc.
- Model : Englobe tout le data du jeu.  Collection représentant la carte, position du joueur, nombre de ressource et de matériaux, etc.
	
### Éléments additionnels
Vous devez bonifier le concept de base du jeu avec **2** nouveaux éléments de votre choix.
Vous avez carte blanche pour personnaliser le jeu à votre goût. 

Amusez-vous et faites preuve de créativité! 

Voici des idées de base :
- Ajoutez des actions, le personnage doit « Manger » et « Boire » pour survivre. Toutes les actions coûtent une partie de nourriture et d’hydratation. Si une de ces deux ressources manque, le joueur meurt et la partie est terminée.
- Ne limiter pas la grille à une taille fixe.  Faite une grille dynamique qui peut s’agrandir à l’infini à mesure qu’on se déplace.
- Ajouter un chronomètre annonçant l’arrivé de l’hiver.  Vous devez compléter votre maison avant l’hiver sinon le joueur meurt et la partie est terminée.
- Ajouter du Ascii Art représentant les tuiles, les matériaux, etc.
- Ajouter la capacité de collecter plusieurs types ressources par terrain. Chaque ressource possède une probabilité de chance d’être collecté. Par exemple : 
  - Dans le désert, 1% chance de prendre de l’eau ou 99% de chance d’avoir du sable
  - Dans le marais, 5% de chance de trouver du poisson, 45% de chance de trouver de l’argile et 50% de chance de trouver de l’eau.
  - Les ressources et les pourcentages peuvent varier selon vos désirs.
- Autres idées : Soyez créatif et amusez-vous !

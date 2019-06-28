## Préface

 L’utilisation des diagrammes UML n’est pas pertinent pour un projet utilisant Unity. Nous avons alors choisi de décrire le fonctionnement général du Jeu.


## Génération de salle :

Chaque salle est composée de plusieurs bouts de salle. Chaque bout de salle est stocké dans un script sur un gameobject pour pouvoir être facilement instancié: RoomTemplates ( pour les parties de salle des 3 premiers niveaux ) et dans RoomTemplates2 pour les salles de niveaux 4 et plus.

Chaque bout de salle est composé d'au moins 2 Tilemap, une pour le sol et une autre pour les murs et les collisions.
Chaque bout de salle est également composée de spawnpoints, ce sont des gameobjects avec une position et un script qui permet d'ajouter le gameobject à une liste de gameobject définie par le script.
Ainsi plus tard si on souhaite faire apparaître un élément à une position stockée dans cette liste on pourra facilement attribuer une position à l'élément choisi.

Un cas classique est de créer 2 groupes de spawnpoints par bout de salle. Un groupe pour les éléments aux murs et un autre pour les éléments au sol.
Ainsi on pourra choisir de générer une clef par exemple à une position tirée aléatoirement dans la liste des spawnpoints sol. Puis de choisir aléatoirement des positions dans cette même liste pour que les autres emplacement soient complétés par les éléments d'un tableau constitué de fleurs par exemple. On peut également choisir aléatoirement de ne pas instancier d'élément dans les spawnpoints restants.

Pour les éléments muraux on répète le même schéma, tout en prenant soin de bien instancier en premier la porte à l'emplacement d'un des spawnpoints de la liste de spawnpoints muraux.

On peut également choisir de rajouter un spawnpoint dans un bout de salle chargé d'instancier un autre bout de salle à côté de ce premier bout de salle. Cela permet à un bout de salle dit "début" de faire apparaître un autre bout de salle qui lui pourrait également faire apparaître un autre bout de salle ect, jusqu'à tomber sur un bout de salle dit "fin" qui lui ne fait pas apparaître d'autre bout de salle et donc termine le processus.

Il faut donc bien faire attention à faire apparaître des bouts de salle de façon logique et cohérente pour éviter que 2 bouts de salle apparaissent au même endroit. Il faut également bien sûr éviter qu’un bout de salle fasse apparaître un autre bout de salle sur lequel le joueur ne pourrait pas aller.

Chaque élément (clef, porte, fleurs ect) sont stockés dans des tableaux de gameobject, eux-même stockés dans un script EnigmaTemplates présent sur le gameobject EnigmaTemplates.

Sur ce script on retrouve tous les éléments décors et énigmes qu'on peut instancier mais également les listes où les spawnpoints se rajouteront quand leur bout de salle respectif sera généré.

C'est ce script qui va choisir quelle énigme sera générée et quels éléments de décor seront générés.
Mais il faut attendre que les bouts de salles aient terminé de tous s'instancier pour que les spawnpoints aient terminé de tous se stocker dans les listes prévues avant qu'on puisse utiliser ces spawnpoints.

C'est pour cela que les fonctions Scena1, Scena2, Scena3 et Scena4 ont un délai de 1f avant d'être appelée.


La fonction Scena4 est intéressante car elle appelle toutes les autres et permet donc de générer les bons éléments d'énigmes et ce qu'importe les spawnpoints qui ont été instancié par l'aléatoire de l'instanciation des bouts de salle.

Les autres fonctions Scena 1 à 12 permettent d'instancier les éléments propres à leur énigme. Ainsi chaque cadenas généré est généré avec les indices qui permettent de le résoudre.

## Structure des objets du Jeu, et des interactions :

Tous les Objets avec lequel nous pouvons interagir sont définis par 1 de 3 catégories : Un obstacle, un indice ou un item. Nous avons décidé de créer des scripts que nous pouvons attaché dans le code pour contenir de l’information sur nos GameObject dans Unity. Ces scripts sont des classes qui héritent de “ScriptableObject”, l’équivalent d’une classe abstraite.

Une classe Objet héritera de ScriptableObject, les classes Obstacles, Items et Hints hériteront de la classe Objet. Nous pouvons alors factoriser l’information en créant des assets dans Unity sans oublier des informations importantes. Nous pouvons aussi créer des méthodes abstraites.

Nous avons maintenant un script “Interactable” qui permet de dire que le joueur peut interagir avec le GameObject. Nous pouvons attacher à ce script un asset qui dérive d’un item, hint, ou obstacle. Ce Script comporte des méthodes pour gérer tous les différents types d’objet du jeu.

Le gameObject “Joueur” comporte un script “PlayerInteract” qui lui permet, quand il rentre en collision avec un objet qui a une boite de collision, de récupérer le script “Interactable”, si présent. Il n’y a pas que le Joueur qui aura besoin des informations liés aux objets. Certains objets interagissent entre eux. Même les éléments de l’Interface Utilisateur aura besoin de ces informations comme le Tooltip et la Textbox.


## Système d’événement

Le projet dépend en grande partie de la fonctionnalité des méthodes “delegate”. Les delegates permettent de limiter les références multiples entre les différents objets du jeu. En effet nous pouvons créer des événements et tout objet dans le jeu qui a besoin de faire quelque-chose quand cet événement arrive, peut le faire. Cela permet de “refresh” les données à chaque événements au lieu de chaque frame.

De plus, nous pouvons créer des dépendances sur des instances d’informations avec les fonctions Awake() et Start() de Unity. Mais avec la génération procédurale des salles et des énigmes, nous ne pouvons pas dépendre de ces méthodes. Beaucoup des informations du jeu sont générées “on run-time”, d’où l'intérêt de nos “delegates”.


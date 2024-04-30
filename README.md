![logo](https://media.discordapp.net/attachments/1019490902319829013/1234841481089646592/LP.png?ex=6632333f&is=6630e1bf&hm=ea543435f6e670bac662590d66898ea28d0a760ff0d6f34ebeb6f1f672ce45f2&=&format=webp&quality=lossless&width=1440&height=429)
Lyonpalme, est application c# qui cherche a créer des materiels, ajouter des prêts, visualisation de prêts, visualisation des stock de matériel ainsi que fin de prêt.
#
voici le schema de la base de donnée, avec les tables, ainsi que les collones de chacunes d'elles.


![schema base de données](https://media.discordapp.net/attachments/1019490902319829013/1220746820112613446/image.png?ex=6631ae52&is=66305cd2&hm=6e80406e3747b7f79a32e8320e6fb62e08b873a321bacbe8f456297f71f92873&=&format=webp&quality=lossless&width=825&height=700)

en plus du schema de la base de donnée, voici également 

#
voici le diagrame de cas d'utilisation de notre application

![diagrame de cas d'utilisation](https://media.discordapp.net/attachments/1019490902319829013/1234837747915554867/image.png?ex=66322fc5&is=6630de45&hm=cca60a91df486da142a1f6e299602681b74ec4ed80b4d7672fc4686abef2b905&=&format=webp&quality=lossless&width=969&height=700)

#
en vous connectant avec le login mot de passe

login : phauchon 

mot de passe : C1Secret!

vous avez acces à l'ensemble de l'application

![formulaire login](https://media.discordapp.net/attachments/1019490902319829013/1234839866961825792/image.png?ex=663231be&is=6630e03e&hm=fbb5080b3b8bfc1ee68722766aaf89227986b9681c30fbd541bb8aafdc8b6f14&=&format=webp&quality=lossless&width=1144&height=492)

une fois l'application lancer vous acceder a la page d'accueil qui vous permet d'acceder au deux formulaire principaux materiel et pret 

![formulaire principale](https://media.discordapp.net/attachments/1019490902319829013/1234841776951660666/image.png?ex=66323385&is=6630e205&hm=69d83f3221f7e29dce788758cf7c7eed35be52a9f758b313f38e5680bfb36fbe&=&format=webp&quality=lossless&width=1135&height=591)

le formulaire materiel possède toute la vue du stock on y vois le materiel en stock et la quantité pour chaque type de materiel

![formulaire materiel](https://media.discordapp.net/attachments/1019490902319829013/1234842210776911902/image.png?ex=663233ed&is=6630e26d&hm=af0683dcb398aededca07c296d49ad5e72de63876152f31c053371ad9ce0baeb&=&format=webp&quality=lossless&width=1153&height=636)

en cliquant sur ajout materiel un formulaire permet d'ajouter du materiel dans la base de donnée vous avez également une petite vue du dernier id utilisé pour savoir quel id sera le prochain disponible

![formulaire ajout materiel](https://media.discordapp.net/attachments/1019490902319829013/1234842268750315611/image.png?ex=663233fb&is=6630e27b&hm=67b2799d42f99dd8c95d5e60636d31f12985f2e3749970c16f8400c1eb78592c&=&format=webp&quality=lossless&width=1090&height=634)

le formulaire pret permet de visualisé les prêts encore en cours de la table avec tout les élement qu'il leur sont associé, il permet également la supression de pret (mettre fin à un pret) en ajoutant une date de fin au jours ou le pret est suprimé.

![formulaire pret](https://media.discordapp.net/attachments/1019490902319829013/1234842343153074196/image.png?ex=6632340c&is=6630e28c&hm=2d938463536f28b840cf35d954aae72cc568eed73fdc4751e11d05ea5e0916ab&=&format=webp&quality=lossless&width=1189&height=652)

vous pouvez également ajouter un pret en cliquant sur le bouton pour ajouter, 

![formulaire ajout pret](https://media.discordapp.net/attachments/1019490902319829013/1234842407841960036/image.png?ex=6632341c&is=6630e29c&hm=44a3479315e1491512898ebc6de75c7218b4ed4fe1eda22d2d842b02791dd8f4&=&format=webp&quality=lossless&width=1089&height=595)

#

pour faire tout cela l'application utilise une liaison à des procédure stocké, et en passant par un utilisateur spécifique celle ci récupere les donnée dans dbinterface et les affiche dans chaque formulaire avec l'appel de ses fonctions mise en static.
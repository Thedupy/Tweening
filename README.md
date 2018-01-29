# Tweening
Dans le fichier Tween.cs, vous aurez deux classes
- TweenPosition : Va effectuer de l'easing sur un Vector2. Utilisable donc sur la position principalement.
- TweenValue : Va effectuer de l'easing sur un float.

## TWEENPOSITION
TweenPosition est la classe la plus simple a utiliser.
![alt text](https://i.imgur.com/B9dU3iT.png "important parts")

Assurez vous d'avoir un objet TweenPosition déclaré et instancié dans l'objet voulu, et qu'il soit Update avec le GameTime (le mien est en milliseconde) ainsi qu'avec une reference du Vector2 de votre choix (ici la Position du Sprite).

Il vous suffit ensuite d'appeller la fonction Move de votre objet TweenPosition.

![alt text](https://i.imgur.com/P4BDujO.png "param")

Les parametre sont : 
- Vector2 change : La futur position.
- float duraction : Le temps que mettra le changement pour aller au bout du mouvement
- EaseFunction function (de base sur Linear, voir la partie sur EaseFunction un peu plus bas) : La Fonction que vous voulez appliquer.

![alt text](https://i.imgur.com/9Mccgx4.png "move")

## TWEENVALUE

![alt text](https://i.imgur.com/tz4Omku.png "loll")

## EASEFUNCTION
En dessous des deux class TweenPosition et TweenValue, vous allez trouver une Enumeration appellé EaseFunction, ainsi qu'une class Ease.
L'enumeration sert simplement  a retourner la valeur via la bonne fonction (la fonction Easing de la class Ease est appellé dans le Update des deux class Tween).

Si vous voulez rajouter une fonction, il faudra la rajouter dans l'enum et dans la fonction Easing.

Vous pouvez voir et regardez comment les valeurs sont retourné en fonction de la fonction utilisé sur [ce site](http://gizma.com/easing/)

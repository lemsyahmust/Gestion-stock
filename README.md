# Gestion-stock
# 
<h3>I.	Présentation du projet</h3>

* La mise en place de l’application  "Gestion de Stock " réalisée dans l'objectif d'informatiser les fonctions principales d'un grossiste fournisseur des recharge telephonique et des portables, caractérisées par la gestion du stock, des revendeurs, des produits, et des commandes.

 * Le développement de l’application "Gestion de stock et livraison ", est basé sur le  VB.NET comme langage de programmation  et SQL SERVER 2008 comme outil de gestion de base de données.

 * Ce grossiste est spécialisé dans l'achat et revente des différents produits commerciaux qui constituent la base des communications mobiles (recharges, portables, puces), et d'autres la base des réseaux internet (modems). Ces produits sont procurés depuis les grands opérateurs connus qui figurent dans notre pays.
 
  * L'achat des produits depuis les opérateurs est fixé par un certain prix qui diffère d'un produit à un autre. La même chose lors de la revente: à chaque revendeur et pour chaque catégorie des produits est associé un pourcentage calculé sur le tarif client qui décide du prix de vente des produits à ce revendeur.
  
  <h3>II. Analyse et Conception</h3>
  
          1. Dictionnaire de données:
          
<table>
       <tr>
        <td><b>Libelle </b></td>
        <td><b>Description </b></td>
        <td> </td>
        <td><b>Libelle </b></td>
        <td><b>Description </b></td>
       </tr>
       <tr>
        <td>idGross  </td>
        <td>Identifiant du grossiste </td>
        <td> </td>
        <td>nomGross  </td>
        <td>Nom du grossiste  </td>
       </tr>
       <tr>
        <td>capital  </td>
        <td>Capital du grossiste  </td>
        <td> </td>
        <td>codeSoc </td>
        <td>Code d’un opérateur  </td>
       </tr>
       <tr>
        <td>nomSoc   </td>
        <td>Nom d’un opérateur  </td>
        <td> </td>
        <td>telSoc </td>
        <td>Numéro de téléphone d’un opérateur  </td>
       </tr>
       <tr>
        <td>codeRevend  </td>
        <td>Identifiant d’un revendeur  </td>
        <td> </td>
        <td>codeCateg </td>
        <td>Identifiant d’une catégorie produit </td>
       </tr>
       <tr>
        <td>categPdt  </td>
        <td>Nom d’une catégorie produit  </td>
        <td> </td>
        <td>typeCateg </td>
        <td>Type d’une catégorie produit </td>
       </tr>
       <tr>
        <td>qteCmd  </td>
        <td>Quantité commandée d’un produit </td>
        <td> </td>
        <td>prixU </td>
        <td>Prix unitaire du produit commandé </td>
       </tr>
       <tr>
        <td>totalPdt  </td>
        <td>Montant total d'un produit commandé </td>
        <td> </td>
        <td>qteAchat </td>
        <td>Quantité achetée d’un produit en provenance d’un opérateur </td>
       </tr>
       <tr>
        <td>codeArchSt </td>
        <td>Identifiant d'un archive d'un produit </td>
        <td> </td>
        <td>SI </td>
        <td>Stock initial d'un produit pour une date donnée </td>
       </tr>
       <tr>
        <td>pourcentage </td>
        <td>Pourcentage de revente d'un produit pour un revendeur </td>
        <td> </td>
        <td>idTypeUser </td>
        <td>Type d'un utilisateur </td>
       </tr>
       <tr>
        <td>nomRevend </td>
        <td>Nom d’un revendeur </td>
        <td> </td>
        <td>adrRevend </td>
        <td>Adresse d’un revendeur </td>
       </tr>
       <tr>
        <td>telRevend </td>
        <td>Numéro de téléphone d’un revendeur </td>
        <td> </td>
        <td>codePdt </td>
        <td>Identifiant d’un produit </td>
       </tr>
       <tr>
        <td>desigPdt </td>
        <td>Désignation d’un produit </td>
        <td> </td>
        <td>prixPdt </td>
        <td>Prix client d’un produit </td>
       </tr>
       <tr>
        <td>qteStock </td>
        <td>Quantité en stock actuelle d’un produit </td>
        <td> </td>
        <td>pourcentAchat </td>
        <td>pourcentage d'achat d’un produit de l'opérateur </td>
       </tr>
       <tr>
        <td>numCmd </td>
        <td>Numéro d’une commande </td>
        <td> </td>
        <td>dateCmd </td>
        <td>Date d'enregistrement d'une commande </td>
       </tr>
       <tr>
        <td>reste </td>
        <td>Reste à payer d'une commande </td>
        <td> </td>
        <td>montantHT </td>
        <td>Montant d'une commande </td>
       </tr>
       <tr>
        <td>etatP </td>
        <td>Etat du paiement d'une commande </td>
        <td> </td>
        <td>dateAchat </td>
        <td>date d’achat d’un produit en provenance d’un opérateur </td>
       </tr>
       <tr>
        <td>nomCompUser </td>
        <td>Nom complet d'un utilisateur </td>
        <td> </td>
        <td>SF </td>
        <td>Stock final d'un produit pour une date donnée </td>
       </tr>
        <tr>
        <td>dateArch </td>
        <td>Date d'archivage d'un produit </td>
        <td> </td>
        <td> </td>
        <td> </td>
       </tr>
      
</table>
  
          2. Règles de gestion :
  Ici on a travailler avec la méthode <b>CASCADE</b>, Après une profonde analyse du cahier de charges rédigé à partir des informations reçues du client, il a été conclu que le schéma conceptuel du projet doit se composer des entités suivantes: 

 * Grossiste: définit le nom et le capital du futur propriétaire de l'application.
 * User: définit l'ensemble des utilisateurs de l'application. Ces utilisateurs peuvent être de différents types (Administrateur, Utilisateur Ordinaire,...) qui sont décrits dans l'entité TypeUser.
 * Société: caractérise les principaux opérateurs qui sont en relation avec le client.
 * Revendeur: décrit l'ensemble des clients revendeurs qui achètent en gros les produits depuis le grossiste à travers des commandes. Ces produits sont divisés en plusieurs catégories définies dans l'entité CategoriePdt.
 * ArchiveStock : pour archiver le stock initial (SI) et le stock final (SF) d'un produit pour une certaine date.

<b>Les principales règles de gestion du système d'information sont les suivantes :</b>
* Chaque produit est caractérisé par une catégorie des produits. Il existe pour le moment 4 catégories : Recharges, Puces, Modems, et Portables.
* Un revendeur peut lancer  plusieurs commandes pour acheter plusieurs produits en gros. Ce revendeur possède un certain pourcentage d'achat sur chaque catégorie des produits  sauf les portables il est fixé.
* L'application peut avoir plusieurs utilisateurs que chacun a ses droits d'accès.

          3. La Méthode MERISE :

Merise est une méthode d'analyse, de conception et de gestion de projet informatique.

          3-1. Modèle Conceptuel de Données (MCD) :
          
Le schéma du MCD suivant décrit les différentes entités ainsi que les relations existantes entre elles.

![MCD](https://user-images.githubusercontent.com/83125801/179428779-889286e8-727d-4fb6-804d-2a339afc4266.png)


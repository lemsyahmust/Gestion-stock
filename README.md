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
        <td>Libelle </td>
        <td>Description </td>
        <td> </td>
        <td>Libelle </td>
        <td>Description </td>
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
 
      </table>
  

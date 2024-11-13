# Visualiseur de Journaux (Logs Viewer)

Un visualiseur de journaux Windows (Event Log Viewer) en C# permettant de lire et d'exporter les entrées des journaux système sous format CSV ou TXT.

## Description

Ce projet vous permet de consulter les journaux système de Windows (Event Logs), de les filtrer par type (Erreur, Avertissement, etc.), de les afficher dans une interface graphique et d'exporter les logs dans un fichier CSV ou TXT.

### Fonctionnalités principales :
- **Filtrer les événements** : Filtrez les journaux selon le type d'événement (Information, Avertissement, Erreur, etc.).
- **Supprimer des entrées** : Supprimez des entrées spécifiques ou tout le contenu du tableau.
- **Exporter les logs** : Exportez les logs visibles dans un fichier CSV ou TXT.
- **Interface simple et stylisée** : Interface graphique personnalisée avec des boutons et un tableau bien présenté.

## Prérequis

- Visual Studio ou un autre IDE compatible avec .NET Framework.
- Le programme fonctionne sur Windows et nécessite des privilèges administratifs pour accéder à certains journaux système.

## Installation

1. Clonez le repository ou téléchargez le projet sur votre machine.
2. Ouvrez le projet dans Visual Studio ou un IDE compatible avec C#.
3. Compilez le projet en mode Debug ou Release.
4. Exécutez le programme dans Visual Studio.

### Utilisation

## Liste des Journaux Système :

La liste des journaux système est affichée dans un ListBox.
Sélectionnez un journal pour afficher ses événements dans un tableau.

## Filtrer les événements :

Utilisez la ComboBox pour choisir un type d'événement (Information, Erreur, etc.).
Cliquez sur Filtrer pour appliquer le filtre.

## Supprimer des événements :

Sélectionnez les événements dans le tableau et cliquez sur Supprimer pour les enlever.
Cliquez sur Tout Supprimer pour supprimer toutes les entrées du tableau.

## Exporter les logs :

Cliquez sur Exporter pour sauvegarder les logs visibles dans un fichier CSV ou TXT.
Sélectionnez le format (CSV ou TXT) et l'emplacement pour sauvegarder le fichier.

Fonctionnement de l'export :

Les logs exportés contiennent les colonnes suivantes :
- Niveau
- Date et Heure
- Source
- Catégorie
- Message
  
Les fichiers CSV sont séparés par des points-virgules (;) et les dates sont formatées comme du texte pour une lecture correcte dans Excel.

## Exemple d'export CSV (en brut) :

Niveau;Date et Heure;Source;Catégorie;Message
"Information";"2024-11-14 08:45:00";"Application";"Général";"L'application a démarré."
"Avertissement";"2024-11-14 09:10:00";"Système";"Disque";"Espace disque faible."
"Erreur";"2024-11-14 09:30:00";"Application";"Erreur de connexion";"Impossible de se connecter 

## Exemple d'export TXT :

Niveau    Date et Heure      Source     Catégorie     Message
Information  2024-11-14 08:45:00    Application   Général   L'application a démarré.
Avertissement 2024-11-14 09:10:00    Système       Disque     Espace disque faible.
Erreur  2024-11-14 09:30:00    Application   Erreur de connexion   Impossible de se connecter à la base de données.

## Technologies utilisées
- C# (.NET Framework) : Le programme est développé en C# avec le .NET Framework.
- Windows Forms : Utilisation de Windows Forms pour l'interface graphique.

## Auteurs
Skrilak

# Mise en application

**Cours / Séance :** Création de bibliothèques en C#, fichiers binaires & création d’installateurs  
**Séance 07 — 10/03/2025**

---

## Exercice 01 : Générateur de mot de passe

**(Bibliothèque dynamique — `.DLL`)**

Créer une bibliothèque dynamique **`PasswordLib.dll`** permettant de :

- Générer un mot de passe aléatoire selon des critères définis (longueur, majuscules, chiffres, caractères spéciaux).
- Évaluer la force d’un mot de passe donné.

### Étapes

1. Créer une bibliothèque dynamique **PasswordLib.dll** avec les méthodes :

```csharp
GeneratePassword(int length, bool useUpper, bool useDigits, bool useSpecial)
EvaluateStrength(string password)
```

2. Créer une application console **PasswordConsoleApp** qui utilise **PasswordLib.dll**.

3. Ajouter un menu dans l’application console **PasswordConsoleApp** :

- Générer un mot de passe
- Évaluer la force d’un mot de passe donné

4. Ajouter la référence à **PasswordLib.dll** dans l’application console et l’utiliser.

---

## Exercice 02 : Gestion de fichiers binaires

**(Bibliothèque statique — `.LIB`)**

Créer une bibliothèque statique **BinaryFileLib.lib** permettant l’écriture et la lecture de fichiers binaires.

### Étapes

1. Créer une bibliothèque statique **BinaryFileLib.lib** contenant :

```csharp
void WriteBinary(string filePath, string content)
string ReadBinary(string filePath)
```

2. Créer une application console **BinaryConsoleApp** qui :

- Permet à l’utilisateur de saisir un texte et de l’enregistrer en binaire.
- Lit et affiche les données stockées.

3. Compiler **BinaryFileLib** en tant que bibliothèque statique et l’intégrer à **BinaryConsoleApp**.

---

## Exercice 03 : Bibliothèque de conversion de température

**(DLL)**

Créer une bibliothèque dynamique **TemperatureLib.dll** pour convertir des températures.

##3 Étapes

1. Créer **TemperatureLib.dll** avec les méthodes :

```csharp
double CelsiusToFahrenheit(double celsius)
double FahrenheitToCelsius(double fahrenheit)
```

2. Créer une application **TempConsoleApp** qui utilise cette bibliothèque pour convertir des températures saisies par l’utilisateur.

---

## Exercice 04 : Gestion des utilisateurs en binaire

Stocker et récupérer une liste d’utilisateurs dans un fichier binaire.

### Étapes

1. Définir une classe **Utilisateur** avec :

- Nom
- Prénom
- Courriel

2. Écrire une application qui :

- Permet d’ajouter des utilisateurs et de les enregistrer dans un fichier binaire.
- Charge et affiche les utilisateurs enregistrés.

3. Utiliser la **sérialisation binaire en C# (`BinaryFormatter`)**.

---

## Exercice 05 : Gestion de notes en binaire

Créer une application pour gérer les notes des étudiants via un fichier binaire.

### Étapes

1. Définir une classe **Étudiant** avec :

- Nom
- Matière
- Note

2. Implémenter une application qui :

- Permet à l’utilisateur d’entrer des notes et de les enregistrer en binaire.
- Charge les notes et affiche la moyenne.

---

## Exercice 06 : Création d’un installateur pour PasswordConsoleApp

Créer un installateur pour **PasswordConsoleApp** en utilisant **Inno Setup**.

### Étapes

1. Télécharger et installer **Inno Setup**.

2. Configurer l’installateur :

- Ajouter `PasswordConsoleApp.exe`
- Ajouter `PasswordLib.dll`
- Créer des raccourcis sur le **bureau** et dans le **menu Démarrer**
- Ajouter une **option de désinstallation**

3. Générer l’installateur et tester l’installation du programme.

---

## Exercice 07 : Création d’un installateur pour BinaryConsoleApp

Créer un installateur pour **BinaryConsoleApp** en utilisant **NSIS**.

### Étapes

1. Télécharger et installer **NSIS**.

2. Configurer un script **NSIS** pour :

- Ajouter `BinaryConsoleApp.exe`
- Ajouter `BinaryFileLib.lib`
- Créer un **raccourci sur le bureau**
- Ajouter une **option de désinstallation**

3. Générer l’installateur et tester l’installation.

---

## Exercice 08 : Installateur multi-application avec WiX Toolset

Créer un installateur unique pour **PasswordConsoleApp** et **BinaryConsoleApp**.

### Étapes

1. Installer **WiX Toolset**.

2. Configurer l’installateur pour inclure :

- `PasswordConsoleApp.exe` ET `PasswordLib.dll`
- `BinaryConsoleApp.exe` ET `BinaryFileLib.lib`

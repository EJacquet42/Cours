<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Compte-rendu du TP : Sécurisation d'une Application Web</title>
</head>
<body>

<h1>Compte-rendu du TP : Sécurisation d'une Application Web</h1>

<h2>Introduction</h2>

<p>Dans ce TP, notre objectif était de comprendre les failles de sécurité courantes comme les injections SQL et les attaques XSS, tout en apprenant à sécuriser une application web.</p>

<h2>Installation du Serveur LAMP</h2>

<p>Nous avons installé un environnement LAMP pour héberger notre application :</p>

<ul>
    <li>Linux : Ubuntu a été choisi comme système d'exploitation.</li>
    <li>Apache : Installation du serveur web Apache pour servir les pages web.</li>
    <li>MySQL : Configuration de la base de données MySQL pour stocker les données.</li>
    <li>PHP : Configuration de PHP pour le traitement des scripts côté serveur.</li>
</ul>

<h3>Étapes d'installation :</h3>

<ol>
    <li>Mise à jour des paquets existants :</li>
    <pre><code>sudo apt update</code></pre>
    <li>Installation d'Apache, MySQL et PHP :</li>
    <pre><code>sudo apt install apache2 mysql-server php libapache2-mod-php php-mysql</code></pre>
    <li>Configuration de MySQL en suivant les instructions fournies lors de l'installation.</li>
    <li>Vérification du fonctionnement du serveur Apache en accédant à l'adresse IP de la machine depuis un navigateur web.</li>
</ol>

<h2>Injection SQL (SQLI)</h2>

<ul>
    <li><strong>Description :</strong> L'injection SQL permet à un attaquant d'insérer du code SQL malveillant dans une requête.</li>
    <li><strong>Risques :</strong> Risques de divulgation ou de modification non autorisée de données dans la base de données.</li>
    <li><strong>Solution :</strong> Utilisation de requêtes paramétrées pour prévenir les injections.</li>
</ul>

<p>Exemple en PHP :</p>
<code>
    $stmt = $pdo->prepare("SELECT * FROM users WHERE username = ?");
    $stmt->execute([$username]);
</code>

<h2>Cross-Site Scripting (XSS)</h2>

<ul>
    <li><strong>Description :</strong> L'attaque XSS consiste à injecter des scripts malveillants dans des pages web.</li>
    <li><strong>Risques :</strong> Risques de vol de cookies, d'exécution de scripts malveillants, etc.</li>
    <li><strong>Solution :</strong> Filtrage et échappement des données utilisateur pour prévenir les attaques XSS.</li>
</ul>

<p>Exemple en PHP :</p>
<code>
    $username = htmlspecialchars($_POST['username']);
</code>

<h2>Sécurisation de l'Application et du Système</h2>

<p>Pour renforcer la sécurité de notre application, nous avons pris les mesures suivantes :</p>

<ul>
    <li>Utilisation de requêtes paramétrées pour les interactions avec la base de données.</li>
    <li>Validation et échappement des données utilisateur pour prévenir les attaques.</li>
    <li>Maintenance régulière du système et des logiciels pour appliquer les correctifs de sécurité.</li>
</ul>

<h2>Conclusion</h2>

<p>Ce TP nous a permis de comprendre l'importance cruciale de la sécurité dans le développement et la gestion des applications web. En adoptant des pratiques de sécurité solides, nous pouvons réduire considérablement les risques d'attaques et protéger efficacement les données sensibles de nos utilisateurs.</p>

</body>
</html>
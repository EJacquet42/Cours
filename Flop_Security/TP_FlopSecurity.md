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
    <li><strong>Risques :</strong> <br>
    - Divulgation de données sensibles : Les injections SQL peuvent permettre à un attaquant de récupérer ou de modifier des données sensibles dans la base de données.<br>
    - Perte de confidentialité : Les attaquants peuvent extraire des informations confidentielles, telles que des informations d'identification ou des données financières, en exploitant les vulnérabilités d'injection SQL..</li>
    <li><strong>Solution :</strong> <br>
    - Utilisation de requêtes paramétrées ou de requêtes préparées : Comme illustré dans l'exemple PHP fourni dans le compte-rendu du TP, l'utilisation de requêtes paramétrées permet de séparer les données des instructions SQL, ce qui prévient efficacement les injections SQL.<br>
    - Validation des entrées utilisateur : Valider les entrées utilisateur pour s'assurer qu'elles correspondent aux formats attendus peut également contribuer à prévenir les injections SQL en détectant les entrées malveillantes.</li>
</ul>

<p>Exemple d'injection :</p>

    " OR  LIMIT 1; --


<h2>Cross-Site Scripting (XSS)</h2>

<ul>
    <li><strong>Description :</strong> L'attaque XSS consiste à injecter des scripts malveillants dans des pages web.</li>
    <li><strong>Risques :</strong> <br>
    - Vol de cookies et session hijacking : Les attaques XSS peuvent permettre à un attaquant de voler des cookies de session, ce qui pourrait compromettre les comptes des utilisateurs.<br>
    - Altération du contenu : Les attaques XSS peuvent modifier le contenu d'une page web, souvent dans le but de tromper les utilisateurs ou de diffuser des logiciels malveillants.</li>
    <li><strong>Solution :</strong> <br>
    - Comme mentionné dans le compte-rendu, le filtrage et l'échappement des données utilisateur avant leur affichage dans une page web peuvent empêcher l'exécution de scripts malveillants.<br>
    - Utilisation de l'encodage HTML approprié : Assurez-vous que toutes les données provenant de sources non fiables sont correctement encodées avant d'être incluses dans une page HTML.</li>
</ul>

<p>Exemple de XSS :</p>

    <script>alert('Hello XSS')</script>

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
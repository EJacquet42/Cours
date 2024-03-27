<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Compte-rendu du TP : S�curisation d'une Application Web</title>
</head>
<body>

<h1>Compte-rendu du TP : S�curisation d'une Application Web</h1>

<h2>Introduction</h2>

<p>Dans ce TP, notre objectif �tait de comprendre les failles de s�curit� courantes comme les injections SQL et les attaques XSS, tout en apprenant � s�curiser une application web.</p>

<h2>Installation du Serveur LAMP</h2>

<p>Nous avons install� un environnement LAMP pour h�berger notre application :</p>

<ul>
    <li>Linux : Ubuntu a �t� choisi comme syst�me d'exploitation.</li>
    <li>Apache : Installation du serveur web Apache pour servir les pages web.</li>
    <li>MySQL : Configuration de la base de donn�es MySQL pour stocker les donn�es.</li>
    <li>PHP : Configuration de PHP pour le traitement des scripts c�t� serveur.</li>
</ul>

<h3>�tapes d'installation :</h3>

<ol>
    <li>Mise � jour des paquets existants :</li>
    <pre><code>sudo apt update</code></pre>
    <li>Installation d'Apache, MySQL et PHP :</li>
    <pre><code>sudo apt install apache2 mysql-server php libapache2-mod-php php-mysql</code></pre>
    <li>Configuration de MySQL en suivant les instructions fournies lors de l'installation.</li>
    <li>V�rification du fonctionnement du serveur Apache en acc�dant � l'adresse IP de la machine depuis un navigateur web.</li>
</ol>

<h2>Injection SQL (SQLI)</h2>

<ul>
    <li><strong>Description :</strong> L'injection SQL permet � un attaquant d'ins�rer du code SQL malveillant dans une requ�te.</li>
    <li><strong>Risques :</strong> <br>
    - Divulgation de donn�es sensibles : Les injections SQL peuvent permettre � un attaquant de r�cup�rer ou de modifier des donn�es sensibles dans la base de donn�es.<br>
    - Perte de confidentialit� : Les attaquants peuvent extraire des informations confidentielles, telles que des informations d'identification ou des donn�es financi�res, en exploitant les vuln�rabilit�s d'injection SQL..</li>
    <li><strong>Solution :</strong> <br>
    - Utilisation de requ�tes param�tr�es ou de requ�tes pr�par�es : Comme illustr� dans l'exemple PHP fourni dans le compte-rendu du TP, l'utilisation de requ�tes param�tr�es permet de s�parer les donn�es des instructions SQL, ce qui pr�vient efficacement les injections SQL.<br>
    - Validation des entr�es utilisateur : Valider les entr�es utilisateur pour s'assurer qu'elles correspondent aux formats attendus peut �galement contribuer � pr�venir les injections SQL en d�tectant les entr�es malveillantes.</li>
</ul>

<p>Exemple d'injection :</p>

    " OR  LIMIT 1; --


<h2>Cross-Site Scripting (XSS)</h2>

<ul>
    <li><strong>Description :</strong> L'attaque XSS consiste � injecter des scripts malveillants dans des pages web.</li>
    <li><strong>Risques :</strong> <br>
    - Vol de cookies et session hijacking : Les attaques XSS peuvent permettre � un attaquant de voler des cookies de session, ce qui pourrait compromettre les comptes des utilisateurs.<br>
    - Alt�ration du contenu : Les attaques XSS peuvent modifier le contenu d'une page web, souvent dans le but de tromper les utilisateurs ou de diffuser des logiciels malveillants.</li>
    <li><strong>Solution :</strong> <br>
    - Comme mentionn� dans le compte-rendu, le filtrage et l'�chappement des donn�es utilisateur avant leur affichage dans une page web peuvent emp�cher l'ex�cution de scripts malveillants.<br>
    - Utilisation de l'encodage HTML appropri� : Assurez-vous que toutes les donn�es provenant de sources non fiables sont correctement encod�es avant d'�tre incluses dans une page HTML.</li>
</ul>

<p>Exemple de XSS :</p>

    <script>alert('Hello XSS')</script>

<h2>S�curisation de l'Application et du Syst�me</h2>

<p>Pour renforcer la s�curit� de notre application, nous avons pris les mesures suivantes :</p>

<ul>
    <li>Utilisation de requ�tes param�tr�es pour les interactions avec la base de donn�es.</li>
    <li>Validation et �chappement des donn�es utilisateur pour pr�venir les attaques.</li>
    <li>Maintenance r�guli�re du syst�me et des logiciels pour appliquer les correctifs de s�curit�.</li>
</ul>

<h2>Conclusion</h2>

<p>Ce TP nous a permis de comprendre l'importance cruciale de la s�curit� dans le d�veloppement et la gestion des applications web. En adoptant des pratiques de s�curit� solides, nous pouvons r�duire consid�rablement les risques d'attaques et prot�ger efficacement les donn�es sensibles de nos utilisateurs.</p>

</body>
</html>
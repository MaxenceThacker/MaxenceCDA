-- EXERCICE 1 : EXEMPLE --

-- QUESTION 1 --

USE exemple;
SELECT * FROM employe

-- QUESTION 2 --

USE exemple;
SELECT nodept AS 'Numero Departement', nom, noregion AS 'Numero Region'
FROM dept 

-- QUESTION 3 --

USE exemple;
SELECT nom AS 'Nom Employe', dateemb AS 'Date Embauche', nosup AS 'Numero Superieur', nodep AS 'Numero Departement Employe', salaire
FROM employe

-- QUESTION 4 --

USE exemple;
SELECT titre AS 'Titre Employe'
FROM employe

-- QUESTION 5 --

USE exemple;
SELECT DISTINCT titre 
FROM employe

-- QUESTION 6 --

USE exemple;
SELECT nom AS 'Nom Employe', noemp AS 'Numero Employe', nodep AS 'Numero Departement Employe'
FROM employe
WHERE titre = 'Secrétaire'

-- QUESTION 7 --

USE exemple;
SELECT nom AS 'Nom Departement', nodept AS 'Numero Departement' 
FROM dept
WHERE nodept > 40

-- QUESTION 8 --

USE exemple;
SELECT nom AS 'Nom Employe', prenom AS 'Prenom Employe'
FROM employe
WHERE nom < prenom 

-- QUESTION 9 --

USE exemple;
SELECT nom AS 'Nom Employe', salaire AS 'Salaire Employe', nodep AS 'Numero Departement Employe'
FROM employe
WHERE titre = 'Représentant', nodep = 35, salaire > 20000

-- QUESTION 10 --

USE exemple;
SELECT nom AS 'Nom Employe', titre AS 'Titre Employe', salaire AS 'Salaire Employe'
FROM employe
WHERE titre = 'Représentant' OR titre = 'Président'

-- QUESTION 11 --

USE exemple;
SELECT nom AS 'Nom Employe', nodep AS 'Numero Departement Employe'
FROM employe
WHERE salaire in (
    SELECT nodep AS 'Numero Departement Employe', titre AS 'Titre Employe' 
    FROM employe 
    WHERE nodep = 34, titre = 'Représentant' OR titre = 'Secrétaire'
    )

-- QUESTION 12 --

USE exemple;
SELECT nom AS 'Nom Employe', titre AS 'Titre Employe', nodep AS 'Numero Departement Employe', salaire AS 'Salaire Employe'
FROM employe
WHERE titre = 'Représentant', titre = 'Secrétaire' IN (
    SELECT nodep 
    FROM employe 
    WHERE nodep = 34
)

-- QUESTION 13 --

USE exemple;
SELECT nom AS 'Nom Employe', salaire AS 'Salaire Employe'
FROM employe
WHERE salaire BETWEEN 20000 AND 30000

-- QUESTION 14 --

/** PAS DE QUESTION 14 **/ 

-- QUESTION 15 -- 

SELECT nom AS 'Nom Employe'
FROM employe
WHERE nom LIKE "H%"

-- QUESTION 16 --

SELECT nom AS 'Nom Employe'
FROM employe
WHERE nom LIKE '%n'

-- QUESTION 17 --

SELECT nom AS 'Nom Employe' 
FROM employe 
WHERE SUBSTR(nom, 2, 1) = 'u'

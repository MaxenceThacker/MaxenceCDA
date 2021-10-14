-- QUESTION 1 --

SELECT prenom, noregion
FROM employe
INNER JOIN dept on employe.nodep = dept.nodept

-- QUESTION 2 --

SELECT D.nodept, E.nom, D.nom
FROM dept AS D INNER JOIN employe AS E ON E.nodep = D.nodept
ORDER BY E.nodep

-- QUESTION 3 --

SELECT E.nom
FROM employe AS E INNER JOIN dept AS D ON E.nodep = D.nodept
WHERE D.nom = 'Distribution'

-- QUESTION 12 --

SELECT COUNT(nom), titre
FROM employe 
GROUP BY titre

-- QUESTION 13 --

SELECT AVG(salaire), SUM(salaire), D.noregion
FROM employe AS E INNER JOIN dept AS D ON E.nodep = D.nodept
GROUP BY D.noregion

-- QUESTION 14 -- 

SELECT nodep
FROM employe
GROUP BY nodep
WHERE nodep >= 3
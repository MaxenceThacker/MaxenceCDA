--1--
SELECT *
FROM clients
--2--
SELECT IdProduit, NomProduit
FROM produits
WHERE CouleurProduit = 'rouge' AND PoidsProduit > 2000
--3--
SELECT NomRepres 
FROM representants AS r 
INNER JOIN ventes AS v ON r.IdRepres = v.IdRepres 
GROUP BY v.IdRepres 
HAVING COUNT(v.IdRepres) >= 1 
ORDER BY NomRepres
--4--
SELECT NomClient
FROM clients AS c
INNER JOIN ventes AS v ON c.IdClient = v.IdClient
WHERE VilleClient = 'Paris' AND Quantite > 180
GROUP BY NomClient
--5--
SELECT NomRepres, NomClient
FROM representants AS r 
INNER JOIN ventes AS v ON r.IdRepres = v.IdRepres
INNER JOIN clients AS c ON v.IdClient = c.IdClient
INNER JOIN produits AS p ON v.IdProduit = p.IdProduit
WHERE CouleurProduit = 'rouge' AND Quantite > 100
/* j'ai hésité à mettre un GROUP BY NomClient mais je me suis dit qu'un Client pourrait avoir plusieurs représentant */
--6--
SELECT v.IdProduit, NomProduit, SUM(Quantite)
FROM produits AS p
INNER JOIN ventes AS v ON p.IdProduit = v.IdProduit
GROUP BY v.IdProduit
--7--
SELECT NomClient 
FROM ventes AS v 
INNER JOIN clients AS c ON v.IdClient = c.IdClient 
GROUP BY v.IdClient 
HAVING AVG(Quantite) < SUM(Quantite)
--8--
CREATE VIEW v_VentesClients AS 
SELECT 
v.`IdClient`, 
`NomClient`, 
`VilleClient`,
`IdVente`, 
`IdRepres`, 
`IdProduit`, 
`Quantite`
FROM clients AS c 
INNER JOIN ventes AS v ON c.IdClient = v.IdClient
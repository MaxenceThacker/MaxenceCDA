--1
SELECT commande 
FROM fournis
WHERE numfou = '9120'

--2
SELECT DISTINCT numfou 
FROM fournis 
WHERE numfour IS NOT NULL 

--3

SELECT COUNT(commande) AS nbrcommande 
FROM fournis, entcom
GROUP BY numfou

--4

SELECT codart, libart, stkphy, stkale, qteann
FROM produit
WHERE stkphy <= stkale AND qtnann < 1000

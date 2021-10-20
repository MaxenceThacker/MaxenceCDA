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

--5

SELECT *
FROM fournis
WHERE posfou LIKE '75___' OR posfou LIKE '78___' OR posfou LIKE '92___' OR posfou LIKE '77___'
ORDER BY nomfou 

--6 

SELECT numcom, datcom
FROM entcom
WHERE datcom LIKE '%-03-%' OR datecom LIKE '%-04-%'

--7

SELECT numcom, datcom, obscom
FROM entcom
WHERE obscom <> "" AND datcom = DATE(NOW())

--8

SELECT Num, (Totalqte*Totalprix) AS 'Total'
FROM (SELECT numcom AS 'Num', SUM(qtecde) AS 'Totalqte', SUM(priuni) AS 'Totalprix' FROM ligcom GROUP BY numcom) AS Lig
ORDER BY Total DESC

--9

SELECT Num, (Totalqte*Totalprix) AS 'Total'
FROM (SELECT numcom AS 'Num', qtecde, SUM(qtecde) AS 'Totalqte', SUM(priuni) AS 'Totalprix' FROM ligcom GROUP BY numcom HAVING qtecde >= 1000 ) AS Lig
HAVING Total > 10000
ORDER BY Total DESC

--10

SELECT numcom, nomfou, datcom
FROM entcom
INNER JOIN fournis ON entcom.numfou = fournis.numfou

--11

SELECT entcom.numcom, nomfou, libart, (qtecde*priuni), obscom
FROM produit
INNER JOIN ligcom ON produit.codart = ligcom.codart
INNER JOIN entcom ON ligcom.numcom = entcom.numcom
INNER JOIN fournis ON entcom.numfou = fournis.numfou
WHERE obscom LIKE '%urgent%'

--12


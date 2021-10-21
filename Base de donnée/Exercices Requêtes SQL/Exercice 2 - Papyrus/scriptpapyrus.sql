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

Select numcom, sum(priuni* qtecde) as total  from ligcom
group by numcom
order by total desc


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

SELECT fournis.nomfou, SUM(qte1+qte2+qte3) AS 'total'
FROM vente
INNER JOIN fournis ON vente.numfou = fournis.numfou
GROUP BY nomfou
HAVING total > 0

--OR

SELECT nomfou
FROM fournis
WHERE numfou IN (SELECT numfou FROM vente WHERE (qte1+qte2+qte3) > 0)

--13

SELECT numcom, datcom
FROM entcom
WHERE numfou IN (SELECT numfou FROM entcom WHERE numcom = 70210)

/** ATTENTION A NE PAS REPRODUIRE **/

 e.numcom, e.datcom
FROM entcom 
INNER JOIN entcom AS e ON entcom.numfou = e.numfou
WHERE e.numcom = 70210

--14 

SELECT DISTINCT libart, prix1 FROM vente
INNER JOIN produit ON produit.codart = vente.codart
WHERE prix1 < (SELECT min(prix1) FROM vente WHERE codart LIKE 'R%'); 

--15

SELECT nomfou,vente.codart FROM vente 
INNER JOIN produit ON vente.codart=produit.codart
INNER JOIN fournis ON vente.numfou=fournis.numfou  
WHERE stkphy<=1.5*stkale 
ORDER BY codart,nomfou

--16

SELECT nomfou,vente.codart FROM vente 
INNER JOIN produit ON vente.codart=produit.codart
INNER JOIN fournis ON vente.numfou=fournis.numfou  
WHERE stkphy<=1.5*stkale AND delliv <= 30
ORDER BY codart,nomfou

--17

SELECT fournis.numfou, vente.codart, nomfou, SUM(stkphy)
FROM fournis
INNER JOIN vente ON fournis.numfou = vente.numfou
INNER JOIN produit ON vente.codart = produit.codart
WHERE vente.delliv  < 31
AND  stkphy  <= (stkale * 1.5)
GROUP BY fournis.numfou, vente.codart, nomfou
ORDER BY SUM(stkphy)  DESC

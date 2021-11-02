--1 
SELECT ville_nom
FROM villes_france 
WHERE LENGTH(ville_nom) >= 40
--2 
SELECT departement_nom, departement_code
FROM departements
WHERE departement_code LIKE '97%'
--3 
SELECT departement_nom
FROM departements AS d
INNER JOIN regions AS r ON d.departement_regionId = r.region_id
WHERE region_nom = 'Hauts-de-France'
ORDER BY departement_nom
--4
SELECT ville_nom, departement_nom
FROM villes_france AS vf
INNER JOIN departements AS d ON vf.ville_departement = d.departement_code
ORDER BY ville_population_2012 DESC
--5
SELECT departement_nom, departement_code, COUNT(ville_commune) AS 'TotalCommune'
FROM departements AS d 
INNER JOIN villes_france AS vf ON d.departement_code = vf.ville_departement
GROUP BY departement_nom
ORDER BY TotalCommune DESC
--6
SELECT departement_nom, SUM(ville_surface) AS 'totalSurfaceCommune'
FROM departements AS d
INNER JOIN villes_france AS vf ON d.departement_code = vf.ville_departement
GROUP BY ville_departement
ORDER BY total DESC
--7
SELECT COUNT(ville_nom) AS 'Total des villes'
FROM villes_france
WHERE ville_nom LIKE 'Saint%'
--8
SELECT cv.ville_nom 
FROM (SELECT DISTINCT COUNT(ville_nom) AS 'Total', ville_nom FROM villes_france GROUP BY ville_nom) AS cv 
WHERE cv.Total > 1 
ORDER BY cv.Total DESC
--9
SELECT ville_nom
FROM villes_france
WHERE ville_surface > (SELECT AVG(ville_surface) FROM villes_france)
--10
SELECT departement_nom
FROM departements AS d
INNER JOIN villes_france AS vf ON d.departement_code = vf.ville_departement
WHERE ville_population_2012 > 1500000
--11
UPDATE villes_france
SET ville_nom = REPLACE(ville_nom, 'SAINT-', 'SAINT ')
Where ville_nom LIKE 'SAINT-%'
--12
SELECT ville_nom
FROM villes_france
WHERE ville_surface > (SELECT MIN(ville_surface) FROM villes_france)
ORDER BY ville_surface 
LIMIT 50
--13
ALTER TABLE regions
ADD region_nbDepartemnt
--14
DELIMITER $
CREATE PROCEDURE MajRegion()
BEGIN
ALTER TABLE regions
ADD region_nbDepartemnt INT;
END $
DELIMITER ;
--15
CREATE VIEW v_villes AS 
SELECT *
FROM villes_france AS vf 
INNER JOIN departements AS d ON vf.ville_departement = d.departement_code
INNER JOIN regions AS r ON d.departement_regionId = region_id
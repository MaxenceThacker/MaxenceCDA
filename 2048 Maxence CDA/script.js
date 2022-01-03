document.addEventListener('DOMContentLoaded', () => {
    const GRIDAFF = document.querySelector('.grid');
    const SCOREAFF = document.getElementById('score');
    const RESULATAFF = document.getElementById('resultat');
    var width = 4;
    let grilles = [];

    //Creation de la grille de jeu
    function createGrid() {
        for (let i = 0; i < width*width; i++) {
            grille = document.createElement('div');
            grille.innerHTML = 0;
            GRIDAFF.appendChild(grille);
            grilles.push(grille); 
        }
        generateRandom();
        generateRandom();

    }
    createGrid();


    //console.log(grilles.length)

    //Generer un nombre aléatoir avec math floor
    function generateRandom() {
        let nombreRandom = Math.floor(Math.random() * grilles.length); //ICI on va essayer de ne pas utiliser de fonction recursive car en fin de jeu le nombre de boucle sera trop conséquent par rapport au nombre de case disponible, 
        //on va donc essayer de recuper le nombre de case disponible c:
        if (grilles[nombreRandom].innerHTML == 0) {
            grilles[nombreRandom].innerHTML = 2;
        }else generateRandom();
    }

    //movement 

})
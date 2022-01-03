document.addEventListener('DOMContentLoaded', () => {
    const GRIDAFF = document.querySelector('.grid');
    const SCOREAFF = document.getElementById('score');
    const RESULATAFF = document.getElementById('resultat');
    let width = 4;
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

    

    function caseVide() {
        for (let i=0; i < 16; i++) {
            if (i % 4 === 0) {
                let total1 = grilles[i].innerHTML;
                let total2 = grilles[i+1].innerHTML;
                let total3 = grilles[i+2].innerHTML;
                let total4 = grilles[i+3].innerHTML;
                //on recupere chaque ligne sous la forme d'un tableau de ligne
                let row = [parseInt(total1), parseInt(total2), parseInt(total3), parseInt(total4)];

                console.log(row);

                let rowFiltre = row.filter(caseVide => caseVide === 0);

                rowNbrCaseVide = rowFiltre.length;
                console.log(rowNbrCaseVide);
                 //je dois encore trouvé une methode pour additionné le nombre de case "0" par row
                 //à chaque fois ça plante...
            }
            
        }
    }
    caseVide();
    //console.log(grilles.filter(grille => grille.innerHTML = 0))

    //Generer un nombre aléatoire avec math floor
    function generateRandom() {
        let nombreRandom = Math.floor(Math.random() * grilles.length/*a changé*/); //ICI on va essayer de ne pas utiliser de fonction recursive car en fin de jeu le nombre de boucle sera trop conséquent par rapport au nombre de case disponible, 
        //on va donc essayer de recupere le nombre de case disponible c:
        if (grilles[nombreRandom].innerHTML == 0) {
            grilles[nombreRandom].innerHTML = 2;
        }else generateRandom();
    }

    



function gauche() {
    for (let i=0; i < 16; i++) {
        //j'ai récuperer la base de la fontion caseVide()
      if (i % 4 === 0) {
        let total1 = grilles[i].innerHTML;
        let total2 = grilles[i+1].innerHTML;
        let total3 = grilles[i+2].innerHTML;
        let total4 = grilles[i+3].innerHTML;
        let row = [parseInt(total1), parseInt(total2), parseInt(total3), parseInt(total4)];

        //on doit filtrer la ligne pour recuperée les cases pleines
        let rowFiltre = row.filter(num => num);
        console.log(rowFiltre);
        //on soustrait le nombre de cases pleine au total de nombre de case disponible poour savoir si on peut se deplacer
        let casedispo = 4 - rowFiltre.length;
        console.log(casedispo);
        //on revoie le 
        let zeros = Array(casedispo).fill(0);
        let newRow = rowFiltre.concat(zeros);
        console.log(newRow);


        grilles[i].innerHTML = newRow[0];
        grilles[i +1].innerHTML = newRow[1];
        grilles[i +2].innerHTML = newRow[2];
        grilles[i +3].innerHTML = newRow[3];
      }
    }
  }
  gauche();

//   function combineRow() {
//     for (let i =0; i < 15; i++) {
//       if (grilles[i].innerHTML === grilles[i +1].innerHTML) {

//         let combineTotal = parseInt(grilles[i].innerHTML) + parseInt(grilles[i +1].innerHTML);

//         grilles[i].innerHTML = combinedTotal;

//         grilles[i +1].innerHTML = 0;

//         score += combineTotal;
//         scoreDisplay.innerHTML = score;
//       }
//     }
//   }

//   function movement(e) {
//     if(e.keyCode === 37) {
//       keyGauche();
//   }
//   document.addEventListener('keyup', movement);

//   function keyGauche() {
//     gauche();
//     combineRow();
//     gauche();
//     generateRandom();
});
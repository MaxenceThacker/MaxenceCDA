var contenu = document.querySelector(".contenu");
const requ = new XMLHttpRequest();
const requ2 = new XMLHttpRequest();
const requ3 = new XMLHttpRequest();

// /* GET FILM*/
//  requ.open('GET', 'https://localhost:44374/api/Film', true);
//  requ.send();

// /* GET SALLE */
// requ2.open('GET', 'https://localhost:44374/api/Salle', true);
// requ2.send();

// /* GET SEANCE */
// requ3.open('GET', 'https://localhost:44374/api/Seance', true);
// requ3.send();

// /**** GET by ID FILM */
// requ.open('GET', 'https://localhost:44374/api/Film/1', true);
// requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
// requ.send();

// /**** GET by ID SALLE */
// requ2.open('GET', 'https://localhost:44374/api/Sallle/1', true);
// requ2.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
// requ2.send();

// /**** GET by ID SEANCE */
// requ3.open('GET', 'https://localhost:44374/api/Seance/1', true);
// requ3.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
// requ3.send();


// /**** POST FILM */
// requ.open('POST', 'https://localhost:44374/api/Film', true);
// requ.setRequestHeader("Content-Type", "application/json");
// var args={
//     "idFilm": 3,
//     "libelleFilm": "Joy",
//     "dureeMinuteFilm": 55
//   }
//   requ.send(JSON.stringify(args));

// /**** POST SALLE */
// requ2.open('POST', 'https://localhost:44374/api/Salle', true);
// requ2.setRequestHeader("Content-Type", "application/json");
// var args={
//     "idSallee": 2,
//     "nbrPlaceSalle": "40"
//   }
//   requ2.send(JSON.stringify(args));

// /**** POST SEANCE */
// requ3.open('POST', 'https://localhost:44374/api/Seance', true);
// requ3.setRequestHeader("Content-Type", "application/json");
// var args={
//     "idSeance": 3,
//     "idFilm": 2,
//     "idSalle": 1,
//     "horaireSeance": "15:30:00",
//     "dateSeance": "2022-01-28T15:30:00.608Z"
//   }
//   requ3.send(JSON.stringify(args));

//   /**** PUT FILM */
//   requ.open('PUT', 'https://localhost:44374/api/Film/1', true);
//   requ.setRequestHeader("Content-Type", "application/json");
//   var args={
//     "idFilm": 3,
//     "libelleFilm": "Joy",
//     "dureeMinuteFilm": 100
//   }
//     requ.send(JSON.stringify(args));

//   /**** PUT SALLE */
//   requ2.open('PUT', 'https://localhost:44374/api/Salle/1', true);
//   requ2.setRequestHeader("Content-Type", "application/json");
//   var args={
//       "idSalle": 3,
//       "nbrPlaceSalle": "150"
//     }
//     requ2.send(JSON.stringify(args));

//   /**** PUT SEANCE */
//   requ3.open('PUT', 'https://localhost:44374/api/Seance/1', true);
//   requ3.setRequestHeader("Content-Type", "application/json");
//   var args={
//     "idSeance": 3,
//     "idFilm": 1,
//     "idSalle": 2,
//     "horaireSeance": "17:30:00",
//     "dateSeance": "2022-01-28T17:30:00.608Z"
//   }
//     requ3.send(JSON.stringify(args));


// /**** Delete FILM */
// requ.open('DELETE', 'https://localhost:44374/api/Film/2', true);
// requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
// requ.send();

/**** Delete SALLE */
requ2.open('DELETE', 'https://localhost:44374/api/Salle/2', true);
requ2.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
requ2.send();


// /**** Delete SEANCE */
// requ3.open('DELETE', 'https://localhost:44374/api/Seance/2', true);
// requ3.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
// requ3.send();



requ.onreadystatechange = function(event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("R??ponse re??ue: %s", this.responseText);;
            console.log(this.responseText);
            reponse=JSON.parse(this.responseText);
            
            
        } else {
            console.log("Status de la r??ponse: %d (%s)", this.status, this.statusText);
        }
    }
};

requ2.onreadystatechange = function(event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("R??ponse re??ue: %s", this.responseText);;
            console.log(this.responseText);
            reponse=JSON.parse(this.responseText);
            
            
        } else {
            console.log("Status de la r??ponse: %d (%s)", this.status, this.statusText);
        }
    }
};

requ3.onreadystatechange = function(event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("R??ponse re??ue: %s", this.responseText);;
            console.log(this.responseText);
            reponse=JSON.parse(this.responseText);
            
            
        } else {
            console.log("Status de la r??ponse: %d (%s)", this.status, this.statusText);
        }
    }
};
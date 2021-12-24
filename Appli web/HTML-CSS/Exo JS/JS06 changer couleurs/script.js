var nbrclic = 0;
var p = document.getElementsByClassName("pcolor");
var t = document.getElementsByClassName("l")
for (let i = 0; i < p.length; i++) {
    p[i].addEventListener('click', changep);
    
}

for (let i = 0; i < t.length; i++) {

    t[i].addEventListener('click', changet);

}


function changet() {
    for (let i = 0; i < t.length; i++) {

        if (t[i].tagName =='H1' && t[i].style.color == 'black') {
            t[i].style.color = "red";
        } else if (t[i].tagName =='H1' && t[i].style.color == 'red') {
            t[i].style.color = "green";
        } else {
            t[i].style.color = 'black';
        }

    }
}


function changep() {
    for (let i = 0; i < p.length; i++) {
        if (p[i].style.color == 'black') {
            p[i].style.color = "red";
        } else {
            p[i].style.color = "black";
        }
        
    }
    
}
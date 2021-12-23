// var listeBoutton = document.getElementsByClassName('button1')
// for (let i = 0; i < listeBoutton.length; i++) {
//     listeBoutton[i].addEventListener('click', change)
    
// }

// function change(){
// 	if (document.frm.button1.style.background='blue'){document.frm.button1.style.background='green';alert ("green");}
// 	if (document.frm.button1.style.background='green'){document.frm.button1.style.background='crimson';alert ('crimson');}
//     if (document.frm.button1.style.background='crimson'){document.frm.button1.style.background='blue';alert ("blue");}
// }

var indic=0;
var maboite=document.getElementById("boite");
maboite.addEventListener("click",change)
function change()
{
 
if (indic==0)
	{
	maboite.style.backgroundColor="blue";
	indic=1;
	}else if (indic==1)
	{
	maboite.style.backgroundColor="red";
	indic=2;	
	}
    else
	{
    maboite.style.backgroundColor="green";
	indic=0;	
	}
}
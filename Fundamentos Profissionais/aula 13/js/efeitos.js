function popup() {
	document.getElementById("b1").onclick = mostraPopUp;
	document.getElementById("b2").onclick = escondePopUp;
}
function mostraPopUp() {
	document.getElementById("popup").style.visibility = "visible";
}
function escondePopUp() {
	document.getElementById("popup").style.visibility = "hidden";
}


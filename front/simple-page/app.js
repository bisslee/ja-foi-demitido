let subdominio = window.location.hostname.split('.')[0];

if(subdominio == 127)
    subdominio = "ocuca";

const primeiraLetra = subdominio.charAt(0).toUpperCase();
const demitido = subdominio.slice(1).toLowerCase();
console.log(demitido)
const segundaLetra = demitido.charAt(0).toUpperCase();
const resto = demitido.slice(1);
const subdominioFormatado = primeiraLetra + " " + segundaLetra + resto;
const title = document.getElementById('title');
const resposta = document.getElementById('resposta');
document.title = subdominioFormatado + ", já foi demitido?";
if (subdominio !== 'ocuca') {
    let linksCuca = document.querySelector('.links-cuca');
    if (linksCuca)
        linksCuca.style.display = 'none';
}
title.innerText = subdominioFormatado;

async function buscaAPI() {
    try{
        const uri = `https://api.jafoidemitidodocorinthians.com.br/fired/${demitido}`;
        const response = await fetch(uri);
        const data = await response.json();
        console.log(data)
        if (data.erro) {
            throw new Error()
        }

        if (data.wasFired){
            resposta.innerHTML = 'SIIIIIIIIIIIIIM';
        }
        else{
            resposta.innerHTML = 'NÃO';
        }

    }
    catch(error){
        resposta.innerHTML = `deu erro: ${error}`
    }
}

buscaAPI();

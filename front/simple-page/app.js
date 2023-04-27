let subdominio = window.location.hostname.split(".")[0];

if (subdominio == 127 || subdominio == 'localhost') subdominio = "ocuca";

const primeiraLetra = subdominio.charAt(0).toUpperCase();
const demitido = subdominio.slice(1).toLowerCase();

const resposta = document.getElementById("resposta");
const title = document.getElementById("title");

let titleFormatado = "";
let firedId = 0;

function formataTitle() {
  const segundaLetra = demitido.charAt(0).toUpperCase();
  const resto = demitido.slice(1);
  titleFormatado = primeiraLetra + " " + segundaLetra + resto;

  document.title = titleFormatado + ", já foi demitido?";
  if (subdominio !== "ocuca") {
    let linksCuca = document.querySelector(".links-cuca");
    if (linksCuca) linksCuca.style.display = "none";
  }
  title.innerText = titleFormatado;
  return titleFormatado
}

async function buscaFired(fired) {
  const uri = `https://localhost:7077/Fired/${fired}`;  
//   const uri = `https://api.jafoidemitidodocorinthians.com.br/fired/${fired}`;
  fetch(uri, {
    method: "GET",
    withCredentials: false,
    crossorigin: true,
  })
    .then((res) => res.json())
    .then((data) => {
      console.log(data);
      if (data.wasFired) {
        resposta.innerHTML = "SIIIIIIIIIIIIIM";
      } else {
        resposta.innerHTML = "NÃO";
      }
      return  data.id;
      
    })
    .catch((error) => {
      console.error(error);
    });
}
titleFormatado = formataTitle();
firedId = buscaFired(demitido);


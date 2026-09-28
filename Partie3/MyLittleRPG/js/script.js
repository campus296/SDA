const apiUrl = "https://localhost:7105/api/Tuile";

const centreX = 10;
const centreY = 10;

async function chargerCarte() {
    const cases = document.querySelectorAll(".case");

    let index = 0;

    // De 8 à 12 en X et Y = grille 5 x 5 autour de (10,10)
    for (let y = centreY - 2; y <= centreY + 2; y++) {

        for (let x = centreX - 2; x <= centreX + 2; x++) {

            const tuile = await chargerTuile(x, y);

            afficherTuile(cases[index], tuile);

            index++;
        }
    }
}

async function chargerTuile(x, y) {
    try {
        const response = await fetch(`${apiUrl}/${x}/${y}`);

        if (!response.ok) {
            throw new Error(`Erreur HTTP : ${response.status}`);
        }

        return await response.json();
    }
    catch (erreur) {
        console.error(`Erreur pour la tuile (${x}, ${y}) :`, erreur);
        return null;
    }
}

function afficherTuile(caseHtml, tuile) {

    if (tuile == null) {
        caseHtml.textContent = "?";
        return;
    }

    caseHtml.innerHTML = "";

    const image = document.createElement("img");

    image.src = tuile.imageURL;
    image.alt = "Tuile " + tuile.type;

    caseHtml.appendChild(image);
}

chargerCarte();
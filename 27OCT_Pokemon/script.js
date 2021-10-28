var url = "https://pokeapi.co/api/v2/pokemon/";
var whichPokemon;

function searchPokemon() {
    whichPokemon = document.getElementById("searchbar").value;
    whichPokemon = whichPokemon.toLowerCase();
    url = "https://pokeapi.co/api/v2/pokemon/"
    url += whichPokemon; // url = url + pokemon
    fetch(url)
    .then(response => response.json())
    .then(pokemon => {
        var sprite = document.getElementById('sprite');
        sprite.innerHTML = "<img src=" + pokemon.sprites.front_default + ">";

        var name = document.getElementById('name');
        name.innerHTML = pokemon.name;

        var move1 = document.getElementById('move1');
        move1.innerHTML = pokemon.moves[1].move.name;

        var move2 = document.getElementById('move2');
        move2.innerHTML = pokemon.moves[2].move.name;

        var move3 = document.getElementById('move3');
        move3.innerHTML = pokemon.moves[3].move.name;

        var move4 = document.getElementById('move4');
        move4.innerHTML = pokemon.moves[4].move.name;

        //console.log(pokemon);
    }).catch(err => console.log(err))
}
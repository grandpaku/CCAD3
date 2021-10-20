var myArray = [4,56,6,7,8,9];

/* 
Exercise 1:
Write the code that will catch the value 8 
from the array and will be printed in the console
For example: myArray[1] <--This is equal to 56
*/


var number56 = 4; 
number56 = myArray[4];
console.log("I catch the value: " + number56);


/* 
Exercise 2:
Write the code that will catch the value 16 
from the matrix and will be printed in the console
For example: matrix[0][2] <--This is equal to 6
*/
var matrix = [[4,5,6,7],[9,15,16,6],[9,15,20,54]];
var number16 = 4;
number16 = matrix[1][2];
console.log("I catch the value: " + number16);


/* 
Exercise 3:
Now let's use objects (this is a previous topics
to classes in Javascript)
Write the code that will get the value of the age
Example: thename = human["name"] <---This will give you "John Doe"
*/
var human = {"name": "John Doe","Age": 33, "Country": "USA"};
var tempAge = 4;
tempAge = human["Age"]
console.log("I catch the value: " + tempAge);


/*
Exercise 4:
Lets mixed objects and arrays
Write the code that prints:
"The Braves team were founded in 1871. This team is from Atlanta"
Example:
var AstrosTeam = arrayOfTeams[1];
var teamName = AstrosTeam["name"];
var city = AstrosTeam["City"];
var founded = AstrosTeam["Founded"];
console.log("The "+ teamName + " team were founded in " +founded + ". This team is from "+ 
city);
*/

var team1 = {"name": "Red Sox","City": "Boston", "Founded": 1901};
var team2 = {"name": "Astros","City": "Houston", "Founded": 1962};
var team3 = {"name": "Dodgers","City": "Los Angeles", "Founded": 1883};
var team4 = {"name": "Braves","City": "Atlanta", "Founded": 1871};
var arrayOfTeams = [team1,team2,team3,team4];
var team = arrayOfTeams[3];
var teamName = team["name"];
var founded = team["Founded"];
var city = team["City"]; 
var stringToPrint= "The team " + teamName + "was founded in " + founded + ". This team is from " + city + ".";
console.log(stringToPrint);


/*
Exercise 5:
Lets mixed objects, arrays and objects inside other objects.
Write that gets the name and foundation year of packers but from
the MacroObject
"The team Packers were founded in 1919"
Example:
var theTeams = macroObject["arrayOfTeams"];
var raysTeam = theTeams[0];
var nameOfTeam = raysTeam["name"];
var yearFoundation = raysTeam["Founded"];
var stringToPrint = "The team "+nameOfTeam+" were founded in "+yearFoundation;
console.log(stringToPrint);
*/


var team5 = {"name": "Rays","City": "Tampa Bay", "Founded": 1998};
var team6 = {"name": "Packers","City": "Green Bay", "Founded": 1919};
var array11 = [0,1,2,4,6,7];
var arrayOfTeams2 = [team5, team6];
var macroObject = {"arrayOfTeams" : arrayOfTeams2, "otherArray": array11};

var box = macroObject["arrayOfTeams"];
var packers = box["team6"];

var nameOfTeam = packers["name"];
var yearFoundation = packers["Founded"];

var stringToPrint = "The team " + nameOfTeam + " were founded in " + yearFoundation;
console.log(stringToPrint);
function buttonClicked()
{
    var value1 = document.getElementById('number1').value;
    var value2 = document.getElementById('number2').value;
    value1 = parseInt(value1);
    value2 = parseInt(value2);
    var result = value1 + value2;
    document.getElementById('result').value = result;
    console.log(result);
}
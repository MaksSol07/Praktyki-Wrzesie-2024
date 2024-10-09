<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Obliczanie pola trójkąta</title>
</head>
<body>

<h2>Kalkulator pola trójkąta</h2>

<form method = "post">
    <label for = "podstawa">Podstawa trójkąta (cm): </label>
    <input type = "number" name = "podstawa" id = "podstawa" step = "any" required><br><br>
    
    <label for = "wysokosc">Wysokość trójkąta (cm): </label>
    <input type = "number" name = "wysokosc" id = "wysokosc" step = "any" required><br><br>
    
    <input type = "submit" value = "Oblicz pole">
</form>

<?php
if ($_SERVER ["REQUEST_METHOD"] == "POST") {
    $podstawa = $_POST ['podstawa'];
    $wysokosc = $_POST ['wysokosc'];
    
    function poleTrojkata($podstawa, $wysokosc) {
        return ($podstawa * $wysokosc) / 2;
    }
}

$pole = poleTrojkata($podstawa, $wysokosc);

if($podstawa > 0 || $wysokosc > 0){
    echo "<h3><i>Pole trójkąta wynosi: $pole cm^2</i></h3>";
}else{
    echo "<h3><i>Wysokość lub podstawa trójkąta nie może być zerem lub livzbą ujemną</i></h3>";
}
?>

<h2>Kalkulator obwodu trójkąta</h2>

<form method = "post">
    <label for = "bok1">bok1 (cm): </label>
    <input type = "number" name = "bok1" id = "bok1" step = "any" required><br><br>
    
    <label for = "bok2">bok2 (cm): </label>
    <input type = "number" name = "bok2" id = "bok2" step = "any" required><br><br>
    
    <label for = "bok3">bok3 (cm): </label>
    <input type = "number" name = "bok3" id = "bok3" step = "any" required><br><br>

    <input type = "submit" value = "Oblicz pole">
</form>

<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $bok1 = $_POST['bok1'];
    $bok2 = $_POST['bok2'];
    $bok3 = $_POST['bok3'];
    
    function obwodTrojkota($bok1, $bok2, $bok3) {
        return ($bok1 + $bok2 + $bok3);
    }
}

$obwod = obwodTrojkota($bok1, $bok2, $bok3);
    
if($bok1 + $bok2 > $bok3 && $bok1 + $bok3 > $bok2 && $bok2 + $bok3 > $bok1){
    echo "<h3><i>Obwód Trójkąta wynosi: $obwod cm.</i></h3>";
    }else{
        echo "<h3><i>Trójkąt nie może powstać z tych boków</i></h3>";
    }
?>


</body>
</html>

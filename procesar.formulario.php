<?php

$nombre = $_POST["nombre"];
$edad = $_POST["edad"];
$antivirus = filter_input(INPUT_POST, "antivirus", FILTER_VALIDATE_BOOL);
$contraseña = filter_input(INPUT_POST, "contraseña", FILTER_VALIDATE_BOOL);
$informacion = filter_input(INPUT_POST, "informacion", FILTER_VALIDATE_BOOL);
$ataques = filter_input(INPUT_POST, "ataques", FILTER_VALIDATE_BOOL);
$cambioCib = filter_input(INPUT_POST, "cambioCib", FILTER_VALIDATE_BOOL);



$host = "localhost";
$dbname = "ciberseguridad";
$username = "root";
$password = "";

$conn = new mysqli("localhost", "root", "", "ciberseguridad");

if (mysqli_connect_errno()) {
    die("Connection error: " . mysqli_connect_error());
}           

echo "yaaas.";
                            
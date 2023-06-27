<?php

$nombre = $_POST["nombre"];
$edad = $_POST["edad"];
$antivirus = filter_input(INPUT_POST, "antivirus", FILTER_VALIDATE_BOOL);
$contraseña = filter_input(INPUT_POST, "contraseña", FILTER_VALIDATE_BOOL);
$informacion = filter_input(INPUT_POST, "informacion", FILTER_VALIDATE_BOOL);
$ataques = filter_input(INPUT_POST, "ataques", FILTER_VALIDATE_BOOL);
$cambioCib = filter_input(INPUT_POST, "cambioCib", FILTER_VALIDATE_BOOL);

if ( ! $terms) {
    die("Terms must be accepted");
}   

$host = "localhost";
$dbname = "message_db";
$username = "root";
$password = "";
        
$conn = mysqli_connect(hostname: $host,
                       username: $username,
                       password: $password,
                       database: $dbname);
        
if (mysqli_connect_errno()) {
    die("Connection error: " . mysqli_connect_error());
}           
        
$sql = "INSERT INTO message (name, body, priority, type)
        VALUES (?, ?, ?, ?)";

$stmt = mysqli_stmt_init($conn);

if ( ! mysqli_stmt_prepare($stmt, $sql)) {
 
    die(mysqli_error($conn));
}

mysqli_stmt_bind_param($stmt, "ssii",
                       $name,
                       $message,
                       $priority,
                       $type);

mysqli_stmt_execute($stmt);

echo "Record saved.";
?>
<?php
define('HOST', 'localhost');
define('USERNAME', 'root');
define('PASSWORD', '');
define('DATABASE', 'ordersystem');

function create_connection() {
	$conn = mysqli_connect(HOST, USERNAME, PASSWORD, DATABASE);
	
    if($conn-> connect_error)
    {
        die('Can not connect to the server: ' .$conn->connect_error);
    }

    return $conn;
	
}

$conn = create_connection();
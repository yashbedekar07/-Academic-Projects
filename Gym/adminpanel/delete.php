
<!-- delete.php -->
<?php
// Connect to the database
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "gym";

$conn = mysqli_connect($servername, $username, $password, $dbname);

// Check connection
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

// Handle record deletion
if (isset($_GET["id"])) {
    $id = $_GET["id"];
    $query = "DELETE FROM registration  WHERE ID='$id'";
    mysqli_query($conn, $query);

    // Redirect back to the record page
    header("Location: index.php");
    exit();
}

// Close the database connection
mysqli_close($conn);
?>



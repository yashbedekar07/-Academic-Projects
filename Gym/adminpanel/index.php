<!DOCTYPE html>
<html>
<title>BodyPowerGym</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="shortcut icon" type="image/x-icon" href="assets/img/favicon.ico">
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KK94CHFLLe+nY2dmCWGMq91rCGa5gtU4mk92HdvYe+M/SXH301p5ILy+dN9+nJOZ" crossorigin="anonymous">
<style>
  *{
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: 'Poppins',sans-serif;
}
body{
  height: 100vh;
  display: contain;
  justify-content: center;
  align-items: center;
  padding: 10px;
  background-image:linear-gradient(rgba(0,0,0,0.5),#000000), url("assets/img/muscle-3.jfif");
    background-repeat: no-repeat;
    background-size: cover;
    height: 100vh;
  
}
/* Adjustments for small screens */
@media (max-width: 600px) {
  table {
    display: block;
    overflow-x: auto;
    white-space: nowrap;
  }
  
  th, td {
    min-width: 100px;
  }
}

/* Styles for the table */
table {
  width: 100%;
  border-collapse: collapse;
}

caption {
  font-weight: bold;
  margin-bottom: 10px;
}

th, td {
  padding: 10px;
  text-align: left;
  border-bottom: transparent;
  background-color: transparent;
  color: #fff;
}

th {
  background-color: #3498db;
  color: #fff;
  font-weight: bold;
}

/* Styles for form elements */
input[type="text"],
input[type="email"],
input[type="tel"],
select {
  width: 100%;
  padding: 5px;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
}

input[type="submit"] {
  padding: 10px 20px;
  background-color: #4CAF50;
  color: #fff;
  border: none;
  border-radius: 4px;
  cursor: pointer;
}

input[type="submit"]:hover {
  background-color: #45a049;
}

/* Additional styles */
.edit-button,
.delete-button,
.add-button {
  padding: 5px 10px;
  background-color: #3498db;
  color: #fff;
  border: none;
  border-radius: 4px;
  cursor: pointer;
  text-decoration: none;
  margin-right: 5px;
}

.delete-button {
  background-color: #e74c3c;
}

.add-button {
  background-color: #27ae60;
}
.container
{
  background: transparent;
  color: #fff;
  margin-top: 20px;
}

</style>
<body>
  
<!-- Page Content -->
  <div class="container" align="center">
    <h1>Admin Dashboard</h1>
  </div>
</div><!--record page-->
<?php
// Connect to database
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "gym";

$conn = mysqli_connect($servername, $username, $password, $dbname);

// Retrieve data from table
$sql = "SELECT * FROM registration";
$result = mysqli_query($conn, $sql);
?>
<table cellpadding="10" cellspacing="0">
<tr>
<th>ID</th>
<th>Name</th>
<th>Email</th>
<th>Phone</th>
<th>Gender</th>
<th>Address</th>
<th>Role</th>
<th>Records</th>
<th>Delete</th>
</tr>
<?php
while ($row = mysqli_fetch_assoc($result)) {
  echo '<tr>';
  echo '<td>' . $row['id'] . '</td>';
  echo '<td>' . $row['name'] . '</td>';
  echo '<td>' . $row['email'] . '</td>';
  echo '<td>' .$row['phone'] . '</td>';
  echo '<td>' .$row['gender'] . '</td>';
  echo '<td>' .$row['address'] . '</td>';
  echo '<td>' .$row['role'] . '</td>';
  echo "<td>";
  echo "<button class='edit-button' onclick='location.href=\"edit.php?id=" . $row["id"] . "\"'>Edit</button>";
  echo "</td>";
  echo "<td>";
  echo "<button class='delete-button' onclick='location.href=\"delete.php?id=" . $row["id"] . "\"'>Delete</button>";
  echo "</td>";
  echo "<td>";
  echo "</td>";
  
  echo '</tr>';
}
// Add the "Add" button row
echo '<tr>';
echo '<td colspan="8" style="text-align: center;">';
echo '<button class="add-button" onclick="location.href=\'add.php\'">Add Members</button>';
echo '</td>';
echo '</tr>';

echo '</table>';
?>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ENjdO4Dr2bkBIFxQpeoTz1HIcje39Wm4jDKdf19U8gI4ddQ3GYNS7NTKfAdVQSZe" crossorigin="anonymous"></script>

</body>
</html> 


<!-- edit.php -->
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

// Handle form submission
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $id = $_POST["id"];
    $name = $_POST["name"];
    $email = $_POST["email"];
    $Phone= $_POST["phone"];
    $Gender=$_POST["gender"];
    $Address = $_POST["address"];
    $role = $_POST["role"];

    // Update the record
    $query = "UPDATE registration  SET Name='$name', Email='$email', Phone='$Phone',Gender='$Gender',Address='$Address',role='$role' WHERE ID='$id'";
    mysqli_query($conn, $query);

    // Redirect back to the record page
    header("Location: index.php");
    exit();
}

// Fetch the record to be edited
if (isset($_GET["id"])) {
    $id = $_GET["id"];
    $query = "SELECT * FROM registration WHERE ID='$id'";
    $result = mysqli_query($conn, $query);
    $record = mysqli_fetch_assoc($result);
}

// Close the database connection
mysqli_close($conn);
?>

<!DOCTYPE html>
<html>
<head>
    <title>Edit Record</title>
</head>
<style>
 @import url('https://fonts.googleapis.com/css2?family=Poppins:wght@200;300;400;500;600;700&display=swap');
*{
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: 'Poppins',sans-serif;
}
body{
  height: 100vh;
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 10px;
  background-image:linear-gradient(rgba(0,0,0,0.5),#000000), url("assets/img/muscle-3.jfif");
    background-repeat: no-repeat;
    background-size: cover;
    height: 100vh;
  
}
.container{
  max-width: 500px;
  width: 50%;
  background-color: #ffffffc2;
  padding: 25px 30px;
  border-radius: 5px;
  box-shadow: 0 5px 10px rgba(0,0,0,0.15);
}
.container .title{
  font-size: 25px;
  font-weight: 500;
  position: relative;
}
.container .title::before{
  content: "";
  position: absolute;
  left: 0;
  bottom: 0;
  height: 3px;
  width: 30px;
  border-radius: 5px;
  background: linear-gradient(135deg, #000000, #ac0404);
}
.content form .user-details{
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  margin: 20px 0 12px 0;
}
form .user-details .input-box{
  margin-bottom: 15px;
  width: calc(100% / 2 - 20px);
}
form .input-box span.details{
  display: block;
  font-weight: 500;
  margin-bottom: 5px;
}
.user-details .input-box input{
  height: 45px;
  width: 100%;
  outline: none;
  font-size: 16px;
  border-radius: 5px;
  padding-left: 15px;
  border: 1px solid #f50404;
  border-bottom-width: 2px;
  transition: all 0.3s ease;
}
.user-details .input-box input:focus,
.user-details .input-box input:valid{
  border-color: #680303;
}
 form .gender-details .gender-title{
  font-size: 20px;
  font-weight: 500;
 }
 form .category{
   display: flex;
   width: 80%;
   margin: 14px 0 ;
   justify-content: space-between;
 }
 form .category label{
   display: flex;
   align-items: center;
   cursor: pointer;
 }
 form .category label .dot{
  height: 18px;
  width: 18px;
  border-radius: 50%;
  margin-right: 10px;
  background: #a10303;
  border: 5px solid transparent;
  transition: all 0.3s ease;
}
 #dot-1:checked ~ .category label .one,
 #dot-2:checked ~ .category label .two,
 #dot-3:checked ~ .category label .three{
   background: #f80404d2;
   border-color: #050303;
 }
 form input[type="radio"]{
   display: none;
 }
 form .button{
   height: 45px;
   margin: 35px 0
 }
 form .button input{
   height: 100%;
   width: 100%;
   border-radius: 5px;
   border: none;
   color: #fff;
   font-size: 18px;
   font-weight: 500;
   letter-spacing: 1px;
   cursor: pointer;
   transition: all 0.3s ease;
   background: linear-gradient(135deg, #000000, #c59696);
 }
 form .button input:hover{
  /* transform: scale(0.99); */
  background: linear-gradient(-135deg, #f70404, #000000);
  }
 @media(max-width: 584px){
 .container{
  max-width: 100%;
}
form .user-details .input-box{
    margin-bottom: 15px;
    width: 100%;
  }
  form .category{
    width: 100%;
  }
  .content form .user-details{
    max-height: 300px;
    overflow-y: scroll;
  }
  .user-details::-webkit-scrollbar{
    width: 5px;
  }
  }
  @media(max-width: 459px){
  .container .content .category{
    flex-direction: column;
  }
}

</style>
  <div class="container">
    <div class="title">Registration</div>
    <div class="content">
      <form action="#" method="post">
        <div class="user-details">
          <div class="input-box">
            <span class="details">ID</span>
          <input name="id" value="<?php echo $record['id']; ?>">
          </div>
          <div class="input-box">
            <span class="details">Full Name</span>
            <input type="name" name="name" value="<?php echo $record['name']; ?>">
          </div>
          <div class="input-box">
            <span class="details">Email</span>
            <input type="email" name="email" value="<?php echo $record['email']; ?>">
          </div>
          <div class="input-box">         
            <span class="details">Phone</span>
            <input type="phone"  name="phone"value="<?php echo $record['phone']; ?>" >
          </div>
          <div class="input-box">
            <span class="details">Gender</span>
            <input type="gender"name="gender"value="<?php echo $record['gender']; ?>" >
          </div>
          <div class="input-box">
            <span class="details">Address</span>
            <input type="address"  name="address"value="<?php echo $record['address']; ?>" >
          </div>
          <div class="input-box">
            <span class="details">Role</span>
            <input type="text"name="role" value="<?php echo $record['role']; ?>">
          </div>
        </div>
        <div class="button">
          <input type="submit" value="Save">
        </div>
      </form>
</body>
</html>



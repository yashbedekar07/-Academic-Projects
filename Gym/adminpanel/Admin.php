<?php
// Check if the form has been submitted
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    // Retrieve the username and password from the form
    $username = $_POST['username'];
    $password = $_POST['password'];
    
    // Validate the username and password
    if ($username == 'yash.bedekar07@gmail.com' && $password == 'yashbedekar07') {
        // Start a session and redirect the user to a secure page
        session_start();
        $_SESSION['username'] = $username;
        header('Location: index.php');
        exit;
    } else {
        // Display an error message if the username and password are invalid
        $error_message = 'Invalid username or password. Please try again.';
    }
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>BodyPowerGym</title>
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css">
  <link rel="shortcut icon" type="image/x-icon" href="assets/img/favicon.ico">
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
  </style>
</head>
<body>
  <div class="container">
  <div class="title">Login</div><br>
    <form id="login-form" actions="#" method="post">
      <div class="mb-3">
        <label for="email" class="form-label">Email address</label>
        <input type="email" class="form-control" id="email" name="username" required>
      </div>
      <div class="mb-3">
        <label for="password" class="form-label">Password</label>
        <input type="password" class="form-control" id="password" name="password" required>
      </div>
      <button type="submit" class="btn btn-primary">Login</button>
    </form>
  </div>
  <script>
    document.getElementById('login-form').addEventListener('submit', function(event) {
      event.preventDefault(); // Prevent form submission
      
      // Get form values
      var email = document.getElementById('email').value;
      var password = document.getElementById('password').value;
      
      // Perform validation and login logic here
      if (email === 'yash.bedekar07@gmail.com' && password === 'yashbedekar07') {
        alert('Login successful');
        window.location.href = 'index.php'; // Redirect to the next page
     
        // Redirect to dashboard or perform other actions
      } else {
        alert('Invalid username or password.');
      }
    });
  </script>
</body>
</html>

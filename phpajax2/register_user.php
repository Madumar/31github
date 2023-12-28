<?php
if (isset($_GET['username']) && isset($_GET['email']) && isset($_GET['password'])) {
    $username = $_GET['username'];
    $email = $_GET['email'];
    $password = $_GET['password'];

    if (empty($username) || empty($email) || empty($password)) {
        echo "Please fill in all fields.";
    } else {
        echo "Registration successful!<br>";
        echo "Username: $username<br>";
        echo "Email: $email<br>";
        echo "Password: $password";
    }
} else {
    echo "Registration failed. Please try again.";
}
?>

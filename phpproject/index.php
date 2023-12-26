<!DOCTYPE html>
<html>
<head>
    <title>PHP Form Example</title>
</head>
<body>

<h2>Sample Form</h2>

<form method="post" action="process_form.php">
    <label for="name">Name:</label>
    <input type="text" id="name" name="name" required><br><br>
    
    <label for="email">Email:</label>
    <input type="email" id="email" name="email" required><br><br>
    
    <label for="message">Message:</label><br>
    <textarea id="message" name="message" rows="4" cols="50" required></textarea><br><br>
    
    <input type="submit" value="Submit">
</form>
</body>
</html>

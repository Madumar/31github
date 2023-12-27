<?php
if (isset($_GET['task'])) {
    $newTask = $_GET['task'];

    // Simulated task addition (replace this with your database logic)
    // For example, adding the new task to an array
    // Ideally, you would sanitize and validate user input here
    $tasks = array("Task 1", "Task 2", "Task 3");
    $tasks[] = $newTask;

    // Output tasks as list items after adding the new task
    echo "<ul>";
    foreach ($tasks as $task) {
        echo "<li>$task</li>";
    }
    echo "</ul>";
}
?>

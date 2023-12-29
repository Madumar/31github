<?php
$names = array("John", "Jane", "Alice", "Bob", "Charlie", "David", "Eva", "Frank");

// Get the parameter passed through AJAX
$q = $_REQUEST["q"];

$hint = "";
if ($q !== "") {
    $q = strtolower($q);
    $len = strlen($q);
    foreach($names as $name) {
        if (stristr($q, substr($name, 0, $len))) {
            if ($hint === "") {
                $hint = $name;
            } else {
                $hint .= ", $name";
            }
        }
    }
}
echo $hint === "" ? "No suggestions" : $hint;
?>

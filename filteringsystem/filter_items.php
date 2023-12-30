<?php
// Simulated items
$items = array(
    array("title" => "Item 1", "category" => "category1"),
    array("title" => "Item 2", "category" => "category2"),
    array("title" => "Item 3", "category" => "category1"),
    array("title" => "Item 4", "category" => "category2"),
    array("title" => "Item 5", "category" => "category1")
);

// Get the entered category from user input
$category = $_GET['category'];

// Filter items based on the entered category
$filteredItems = array_filter($items, function ($item) use ($category) {
    return stripos($item['category'], $category) !== false;
});

// Display filtered items
if (!empty($filteredItems)) {
    foreach ($filteredItems as $item) {
        echo "<p>" . $item['title'] . " (" . $item['category'] . ")</p>";
    }
} else {
    echo "<p>No items found for category: " . $category . "</p>";
}
?>

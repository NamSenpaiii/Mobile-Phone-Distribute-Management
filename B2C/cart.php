<?php
    // Include the database connection file
    require_once('db/config.php');
    
    // Check if the user is logged in
    session_start();
    if (!isset($_SESSION['user'])) {
        header('Location: cart');
        exit();
    }
    
    // Get the CustomerID from the session
    $customerID = $_SESSION['customerID'];
    
    // Prepare the SQL query to get the orders for the customer
    $sql = "SELECT * FROM ROrders WHERE CustomerID = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param('i', $customerID);
    $stmt->execute();
    $orders = $stmt->get_result()->fetch_all(MYSQLI_ASSOC);
    
    // Prepare the SQL query to get the order details for each order
    $sql = "SELECT * FROM ROrderDetails WHERE OrderID = ?";
    $stmt = $conn->prepare($sql);
    
    // Loop through each order and print the details
    foreach ($orders as $order) {
        // Get the order details for this order
        $stmt->bind_param('i', $order['OrderID']);
        $stmt->execute();
        $orderDetails = $stmt->get_result()->fetch_all(MYSQLI_ASSOC);
        
        // Print the order information
        echo '<h3>Order #' . $order['OrderID'] . '</h3>';
        echo '<p>Order Date: ' . $order['OrderDate'] . '</p>';
        
        // Print the order details
        echo '<table>';
        echo '<tr><th>ProductID</th><th>Quantity</th><th>Price</th></tr>';
        foreach ($orderDetails as $orderDetail) {
            echo '<tr>';
            echo '<td>' . $orderDetail['ProductID'] . '</td>';
            echo '<td>' . $orderDetail['Quantity'] . '</td>';
            echo '<td>' . $orderDetail['Price'] . '</td>';
            echo '</tr>';
        }
        echo '</table>';
    }
    
    // Close the database connection
    $stmt->close();
    $conn->close();
?>

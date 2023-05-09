<?php
include 'db/config.php';

if(isset($_POST['id'])){
    $id = $_POST['id'];
    $sql = "DELETE FROM products WHERE ProductID = $id";
    $result = $conn->query($sql);
    if($result){
        echo 'Product deleted successfully';
    }
    else{
        echo 'Error deleting product';
    }
}
?>

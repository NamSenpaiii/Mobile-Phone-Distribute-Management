<?php
    require_once 'config.php';
    function login($username, $password)
    {
        $conn = create_connection();
        $sql = "select * from Rcustomers where username = ?";
        $stm = $conn->prepare($sql);
        $stm->bind_param('s', $username);

        if (!$stm->execute()) return false;

        $result = $stm->get_result();
        if($result->num_rows !== 1) return false;

        $data = $result->fetch_assoc();


        $hashed = $data['Password'];
       
        return password_verify($password, $hashed);
    }
?>

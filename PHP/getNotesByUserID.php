<?php
    require_once 'include/DB_Functions.php';
    $db = new DB_Functions();

    if (isset($_POST['id'])) {    // edit by omar
        
        // receiving the post params
        $user_id = $_POST['id'];
        $response["notes"] = $db->getNotesByUserID($user_id);
        echo json_encode($response);

    }
?>
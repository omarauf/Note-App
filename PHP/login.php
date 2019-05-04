<?php
    require_once 'include/DB_Functions.php';
    $db = new DB_Functions();

    if (isset($_POST['email']) && isset($_POST['password'])) {
    
        // receiving the post params
        $email = $_POST['email'];
        $password = $_POST['password'];
        
        // get the user by email and password
        $user = $db->getUserByEmailAndPassword($email, $password);
        if ($user != false) {
            // user is found
            $response["error"] = FALSE;	
            $response["id"] = $user["id"];
            $response["name"] = $user["name"];
            $response["email"] = $user["email"];
            echo json_encode($response);
            
        } else {
            // user is not found with the credentials
            // user failed to store
            $response["error"] = TRUE;
            $response["error_msg"] = "Unknown error occurred in registration!";
            echo json_encode($response);      
        }

    }else {
        // required post params is missing
        $response["error"] = TRUE;
        $response["error_msg"] = "Required parameters email or password is missing!";
        echo json_encode($response);
    }
?>
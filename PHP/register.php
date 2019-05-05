<?php
    require_once 'include/DB_Functions.php';
    $db = new DB_Functions();

    if (isset($_POST['name']) && isset($_POST['email']) && isset($_POST['password'])) {    // edit by omar
        
        // receiving the post params
        $name = $_POST['name'];
        $email = $_POST['email'];
        $password = $_POST['password'];

        // check if user is already existed with the same email
        if ($db->isUserExisted($email)) {
            // user already existed
            $response["error"] = TRUE;
            $response["error_msg"] = "User already existed with " . $email;
            echo json_encode($response);
        }else {
            $user = $db->storeUser($email, $password, $name); 
            if ($user) {
                // user stored successfully
                //$_SESSION['email'] = $user["email"];
                //$_SESSION['name'] = $user["name"];
                //$_SESSION['id'] = $user["id"];
                
                //redierct to Note Page
                //header("Location: Note.php");
                // user stored successfully
                //add default note
                $db->addNoteByUserId($user["id"]);
                $response["error"] = FALSE;	
                $response["id"] = $user["id"];
                $response["name"] = $user["name"];
                $response["email"] = $user["email"];
                echo json_encode($response);
            } else {
                // user failed to store
                $response["error"] = TRUE;
                $response["error_msg"] = "Unknown error occurred in registration!";
                echo json_encode($response);
            }
        }
    } else {
        $response["error"] = TRUE;
        $response["error_msg"] = "Required parameters is missing!";
        echo json_encode($response);
    }
?>
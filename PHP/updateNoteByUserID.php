<?php
    require_once 'include/DB_Functions.php';
    $db = new DB_Functions();

if (isset($_POST['id']) && isset($_POST['json'])) {    // edit by omar
        
        // receiving the post params
        $user_id = $_POST['id'];
        $json = $_POST['json'];
        //$data = str_replace("\\", '\\\\', $json);
        $arr = json_decode($json, true);
        foreach ($arr["notes"] as $key => $value) {
            $db->updateNoteByNoteID($value['note_id'], $value['note'], $value['note_title']);
        }
        $response["error"] = false;
        echo json_encode($response);   
        
        //$db->updateNoteByNoteID($note_id, $note);
        //$response["notes"] = $db->getNotesByUserID($user_id);
        //echo json_encode($response);

    }
?>
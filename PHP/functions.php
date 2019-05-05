<?php
    require_once 'include/DB_Functions.php';
    $db = new DB_Functions();
    
    //To  Update the notes for user by id
    if (isset($_POST['id']) && isset($_POST['json']) && $_POST['request'] === 'update') {   
        
        // receiving the post params
        $user_id = $_POST['id'];    //user id
        $json = $_POST['json'];     //all notes as json
        $arr = json_decode($json, true);    //convert json to array
        foreach ($arr["notes"] as $key => $value) {
            $db->updateNoteByNoteID($value['note_id'], $value['note'], $value['note_title'], $value['tag']);
        }
        $response["notes"] = $db->getNotesByUserID($user_id);
        echo json_encode($response);
    }

    //Get the Notes for user by it's id
    if (isset($_POST['id']) && $_POST['request'] === 'get') {    // edit by omar
    
        // receiving the post params
        $user_id = $_POST['id'];    //user id
        $response["notes"] = $db->getNotesByUserID($user_id);
        echo json_encode($response);
    }

    //create new note for user by it's id
    if (isset($_POST['id']) && $_POST['request'] === 'newNote') {    // edit by omar
    
        // receiving the post params
        $user_id = $_POST['id'];    //user id
        $db->addNoteByUserId($user_id);
        //bring all note with note new note
        $response["notes"] = $db->getNotesByUserID($user_id);
        echo json_encode($response);
    }

    //delet note 
    if (isset($_POST['user_id']) && isset($_POST['note_id']) && $_POST['request'] === 'deletNote') {    // edit by omar
    
        // receiving the post params
        $user_id = $_POST['user_id'];    //user id
        $note_id = $_POST['note_id'];    //note id
        $db->deleteNoteByNoteId($note_id);
        //bring all note with note new note
        $response["notes"] = $db->getNotesByUserID($user_id);
        echo json_encode($response);
    }
    
    //duplicateNote 
    if (isset($_POST['user_id']) && isset($_POST['note_id']) && $_POST['request'] === 'duplicateNote') {    // edit by omar
    
        // receiving the post params
        $note_id = $_POST['note_id'];    //note id
        $user_id = $_POST['user_id'];    //user id
        $db->duplicateNote($note_id);
        //bring all note with note new note
        $response["notes"] = $db->getNotesByUserID($user_id);
        echo json_encode($response);
    }

    
?>
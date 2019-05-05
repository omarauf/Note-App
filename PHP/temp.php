<?php
    require_once 'include/DB_Functions.php';
    $db = new DB_Functions();
    
    $json = '{"notes":[{"note":"{rtf1\\\\ansi\\\\ansicpg1252\\\\deff0\\\\deflang1033{\\\\fonttbl{\\\\f0\\\\fnil\\\\fcharset0 Microsoft Sans Serif;}}\\\\r\\\\n\\\\viewkind4\\\\uc1\\\\pard\\\\f0\\\\fs17 New Notedsvd\\\\par\\\\r\\\\nvdsv\\\\par\\\\r\\\\nds\\\\par\\\\r\\\\nv\\\\par\\\\r\\\\ndsv\\\\par\\\\r\\\\n}\\\\r\\\\n","note_id":1,"note_title":"new Note"},{"note":"{\\\\rtf1\\\\ansi\\\\ansicpg1252\\\\deff0\\\\deflang1033{\\\\fonttbl{\\\\f0\\\\fnil\\\\fcharset0 Microsoft Sans Serif;}}\\\\r\\\\n\\\\viewkind4\\\\uc1\\\\pard\\\\f0\\\\fs17 New Note\\\\par\\\\r\\\\n\\\\par\\\\r\\\\ndddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd\\\\par\\\\r\\\\nddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd\\\\par\\\\r\\\\n\\\\fs32 dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd\\\\par\\\\r\\\\nddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd\\\\fs17\\\\par\\\\r\\\\n}\\\\r\\\\n","note_id":3,"note_title":"new Note"},{"note":"{\\\\rtf1\\\\ansi\\\\ansicpg1252\\\\deff0\\\\deflang1033{\\\\fonttbl{\\\\f0\\\\fnil\\\\fcharset0 Microsoft Sans Serif;}}\\\\r\\\\n{\\\\colortbl ;\\\\red255\\\\green0\\\\blue0;}\\\\r\\\\n\\\\viewkind4\\\\uc1\\\\pard\\\\f0\\\\fs17 dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd\\\\par\\\\r\\\\nddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd\\\\par\\\\r\\\\n\\\\fs32 dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd\\\\par\\\\r\\\\nddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd\\\\par\\\\r\\\\n\\\\par\\\\r\\\\n\\\\par\\\\r\\\\n\\\\cf1\\\\fs17 vdsv\\\\par\\\\r\\\\nds\\\\par\\\\r\\\\nv\\\\par\\\\r\\\\ndsv\\\\par\\\\r\\\\n\\\\cf0\\\\par\\\\r\\\\n}\\\\r\\\\n","note_id":4,"note_title":"new Note"},{"note":"{\\\\rtf1\\\\ansi\\\\ansicpg1252\\\\deff0\\\\deflang1033{\\\\fonttbl{\\\\f0\\\\fnil\\\\fcharset0 Microsoft Sans Serif;}}\\\\r\\\\n\\\\viewkind4\\\\uc1\\\\pard\\\\f0\\\\fs17 New Note\\\\par\\\\r\\\\n}\\\\r\\\\n","note_id":18,"note_title":"Hi there"},{"note":"{\\\\rtf1\\\\ansi\\\\ansicpg1252\\\\deff0\\\\deflang1033{\\\\fonttbl{\\\\f0\\\\fnil\\\\fcharset0 Microsoft Sans Serif;}}\\\\r\\\\n\\\\viewkind4\\\\uc1\\\\pard\\\\f0\\\\fs17 New Note\\\\par\\\\r\\\\n}\\\\r\\\\n","note_id":23,"note_title":"new Note"},{"note":"{\\\\rtf1\\\\ansi\\\\ansicpg1252\\\\deff0\\\\deflang1033{\\\\fonttbl{\\\\f0\\\\fnil\\\\fcharset0 Microsoft Sans Serif;}}\\\\r\\\\n\\\\viewkind4\\\\uc1\\\\pard\\\\f0\\\\fs17 New Note\\\\par\\\\r\\\\n}\\\\r\\\\n","note_id":24,"note_title":"Ok its very good"},{"note":"{\\\\rtf1\\\\ansi\\\\ansicpg1252\\\\deff0\\\\deflang1033{\\\\fonttbl{\\\\f0\\\\fnil\\\\fcharset0 Microsoft Sans Serif;}}\\\\r\\\\n\\\\viewkind4\\\\uc1\\\\pard\\\\f0\\\\fs17 New Note\\\\par\\\\r\\\\n}\\\\r\\\\n","note_id":30,"note_title":"new Note"},{"note":"{\\\\rtf1\\\\ansi\\\\ansicpg1252\\\\deff0\\\\deflang1033{\\\\fonttbl{\\\\f0\\\\fnil\\\\fcharset0 Microsoft Sans Serif;}}\\\\viewkind4\\\\uc1\\\\pard\\\\f0\\\\fs17 New Note\\\\par}","note_id":26,"note_title":"new Note"}]}';

    $noteInPC = json_decode($json, true);    //convert json to array
    $noteInPC = $noteInPC["notes"];
    $noteInServer = $db->getNotesByUserID(31);

    $noteIDinPC = array();
    $noteIDinServer = array();

    foreach ($noteInPC as $key => $value) {
        $noteIDinPC[] = $value['note_id'];
    }

    foreach ($noteInServer as $key => $value) {
        $noteIDinServer[] = $value['note_id'];
    }

    //$result=array_diff($noteInPC,$noteInServer);        //new note

    //$result=array_diff($noteInServer,$noteInPC);        //delet note 

    //echo json_encode($arr);
    //print_r($noteInPC["notes"]);
    print("<pre>".print_r($noteIDinServer,true)."</pre>");
    echo "<br />";
    echo "<br />";
    echo "<br />";

    echo "<br />";
    echo "<br />";
    
    //echo json_encode($note);
    //print_r($noteInServer);
    print("<pre>".print_r($noteIDinPC,true)."</pre>");

   


    //To  Update the notes for user by id
    if (isset($_POST['id']) && isset($_POST['json']) && $_POST['request'] === 'update') {   
        
        // receiving the post params
        $user_id = $_POST['id'];    //user id
        $json = $_POST['json'];     //all notes as json
        $arr = json_decode($json, true);    //convert json to array
        foreach ($arr["notes"] as $key => $value) {
            $db->updateNoteByNoteID($value['note_id'], $value['note'], $value['note_title']);
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
?>
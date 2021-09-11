function ClearAllRadioButtons() {
    var ele = document.getElementsByName("answers");
    for (var i = 0; i < ele.length; i++) {
        ele[i].checked = false;
    }
}

function CheckRadioButtonSelected() {
    var ele = document.getElementsByName("answers");
    for (var i = 0; i < ele.length; i++) {
        if (ele[i].checked)
        {
             return ele[i].value;
        }
    }
}

function GetKeysStorage() {

    var values = Object.keys(localStorage);

    return values;
}
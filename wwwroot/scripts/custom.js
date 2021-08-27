function ClearAllRadioButtons() {
    var ele = document.getElementsByName("answers");
    for (var i = 0; i < ele.length; i++) {
        ele[i].checked = false;
    }
}
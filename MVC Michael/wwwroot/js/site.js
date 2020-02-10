function ToggleAddForm() {
    var ImageForm = document.getElementById("AddImageForm");
    if (ImageForm.style.display === "none" || ImageForm.style.display === "" ) {
        ImageForm.style.display = "block";
    } else {
        ImageForm.style.display = "none";
    }
}

function Upload() {
    ToggleAddForm;
}


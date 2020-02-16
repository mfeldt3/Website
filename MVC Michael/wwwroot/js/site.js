function checkAuthorization() {
    authorization = document.getElementById("authorizationCode").value;
    authLabel = document.getElementById("authLabel");
    if (authorization !== "2122") {
        authLabel.innerHTML = "Authorization Code: Invalid Access";
        document.getElementById("authLabel").style.color = "red";
        return false;
    }
    else {
        return true;
    }
}

function deleteValidation() {
    $('.modal').on('shown.bs.modal', function (e) {
        $('carousel').carousel('pause');
    })
    var result = prompt("Please enter authorization code");
    if (result === "2122") {
        return true;
    } else {
        alert("Invalid Access");
        return false;
    }
}

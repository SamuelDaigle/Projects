function validateForm() {
    var returnedValue = true;
    var username = document.forms["signUp"]["txtUsername"].value;
    var password = document.forms["signUp"]["txtPassword"].value;
    var billet = document.forms["signUp"]["txtBillets"].value;
    var randomnumber = Math.floor((Math.random() * 1000000) + 100000);

    if (isNullOrEmpty(username) ||
        isNullOrEmpty(password) ||
        isNullOrEmpty(billet)) {
        returnedValue = false;
        alert("Les champs doivent tous être remplis");
    }

    if (returnedValue == true) {
        alert("Bonjour " + username + ",\nVous avez acheté " + billet + " billets.\nVotre numéro de transaction est " + randomnumber);
    }
    return returnedValue;

}
function isNullOrEmpty(string) {
    var returnedValue = false;
    if (string == null) {
        returnedValue = true;
    }
    else if (string.trim() === "") {
        returnedValue = true;
    }
    return returnedValue;
}
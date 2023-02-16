function ValidateForm(){
    var email = document.getElementById("email").value;
    var password = document.getElementById("password").value;

    if(email == ""){
        alert("Вы не ввели почту");
        return false;
    }
    if(password == ""){
        alert("Вы не ввели пароль");
        return false;
    }
    alert("Авторизация прошла успешно");
    return true;
}
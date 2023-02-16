function ValidateForm(){
    var fname = document.getElementById("fname").value;
    var lname = document.getElementById("lname").value;
    var flname = document.getElementById("flname").value;
    var email = document.getElementById("email").value;
    var password = document.getElementById("password").value;
    var confirmpassword = document.getElementById("confirm-password").value;

    if(fname == ""){
        alert("Вы не ввели имя");
        return false;
    }
    if(lname == ""){
        alert("Вы не ввели фамилию");
        return false;
    }
    if(flname == ""){
        alert("Вы не ввели отчество");
        return false;
    }
    if(email == ""){
        alert("Вы не ввели почту");
        return false;
    }
    if(password == ""){
        alert("Вы не ввели пароль");
        return false;
    }
    if(password != confirmpassword){
        alert("Пароли не совпадают");
        return false;
    }
    alert("Регистрация прошла успешно!")
    return true;
}
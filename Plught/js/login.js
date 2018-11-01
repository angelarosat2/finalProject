$(document).ready(function(){
    $('#loginForm .btnLogin').on('click',login);
})

function login(e){
    e.preventDefault();

    $('#loginForm #password').removeClass('error');
    $.ajax({
        url: "http://localhost/backend/login.php", 
        method: 'POST',
        dataType: 'json',
        data: $('#loginForm').serialize(),
        crossDomain: true,
        success: function(result){
            if(result.status){
                //redireccionar cuando ok
                window.location="indexHome.html";
            }else{
                $('#loginForm #password').addClass('error');
                $('#loginForm #usernameInput').addClass('error');
                document.getElementById("errorMsg").innerHTML = "Contraseña o usuario incorrecto";

            }
        },
        error: function(error){
            console.log(error);
        }   
    });
}
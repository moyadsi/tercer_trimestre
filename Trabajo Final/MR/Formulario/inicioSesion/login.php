<?php
include("../../conexionBD.php");
session_start();
if(isset($_POST["iniciar"])){
  // si todos los campos estan llenos se comienza todo el proceso del login 
  if(strlen($_POST["email"]) >= 1 && strlen($_POST["contraseña"]) >= 1 ){

    $email = trim($_POST["email"]);
    $contraseña = trim($_POST["contraseña"]);

// se crea la varible donde se hace la conulta a la base de datos 
    $result_pasajero = mysqli_query($conex,"SELECT * FROM registro_pasajero WHERE correo ='$email'");

    $result_conductor = mysqli_query($conex,"SELECT * FROM `registro_conductor` WHERE correo ='$email'");
    
// se ACTIVA FUNCION para para seleccionar el primer resultado  de la base de datos 
mysqli_data_seek($result_pasajero,0);
mysqli_data_seek($result_conductor,0);

// se crea variable para manejar el contenido del resultado 

$extract_pasajero = mysqli_fetch_array($result_pasajero);

$extract_conductor = mysqli_fetch_array($result_conductor);

 
// se confirma si la extraxion devuelve algo o no 

if(is_null($extract_pasajero) && is_null($extract_conductor)){
    // si no devuelve nada se alerta que no se encuentra resgistrado 
    ?>
        <script>  
            alert("el correo no se encuentra registrado");
        </script>
  <?php
  exit();
}
else if($extract_pasajero['correo'] === $email && $extract_pasajero['contraseña'] === $contraseña){
    // si los datos ingresados son correctos se le deja ingresar 
    $_SESSION['usuario']= $email;
    header("location: ../../interfas.html");
    exit();
} 
else if($extract_conductor['correo'] === $email && $extract_conductor['contraseña'] === $contraseña){
    // si los datos ingresados son correctos se le deja ingresar 
    $_SESSION['usuario']= $email;
    header("location: ../../interfas2.html");
    exit();
} 

else{
    // si delvuelve algo pero la contraseña no coinciden se alerta al usuario
  ?>
  <script>
      alert("la contraseña no coincide ");
      window.location = './index.php'
  </script>
  <?php

}

    
}else{
    // si no ha llenado los campos se le alerta al usuario que ingrese los datos
    ?>
    <script>
        alert("por favor llene los campos");
    </script>
    <?php
}

}
?>
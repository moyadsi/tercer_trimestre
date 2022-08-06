<?php
    include("../../conexionBD.php");
    if(isset($_POST["registrar"])){
        // se crean las variables con los datos que contienen lo de cada input 
        $nombres =  trim ($_POST["nombre"]);
        $apellidos = trim ($_POST["apellidos"]);
        $email = trim ($_POST["correo"]);
        $contraseña = trim ($_POST["contraseña"]);
        $confirmar_contraseña = trim ($_POST["confirmar-contraseña"]);
        $nacimiento = trim ($_POST["nacimiento"]);
        $genero =  trim ($_POST["Genero"]);
        define("KEY_P",0);
        
        // se crea una  varible donde se hace una consulta  para insertar los datos del formulario 
        $consulta = "INSERT INTO `registro_pasajero`( nombres, apellidos, correo, contraseña, Fecha_nacimiento, genero) 
        VALUES ('$nombres','$apellidos','$email','$contraseña','$nacimiento' ,'$genero')";

        //se confirman las contraseñas 
        if($contraseña <> $confirmar_contraseña){
            ?>
            <script>
                alert("las contraseñas no coinciden");
            </script>
            <?php
            exit();
        }


        // se envian los datos a la base de datos 
        $registro = mysqli_query($conex,$consulta);
        
        // se confirma el envio de datos 
        if($registro){
            ?>
            <script>
                alert("se ha registrado con exito ")
            </script> 
            <?php
        }
         // si no se confirma el envio de datos se alerta al usuario 
        else{
            ?>
            <script>
                alert("no se ha registrado con exito ")
            </script> 
            <?php
        }
    }
 ?>
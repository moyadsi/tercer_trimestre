<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="estiloinicio.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Anek+Latin:wdth,wght@100,200;100,800;115,800&display=swap" rel="stylesheet">
    <link rel="icon" href="imagenes/logo.icon">
    <title>MOTO ROAND </title>

</head>
<body>
    
    <div class="contenedero1">
        <form class="formulario iniciar-sesion" action="" method="post">
            <h2 class="crear-cuenta">Iniciar Sesion</h2>
            <input type="email" name="email" placeholder="Ingrese su correo">
            <input type="password" name="contraseña" placeholder="Ingrese su contraseña">
            <input type="submit" name="iniciar" value="Iniciar Sesion"> <br> <br>
            <a class="clave" href="../inicioSesion/cambioclave.html">Olvide mi contraseña</a>
        </form>
        <div class="bienvenida">
            <div class="inicio">
                <h2>Bienvenido de nuevo</h2>
                <p>Necesitas quien te lleve? Moto Road te puede ayudar, conoce nuestros servicios. <br>
                    Si aún no conoces nuestros servicios da clic aqui</p>
                <a href="../../index.html"><button class="boton" >Inicio</button></a>
            </div>
        </div>

    </div>
    <?php
    include("login.php")
    ?>
</body>
</html>
# LosBorbotones_TPGDD2019
Hola, este es un trabajo práctico que implementó la Universidad Tecnológica Nacional, en la materia Gestión de Datos, en el año 2019

# INTEGRANTES
* Villegas Avalos Carlos Alejandro
* Rojas Miguel

# AMBIENTE DE DESARROLLO

Para poder ejecutar el siguiente programa se necesita dos aplicaciones, cada una con sus diferentes configuraciones.

SQL Server 2012
 * SQL Server 2012 Service Express [Link](https://www.microsoft.com/es-cl/download/details.aspx?id=50003)

1.- Primer paso, se necesita tener instalado el motor de base de datos SQL Server 2012 con las siguientes consideraciones:
* El nombre de la instancia del motor de base de datos a instalar debe llamarse “SQLSERVER2012”, no utilizar el nombre “Default” para la instancia e instalar como instancia con nombre (“Named Instance”).
* La autenticación debe ser por “Modo Mixto”.
* El usuario administrador de la base de datos deberá tener la siguiente configuración:
  * Username: “sa”
  * Password: “gestiondedatos”

2.- Segundo paso, una vez instalado el motor de base de datos se deberán instalar las herramientas cliente de trabajo: “Microsoft SQL Server Management Studio Express” para SQL Server 2012 y ejecutar esta aplicación e ingresar los datos del usuario “sa” creado anteriormente (en modo “Autenticación de SQL Server”).

3.- Tercer paso, dentro del “Management Studio” crear una nueva base de datos con los parámetros default y nombre de base “GD2C2019”.

4.- Cuarto paso, crear un nuevo “Inicio de Sesión”, desde el item “Seguridad” perteneciente al servidor de Base de Datos general, el inicio de sesión debe poseer las siguientes características:
* Solapa “General”:
  * Nombre de inicio de sesión: “gdCupon2019”
  * Autenticación de SQL Server
  * Contraseña: “gd2019”
  * Base de Datos Predeterminada: GD2C2019.
  * El resto de los parámetros respetar sus valores default.
* Solapa “Funciones del Servidor”:
  * Seleccionar “sysadmin”
* Solapa “Asignación de Usuarios”:
  * Seleccionar asignar a “GD2C2019”
* Para el resto de los parámetros respetar sus valores default.

5.- Quinto paso, salir del “Management Studio” como usuario “sa” y volver a ingresar con el nuevo usuario “gd” creado, es probable que informe que la contraseña ha caducado, cambiar la contraseña ingresando exactamente la misma que antes: “gd2019”.

6.- Sexto paso, una vez que tenemos la base de datos creada y configurada con el usuario, necesitamos ejecutar dos scripts, para ello debemos ejecutar un comando de consola de SQL Server llamada “sqlcmd”, este comando debe ejecutar en orden los siguientes dos archivos:
* gd_esquema.Schema.sql: Este archivo genera un esquema llamado “gd_esquema” dentro de la base de datos y lo asigna al usuario “gdCupon2019”.
* gd_esquema.Maestra.sql: Este archivo crea la tabla Maestra.
* gd_esquema.Maestra.Table.sql: Este archivo carga con los datos correspondientes, el archivo posee un volumen significante y no puede ser ejecutado desde el “Managment Studio”.

7.- Septimo paso, la cátedra provee un archivo BATCH para ejecutar esta operación, denominado “EjecutarScriptTablaMaestra.bat”. Haciendo doble clic sobre el mismo se ejecutan ambos archivos (“gd_esquema.Schema.sql” y “gd_esquema.Maestra.Table.sql”) a través del modo consola, el Script necesita aproximadamente 40 minutos para finalizar su ejecución.
 * sqlcmd –S <Servidor\Instancia> -U <Nombre_de_usuario> -P <Password> -i <Nombre_del_archivo1>,< Nombre_del_archivo2> -a 32767

Ejemplo:
 * sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2012 -i gd_esquema.Schema.sql,gd_esquema.Maestra.Table.sql -a 32767 -o resultado_output.txt
 
Visual Studio 2012
 * Visual Studio Express 2012 for Windows Desktop [Link](https://my.visualstudio.com/Downloads?q=visual%20studio%202012&wt.mc_id=o~msft~vscom~older-downloads)
 
 1.- Primer paso, para ejecutar esta aplicación es necesario instalar Visual Studio 2012 con el Framework de .NET 4.5, la versión Express posee la funcionalidad necesaria como para desarrollar el Trabajo Práctico.
 
 2.- Segundo paso, la aplicación Desktop deberá conectarse a la base de datos con los siguientes parámetros:
 * Origen de datos: Microsoft SQL Server (SqlClient)
 * localhost\SQLSERVER2012
 * Utilizar autenticación de SQL Server:
   * Nombre de Usuario: gdCupon2019
   * Password: gd2019
 * Nombre de la base de datos: GD2C2019

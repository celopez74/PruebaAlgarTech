# PruebaAlgarTech


## 1. Creacion de base de datos
Para la Creación de la base de datos se debe ejecutar desde el SQLserver Management Studio el Script que se encuentra en la ruta:  /DatabaseScript/AlgarTestScript.sql  de este repositorio.
Se debe tener en cuenta que el lmdf y .ldf de base de datos se intentarán crear en la ruta C:\MSSQL\DATA, la cual debe existir en el sistem operativo.

## 2. Agregar Cadenas de Conexion
Una vez creada la base de datos, se debe generar el conexion string correspondiente y reemplazarlo por los existentes en los archivos \TestAlgarBlazor\TestAlgarBlazor\appsettings.json y \TestAlgarBlazor\TestAlgarBlazor.WebApi\appsettings.json

una vez editadas las cadenas de conexión a la base de datos previamente creada, se procede a abrir la solucion TestAlgarBlazor.sln

## 3. Ejecutar la aplicacion
Una vez abierta la solucion de visual studio,  se debe establecer como proyecto de inicio TestAlgarBlazor, una vez hecho esto, se puede ejecutar la aplicación.

## 4. Ejecutar el web.api
Para ejecutar el Web Api, se debe establecer como proyecto de inicio el proyecto TestAlgarBlazor.WebApi  y ejecutar.  
Se abrirar Swagger el cual permitira testear un metodo de consulta a la base de datos de las compras registradas en el sistema, por id.



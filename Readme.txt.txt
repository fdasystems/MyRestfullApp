Paso 1) 
	Copiar o extraer el contenido a la carpeta C:/MyRestfullApp
De modo que la Solucion quede en la carpeta C:\MyRestfullApp\MyRestfullApp.


Paso 2) 
	Dentro de C:\MyRestfullApp\Sql, se encuentran los 3 archivos .sql 
que generan la base de datos, la tabla y la populan con datos. 
Ejecutarlos segun el orden numerico.

El destino sera:
C:\MyRestfullApp\MyRestfullApp\MyRestfull.Data\App_Data\bd.mdf
C:\MyRestfullApp\MyRestfullApp\MyRestfull.Data\App_Data\bd_log.ldf

Asegurarse de que no existan dichos archivos 
(Se eliminaron por defecto, por cualquier error se dejan los archivos 
que se generaron en la carpeta _bkp dentro de dicho directorio)

Paso 3) Abrir la solucion 

C:\MyRestfullApp\MyRestfullApp\MyRestfullApp.sln

Paso 4) Compilar y Ejecutar las pruebas unitarias
	Comprobar que todas las pruebas se satisfacen.
 
Paso 5) Ejecutar la solucion y llamar a los metodos:
Ejemplos
http://localhost:3331/MyRestfullApp/Cotizacion/Pesos
http://localhost:3331/MyRestfullApp/Cotizacion/Real
http://localhost:3331/MyRestfullApp/Cotizacion/Dolar
http://localhost:3331/MyRestfullApp/Usuarios
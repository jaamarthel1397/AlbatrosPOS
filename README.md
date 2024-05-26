El presente proyecto es un sistema de punto de ventas el cual permite realizar las siguientes acciones:
- Administrar productos
- Administrar Clientes
- Administrar direcciones
- Administrar Ordenes (por encabezado y detalles)
- Crear usuarios

El proyecto cuenta con autenticación usando JWT para proteger sus controladores.

Para inicializar el proyecto es necesario 
1- Ejecutar el comando:
CREATE DATABASE AlbatrosPOS y ajustar la cadena de conexión si es necesario.
2- Ejecutar las migraciones con Entity Framework usando el comando
Update-Database
o los scripts SQL incluidos.

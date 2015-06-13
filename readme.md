# ASP.NET 5 System Info Sample App

Aplicación ASP.NET 5 que muestra información del sistema operativo instalado en el servidor. 

Esta aplicación pretende demostrar como usar el sistema de inyección de dependencias de 
ASP.NET 5 teniendo implementaciones específicas para Windows y Debian del servicio encargado de 
obtener la lista de software instalado en servidor.

La forma mas rápida de probar esta aplicación tanto en Windows como en Linux es la siguiente:

* Abrir una línea de comandos en el directorio ```src/ASPNET5SystemInfoApp```
* Ejecutar el comando ```dnu restore``` para resolver las dependencias del proyecto
* Ejecutar el comando ```dnx . kestrel``` para ejecutar el servidor web
* Abrir la dirección [http://localhost:5004/Home/About](http://localhost:5004/Home/About) en el navegador web

---
Aplicación de ejemplo de la charla sobre ASP.NET 5 del [evento de presentación](http://dotnetters.es/arranco-la-aventura-dotnetters/) 
de [@DotNetters](https://twitter.com/dotnetters).

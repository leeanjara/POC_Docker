Prueba de concepto "uso de variables de entorno y volúmenes" en docker

# Instrucciones

1. Si no se está ejecutando, iniciar docker desktop
1. Abrir terminal en la ruta del proyecto "POC.Docker"
1. Compilar proyecto en modo Debug
1. Ejecutar "docker compose up"
1. Ir a "http://localhost:28028"
   
A este punto se debería haber creado un directorio "logs" en la ruta del proyecto y un archivo "log.txt" que contenga el valor de la variable de entorno definida en docker compose.

# Comandos útiles
- borrar containers y las imágenes creadas al hacer compose up
- - docker compose down --rmi="all"
- compilar proyecto en debug
- - dotnet build

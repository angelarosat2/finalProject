#!/bin/bash
while true; do
echo "Que deseas hacer?"
echo "1.  Configurar archivo para respaldo."
echo "2.  Configurar directorio para respaldo"
echo "3.  Configurar CRON"
echo "4.  Listar crontab del usuario"
echo "5.  Salir"

echo "Ingrese una opcion"
read opcion

case $opcion in
	1)
     bash ejercicio1.bash
     ;;
     2)
     bash ejercicio2.bash
     ;;
     3)
     bash ejercicio3.bash
     ;;
     4)
     bash ejercicio4.bash
     ;;
     5)
     break
     ;;
     *)
     echo "No es una opcion valida, por favor ingrese una opcion del 1 al 5"
     ;;
esac  
done
#Para ejecutar este código debe ingresar: bash ejercicio1.bash

!#/bin/bash 
echo "Desea filtrar los login y logout por nombre de usuario? S/N"
read respuesta

if [ $respuesta = "s" ]
then
    echo "Ingrese un usuario"
    read user
    while [ -z "$user" ]; do
        echo "Debe ingresar un usuario"
        read user
    done
    last -w $user
    last -f /var/log/wtmp.1 -w $user
elif [ $respuesta = "n" ]
then
    last
    last -f /var/log/wtmp.1
else
    echo "Opción inválida"
fi
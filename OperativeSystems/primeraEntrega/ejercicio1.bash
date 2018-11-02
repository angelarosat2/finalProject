#!/bin/bash 
source ./ejercicio5.bash

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
    
    user_ishere=$(cat /etc/passwd | grep "$user")
    last=$(last -w $user | grep $user)
    if [ -z "$user_ishere" ]
    then 
	   echo "-------------------------------------------------------------------------------------" 
	   echo "EL USUARIO INGRESADO NO EXISTE, SE MOSTRARAN LOS LOGIN Y LOGOUT DE TODOS LOS USUARIOS"
	   last | more
	   last -f /var/log/wtmp.1 | more &> /dev/null
   elif [ -z "$last" ]
   then
	   echo "-----------------------------"
	   echo "EL USUARIO NO TIENE REGISTROS"
   else 
    echo "SE LISTARAN TODAS LAS FECHAS Y HORAS DE TODOS LOS LOGINS Y LOGOUTS DEL USUARIO $user"
	echo "--------------------------------------"
    last -w $user
    last -f /var/log/wtmp.1 -w $user &> /dev/null
    fi
elif [ $respuesta = "n" ]
then
    echo "SE LISTARAN TODOS LOS LOGINS Y LOGOUTS"
	echo "--------------------------------------"
    last
    last -f /var/log/wtmp.1 &> /dev/null
else
    echo "Opción inválida"
fi

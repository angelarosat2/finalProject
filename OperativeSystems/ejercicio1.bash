#!/bin/bash 

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
    last=$(last -w $user | grep 'reboot')
    if [ -z "$user_ishere" ]
    then 
	   echo "-------------------------------------------------------------------------------------" 
	   echo "EL USUARIO INGRESADO NO EXISTE, SE MOSTRARAN LOS LOGIN Y LOGOUT DE TODOS LOS USUARIOS"
	   last | more
	   last -f /var/log/wtmp.1 | more
   elif [ -z "$last" ]
   then
	   echo "-----------------------------"
	   echo "EL USUARIO NO TIENE REGISTROS"
   else 
    last -w $user
    last -f /var/log/wtmp.1 -w $user
    fi
elif [ $respuesta = "n" ]
then
    last
    last -f /var/log/wtmp.1
else
    echo "Opción inválida"
fi

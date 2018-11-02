#!/bin/bash 
source ./ejercicio5.bash &> /dev/null

echo "Ingrese el usuario para filtrar sus logins y logouts"
read user

user_ishere=$(cat /etc/passwd | grep "$user")
last=$(last -w $user | grep "$user")

if [ -z "$user" ]
then
   echo "SE LISTARAN TODOS LOS LOGINS Y LOGOUTS"
	echo "--------------------------------------"
    last
    last -f /var/log/wtmp.1 &> /dev/null
    
elif [ -z "$user_ishere"  ]
then 
    echo "-------------------------------------------------------------------------------------" 
	echo "EL USUARIO INGRESADO NO EXISTE, SE MOSTRARAN LOS LOGIN Y LOGOUT DE TODOS LOS USUARIOS"
	last | more
	last -f /var/log/wtmp.1 | more | &> /dev/null
    
	   
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

#!/bin/bash
crontab -l &> /dev/null
if [ $? -eq 1 ]
then
	echo "No tienes ningun cron configurado."
else
	crontab -l
fi

echo "Presione enter para salir"
	read salir
	exit

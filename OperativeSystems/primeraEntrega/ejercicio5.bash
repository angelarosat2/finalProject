#!/bin/bash

dia=$(date +"%d+%m+%Y %H+%M")

if [ $? -eq 0 ]
then
	echo "El usuaurio $USER ejecuto el script "
else
	echo "El usuario $USER intento ejecutar el script el dia $dia"
fi

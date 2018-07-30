#!/bin/bash

fecha=`date +%Y-%d-%m` #Aca te guarda la fecha, se utiliza para nombrar el dia que se hizo el respaldo
hora=`date +%k:%M`

if [ ! -d /media/sf_shared_host_folder/respaldos/respaldosHome ]; #verifica que exista la carpeta respaldos para home
then
	mkdir -p /media/sf_shared_host_folder/respaldos/respaldosHome #si no existe la crea, el -p es para que cree las carpetas padres que pueden no existir
fi
directorioRespaldosHome='/media/sf_shared_host_folder/respaldos/respaldosHome/respaldoHome-' #aca te guarda el directorio donde se va a guardar el respaldo home y el principio del nombre

if [ ! -d /media/sf_shared_host_folder/respaldos/respaldosEtc ]; #verifica que exista la carpeta respaldos para etc
then
	mkdir -p /media/sf_shared_host_folder/respaldos/respaldosEtc #si no existe la crea, el -p es para que cree las carpetas padres que pueden no existir
fi
directorioRespaldosEtc='/media/sf_shared_host_folder/respaldos/respaldosEtc/respaldoEtc-' #aca te guarda el directorio donde se va a guardar el respaldo etc y el principio del nombre


if [ ! -d /media/sf_shared_host_folder/respaldos/respaldosLib ]; #verifica que exista la carpeta respaldos para lib
then
	mkdir -p /media/sf_shared_host_folder/respaldos/respaldosLib #si no existe la crea, el -p es para que cree las carpetas padres que pueden no existir
fi
directorioRespaldosLib='/media/sf_shared_host_folder/respaldos/respaldosLib/respaldoLib-' #aca te guarda el directorio donde se va a guardar el respaldo de lib y el principio del nombre


tar -czvf $directorioRespaldosHome-$fecha.tar.gz /home
tar -czvf $directorioRespaldosEtc-$fecha.tar.gz /etc
tar -czvf $directorioRespaldosLib-$fecha.tar.gz /var/lib


if [ ! -d /var/log/mis_respaldos.txt ]; #verifica que exista el archivo para guardar quien hizo cada respaldo
then
	touch /var/log/mis_respaldos.txt #si no existe lo crea
	if [ $? -eq 0 ]; then
		printf "El usuario $USER realizo un respaldo exitoso de las carpetas /home/*, /etc/* y /var/log/* el dia $fecha a la hora $hora. Estos respaldos se almacenaron en /media/sf_shared_host_folder/respaldos\n" >> /var/log/mis_respaldos.txt
	else
    	printf "El usuario $USER intento hacer un respaldo de las carpetas /home/*, /etc/* y /var/log/* el dia  $fecha  a la hora  $hora pero no se pudo respaldar correctamente.\n" >> /var/log/mis_respaldos.txt
	fi
fi




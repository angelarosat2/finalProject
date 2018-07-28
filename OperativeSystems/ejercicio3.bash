#!/bin/bash

fecha=`date +%Y-%d-%m` #Aca te guarda la fecha, se utiliza para nombrar el dia que se hizo el respaldo

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
directorioRespaldosLib='/media/sf_shared_host_folder/respaldos/respaldosEtc/respaldoEtc-' #aca te guarda el directorio donde se va a guardar el respaldo de lib y el principio del nombre


tar -czvf $directorioRespaldosHome-$fecha.tar.gz /home
tar -czvf $directorioRespaldosEtc-$fecha.tar.gz /etc
tar -czvf $directorioRespaldosLib-$fecha.tar.gz /var/lib

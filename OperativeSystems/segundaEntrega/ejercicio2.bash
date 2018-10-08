#!/bin/bash
echo "Ingrese la ruta absoluta del directorio que quieres respaldar"
read ruta

while [ ! -d "$ruta" -o -z "$ruta" ]
do
	echo "La ruta ingresada no existe o esta mal escrita, deseas re-ingresar la ruta? S/N"
	read respuesta
	if [ "$respuesta" == "S" ] || [ "$respuesta" == "s" ]
	then
		read ruta
	elif [ "$respuesta" == "N" ] || [ "$respuesta" == "n" ]
		then
			exit
		else
			echo "Ingrese una opcion valida por favor"
		fi
	done
	echo "Desea comprimir el directorio a respaldar? S/N"
	read respuestaComprimir
	if [ ! -d /media/sf_shared_host_folder/respaldos/respaldosDirectorios ];
	then
		sudo mkdir -p /media/sf_shared_host_folder/respaldos/respaldosDirectorios 
	fi
	while [ -z "$respuestaComprimir" ]
	do
		echo "Por favor ingrese una de las dos opciones. S/N"
		read respuestaComprimir
	done
	if [ "$respuestaComprimir" == "S" ] || [ "$respuestaComprimir" == "s" ]
	then
		sudo tar -czf /media/sf_shared_host_folder/respaldos/respaldosDirectorios/respaldoDirectorio`date +%d%b%Y%_H_%M`.tar.gz $ruta &> /dev/null
		if [ $? -eq 1 ]
		then
			echo "No se pudo realizar el respaldo del directorio"
		else
			echo "El respaldo se hizo correctamente"
		fi
	elif [ "$respuestaComprimir" == "N" ] || [ "$respuestaComprimir" == "n" ]
		then
			sudo tar -cf /media/sf_shared_host_folder/respaldos/respaldosDirectorios/respaldoDirectorio`date +%d%b%Y%_H_%M`.tar $ruta 
			if [ $? -eq 1 ]
		then
			echo "No se pudo realizar el respaldo del directorio"
		else
			echo "El respaldo se hizo correctamente"
		fi
		else
			echo "Ingrese S o N"
		fi
	echo "Estos son los respaldos de los directorios realizados hasta ahora"
	ls /media/sf_shared_host_folder/respaldos/respaldosDirectorios

	echo "Presione enter para salir"
	read salir
	exit
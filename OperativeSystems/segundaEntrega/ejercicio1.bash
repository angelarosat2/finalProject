#!/bin/bash
echo "Ingrese la ruta absoluta del archivo que quieres respaldar"
read ruta

while [ ! -d "$ruta" -o -z "$ruta"]
do
	echo "La ruta ingresada no existe o esta mal escrita, deseas re-ingresar la ruta? S/N"
	read respuesta
		if [ "$respuesta" == "S" ] || [ "$respuesta" == "s" ]
		then
			read ruta
		elif [ "$respuesta" == "N" ] || [ "$respuesta" == "n" ]
		then
			break
		else
			echo "la concha de tu hermana"
		fi
done
echo "La ruta ingresada es " $ruta


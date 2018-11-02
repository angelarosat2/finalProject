#!/bin/bash

echo "Desea filtrar los login y logouts por fecha? s/n"
read respuesta

if [ -z "$respuesta" ]
then
	echo "Opcion invalida, vuelva a intentarlo"
	echo " "
elif [[ $respuesta = "s" ]]
then

	echo "Ingrese fecha de inicio (YYYY-MM-DD)"
	read fecha_inicial

	echo "Ingrese fecha final (YYYY-MM-DD)"
	read fecha_final
	
	wtmp_files=$(find /var/log/ | grep wtmp)
	
	if [ -z "$fecha_final" ] && [ -n "$fecha_inicial" ]
	then
		echo "--->NO INGRESO FECHA FINAL, SE LE MOSTRARAN TODOS LOS REGISTROS DESDE $fecha_inicial <---"
		for file in $wtmp_files
		do
			last -f $wtmp_files -s "$fecha_inicial"
		done
	elif [ -z "$fecha_desde" ] && [ -n "$fecha_hasta" ]
	then
		echo "--->NO SE INGRESO FECHA INICIAL, SE LE MOSTRARAN TODOS LOS REGISTROS HASTA $fecha_final <---"
		last -t "$fecha_final"
		for file in $wtmp_files
		do
			last -f $wtmp_files -t "$fecha_hasta"
		done
	elif [ -z "$fecha_final" ] && [ -z "$fecha_inicial" ]
	then

		echo "--->NO INGRESO NINGUNA FECHA, SE LE MOSTRARAN TODOS LOS REGISTROS <---"
		for file in $wtmp_final
		do
			last
		done	
		echo " "
	elif [ -n "$fecha_final" ] && [ -n "$fecha_inicial" ]
	then
		if [[ "$fecha_inicial" < "$fecha_final" ]]
		then
			do_last="$(for file in $wtmp_files 
			do 
				last -f $wtmp_files -s $fecha_inicial -t $fecha_final 
			done)"
			registros=$(echo "${do_last}" | grep 'reboot')
		
			if [ -z "$registros" ]
			then
				echo "--->NO HAY REGISTROS EN EL RANGO DE FECHAS INGRESADO, <---"
			else
				echo "--->SE MOSTRARAN LOS REGISTROS ENTRE LAS FECHAS $fecha_inicial Y $fecha_final <---"
				echo "$do_last"
			fi
		fi
	else 
		echo "FORMATO DE FECHAS INCORRECTO"
	fi
elif [ $respuesta = "n" ]
then
	last | more
else
	echo "OPCION INVALIDA, VUELVA A INTENTARLO"
fi

#!/bin/bash

	echo "Desea filtrar los login y logouts por fecha? s/n"
	read respuesta

if [ -z "$respuesta" ]
then
	echo "Opcion invalida, vuelva a intentarlo"
	echo " "
fi

if [[ $respuesta = "s" ]]
then

	echo "Ingrese fecha de inicio (YYYY-MM-DD)"
	read fecha_inicial

	echo "Ingrese fecha final (YYYY-MM-DD)"
	read fecha_final
	last=$(last -s $fecha_inicial -t $fecha_final | last -f /var/log/wtmp.1 -s $fecha_inicial -t $fecha_final)
	registro_existe=$(echo $last | grep 'reboot')
	if [[ -z "$fecha_inicial" ]] && [[ -z "$fecha_final" ]]
	then
		print "Debe ingresar un rango de fechas"
	elif [[ -z "$fecha_inicial" ]]
	then
		last -t $fecha_final
		last -f /var/log/wtmp.1 $fecha_final
		echo "-------------------------------------------------------------------------------------------------"
		echo "----->SOLO INGRESO FECHA FINAL, SE LE MOSTRARAN TODOS LOS LOGIN Y LOGOUT HASTA $fecha_final <-----" 
		echo " "
	elif [[ -z "$fecha_final" ]]
	then
		last -s $fecha_inicial
		last -f /var/log/wtmp.1 $fecha_inicial
		echo "----------------------------------------------------------------------------------------------------"
		echo "----->SOLO INGRESO FECHA INICIAL, SE LE MOSTRARAN TODOS LOS LOGIN Y LOGOUT DESDE $fecha_inicial <-----"
		echo " "
	elif [[ $fecha_inicial -ge $fecha_final ]]
	then
		echo "------------------------------------------------------------------------------------------------"
		echo "LA FECHA INICIAL ES MAYOR A LA FECHA FINAL O NO SE ENCONTRARON REGISTROS EN ESE RANGO DE FECHAS"
		echo " "
	elif [ -z "$registro_existe" ]
	then
		echo "-------------------------------------------------------------------------------"
		echo "NO EXISTEN REGISTROS PARA ESE RANGO DE FECHAS, SE MOSTRARAN TODOS LOS REGISTROS"
		last | more
		last -f /var/log/wtmp.1 | more
	else
		last -s "$fecha_inicial" -t "$fecha_final" | more
		last -f /var/log/wtmp.1 -s "$fecha_inicial" -t "$fecha_final" | more
	fi

elif [[ $respuesta = "n" ]]
then
	last | more
	last -f /var/log/wtmp.1 | more
else 
	echo "------------------------------------"
	print "Opcion invalida, vuelva a intentarlo"
fi

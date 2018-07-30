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
	read fecha_inicio

	echo "Ingrese fecha final (YYYY-MM-DD)"
	read fecha_final

	if [[ -z "$fecha_inicial" ]] && [[ -z "$fecha_final" ]]
	then
		echo "Debe ingresar un rango de fechas"
	fi
	if [ -z "$fecha_inicio" ]
	then
		last -t $fecha_final
		last -f /var/log/wtmp.1 $fecha_final
		echo "-------------------------------------------------------------------------------------------------"
		echo "----->SOLO INGRESO FECHA FINAL, SE LE MOSTRARAN TODOS LOS LOGIN Y LOGOUT HASTA " $fecha_final "<-----" 
		echo " "
	elif [ -z "$fecha_final" ]
	then
		last -s $fecha_inicio
		last -f /var/log/wtmp.1 $fecha_inicio
		echo "----------------------------------------------------------------------------------------------------"
		echo "----->SOLO INGRESO FECHA INICIAL, SE LE MOSTRARAN TODOS LOS LOGIN Y LOGOUT DESDE" $fecha_inicio "<-----"
		echo " "
	elif [ $fecha_inicio > $fecha_final ]
	then
		echo "------------------------------------------------------------------------------------------------"
		echo "LA FECHA INICIAL ES MAYOR A LA FECHA FINAL O NO SE ENCONTRARON REGISTROS EN ESE RANGO DE FECHAS"
		echo " "
	else
		last -s $fecha_inicial -t $fecha_final
		last -f /var/log/wtmp.1 -s $fecha_inicial -t $fecha_final
	fi

elif [[ $respuesta = "n" ]]
then
	last | more
	last -f /var/log/wtmp.1 | more
else 
	echo "------------------------------------"
	echo "Opcion invalida, vuelva a intentarlo"
	echo " "
fi

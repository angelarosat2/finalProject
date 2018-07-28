#!/bin/bash

echo "Desea filtrar los logs por fecha? s/n"
read respuesta
if [ $respuesta = "S" ]
then
	echo "Ingrese dia incial"
	read dia_inicial
	
	echo "Ingrese mes inicial"
	read mes_inicial

	echo "Ingrese anio inicial"
	read anio_inicial

	echo "Ingrese dia final"
	read dia_final

	echo "Ingrese mes final"
	read mes_final

	echo "Ingrese anio final"
	read anio_final

	while [ -z "$dia_inicial" ]; do
		echo "Debe ingresar un dia inicial"
		read dia_inicial
	done
	while [ -z "$mes_inicial" ]; do
		echo "Debe ingresar mes inicial"
		read mes_inicial
	done
	while [ -z "$anio_inicial" ]; do
		echo "Debe ingresar un anio inicial"
		read anio_incial
	done
	while [ -z "$dia_final" ]; do
		echo "Debe ingresar dia final"
		read dia_final
	done
	while [ -z "$mes_final" ]; do
		echo "Debe ingresar mes final"
		read mes_final
	done
	while [ -z "$anio_final" ]; do
		echo "Debe ingresar anio final"
		read anio_final
	done
	fecha_inicio.integer = $(date -d "$dia_inicial" "/" "$mes_incial" "/" "$anio_inicial" + "%d+%m+%Y" )

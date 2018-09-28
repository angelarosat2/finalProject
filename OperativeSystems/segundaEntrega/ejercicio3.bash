#!/bin/bash
echo "Ingrese en que minuto quiere que se ejecute la tarea (00 - 59), si lo desea puede dar enter sin ingresar un valor y la tarea se realizara cada minuto."
read minuto
while [ $minuto > 59 ]
do
	echo "Ingrese un valor entre el rango de 00 a 59, sino presione enter para que la tarea se ejecute cada minuto."
	read minuto
done
if [ -z "$minuto"]
then
	minuto="*"
fi
echo $minuto
echo "Ingrese a que hora quiere que se ejecute la tarea (00 - 23), si lo desea puede dar enter sin ingresar un valor y la tarea se realizara cada hora."
read hora

echo "Ingrese que dia quiere que se ejecute la tarea (1 - 31), si lo desea puede dar enter sin ingresar un valor y la tarea se realizara cada dia."
read dia

echo "Ingrese en que mes quiere que se ejecute la tarea (1 - 12), si lo desea puede dar enter sin ingresar un valor y la tarea se realizara cada mes."
read mes

echo "Ingrese en que dia de la semana quiere que se ejecute la tarea (1 - 7), si lo desea puede dar enter sin ingresar un valor y la tarea se realizara sin importar el dia de la semana."
read diaSemana



#!/bin/bash
GLOBIGNORE="*"

#INICIO INGRESO MINUTO
echo "Ingrese en que minuto quiere que se ejecute la tarea (00 - 59), si lo desea puede dar enter sin ingresar un valor y la tarea se realizara cada minuto."
read minuto
if [ -z $minuto ]
then
	minuto=$(echo *)
else
while [ $minuto -gt 59 ]
do
	echo "Ingrese un valor entre el rango de 00 a 59, sino presione enter para que la tarea se ejecute cada minuto."
	read minuto
done
fi
#FIN INGRESO MINUTO

#INICIO INGRESO HORA
echo "Ingrese a que hora quiere que se ejecute la tarea (00 - 23), si lo desea puede dar enter sin ingresar un valor y la tarea se realizara cada hora."
read hora
if [ -z $hora ]
then
	hora=$(echo *)
else
while [ $hora -gt 23 -o $hora -lt 00 ]
do
	echo "Ingrese un valor entre el rango de 00 a 59, sino presione enter para que la tarea se ejecute cada minuto."
	read hora
done
fi
#FIN INGRESO HORA

#INICIO INGRESO DIA
echo "Ingrese que dia quiere que se ejecute la tarea (1 - 31), si lo desea puede dar enter sin ingresar un valor y la tarea se realizara cada dia."
read dia
if [ -z $dia ]
then
	dia=$(echo *)
else
while [ $dia -gt 31 -o $dia -lt 1 ]
do
	echo "Ingrese un valor entre el rango de 00 a 59, sino presione enter para que la tarea se ejecute cada minuto."
	read dia
done
fi
#FIN INGRESO DIA

#INICIO INGRESO MES
echo "Ingrese en que mes quiere que se ejecute la tarea (1 - 12), si lo desea puede dar enter sin ingresar un valor y la tarea se realizara cada mes."
read mes
if [ -z $mes ]
then
	mes=$(echo *)
else
while [ $mes -gt 12 -o $mes -lt 1 ]
do
	echo "Ingrese un valor entre el rango de 00 a 59, sino presione enter para que la tarea se ejecute cada minuto."
	read mes
done
fi
#FIN INGRESO MES

#INICIO INGRESO DIA SEMANA
echo "Ingrese en que dia de la semana quiere que se ejecute la tarea (1 - 7, siendo 1 lunes y 7 domingo), si lo desea puede dar enter sin ingresar un valor y la tarea se realizara sin importar el dia de la semana."
read diaSemana
if [ -z $diaSemana ]
then
	diaSemana=$(echo *)
else
while [ $diaSemana -gt 7 -o $diaSemana -lt 1 ]
do
	echo "Ingrese un valor entre el rango de 00 a 59, sino presione enter para que la tarea se ejecute cada minuto."
	read diaSemana
done
fi
#FIN INGRESO DIA SEMANA

#INICIO INGRESO COMANDO
echo "Ingrese el comando que desea programar."
read comando
while [ -z "$comando" ]
do
	echo "Por favor, ingrese el comando."
	read comando
done
#FIN INGRESO COMANDO

#Creacion de tarea
crontab -l > newCron &> /dev/null
echo "$minuto $hora $dia $mes $diaSemana $comando" >> newCron
crontab newCron
rm newCron

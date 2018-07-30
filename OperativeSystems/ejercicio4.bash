#!/bin/bash

cat /var/log/mis_respaldos.txt

if [ -d /var/log/mis_respaldos.txt ]
then 
	echo "Todavia no sa han realizado respaldos"
fi

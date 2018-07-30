#Para ejecutar este codigo poner: sort -k6 logs_logins | awk -f ejercicio.awk (opcional: -v 
# usuario="Francisco"
BEGIN {
	printf "-----** EMPIEZA EL SCRIPT **-----\n"
}
{
	if (usuario != "" && usuario == $2) #Aca defino de que usuario quiero la informacion# 
		
		printf "El usuario " $2 " hizo " $4 " el dia " $6 " a las " $7 $8 "\n" 
	else if (usuario == "")
		printf "El usuario " $2 " hizo " $4 " el dia " $6 " a las " $7 $8 "\n"
}
END {
	printf "-----** FIN DEL SCRIPT **-----\n"
}

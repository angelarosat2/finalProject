#Para ejecutar este código debe ingresar: last -w | awk -v user=$USER -f ejercicio1.awk

BEGIN {
    printf "Ahora verá los login y logout del usuario %s \n", user
}
{
    printf $1 " " $4 " " $5 " " $6 " " $7 "\n" 
}
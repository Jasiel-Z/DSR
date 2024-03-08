#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>

int main(){
    int pid = fork();
    printf("ID del proceso: %d\n", pid);

    if (pid > 0){
        sleep(30);
    }else if(pid == 0){
        printf("\nProceso Zombi creado con exito!");
        printf("\nEstará activo durante 30 segundos\n");
        exit(0);
    }else{
        printf("\nLo sentimos. El proceso hijo no pudo ser creado");
    }

    return 0;
}
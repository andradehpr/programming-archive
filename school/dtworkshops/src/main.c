#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include<conio.h> 
#include <string.h>
#include "func.h"
#include <time.h>









int main()
{





            struct dados_pessoais
            {
            char name[35];
            int phone[9];
            char mail[25];
            };



        struct dados_pessoais dados;

        char enter = 0;
        int lang , i, mode , mode1 , type , dt , appday , apptime , appmonth, serv;
        char car[15];
        char model[15];
        int year[4];
        char str[ ] = "dt workshops";



                                    time_t tm;
                                    time(&tm);


        setlocale(LC_ALL,"Portuguese");



    ascii();




    ascii2();



                printf("\n");
                printf("Prima ENTER para continuar\n");
                printf("Press ENTER to continue\n");
                getch();




                system("cls");



                ascii();




                    printf("\t\t\t\t|	   1- English           |");
                    printf("|	   2- Portugu�s	        |\n");
                    scanf("%i",&lang);

                    if(lang==1)
                    {

                      system("cls");




                      ascii();


                      printf("\t\t\t\t|	   3- Light Mode        |");
                      printf("|	   4- Dark Mode         |\n");
                      scanf("%i",&mode);
                      } else{

                            system("cls");




                      ascii();





                      printf("\t\t\t\t|	   5- Modo Dia        |");
                      printf("|	   6- Modo Noite         |\n");
                      scanf("%i",&mode);


                        }




                          switch(mode){










                        case 3:     system("cls");

                                    system("COLOR F7");           //Light Mode

                                    textcolor(BLACK);

                                    ascii();

                                     printf("\t\t\t     |	   7- Make an appointment      |");
                                printf("|	     8- Price List          |\n");
                                    scanf("%i",&dt);
                                    ;break;



















                        case 4:  system("cls");                     //Dark Mode

                                 ascii();


                                  printf("\t\t\t     |	   9- Make an appointment      |");
                                printf("|	     10- Price List          |\n");
                                 scanf("%i",&dt);
                                 ;break;















                        case 5:
                                    system("cls");

                                    system("COLOR F7");           //Modo Dia

                                    textcolor(BLACK);

                                    ascii();

                                    printf("\t\t\t     |	      11- Marca��o hor�ria        |");
                                printf("|	   12- Tabela de Pre�os      |\n");
                                    scanf("%i",&dt);
                                    ;break;
















                        case 6:

                                    system("cls");                 //Modo Noite


                                    ascii();




                                    printf("\t\t\t     |	      13- Marca��o hor�ria        |");
                                printf("|	   14- Tabela de Pre�os      |\n");
                                    scanf("%i",&dt);
                                    ;break;
                                    }


                                    switch(dt){

                                    case 7:

                                     system("cls");

                                     ascii();


                                     printf("                                       Current Date/Time = %s\n\n", ctime(&tm));


                                     printf("                                            Which day do you want to make the appointment?\n\n");
                                                                                    scanf("%i",&appday);


                                     printf("                                           In which month do you want to make the appointment?\n\n");
                                                                                    scanf("%i",&appmonth);




                                     printf("                                        What time do you want to make the appointment? 9h-12h 13h-17h \n\n");
                                                                                    scanf("%i",&apptime);





                                     printf("                                                           What is your name: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(dados.name,40,stdin);


                                     printf("                                                           Your phone number: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(dados.phone,40,stdin);


                                     printf("                                                           Your email address: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(dados.mail,40,stdin);



                                                                                    FILE * Ldados1;


                                                                                    Ldados1 = fopen("dados.txt","a");


                                                                                    if (Ldados1 == NULL) {                           //File
                                                                                    printf("\nError opening the FILE!\n");
                                                                                    exit(1);
                                                                                    }








                                      printf("                                                             Your car brand: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(car,40,stdin);


                                      printf("                                                             Your car model: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(model,40,stdin);


                                                                                    fputs(car, Ldados1);
                                                                                    fputs(model, Ldados1);




                                                                                    fclose(Ldados1);







                                        printf("                                                                  Year: \n\n");


                                                                                    scanf("%i",&year[i]);






                                                                                    printf("\n\n\nSIR/MISS %s ,YOUR APPOINTMENT WILL BE ON THE %iTH OF %i AT %iH. \n\n\n",dados.name,appday,appmonth,apptime);

                                                                                    printf("IF THE DAY/HOUR ARE NOT DISPONIBLE YOU WILL BE NOTIFIED WITH A MESSAGE ON YOUR PHONE.\n\n\n\n");






                                                                                    printf("\t\t\t\t\t\t\t\t\t\t\t\t\t%s\n", strupr (str));









                                    ;break;













                                    case 8:


                                        system("cls");
                                        ascii();




                                        printf("\t\t\t\t|	   1- CMD              |");
                                        printf("|	     2- PDF	          |\n");
                                        scanf("%i",&serv);
                                        if(serv==1){

                                            system("cls");

                                            ascii();

                                            sleep(1);

                                            system("cls");

                                            sleep(1);


                                            ascii4();



                             printf("\nRegulated by Decree-Law No. 138/90, of 26 April, with the changes introduced by Decree-Law No. 162/99, of 13 May.\n\n\n");

                                    printf("Labor (hourly value of 35.00$ + VAT).................................43.05$\n\n\n");




                        printf("Services:\n\n");
                            printf("Focusing of headlights (8.13 + VAT)...................................7.38$ \n");
                            printf("Tests and diagnosis (25.00 + VAT)....................................30.75$ \n");
                            printf("Air Conditioning Charge (60 + VAT)...................................73.80$ \n");
                            printf("Car radio assembly (simple) (25.00 + VAT)............................30.75$ \n");
                            printf("                          (Values with VAT included at the current rate). \n\n");


                            printf("Other services:\n\n");
                            printf("   Mounting of alarms, sound systems, hands-free kit and other services\nin the area of electricity, electronics and mechatronics are available at this\nestablishment on request, with a budget for each specific case.\n ");





                              printf("\n\n\n\n\t\tLisbon, Entrecampos    22/06/2021");














                                        }else{

                                        system("dten.PDF");










                                        }



                                    ;break;















                                    case 9:


                                    system("cls");

                                     ascii();


                                     printf("                                       Current Date/Time = %s\n\n", ctime(&tm));


                                     printf("                                            Which day do you want to make the appointment?\n\n");
                                                                                    scanf("%i",&appday);


                                     printf("                                           In which month do you want to make the appointment?\n\n");
                                                                                    scanf("%i",&appmonth);




                                     printf("                                        What time do you want to make the appointment? 9h-12h 13h-17h \n\n");
                                                                                    scanf("%i",&apptime);





                                     printf("                                                           What is your name: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(dados.name,40,stdin);


                                     printf("                                                           Your phone number: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(dados.phone,40,stdin);


                                     printf("                                                           Your email address: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(dados.mail,40,stdin);



                                                                                    FILE * Ldados;


                                                                                    Ldados = fopen("dados.txt","a");


                                                                                    if (Ldados == NULL) {
                                                                                    printf("\nError opening the FILE!\n");
                                                                                    exit(1);
                                                                                    }




                                      printf("                                                             Your car brand: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(car,40,stdin);


                                      printf("                                                             Your car model: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(model,40,stdin);


                                                                                    fputs(car, Ldados);
                                                                                    fputs(model, Ldados);




                                                                                    fclose(Ldados);





                                        printf("                                                                  Year: \n\n");


                                                                                    scanf("%i",&year[i]);






                                                                                    printf("\n\n\nSIR/MISS %s ,YOUR APPOINTMENT WILL BE ON THE %iTH OF %i AT %iH. \n\n\n",dados.name,appday,appmonth,apptime);

                                                                                    printf("IF THE DAY/HOUR ARE NOT DISPONIBLE YOU WILL BE NOTIFIED WITH A MESSAGE ON YOUR PHONE.\n\n\n\n");






                                                                                    printf("\t\t\t\t\t\t\t\t\t\t\t\t\t%s\n", strupr (str));









                                    ;break;














                                    case 10:
                                    system("cls");
                                        ascii();




                                        printf("\t\t\t\t|	   1- CMD              |");
                                        printf("|	     2- PDF	          |\n");
                                        scanf("%i",&serv);
                                        if(serv==1){

                                            system("cls");

                                            ascii();

                                            sleep(1);

                                            system("cls");

                                            sleep(1);


                                            ascii4();



                             printf("\nRegulated by Decree-Law No. 138/90, of 26 April, with the changes introduced by Decree-Law No. 162/99, of 13 May.\n\n\n");

                                    printf("Labor (hourly value of 35.00$ + VAT).................................43.05$\n\n\n");




                        printf("Services:\n\n");
                            printf("Focusing of headlights (8.13 + VAT)...................................7.38$ \n");
                            printf("Tests and diagnosis (25.00 + VAT)....................................30.75$ \n");
                            printf("Air Conditioning Charge (60 + VAT)...................................73.80$ \n");
                            printf("Car radio assembly (simple) (25.00 + VAT)............................30.75$ \n");
                            printf("                          (Values with VAT included at the current rate). \n\n");


                            printf("Other services:\n\n");
                            printf("   Mounting of alarms, sound systems, hands-free kit and other services\nin the area of electricity, electronics and mechatronics are available at this\nestablishment on request, with a budget for each specific case.\n ");





                              printf("\n\n\n\n\t\tLisbon, Entrecampos    22/06/2021");














                                        }else{

                                        system("dten.PDF");



                                        return 0;



                                        }

                                    ;break;















                                    case 11:
                                    system("cls");

                                     ascii();


                                     printf("                                       Data/hora atual = %s\n\n", ctime(&tm));


                                     printf("                                   \tEm que dia voc� deseja marcar a consulta ao seu carro?\n\n");
                                                                                    scanf("%i",&appday);


                                     printf("                                                Em que m�s deseja fazer o agendamento?\n\n");
                                                                                    scanf("%i",&appmonth);




                                     printf("                                 A que horas voc� quer marcar a consulta do seu carro? 9h-12h 13h-17h \n\n");
                                                                                    scanf("%i",&apptime);





                                     printf("                                                            Qual � o seu nome: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(dados.name,40,stdin);


                                     printf("                                                      Qual � o seu numero de telemovel: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(dados.phone,40,stdin);


                                     printf("                                                            Qual � o seu e-mail: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(dados.mail,40,stdin);



                                                                                    FILE * Ldados2;


                                                                                    Ldados2 = fopen("dados.txt","a");


                                                                                    if (Ldados2 == NULL) {
                                                                                    printf("\nErro a abrir o Ficheiro!\n");
                                                                                    exit(1);
                                                                                    }




                                     printf("                                                            Marca do seu carro: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(car,40,stdin);


                                     printf("                                                            Modelo do seu carro: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(model,40,stdin);


                                                                                    fputs(car, Ldados2);
                                                                                    fputs(model, Ldados2);




                                                                                    fclose(Ldados2);





                                    printf("                                                                   Ano: \n\n");


                                                                                    scanf("%i",&year[i]);






                                                                                    printf("\n\n\nSR/A %s,A CONSULTA DO SEU CARRO SE NO DIA %i DE %i �S %iH. \n\n\n",dados.name,appday,appmonth,apptime);



                                                                                    printf("SE O DIA / HORA N�O ESTIVER DISPON�VEL VOC� SER� NOTIFICADO COM UMA MENSAGEM NO SEU TELEFONE.\n\n\n");




                                                                                    printf("\t\t\t\t\t\t\t\t\t\t\t\t\t%s\n", strupr (str));








                                    ;break;










                                    case 12:
                                    system("cls");
                                        ascii();




                                        printf("\t\t\t\t|	   1- CMD              |");
                                        printf("|	     2- PDF	          |\n");
                                        scanf("%i",&serv);
                                        if(serv==1){

                                            system("cls");

                                            ascii();

                                            sleep(1);

                                            system("cls");

                                            sleep(1);


                                            ascii3();



                             printf("\nRegulada pelo Decreto de Lei n� 138/90, de 26 de Abril, com as altera��es introduzidas pelo Decreto de Lei n� 162/99, de 13 de Maio.\n\n\n");

                                    printf("M�o de Obra(valor hora 35,00$ + IVA)......................................43.05$\n\n\n");




                        printf("Servi�os:\n\n");
                            printf("Focagem de far�is(8,13 + IVA)..............................................7.38$ \n");
                            printf("Testes e diagn�stico (25,00 + IVA)........................................30.75$ \n");
                            printf("Carregamento de ar condicionado (60,00 + IVA) ............................73.80$ \n");
                            printf("Montagem de auto-radio (simples) (25.00 + IVA)............................30.75$ \n");
                            printf("                                      (Valores com IVA incluido � taxa em vigor). \n\n");


                            printf("Outros Servi�os:\n\n");
                            printf("   Montagens de alarmes, sistemas de som, kit m�os livres e outros servi�os\nna �rea da eletricidade, eletr�nica e mecatr�nica est�o dispon�veis neste\nestabelecimento sob consulta, com apresentaa��o de or�amento para cada\ncaso espec�fico.\n  ");





                              printf("\n\n\n\n\t\tLisboa, Entrecampos    22/06/2021");














                                        }else{

                                        system("dtpt.PDF");



                                        return 0;



                                        }

                                    ;break;






                                    ;break;











                                    case 13:


                                     system("cls");

                                     ascii();


                                     printf("                                       Data/hora atual = %s\n\n", ctime(&tm));


                                     printf("                                   \tEm que dia voc� deseja marcar a consulta ao seu carro?\n\n");
                                                                                    scanf("%i",&appday);


                                     printf("                                                Em que m�s deseja fazer o agendamento?\n\n");
                                                                                    scanf("%i",&appmonth);




                                     printf("                                 A que horas voc� quer marcar a consulta do seu carro? 9h-12h 13h-17h \n\n");
                                                                                    scanf("%i",&apptime);





                                     printf("                                                            Qual � o seu nome: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(dados.name,40,stdin);


                                     printf("                                                      Qual � o seu numero de telemovel: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(dados.phone,40,stdin);


                                     printf("                                                            Qual � o seu e-mail: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(dados.mail,40,stdin);



                                                                                    FILE * Ldados3;


                                                                                    Ldados3 = fopen("dados.txt","a");


                                                                                    if (Ldados3 == NULL) {
                                                                                    printf("\nErro a abrir o Ficheiro!\n");
                                                                                    exit(1);
                                                                                    }




                                     printf("                                                            Marca do seu carro: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(car,40,stdin);


                                     printf("                                                            Modelo do seu carro: \n\n");
                                                                                    fflush(stdin);

                                                                                    fgets(model,40,stdin);


                                                                                    fputs(car, Ldados3);
                                                                                    fputs(model, Ldados3);




                                                                                    fclose(Ldados3);




                                    printf("                                                                   Ano: \n\n");


                                                                                    scanf("%i",&year[i]);






                                                                                    printf("\n\n\nSR/A %s,A CONSULTA DO SEU CARRO SE NO DIA %i DE %i �S %iH. \n\n\n",dados.name,appday,appmonth,apptime);



                                                                                    printf("SE O DIA / HORA N�O ESTIVER DISPON�VEL VOC� SER� NOTIFICADO COM UMA MENSAGEM NO SEU TELEFONE.\n\n\n");




                                                                                    printf("\t\t\t\t\t\t\t\t\t\t\t\t\t%s\n", strupr (str));








                                    ;break;











                                    case 14:

                                    system("cls");
                                        ascii();




                                        printf("\t\t\t\t|	   1- CMD              |");
                                        printf("|	     2- PDF	          |\n");
                                        scanf("%i",&serv);
                                        if(serv==1){

                                            system("cls");

                                            ascii();

                                            sleep(1);

                                            system("cls");

                                            sleep(1);


                                            ascii3();



                             printf("\nRegulada pelo Decreto de Lei n� 138/90, de 26 de Abril, com as altera��es introduzidas pelo Decreto de Lei n� 162/99, de 13 de Maio.\n\n\n");

                                    printf("M�o de Obra(valor hora 35,00$ + IVA)......................................43.05$\n\n\n");




                        printf("Servi�os:\n\n");
                            printf("Focagem de far�is(8,13 + IVA)..............................................7.38$ \n");
                            printf("Testes e diagn�stico (25,00 + IVA)........................................30.75$ \n");
                            printf("Carregamento de ar condicionado (60,00 + IVA) ............................73.80$ \n");
                            printf("Montagem de auto-radio (simples) (25.00 + IVA)............................30.75$ \n");
                            printf("                                      (Valores com IVA incluido � taxa em vigor). \n\n");


                            printf("Outros Servi�os:\n\n");
                            printf("   Montagens de alarmes, sistemas de som, kit m�os livres e outros servi�os\nna �rea da eletricidade, eletr�nica e mecatr�nica est�o dispon�veis neste\nestabelecimento sob consulta, com apresenta��o de or�amento para cada\ncaso espec�fico.\n  ");





                              printf("\n\n\n\n\t\tLisboa, Entrecampos    22/06/2021");














                                        }else{

                                        system("dtpt.PDF");



                                        return 0;



                                        }

                                    ;break;






                                    }





}















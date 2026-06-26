#include <iostream>
using namespace std;

constexpr int maxCol = 5; // Atribuir tamanho do Array

bool campo[maxCol]; // Criação do Array campo com tamanhao maxCol

void limpaMinas() {
    for (int i = 0; i < maxCol; i++) campo[i] = false; //Limpeza na memoria do pc, antes do jogo começar
}

void listaMinas() {
    for (int i = 0; i < maxCol; i++) {
        if (campo[i]) cout << "X"; // Se tiver mina escreve X
        else cout << "O"; // Se não tiver escrever O
    }
    cout << endl;
}

void plantaMinas() {
    int qtd, posicao;
    cout << "Quantas minas quer plantar? ";
    cin >> qtd;
    cout << "Em que posições as quer plantar?\n";
    for (int i = 0; i < qtd; i++) {
        cin >> posicao;
        if (posicao >= 1 && posicao <= maxCol) // Se a posição for maior ou igual a 1 & se for menor ou igual ao numero de colunas possiveis
            campo[posicao - 1] = true; // faz -1 porque o array começa em 0, se o user escrever 1, iria ficar na posicao 2 do array
    }
}

bool jogar(bool c[], int nCol) { // c representa o campo e nCol as colunas 
    int p;
    cout << "Em que casa quer jogar (1 a " << nCol << ")? "; 
    cin >> p;

    if (p < 1 || p > nCol) { // Verificação de segurança (fora do array)
        cout << "Posicao invalida! Tenta outra vez.\n";
        return true; // Retorna true para o while continuar e pedir de novo
    }

    if (c[p - 1] == true) { // Se entrar aqui, é porque o jogador acertou numa mina
        cout << "BUM! Acertaste numa mina!\n";
        return false; // Retorna false para o while no main parar
    } 
    else { // Se entrar aqui, a casa está vazia (false)
        cout << "Seguro! Continua a jogar...\n";
        return true; // Retorna true para o while continuar
    }
}

int main() {

    int totJogadas = 0;
    limpaMinas(); // Limpas as minas da memoria antes do jogo começar
    plantaMinas(); // Pergunta quantas minas quer plantar e onde

    while (jogar(campo, maxCol)) { // Enquanto jogar for true, aumenta o numero de jogadas e repete 
        totJogadas++;
    }

    cout << "\n--- FIM DE JOGO ---\n";
    listaMinas(); // Mostra o campo em XXXXX & OOOOO
    cout << "Pontuacao: " << totJogadas << " jogadas seguras.\n";

    return 0;
}
#include <iostream>
using namespace std;

int main() {
    // Escreva seu c�digo aqui
    setlocale(LC_ALL, "portuguese");

    int NumeroProcesso = 0;

    cin >> NumeroProcesso;

    if (NumeroProcesso % 42 == 0)
    {
        cout << "Sim";
    }
    else
    {
        cout << "Nao";
    }

    return 0;
}
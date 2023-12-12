#include <iostream>
using namespace std;

int main() {
    // Escreva seu código aqui
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
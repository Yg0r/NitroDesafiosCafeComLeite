// InverterASequenciaCPP.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

using namespace std;

int main()
{
    int N;

    cin >> N;

    int NumeroMatricula[3]; //Para buildar eu tive que usar um número inteiro não sei o por que mas o certo é usar o valor de "N".

    for (int i = 0; i < N; i++)
    {
        cin >> NumeroMatricula[i];
    }

    int contador = 0;
    for (int i = N - 1; i >= 0; i--)
    {
        cout << NumeroMatricula[i];

        if (contador != N - 1) 
        { 
            cout << " ";
            contador++;
        }
    }

    return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file

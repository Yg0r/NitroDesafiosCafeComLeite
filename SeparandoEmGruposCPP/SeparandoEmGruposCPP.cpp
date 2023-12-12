// SeparandoEmGruposCPP.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>

using namespace std;

int main()
{
    string Nome;
   
    cin >> Nome;

    if (Nome.length() <= 4)
    {
        cout << "GRUPO A";
    }
    else if (Nome.length() <= 10)
    {
        cout << "GRUPO B";
    }
    else
    {
        cout << "GRUPO C";
    }
}
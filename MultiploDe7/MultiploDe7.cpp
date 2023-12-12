// MultiploDe7.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

using namespace std;

int main()
{
	setlocale(LC_ALL, "portuguese");

	int numero;
	
	cin >> numero;

	if (numero >= 1000)
	{
		return 0;
	}
	
	if (numero % 7 == 0)
	{
		cout << "É MULTIPLO DE 7";
	}
	else
	{
		cout << "ESSE NÃO É";
	}
}
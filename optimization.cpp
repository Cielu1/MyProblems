
#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <string>
#include <Windows.h>
#include <fstream>
#include <vector>
#include <stdio.h>
#include <iomanip>
#include <stdio.h>
#include <sstream>
#include <cstdlib> 
#include <math.h>  
using namespace std;

class stwor
{
public:
	stwor(int, int, int, int, int, int, string);
	//void walka(int, int, int, int);
	void wypisz(int);
	static double staty[200][5];
	static string name[200];
private:

	int ID;
};

string nejm[200] = { "0" };
double staty_global[200][5]{ 0 };
double stwor::staty[200][5] = { 0 };
string stwor::name[200] = { "0" };

stwor::stwor(int ID, int attack, int deffence, int damagemin, int damagemax, int HealthPoints, string nazwa)
{
	int i = ID;
	nejm [i] = nazwa;
	staty_global[i][0] = ID;
	staty_global [i][1] = attack;
	staty_global[i][2] = deffence;
	staty_global[i][3] = (damagemin + damagemax)/2;
	staty_global[i][4] = HealthPoints;

	// wypisz(i);
}

void stwor::wypisz(int i) {

	cout << "Stwor: " << name[i] << endl;
	cout << "Atak: " << staty[i][1] << endl;
	cout << "Obrona: " << staty[i][2] << endl;
	cout << "Obrazenia: " << staty[i][3] << endl;
	cout << "Zycie: " << staty[i][4] << endl << endl;
}

void walka(int id, int di, int n, int m)
{
	double dd;
	int i = id;
	int j = di;

	bool c1 = 1;
	int att1 = staty_global[i][1];
	int def1 = staty_global[i][2];
	double dmg1 = staty_global[i][3];
	int hp1s = staty_global[i][4];
	int amt1 = n;

	bool c2 = 1;
	int att2 = staty_global[j][1];
	int def2 = staty_global[j][2];
	double dmg2 = staty_global[j][3];
	int hp2s = staty_global[j][4];
	int amt2 = m;

	int killed;
	cout << n << " " << nejm[i] << " Attacks " << m << " " << nejm[j] << endl;
	int hp2 = hp2s * m;
	int hp1c = hp1s; int hp2c = hp2s;
	int dr = 0;
	int round = 0;


	while (n > 0 && m > 0) {


	//	cout << "RUNDA: " << round << endl << endl;

		if (att1 > att2) {
			int i1 = 0.05 * (att1 - def2);
			dd = n * dmg1 * (1 + i1);
		}

		else {
			int r1 = 0.025 * (def2 - att1);
			dd = n * dmg1 * (1 - r1);
		}

		if (dd > hp2s) {
			killed = floor(dd / hp2s);
			int k = floor(dd);
			hp2c = hp2s - k % hp2c;
		//	cout << n << " " << name[i] << " deals: " << dd << " to " << name[j] << endl;
		//	cout << killed << " " << name[j] << " killed" << endl;
		//	cout << m << " hp left " << hp2c << endl << endl;
		}

		else if (dd > hp2c) {
			killed = 1;
			int k = floor(dd);
			hp2c = hp2s - k % hp2c;
		//	cout << n << " " << name[i] << " deals: " << dd << " to " << name[j] << endl;
		//	cout << killed << " " << name[j] << " killed" << endl;
		//	cout << name[j] << " hp left " << hp2c << endl << endl;

		}

		else {
			hp2c -= dd; killed = 0;
		//	cout << n << " " << name[i] << " deals: " << dd << " to " << name[j] << endl;
		//	cout << killed << " " << name[j] << " killed" << endl;
		//	cout << name[j] << " hp left " << hp2c << endl << endl;
		}



		m -= killed;






		if (att2 > att1) {
			double i1 = 0.05 * (att2 - def1);
			dd = m * dmg2 * (1 + i1);
		}

		else {
			double r1 = 0.025 * (def1 - att2);
			dd = m * dmg2 * (1 - r1);
		}

		if (dd > hp1s) {
			killed = dd / hp1s;
			int k = floor(dd);
			hp1c = hp1s - k % hp1c;
		//	cout << m << " " << name[j] << " deals: " << dd << " to " << name[i] << endl;
		//	cout << killed << " " << name[i] << " killed" << endl;
		//	cout << name[i] << " hp left " << hp1c << endl << endl;
		}

		else if (dd > hp1c) {
			killed = 1;
			int k = floor(dd);
			hp1c = hp2s - k % hp1c;
		//	cout << m << " " << name[j] << " deals: " << dd << " to " << name[i] << endl;
		//	cout << killed << " " << name[i] << " killed" << endl;
		//	cout << name[i] << " hp left " << hp1c << endl << endl;

		}

		else {
			hp1c -= dd; killed = 0;
		//	cout << m << " " << name[j] << " deals: " << dd << " to " << name[i] << endl;
		//	cout << killed << " " << name[i] << " killed" << endl;
		//	cout << name[i] << " hp left " << hp1c << endl << endl;
		}



		n -= killed;

		round++;
	}

	if (m <= 0) {
		cout << nejm[id] << " killed " << nejm[di] << " in " << round << " rounds" << endl;
		cout << nejm[id] << " left " << n << endl << endl;
	}
	if (n <= 0) {
		cout << nejm[di] << " killed " << nejm[id] << " in " << round << " rounds" << endl;
		cout << nejm[di] << " left " << m << endl << endl;
	}



}



int main()
{
	int amt[10];

	stwor troglo(0, 4, 3,1, 3, 5, "Troglodytes"); 
	amt[0] = 1400;
	
	stwor peasant(1, 1, 1, 1, 1, 1, "Peasants");
	amt[1] = 4352;

	stwor angel(2, 20, 20, 50, 50, 200, "Angels"); 
	amt[2] = 24;

	stwor troll(3, 14, 7, 10, 15, 40, "Trolls");
	amt[3] = 158;

	stwor genie(4, 12, 12, 13, 16, 40, "Genies"); 
	amt[4] = 131;

	stwor minotaur(5, 14, 12, 12, 20, 50, "Minotaurs");
	amt[5] = 106;

	stwor imp(6, 2,	3,	1,	2,	4, "Imps"); 
	amt[6] = 1810;

	stwor swordsman(7, 10, 12, 6, 9, 35, "Swordsmen");
	amt[7] = 206;

	stwor goblin(8, 4, 2, 1, 2, 5, "Goblins");
	amt[8] = 1604;

	stwor rogue(9, 8, 3, 2, 4, 10,  "Rogues"); 
	amt[9] = 719;


	for (int i = 1; i < 10; i++)
	{
		cout << "\n" << "--------" << nejm[i] << "-----------" << endl << endl;
		walka(0, i, 1400, amt[i]);
		walka(i,0, amt[i], 1400);
	}

	/* 
	troglo.walka(2, 1, 24, 4350);
	troglo.walka(1, 2, 4350, 24);
	cout << "----------------------------------------------------------------------" << endl;
	troglo.walka(2, 1, 19, 2596);
	troglo.walka(1, 2, 2596, 19);
	cout << "----------------------------------------------------------------------" << endl;
	troglo.walka(2, 1, 24, 4350);
	troglo.walka(1, 2, 4350, 24);
	*/ 

	for (int i = 0; i < 10; i++)
	{



	}


	system("pause");

	return 0;
}

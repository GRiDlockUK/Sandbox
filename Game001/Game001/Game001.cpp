// Game001.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

class Location {
	int row;
	int col;
public:
	Location(int, int);
};

Location::Location(int x, int y) {
	int row = x;
	int col = y;
};


class Player {
	char tile;
	int row;
	int col;
	int homerow;
	int homecol;
public:
	Player(char, int, int);
	void settile(char i) {
		tile = i; 
	}
	void setpos(int x, int y) {
		row = x;
		col = y;
	}
	void setpos(int x, int y, int hx, int hy) {
		row = x;
		col = y;
		homerow = hx; 
		homecol = hy; 
	}
	int gettile() {
		return tile;
	}
	int getrow() {
		return row; 
	}
	int getcol() { 
		return col;	
	}
	int gethomerow() {
		return homerow;
	}
	int gethomecol() {
		return homecol;
	}
};

Player::Player(char t, int r, int c) {
	tile = t;
	row = r;
	col = c;
};


//class Player2 {
//	char tile;
//	Location Currpos;
//	Location Homepos;
//public:
//	Player2(char);
//};
//
//Player2::Player2(char c) {
//	tile = c;
//};

int _tmain(int argc, _TCHAR* argv[])
{

	//setup
	const int Playercount = 2, boardrows = 6, boardcols = 8; // please use minimum 5 x 5
	const char freetile = '.', pushtile = ' ', hometile = 'o';
	char board[boardrows][boardcols];
	int currentPlayer = 0, moveinput, moverow, movecol;

//	Player2 Graham("A", (0, 0));

	Player p0("A",0,0)
		 
	Player pl[2];
		pl[0].settile('A');
		pl[0].setpos(2, 0, 2, 0); 
		pl[1].settile('B');
		pl[1].setpos(boardrows - 3, boardcols - 1, boardrows - 3, boardcols - 1); 


	// init board
	for (int row = 0; row < boardrows; ++row) {
		for (int col = 0; col < boardcols; ++col) {
			board[row][col] = freetile;
		}
	}
	
	// MAIN LOOP
	do {

		// position Player and home tiles
		for (int Player = 0; Player < Playercount; ++Player) {

			//Player
			board[pl[Player].getrow()][pl[Player].getcol()] = pl[Player].gettile();

			//home
			if (board[pl[Player].gethomerow()][pl[Player].gethomecol()] == pushtile) {
				board[pl[Player].gethomerow()][pl[Player].gethomecol()] = hometile;
			}

		}

		// print board
		system("cls");

		for (int col = 0; col < boardcols + 2; ++col)	{
			cout << "-";
		}
		cout << "\n";
		for (int row = 0; row < boardrows; ++row) {
			cout << "|";
			for (int col = 0; col < boardcols; ++col) {
				cout << board[row][col];
			}
			cout << "|\n";
		}

		for (int col = 0; col < boardcols + 2; ++col)	{
			cout << "-";
		}

		// print directions
		cout << "\n\n 7  8  9 \n    |\n 4-- --6\n    |\n 1  2  3\n\n";

		// Player move
		bool validmove = false;
		do {

			moverow = pl[currentPlayer].getrow();
			movecol = pl[currentPlayer].getcol();
			char movetile = pl[currentPlayer].gettile();

			// Player input
			cout << "Player " << movetile << " - Select move direction : ";
			cin >> moveinput;

			// translate input
			switch (moveinput) {
			case 1:
				++moverow;
				--movecol;
				break;
			case 2:
				++moverow;
				break;
			case 3:
				++moverow;
				++movecol;
				break;
			case 4:
				--movecol;
				break;
			case 6:
				++movecol;
				break;
			case 7:
				--moverow;
				--movecol;
				break;
			case 8:
				--moverow;
				break;
			case 9:
				--moverow;
				++movecol;
				break;
			default:
				moveinput = 99;
			}

			// check move
			if (moverow < 0 || moverow > boardrows || movecol < 0 || movecol > boardcols - 1 ||
				(board[moverow][movecol] != freetile && board[moverow][movecol] != hometile)
				) {
				cout << "Invalid Move.. Please retry\n\n";
			}
			else {
				validmove = true;
			}

		} while (!validmove);

		// pushtile and move
		board[pl[currentPlayer].getrow()][pl[currentPlayer].getcol()] = pushtile;
		pl[currentPlayer].setpos(moverow, movecol);

		// next Player 
		currentPlayer++;
		if (currentPlayer > Playercount -1) {
			currentPlayer = 0;
		}

	} while (currentPlayer < 10); // tbc

	// finish
	cout << "\nGame Over!" << endl;
	return 0;


}
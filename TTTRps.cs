using System;

public class Program
{


	public static void Main()
	{
		Gameselect();
	}


	public static void Gameselect()
	{
		string[] Board1 = { "a", "b", "c", "d", "e", "f", "g", "h", "i" };
		string GameSelect;
		Console.WriteLine("Would you like to play Scissors Paper Rock (RPS) or Tic Tac Toe (TTT)");
		GameSelect = Console.ReadLine();
		if (GameSelect.ToLower() == "rps")
		{
			RPS();
		}
		else if (GameSelect.ToLower() == "ttt")
		{
			TTT(Board1);
		}
		else
		{
			Console.WriteLine("Please pick a valid answer");
			Gameselect();

		}
	}



	public static void TTT(string[] Board1)
	{
		Player1(Board1);
		Player2(Board1);
	}


	public static void Player1(String[] Board1)
	{
		string FirstPlayer;
		Console.WriteLine("First player chose a slot with the corresponding letter");
		TTTBoard(Board1);
		FirstPlayer = Console.ReadLine();

		//change strings in the arrays

		if (FirstPlayer.ToLower() == Board1[0])
		{
			Board1[0] = "X";
			WinCON(Board1);
		}
		else if (FirstPlayer.ToLower() == Board1[1])
		{
			Board1[1] = "X";
			WinCON(Board1);

		}
		else if (FirstPlayer.ToLower() == Board1[2])
		{
			Board1[2] = "X";
			WinCON(Board1);

		}
		else if (FirstPlayer.ToLower() == Board1[3])
		{
			Board1[3] = "X";
			WinCON(Board1);
		}
		else if (FirstPlayer.ToLower() == Board1[4])
		{
			Board1[4] = "X";
			WinCON(Board1);
		}
		else if (FirstPlayer.ToLower() == Board1[5])
		{
			Board1[5] = "X";
			WinCON(Board1);
		}
		else if (FirstPlayer.ToLower() == Board1[6])
		{
			Board1[6] = "X";
			WinCON(Board1);
		}
		else if (FirstPlayer.ToLower() == Board1[7])
		{
			Board1[7] = "X";
			WinCON(Board1);
		}
		else if (FirstPlayer.ToLower() == Board1[8])
		{
			Board1[8] = "X";
			WinCON(Board1);
		}
		else if (FirstPlayer.ToLower() == "x")
		{
			Console.WriteLine("Please choose a valid input");
			Player1(Board1);
		}
		else
		{
			Console.WriteLine("Please choose a valid input");
			Player1(Board1);
		}
	}

	public static void Player2(String[] Board1)
	{
		string SecondPlayer;
		Console.WriteLine("Second player chose a slot with the corresponding letter");
		TTTBoard(Board1);
		SecondPlayer = Console.ReadLine();

		if (SecondPlayer.ToLower() == Board1[0])
		{
			Board1[0] = "O";
			WinCON(Board1);

		}
		else if (SecondPlayer.ToLower() == Board1[1])
		{
			Board1[1] = "O";
			WinCON(Board1);

		}
		else if (SecondPlayer.ToLower() == Board1[2])
		{
			Board1[2] = "O";
			WinCON(Board1);

		}
		else if (SecondPlayer.ToLower() == Board1[3])
		{
			Board1[3] = "O";
			WinCON(Board1);

		}
		else if (SecondPlayer.ToLower() == Board1[4])
		{
			Board1[4] = "O";
			WinCON(Board1);

		}
		else if (SecondPlayer.ToLower() == Board1[5])
		{
			Board1[5] = "O";
			WinCON(Board1);

		}
		else if (SecondPlayer.ToLower() == Board1[6])
		{
			Board1[6] = "O";
			WinCON(Board1);

		}
		else if (SecondPlayer.ToLower() == Board1[7])
		{
			Board1[7] = "O";
			WinCON(Board1);

		}
		else if (SecondPlayer.ToLower() == Board1[8])
		{
			Board1[8] = "O";
			WinCON(Board1);

		}
		else if (SecondPlayer.ToLower() == "x")
		{
			Console.WriteLine("Please choose a valid input");
			Player2(Board1);
		}
		else
		{
			Console.WriteLine("Please choose a valid input");
			Player2(Board1);
		}
		TTT(Board1);


		//Check if someone wo
	}


	public static void WinCON(string[] Board1)
	{
		if (Board1[0] == "X" && Board1[4] == "X" && Board1[8] == "X")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 1 wins");
			PlayagainTTT(Board1);
		}
		if (Board1[0] == "X" && Board1[1] == "X" && Board1[2] == "X")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 1 wins");
			PlayagainTTT(Board1);
		}
		if (Board1[3] == "X" && Board1[4] == "X" && Board1[5] == "X")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 1 wins");
			PlayagainTTT(Board1);
		}
		if (Board1[6] == "X" && Board1[7] == "X" && Board1[8] == "X")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 1 wins");
			PlayagainTTT(Board1);
		}
		if (Board1[0] == "X" && Board1[3] == "X" && Board1[6] == "X")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 1 wins");
			PlayagainTTT(Board1);
		}
		if (Board1[1] == "X" && Board1[4] == "X" && Board1[7] == "X")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 1 wins");
			PlayagainTTT(Board1);
		}
		if (Board1[2] == "X" && Board1[5] == "X" && Board1[8] == "X")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 1 wins");
			PlayagainTTT(Board1);
		}
		if (Board1[2] == "X" && Board1[4] == "X" && Board1[6] == "X")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 1 wins");
			PlayagainTTT(Board1);
		}

		if (Board1[0] == "O" && Board1[1] == "O" && Board1[2] == "O")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 2 wins");
			PlayagainTTT(Board1);
		}
		if (Board1[3] == "O" && Board1[4] == "O" && Board1[5] == "O")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 2 wins");
			PlayagainTTT(Board1);
		}
		if (Board1[6] == "O" && Board1[7] == "O" && Board1[8] == "O")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 2 wins");
			PlayagainTTT(Board1);
		}
		if (Board1[0] == "O" && Board1[5] == "O" && Board1[6] == "O")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 2 wins");
			PlayagainTTT(Board1);
		}
		if (Board1[1] == "O" && Board1[4] == "O" && Board1[7] == "O")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 2 wins");
			PlayagainTTT(Board1);
		}
		if (Board1[2] == "O" && Board1[5] == "O" && Board1[8] == "O")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 2 wins");
			PlayagainTTT(Board1);
		}
		if (Board1[0] == "O" && Board1[4] == "O" && Board1[8] == "O")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 2 wins");
			PlayagainTTT(Board1);
		}
		if (Board1[2] == "O" && Board1[4] == "O" && Board1[6] == "O")
		{
			TTTBoard(Board1);
			Console.WriteLine("Player 2 wins");
			PlayagainTTT(Board1);
		}
		else if (Board1[0] != "a" && Board1[1] != "b" && Board1[2] != "c" && Board1[3] != "d" && Board1[4] != "e" && Board1[5] != "f" && Board1[6] != "g" && Board1[7] != "h" && Board1[8] != "i")
		{
			TTTBoard(Board1);
			Console.WriteLine("Tie");
			PlayagainTTT(Board1);
		}

	}

	public static void TTTBoard(string[] Board1)
	{
		Console.Write(Board1[0] + "  ");
		Console.Write(Board1[1] + "  ");
		Console.WriteLine(Board1[2]);
		Console.WriteLine(" ");
		Console.Write(Board1[3] + "  ");
		Console.Write(Board1[4] + "  ");
		Console.WriteLine(Board1[5]);
		Console.WriteLine(" ");
		Console.Write(Board1[6] + "  ");
		Console.Write(Board1[7] + "  ");
		Console.WriteLine(Board1[8]);
		Console.WriteLine(" ");

	}


	//Rock paper scissors code here
	public static void RPS()
	{
		string PlayerChoice;
		Console.WriteLine("What do you pick Scissors (S), Paper (P) or Rock (R)?");
		PlayerChoice = Console.ReadLine();
		Random rnd = new Random();
		int CPUChoice = rnd.Next(1, 4);
		//1 = Rock 2 = Paper 3 = Scissors
		if (CPUChoice == 1 && PlayerChoice == "s")

		{
			Console.WriteLine("CPU Chose Rock");
			Console.WriteLine("You lose");
			Playagain();
		}
		else if (CPUChoice == 1 && PlayerChoice == "p")
		{
			Console.WriteLine("CPU Chose Rock");
			Console.WriteLine("You Win");
			Playagain();
		}
		else if (CPUChoice == 1 && PlayerChoice == "r")
		{
			Console.WriteLine("CPU Chose Rock");
			Console.WriteLine("You Tied");
			Playagain();
		}
		else if (CPUChoice == 2 && PlayerChoice == "r")
		{
			Console.WriteLine("CPU Chose Paper");
			Console.WriteLine("You lose");
			Playagain();
		}
		else if (CPUChoice == 2 && PlayerChoice == "s")
		{
			Console.WriteLine("CPU Chose Paper");
			Console.WriteLine("You Win");
			Playagain();
		}
		else if (CPUChoice == 2 && PlayerChoice == "p")
		{
			Console.WriteLine("CPU Chose Paper");
			Console.WriteLine("You Tied");
			Playagain();
		}
		else if (CPUChoice == 3 && PlayerChoice == "p")
		{
			Console.WriteLine("CPU Chose Scissors");
			Console.WriteLine("You lose");
			Playagain();
		}
		else if (CPUChoice == 3 && PlayerChoice == "r")
		{
			Console.WriteLine("CPU Chose Scissors");
			Console.WriteLine("You Win");
			Playagain();
		}
		else if (CPUChoice == 3 && PlayerChoice == "s")
		{
			Console.WriteLine("CPU Chose Scissors");
			Console.WriteLine("You Tied");
			Playagain();

		}
		else
		{
			Console.WriteLine("Please pick a valid answer");
			RPS();
		}
	}
	public static void Playagain()
	{
		string PlayMore;
		Console.WriteLine("Would you like to Play again (1), stop playing (2) or choose a different game (3)");
		PlayMore = Console.ReadLine();
		if (PlayMore == "1")
		{
			RPS();
		}
		if (PlayMore == "3")
		{
			Gameselect();
		}
		if (PlayMore == "2")
		{
			EndGame();

		}
		else
		{
			Console.WriteLine("Please choose a valid answer");
			Playagain();
		}
	}
	public static void PlayagainTTT(string[] Board1)
	{
		string PlayMore;
		Console.WriteLine("Would you like to Play again (1), stop playing (2) or choose a different game (3)");
		PlayMore = Console.ReadLine();
		if (PlayMore == "1")
		{
			Board1[0] = "a";
			Board1[1] = "b";
			Board1[2] = "c";
			Board1[3] = "d";
			Board1[4] = "e";
			Board1[5] = "f";
			Board1[6] = "g";
			Board1[7] = "h";
			Board1[8] = "i";
			TTT(Board1);
		}
		if (PlayMore == "3")
		{
			Gameselect();
		}
		if (PlayMore == "2")
		{
			EndGame();

		}
		else
		{
			Console.WriteLine("Please choose a valid answer");
			Playagain();
		}
	}


	public static void EndGame()
	{
		Console.WriteLine("Thanks for playing");
		Console.WriteLine("Shutting down in 5");
		System.Threading.Thread.Sleep(700);
		Console.WriteLine("4");
		System.Threading.Thread.Sleep(700);
		Console.WriteLine("3");
		System.Threading.Thread.Sleep(700);
		Console.WriteLine("2");
		System.Threading.Thread.Sleep(700);
		Console.WriteLine("1");
		System.Threading.Thread.Sleep(700);
		Environment.Exit(0);
	}
}

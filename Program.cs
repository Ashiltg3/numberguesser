int n = 0;
bool guessed = false;
void Easy(){
	Random rnd = new Random();
	int num = rnd.Next(1,11);
	int i = 0;
	int counter = 0;
	while(i == 0){	
		Console.WriteLine("I am thinking of a number from 1 to 10. Can you guess it?");
		int guessnum = Convert.ToInt32(Console.ReadLine());
		
		if (guessnum > num){
			Console.WriteLine("Oops! That's too high.");
		}
		else if (guessnum < num){
			Console.WriteLine("Oops! That's too low.");
		}
		else if (guessnum == num){
			Console.WriteLine($"Okay! You guessed it in the {counter + 1}th turn");
			i = 1;
			guessed = true;
		}
		if (counter > 3 && guessed != true){
			Console.WriteLine($"The number is in between {num-rnd.Next(2,4)} and {num + rnd.Next(2,4)}");
		}
		counter++;
		
		
	}
	Console.WriteLine("Do you want to play again?");
	string choice = Console.ReadLine();
	if (choice.ToLower() != "y"){
			n = 1;
		}
		else{
			n = 0;
		}
}

void Medium(){
	Random rnd = new Random();
	int num = rnd.Next(1,101);
	int i = 0;
	int counter = 0;
	while(i == 0){	
		Console.WriteLine("I am thinking of a number from 1 to 100. Can you guess it?");
		int guessnum = Convert.ToInt32(Console.ReadLine());
		
		if (guessnum > num){
			Console.WriteLine("Oops! That's too high.");
		}
		else if (guessnum < num){
			Console.WriteLine("Oops! That's too low.");
		}
		else if (guessnum == num){
			Console.WriteLine($"Okay! You guessed it in the {counter + 1}th turn");
			i = 1;
			guessed = true;
		}
		if (counter > 5 && guessed != true){
			Console.WriteLine($"The number is in between {num- rnd.Next(6,10)} and {num + rnd.Next(6,10)}");
		}
		counter++;
		
		
	}
	Console.WriteLine("Do you want to play again?");
	string choice = Console.ReadLine();
	if (choice.ToLower() != "y"){
			n = 1;
		}
		else{
			n = 0;
		}
}

void Hard(){
	Random rnd = new Random();
	int num = rnd.Next(1,1001);
	int i = 0;
	int counter = 0;
	while(i == 0){	
		Console.WriteLine("I am thinking of a number from 1 to 1000. Can you guess it?");
		int guessnum = Convert.ToInt32(Console.ReadLine());
		
		if (guessnum > num){
			Console.WriteLine("Oops! That's too high.");
		}
		else if (guessnum < num){
			Console.WriteLine("Oops! That's too low.");
		}
		else if (guessnum == num){
			Console.WriteLine($"Okay! You guessed it in the {counter + 1}th turn");
			i = 1;
			guessed = true;
		}
		if (counter > 10 && guessed != true){
			Console.WriteLine($"The number is in between {num - rnd.Next(30,40)} and {num + rnd.Next(30,40)}");
		}
		counter++;
		
		
	}
	Console.WriteLine("Do you want to play again?");
	string choice = Console.ReadLine();
	if (choice.ToLower() != "y"){
			n = 1;
		}
		else{
			n = 0;
		}
}
void Impossible(){
	Random rnd = new Random();
	int num = rnd.Next(1,10001);
	int i = 0;
	int counter = 0;
	while(i == 0){	
		Console.WriteLine("I am thinking of a number from 1 to 10000. Can you guess it?");
		int guessnum = Convert.ToInt32(Console.ReadLine());
		
		if (guessnum > num){
			Console.WriteLine("Oops! That's too high.");
		}
		else if (guessnum < num){
			Console.WriteLine("Oops! That's too low.");
		}
		else if (guessnum == num){
			Console.WriteLine($"Okay! You guessed it in the {counter + 1}th turn");
			i = 1;
			guessed = true;
		}
		if (counter > 15 && guessed != true){
			Console.WriteLine($"The number is in between {num- rnd.Next(60,80)} and {num + rnd.Next(60,80)}");
		}
		counter++;
		
		
	}
	Console.WriteLine("Do you want to play again?");
	string choice = Console.ReadLine();
	if (choice.ToLower() != "y"){
			n = 1;
		}
		else{
			n = 0;
		}
}


while (n == 0){
	Console.WriteLine("Welcome! Which mode do you feel?(Easy, Medium, Hard, Impossible)");
	string mode = Console.ReadLine();
	if (mode.ToLower() == "easy"){
		Easy();
	}
	else if (mode.ToLower() == "medium"){
		Medium();
	}
	else if (mode.ToLower() == "hard"){
		Hard();
	}
	else if (mode.ToLower() == "impossible"){
		Impossible();
	}
	else{
		Console.WriteLine("Please choose from the options.");
	}
}
//Tic Tac Toe
char[] gameArr = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
int player = 1, input = 0, condition;
char mark;

do{
    Console.Clear();
    gameBoard(gameArr);
    player = (player % 2 == 1) ? 1 : 2;

    if(player == 1){
        mark = 'X';
    }else{
        mark = 'O';
    }
    
    do{
        Console.Write($"Player {player} turn: ");
        try{
            input = Convert.ToInt32(Console.ReadLine());
            if(input <= 9 && input >= 1 && gameArr[input]!='X' && gameArr[input]!='O'){
                gameArr[input] = mark;
                Console.WriteLine(gameArr[input]);
                break;
            }else{
                Console.WriteLine("Input must be 1-9 and you can't choose the already choosen spot!\n");
            }
        }catch (Exception e){
            Console.WriteLine($"{e.Message}\n");
        }
    }while(true);

    player++;
    condition = checkWinner(gameArr);

}while(condition==2);

gameBoard(gameArr);
if(condition == 1){
    Console.WriteLine("It's a draw!");
}else{
    Console.WriteLine($"The Winner is Player {--player}!");
}

//Methods
static void gameBoard(char[] arr){
    Console.WriteLine("Let's play some Tic Tac Toe!\n");
    Console.WriteLine("Player 1 -> X\nPlayer 2 -> O\n");
    Console.WriteLine($"{arr[1]} | {arr[2]} | {arr[3]}");
    Console.WriteLine("---------");
    Console.WriteLine($"{arr[4]} | {arr[5]} | {arr[6]}");
    Console.WriteLine("---------");
    Console.WriteLine($"{arr[7]} | {arr[8]} | {arr[9]}\n");
}

static int checkWinner(char[] arr){
    if(arr[1] == arr[2] && arr[2] == arr[3]){
        return 0;
    }else if(arr[4] == arr[5] && arr[5] == arr[6]){
        return 0;
    }else if(arr[7] == arr[8] && arr[8] == arr[9]){
        return 0;
    }else if(arr[1] == arr[4] && arr[4] == arr[7]){
        return 0;
    }else if(arr[2] == arr[5] && arr[5] == arr[8]){
        return 0;
    }else if(arr[3] == arr[6] && arr[6] == arr[9]){
        return 0;
    }else if(arr[1] == arr[5] && arr[5] == arr[9]){
        return 0;
    }else if(arr[3] == arr[5] && arr[5] == arr[7]){
        return 0;
    }else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9'){
        return 1;
    }else{
        return 2;
    }
}


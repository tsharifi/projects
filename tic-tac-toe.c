/******************************************************************************
Computing 2131 Assignment 1 (Programming)
Moein Sharifi Moghaddam
T00665076

*******************************************************************************/
#include <stdio.h>
#include <time.h>
#include <stdlib.h>

char board[3][3]; // board game array 2D

// prints board
void print_board(){
    
    printf("\n"); 
    printf(" %c | %c | %c \n", board[0][0], board[0][1], board[0][2]); 
    printf("---|---|---\n"); 
    printf(" %c | %c | %c \n", board[1][0], board[1][1], board[1][2]); 
    printf("---|---|---\n");
    printf(" %c | %c | %c \n\n", board[2][0], board[2][1], board[2][2]); 
    
}

// initializes the board for the start o the game
void load_board(){
    
    for(int i = 0; i < 3; i++){
        
        for(int j = 0; j < 3; j++){
            
            if(board[i][j] == '\0'){
                board[i][j] = ' '; 
            }
        }
    }
}

//Takes User input and updates the board 
void user_input(){
    
    int x;  
    int y; 
    printf("Enter your X coordination: " ); 
    scanf("%d", &x); 
    printf("\n"); 
    printf("Enter your Y coordination: " ); 
    scanf("%d", &y); 
    
    x--; 
    y--; 
    
    if((x > 2 && x < 0) || (y > 2 && y < 0) || board[x][y] == 'X' || board[x][y] == 'O' ){
        
        printf("Coordination selected is invalid or already selected \n"); 
        user_input(); 
    } else {
        board[x][y] = 'X'; 
    }
}

// Takes computer input update tha board 
void computer_input(){
    
    int i, j; 
    i = rand() % 3; 
    j = rand() % 3; 
    
    if(board[i][j] == ' '){
        board[i][j] = 'O'; 
    } else {
        computer_input();
    }
}

// checks results to find winner, loser or game is a draw
int check_result(){
    
    int result = 0; 
    if(board[0][0] == 'X' && board[0][1] == 'X' && board[0][2] == 'X'){
        result = 1; 
    } else if (board[1][0] == 'X' && board[1][1] == 'X' && board[1][2] == 'X'){
        result = 1; 
    } else if (board[2][0] == 'X' && board[2][1] == 'X' && board[2][2] == 'X'){
        result = 1; 
    } else if (board[0][0] == 'X' && board[1][0] == 'X' && board[2][0] == 'X'){
        result = 1; 
    } else if (board[0][1] == 'X' && board[1][1] == 'X' && board[2][1] == 'X'){
        result = 1; 
    } else if (board[0][2] == 'X' && board[1][2] == 'X' && board[2][2] == 'X'){
        result = 1; 
    } else if (board[0][0] == 'X' && board[1][1] == 'X' && board[2][2] == 'X'){
        result = 1; 
    } else if(board[0][2] == 'X' && board[1][1] == 'X' && board[2][0] == 'X') { // check O win
        result = 1; 
    } else if(board[0][0] == 'O' && board[0][1] == 'O' && board[0][2] == 'O'){
        result = 2; 
    } else if (board[1][0] == 'O' && board[1][1] == 'O' && board[1][2] == 'O'){
        result = 2; 
    } else if (board[2][0] == 'O' && board[2][1] == 'O' && board[2][2] == 'O'){
        result = 2; 
    } else if (board[0][0] == 'O' && board[1][0] == 'O' && board[2][0] == 'O'){
        result = 2; 
    } else if (board[0][1] == 'O' && board[1][1] == 'O' && board[2][1] == 'O'){
        result = 2; 
    } else if (board[0][2] == 'O' && board[1][2] == 'O' && board[2][2] == 'O'){
        result = 2; 
    } else if (board[0][0] == 'O' && board[1][1] == 'O' && board[2][2] == 'O'){
        result = 2; 
    } else if(board[0][2] == 'O' && board[1][1] == 'O' && board[2][0] == 'O') {
        result = 2; 
    } else{
        result = 3; 
    }
    
    return result; 
}

// checks if all available rooms in board are used alrady or not
int is_full(){
    int count = 0; 
    for(int i = 0; i < 3; i++){
        for(int j = 0; j < 3; j++){
            if(board[i][j] == ' '){
                count++; 
            }
        }
    } 
        
    if(count >= 1){
        return 0;  
    } else {
        return 1;  
    }
}

int main()
{
    srand(time(NULL)); 
    load_board(); 
    print_board();
    while(is_full() == 0){
        user_input(); 
        print_board(); 
        if(is_full() == 1 || check_result() == 1){
            break; 
        }
        computer_input(); 
        printf("Computer move: \n"); 
        print_board(); 
        if(is_full() == 1 || check_result() == 2){
            break; 
        }       
    }
    
    int result = check_result();
    if(result == 1){
        printf("Congratulations You Have Won!\n"); 
    } else if ( result == 2){
        printf("Sorry You Lost!\n"); 
    } else {
        printf("The Game is a Draw!\n"); 
    }

    return 0;
}

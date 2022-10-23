using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Assignment_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           labels= new Label[3,3]
           {

           { slot00, slot01, slot02 },
           { slot10, slot11, slot12 },
           { slot20, slot21, slot22} 
           
           };


        }

        Random random = new Random();
        int[,] board = new int[3, 3];
        private Label[,] labels;

        const int empty = 2;

        private void button1_Click(object sender, EventArgs e)
        {
         
            int winner = playGame();

            if (winner == 0)
                displayWinner.Text = "Player O Wins";
            else if (winner == 1)
                displayWinner.Text = "Player X Wins";
            else
                displayWinner.Text = "Tie";
                                                         

        }


        private int playGame()
        {

            //clears board
            for (int row = 0; row < board.GetLength(0); row++) {


                for (int col = 0; col < board.GetLength(1); col++) { 
                
                board[row, col] = empty;
                    labels[row, col].Text = " ";
                
                }
            }
                                         
                          
          
            for (int turn = 0; turn < 9; turn++)
            {

                int row = turn / 3;
                int col = turn % 3;
                board[row, col] = random.Next(0, 2);


                labels[row, col].Text= board[row,col] == 0? "O": "X";


                if (checkWinner() == true)
                {
                   return board[row, col];
                }




            }
            return empty;



        }
        private bool checkWinner()
        {
            //row
            if (board[0, 0] != empty && (board[0, 0] == board[0, 1]) && (board[0, 1] == board[0, 2]))
            
                return true;
           
            if (board[1, 0] != empty && (board[1, 0] == board[1, 1]) && (board[1, 1] == board[1, 2]))

                return true;
            
            if (board[2, 0] != empty && (board[2, 0] == board[2, 1]) && (board[2, 1] == board[2, 2]))

                return true;
            //col
            if (board[0, 0] != empty && (board[0, 0] == board[1, 0]) && (board[1, 0] == board[2, 0]))

                return true;

            if (board[0, 1] != empty && (board[0, 1] == board[1, 1]) && (board[1, 1] == board[2, 1]))

                return true;

            if (board[0, 2] != empty && (board[0, 2] == board[1, 2]) && (board[1, 2] == board[2, 2]))

                return true;
            //diag
            if (board[0, 0] != empty && (board[0, 0] == board[1, 1]) && (board[1, 1] == board[2, 2]))

                return true;
            if (board[2, 0] != empty && (board[2, 0] == board[1, 1]) && (board[1, 1] == board[0, 2]))

                return true;
            
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAI_8Puzzle
{
    public partial class Form1 : Form
    {
        //Penggunaan class squareCoords
        //Puzzle state adalah state dari 8 puzzle yang ada pada groupBox "gbSolution"
        //Yang akan digunakan untuk checking state sekarang vs solution
        //Dan juga bisa digunakan untuk visualisasi
        squareCoords[,] puzzleState = new squareCoords[3, 3];
        squareCoords[,] goalState = new squareCoords[3, 3];
        squareCoords[,] startState = new squareCoords[3, 3];


        public Form1()
        {
            InitializeComponent();
        }

        private void initPuzzle()
        {
            int numCounter = 0;
            for (int i = 0; i < puzzleState.GetLength(0); i++)
            {
                for (int j = 0; j < puzzleState.GetLength(1); j++)
                {
                    puzzleState[i, j] = new squareCoords(0, 0, numCounter);
                    numCounter++;
                }
            }

            int temp = 0;
            foreach (Button btn in gbSolution.Controls)
            {
                while (!btn.Name.Contains(temp.ToString()))
                {
                    temp++;
                }

                foreach (squareCoords coords in puzzleState)
                {
                    if (coords.Number == temp)
                    {
                        coords.X = btn.Left;
                        coords.Y = btn.Top;

                        //rtbLog.Text += "puzzle coords= x: " + coords.X + " y: " + coords.Y + " number: " + coords.Number + " " + temp + " \n";

                    }
                }

                temp = 0;
            }

            for (int i = 0; i < puzzleState.GetLength(0); i++)
            {
                for (int j = 0; j < puzzleState.GetLength(1); j++)
                {
                    rtbLog.Text += "puzzle coords= x: " + puzzleState[i, j].X + " y: " + puzzleState[i, j].Y + " number: " + puzzleState[i, j].Number + " \n";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initPuzzle();
        }
    }
}

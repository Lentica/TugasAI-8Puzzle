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

        bool debug = true;//set debug flag, jika di set true maka akan ada logging dan message box pada operasi tertentu. Bisa juga untuk melakukan fungsi tertentu
        //yang dibutuhkan untuk debug. Kalau memungkinkan, saat membuat code debug berikan if untuk variable ini, supaya on/off debug mudah.

        int step = 0; //untuk setiap move, increment var ini.
        public Form1()
        {
            InitializeComponent();
        }

        //inisialisasi array puzzle
        private void initPuzzle()
        {
            int numCounter = 0;
            for (int i = 0; i < puzzleState.GetLength(0); i++)
            {
                for (int j = 0; j < puzzleState.GetLength(1); j++)
                {
                    //isi array puzzleState dengan objek squareCoords baru dengan isi x,y 0 dan angka dari kotak
                    puzzleState[i, j] = new squareCoords(0, 0, numCounter);
                    numCounter++;
                }
            }

            //check untuk setiap button dalam gbSolution untuk button dengan nama yang mengandung angka dalam var temp
            int temp = 0;
            foreach (Button btn in gbSolution.Controls)
            {
                while (!btn.Name.Contains(temp.ToString()))
                {
                    temp++;
                }

                //copy property Left dan Top dari button yang match dengan angka dalam var temp
                //ke dalam setiap objek yang ada dalam puzzleState
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

            //visualisasi array puzzleState sebagai sebuah 8 Puzzle
            for (int i = 0; i < puzzleState.GetLength(0); i++)
            {
                rtbLog.Text += "                 ";
                for (int j = 0; j < puzzleState.GetLength(1); j++)
                {
                    rtbLog.Text += puzzleState[i, j].Number + "       ";
                }
                rtbLog.Text += "\n\n";
            }

            rtbLog.Text += "\n\n\n";
            rtbLog.SelectionStart = rtbLog.Text.Length;
            rtbLog.ScrollToCaret();

            startState = puzzleState;
        }

        //visualisasi untuk setiap pergerakan yang dilakukan
        private void visualizeMove(squareCoords currSquare, squareCoords destSquare)
        {
            //Visualisasi menggunakan button (bugged)
            foreach (Button btn in gbSolution.Controls)
            {
                if (btn.Name.Contains(currSquare.Number.ToString()))
                {
                    btn.Left = destSquare.X;
                    btn.Top = destSquare.Y;
                }
            }
            foreach (Button btn in gbSolution.Controls)
            {
                if (btn.Name.Contains(destSquare.Number.ToString()))
                {
                    btn.Left = currSquare.X;
                    btn.Top = currSquare.Y;
                }
            }

            //visualisasi menggunakan richtextbox
            for (int i = 0; i < puzzleState.GetLength(0); i++)
            {
                rtbLog.Text += "                 ";
                for (int j = 0; j < puzzleState.GetLength(1); j++)
                {
                    rtbLog.Text +=puzzleState[i, j].Number + "       ";
                }
                rtbLog.Text += "\n\n";
            }
            rtbLog.Text += "\n\n\n";
            //set posisi cursor ke huruf terakhir dan scroll ke cursor tersebut
            //digunakan agar rich text box auto scroll ke bagian visualisasi text.
            rtbLog.SelectionStart = rtbLog.Text.Length;
            rtbLog.ScrollToCaret();
        }


        //Method yang digunakan untuk menggerakan square 0 dalam array puzzleState
        //int direction -> 0=atas, 1=kanan, 2=bawah, 3=kiri
        private void move(int direction)
        {
            //dokumentasi untuk method ini hanya ada pada direction==0 karena cara kerja sama pada yang lain.
            step++;
            labelStepCount.Text = step + "";
            bool found = false;
            if (direction == 0)
            {//atas

                //var temp untuk index objek yang memiliki Property 'Number'
                //dengan value 0
                int tempIndexI = 0, tempIndexJ = 0;

                //cari square dengan angka 0 dalam array puzzleState
                for (int i = 0; i < puzzleState.GetLength(0); i++)
                {
                    for (int j = 0; j < puzzleState.GetLength(1); j++)
                    {
                        //check apakah setiap objek yang dilewati memiliki Number=0
                        if (puzzleState[i, j].Number == 0)
                        {
                            //copy index nya lalu hentikan pencarian
                            found = true;
                            tempIndexI = i;
                            tempIndexJ = j;
                            if (debug)
                            {

                            }
                            break;
                        }
                    }
                }

                //jika square dengan Number=0 ditemukan maka found=true
                if (found)
                {
                    //check apakah objek tersebut ada di row teratas (row 0)
                    if (tempIndexI == 0)
                    {
                        if (debug)
                        {
                            //MessageBox.Show("this square is top most, cannot move up");
                            //do something
                        }
                        else
                        {
                            //do something
                        }
                    }
                    else
                    {
                        if (debug)
                        {
                            //copy isi dari kotak yang sekarang
                            squareCoords tempCurrSquare = new squareCoords(puzzleState[tempIndexI, tempIndexJ].X, puzzleState[tempIndexI, tempIndexJ].Y, puzzleState[tempIndexI, tempIndexJ].Number);

                            //copy isi dari kotak destinasi yang akan dipindah, karena ke atas maka index I (axis Y) di -1
                            squareCoords tempDestSquare = new squareCoords(puzzleState[tempIndexI - 1, tempIndexJ].X, puzzleState[tempIndexI - 1, tempIndexJ].Y, puzzleState[tempIndexI - 1, tempIndexJ].Number);

                            //tukar isi dari objek tersebut
                            puzzleState[tempIndexI, tempIndexJ] = tempDestSquare;
                            puzzleState[tempIndexI - 1, tempIndexJ] = tempCurrSquare;

                            //jalankan visualisasi
                            visualizeMove(tempCurrSquare, tempDestSquare);
                        }
                        else
                        {

                        }
                    }
                }
            }
            else if (direction == 1)
            {//kanan

                int tempIndexI = 0, tempIndexJ = 0;

                //cari square dengan angka 0 dalam array puzzleState
                for (int i = 0; i < puzzleState.GetLength(0); i++)
                {
                    for (int j = 0; j < puzzleState.GetLength(1); j++)
                    {
                        if (puzzleState[i, j].Number == 0)
                        {
                            found = true;
                            tempIndexI = i;
                            tempIndexJ = j;
                            if (debug)
                            {

                            }
                            break;
                        }
                    }
                }

                //jika square dengan angka 0 ditemukan maka found=true
                if (found)
                {
                    if (tempIndexJ == 2)
                    {
                        if (debug)
                        {
                            //MessageBox.Show("this square is right most, cannot move right");
                            //do something
                        }
                        else
                        {
                            //do something
                        }
                    }
                    else
                    {
                        if (debug)
                        {
                            squareCoords tempCurrSquare = new squareCoords(puzzleState[tempIndexI, tempIndexJ].X, puzzleState[tempIndexI, tempIndexJ].Y, puzzleState[tempIndexI, tempIndexJ].Number);

                            squareCoords tempDestSquare = new squareCoords(puzzleState[tempIndexI, tempIndexJ + 1].X, puzzleState[tempIndexI, tempIndexJ + 1].Y, puzzleState[tempIndexI, tempIndexJ + 1].Number);

                            puzzleState[tempIndexI, tempIndexJ] = tempDestSquare;
                            puzzleState[tempIndexI, tempIndexJ + 1] = tempCurrSquare;

                            visualizeMove(tempCurrSquare, tempDestSquare);
                        }
                        else
                        {

                        }
                    }
                }
            }
            else if (direction == 2)
            {//bawah
                int tempIndexI = 0, tempIndexJ = 0;

                //cari square dgn angka 0
                for (int i = 0; i < puzzleState.GetLength(0); i++)
                {
                    for (int j = 0; j < puzzleState.GetLength(1); j++)
                    {
                        if (puzzleState[i, j].Number == 0)
                        {
                            found = true;
                            tempIndexI = i;
                            tempIndexJ = j;
                            if (debug)
                            {
                                //rtbLog.Text += "square 0 is found! index X square 0: " + tempIndexI + " index Y square 0: " + tempIndexJ+" \n";
                            }
                            break;
                        }
                    }
                }

                if (found)
                {
                    if (tempIndexI == 2)
                    {
                        if (debug)
                        {
                            //MessageBox.Show("this square is bottom most, cannot move down");
                            //do something
                        }
                        else
                        {
                            //do something
                        }
                    }
                    else
                    {
                        if (debug)
                        {
                            squareCoords tempCurrSquare = new squareCoords(puzzleState[tempIndexI, tempIndexJ].X, puzzleState[tempIndexI, tempIndexJ].Y, puzzleState[tempIndexI, tempIndexJ].Number);

                            squareCoords tempDestSquare = new squareCoords(puzzleState[tempIndexI + 1, tempIndexJ].X, puzzleState[tempIndexI + 1, tempIndexJ].Y, puzzleState[tempIndexI + 1, tempIndexJ].Number);

                            puzzleState[tempIndexI + 1, tempIndexJ] = tempCurrSquare;
                            puzzleState[tempIndexI, tempIndexJ] = tempDestSquare;

                            visualizeMove(tempCurrSquare, tempDestSquare);
                        }
                        else
                        {

                        }
                    }
                }
            }
            else if (direction == 3)
            {//kiri

                int tempIndexI = 0, tempIndexJ = 0;

                //cari square dengan angka 0 dalam array puzzleState
                for (int i = 0; i < puzzleState.GetLength(0); i++)
                {
                    for (int j = 0; j < puzzleState.GetLength(1); j++)
                    {
                        if (puzzleState[i, j].Number == 0)
                        {
                            found = true;
                            tempIndexI = i;
                            tempIndexJ = j;
                            if (debug)
                            {

                            }
                            break;
                        }
                    }
                }

                //jika square dengan angka 0 ditemukan maka found=true
                if (found)
                {
                    if (tempIndexJ == 0)
                    {
                        if (debug)
                        {
                            //MessageBox.Show("this square is left most, cannot move left");
                            //do something
                        }
                        else
                        {
                            //do something
                        }
                    }
                    else
                    {
                        if (debug)
                        {
                            squareCoords tempCurrSquare = new squareCoords(puzzleState[tempIndexI, tempIndexJ].X, puzzleState[tempIndexI, tempIndexJ].Y, puzzleState[tempIndexI, tempIndexJ].Number);

                            squareCoords tempDestSquare = new squareCoords(puzzleState[tempIndexI, tempIndexJ - 1].X, puzzleState[tempIndexI, tempIndexJ - 1].Y, puzzleState[tempIndexI, tempIndexJ - 1].Number);

                            puzzleState[tempIndexI, tempIndexJ] = tempDestSquare;
                            puzzleState[tempIndexI, tempIndexJ - 1] = tempCurrSquare;

                            visualizeMove(tempCurrSquare, tempDestSquare);
                        }
                        else
                        {

                        }
                    }

                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            initPuzzle();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (debug)
            {
                if (e.KeyCode == Keys.W)
                {
                    move(0);
                }
                else if (e.KeyCode == Keys.D)
                {
                    move(1);
                }
                else if (e.KeyCode == Keys.S)
                {
                    move(2);
                }
                else if (e.KeyCode == Keys.A)
                {
                    move(3);
                }
            }
        }
    }
}

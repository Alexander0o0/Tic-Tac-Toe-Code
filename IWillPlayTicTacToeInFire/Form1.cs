using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IWillPlayTicTacToeInFire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int turn = 1;
        char Box = ' ';
        public void button_Click(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            var arr = new char[2, 2];

            if (turn == 1)
            {
                char Box = 'X';
                ((Button)sender).Text = Box.ToString();
                turn = turn + 1;
                button.Enabled = false;
            }
            else if (turn == 2)
            {
                char Box = 'O';
                ((Button)sender).Text = Box.ToString();
                turn = turn - 1;
                button.Enabled = false;
            }

            var location = ((Button)sender).Name.Substring(6, 1);

            if (location == "1")
            {
                arr[0, 0] = Box;
                Console.WriteLine(arr);
            }
            else if (location == "2")
            {
                arr[0, 1] = Box;
                Console.WriteLine(arr);
            }
            else if (location == "3")
            {
                arr[0, 2] = Box;
                Console.WriteLine(arr);
            }
            else if (location == "4")
            {
                arr[1, 0] = Box;
                Console.WriteLine(arr);
            }
            else if (location == "5")
            {
                arr[1, 1] = Box;
                Console.WriteLine(arr);
            }
            else if (location == "6")
            {
                arr[1, 2] = Box;
                Console.WriteLine(arr);
            }
            else if (location == "7")
            {
                arr[2, 0] = Box;
                Console.WriteLine(arr);
            }
            else if (location == "8")
            {
                arr[2, 1] = Box;
                Console.WriteLine(arr);
            }
            else if (location == "9")
            {
                arr[2, 2] = Box;
                Console.WriteLine(arr);
            }
        }
    }
}

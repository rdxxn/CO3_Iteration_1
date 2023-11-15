using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iteration_1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlayClick(object sender, EventArgs e)
        {
            new MapSelectMenu().Show(); //Opens MapSelectMenu form
            this.Hide(); //Closes MainMenu form
        }

        private void QuitClick(object sender, EventArgs e)
        {
            Application.Exit(); //Exits the program
        }

        private void LeaderBoardClick(object sender, EventArgs e)
        {
            new LeaderBoard().Show(); //Opens LeaderBoard form
            this.Hide(); //Closes MainMenu form
        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

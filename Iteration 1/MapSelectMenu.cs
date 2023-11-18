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
    public partial class MapSelectMenu : Form
    {
        SelectedMap map = SelectedMap.Map1; //Defaults the selected value to Map1
        enum SelectedMap
        {
            Map1,
            Map2,
            Map3
        }
        public MapSelectMenu()
        {
            InitializeComponent();
        }

        private void MapSelectMenu_Load(object sender, EventArgs e)
        {

        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Exits the program fully when pressing x button
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show(); //Opens LeaderBoard form
            mainMenu.Size = new Size(Convert.ToInt32(this.Width), Convert.ToInt32(this.Height)); //Matches the mainMenu forms size with the size of the MainMenu form
            if (this.WindowState == FormWindowState.Maximized) { mainMenu.WindowState = FormWindowState.Maximized; } //If the MainMenu form was maximised, Maximise the mainMenu form
            mainMenu.DesktopLocation = new Point(Convert.ToInt32(this.DesktopLocation.X), Convert.ToInt32(this.DesktopLocation.Y)); //Matches the position of mainMenu form with the MainMenu form
            this.Hide(); //Hides MapSelectMenu form
        }

        private void btnForwardsPlaceholder_Click(object sender, EventArgs e)
        {
            DifficultySelectMenu difficultySelectMenu = new DifficultySelectMenu();
            difficultySelectMenu.Show(); //Opens LeaderBoard form
            difficultySelectMenu.Size = new Size(Convert.ToInt32(this.Width), Convert.ToInt32(this.Height)); //Matches the difficultySelectMenu forms size with the size of the MainMenu form
            if (this.WindowState == FormWindowState.Maximized) { difficultySelectMenu.WindowState = FormWindowState.Maximized; } //If the MainMenu form was maximised, Maximise the difficultySelectMenu form
            difficultySelectMenu.DesktopLocation = new Point(Convert.ToInt32(this.DesktopLocation.X), Convert.ToInt32(this.DesktopLocation.Y)); //Matches the position of difficultySelectMenu form with the MainMenu form
            this.Hide(); //Hides MainMenu form
        }

        private void btnMap1_Click(object sender, EventArgs e)
        {
            map = SelectedMap.Map1;

        }

        private void btnMap2_Click(object sender, EventArgs e)
        {
            map = SelectedMap.Map2;

        }

        private void btnMap3_Click(object sender, EventArgs e)
        {
            map = SelectedMap.Map3;

        }
    }
}

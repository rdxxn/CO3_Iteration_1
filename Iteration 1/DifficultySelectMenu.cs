﻿using System;
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
    public partial class DifficultySelectMenu : Form
    {
        public DifficultySelectMenu()
        {
            InitializeComponent();
        }

        private void DifficultySelectMenu_Load(object sender, EventArgs e)
        {

        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Exits the program fully when pressing x button
        }
    }
}

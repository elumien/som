﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Organizing_Map
{
    public partial class BaseForm : Form
    {
        protected int IterationLimit { get; set; }
        protected double InitialStandardDeviation { get; set; }
        protected double FinalStandardDeviation { get; set; }
        protected double InitialLearningRateCoefficient { get; set; }

        public BaseForm()
        {
            InitializeComponent();
        }

        protected void SetCommonParametersFromUserInterface()
        {
            timeLabel.Text = "";
            IterationLimit = (int)iterationLimitNumericUpDown.Value;
            InitialStandardDeviation = (double)initialStandardDeviationNumericUpDown.Value;
            FinalStandardDeviation = (double)finalStandardDeviationNumericUpDown.Value;
            InitialLearningRateCoefficient = (double)initialLearningRateCoefficientNumericUpDown.Value;
        }
    }
}

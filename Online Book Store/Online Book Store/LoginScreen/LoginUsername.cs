﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store
{
    /**   
    * @brief    This file includes login username operations.
    */
    public partial class LoginUsername : UserControl
    {
        public LoginUsername()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string GetSetText { get => tbUsername.Text; set => tbUsername.Text = value; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03.WindowsFormUI
{
    public partial class FormCustomerDetails : Form
    {
        public FormCustomerDetails()
        {
            InitializeComponent();
        }

        public BindingSource CustomerCardBindingSource { get { return this.customerCardBindingSource; }  set { } }
    }
}
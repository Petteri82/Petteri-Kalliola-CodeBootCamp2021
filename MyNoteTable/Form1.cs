﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNoteTable
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Messages", typeof(string));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 140;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Clear boxes
            txtTitle.Clear();
            txtMessage.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Add rows to table
            table.Rows.Add(txtTitle.Text, txtMessage.Text);
            
            // Clear boxes
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete fron GridView and Title/Message boxes
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();

            txtTitle.Clear();
            txtMessage.Clear();
        }
    }
}

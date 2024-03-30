﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTracker
{
    public partial class tabCALENDAR : UserControl
    {
        public static int _year, _month;
        public tabCALENDAR()
        {
            InitializeComponent();
        }

        private void tabCALENDAR_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showDays(_month, _year);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            showDays(_month, _year);
        }

        private void showDays(int month, int year)
        {
            tableLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lblMonth.Text = monthName.ToUpper() + " " + year;
            DateTime startofTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startofTheMonth.DayOfWeek.ToString("d")) + 1;

            tableLayoutPanel1.ColumnStyles.Clear(); // Clear existing column styles
            tableLayoutPanel1.RowStyles.Clear(); // Clear existing row styles
            tableLayoutPanel1.ColumnCount = 7; // Assuming 7 days in a week
            tableLayoutPanel1.RowCount = week; // No header row

            for (int i = 1; i < week; i++)
            {
                CdDay cd = new CdDay(" ");
                tableLayoutPanel1.Controls.Add(cd);
            }

            for (int i = 1; i <= day; i++)
            {
                CdDay cd = new CdDay(i + " ");
                tableLayoutPanel1.Controls.Add(cd);
            }

            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent));
            }

            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
            }
        }
    }
}

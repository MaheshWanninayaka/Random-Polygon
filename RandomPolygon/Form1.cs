﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPolygon
{
    public partial class Form1 : Form
    {

        int[] x = new int[100];
        int[] y = new int[100];
        int points;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayLine(int x1, int y1, int x2, int y2)
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(Pens.Black, x1, panel1.Height - y1, x2, panel1.Height - y2);
        }

        private void DeleteLine(int x1, int y1, int x2, int y2)
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(Pens.White, x1, panel1.Height - y1, x2, panel1.Height - y2);
        }

        private void DrawPolygon()
        {
            int i, j;
            for (i = 0; i < points; i++)
            {
                j = (i + 1) % points;
                DisplayLine(x[i], y[i], x[j], y[j]);
            }
        }

        private void DeletePolygon()
        {
            int i, j;
            for (i = 0; i < points; i++)
            {
                j = (i + 1) % points;
                DeleteLine(x[i], y[i], x[j], y[j]);
            }
        }

        private long t(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            return x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
        }

        private Boolean isTwoSides(int i, int j)
        {
            int k;
            bool n, p;
            long value;
            n = false;
            p = false;

            for (k = 0; k < points; k++)
            {
                value = t(x[i], y[i], x[j], y[j], x[k], y[k]);
                if (value == 0)
                {
                    if ((i != k) && (j != k))
                    {
                        return true;
                    }
                }
                else if (value < 0)
                {
                    n = true;
                }
                else
                {
                    p = true;
                }
            }

            if ((n == true) && (p == false))
            {
                return false;
            }
            else if ((n == false) && (p == true))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void button_Genarate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Boolean found;
            Boolean convex;
            int i, j;

            points = int.Parse(textBox_Vertices.Text);

            found = false;
            while (!found)
            {
                convex = true;

                for (i = 0; i < points; i++)
                {
                    x[i] = r.Next(0, panel1.Width);
                    y[i] = r.Next(0, panel1.Height);
                }

                for (i = 0; i < points; i++)
                {
                    j = (i + 1) % points;
                    if (isTwoSides(i, j))
                    {
                        convex = false;
                        break;
                    }
                }

                if (convex)
                {
                    DrawPolygon();
                    found = true;
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            DeletePolygon();
        }
    }
}

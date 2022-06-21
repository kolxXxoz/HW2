using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace risovach
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GenerateNewTile();
            GenerateNewTile();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            using (var p = new Pen(Color.Black, 2))
            {
                var x = 110;

                g.DrawLine(p, x - 1, 25, x - 1, 500);
                g.DrawLine(p, 2 * x - 1, 25, 2 * x - 1, 500);
                g.DrawLine(p, 3 * x - 1, 25, 3 * x - 1, 500);

                g.DrawLine(p, 0, x + 15, 4 * x, x + 15);
                g.DrawLine(p, 0, 2 * x + 15, 4 * x, 2 * x + 15);
                g.DrawLine(p, 0, 3 * x + 15, 4 * x, 3 * x + 15);
            }
        }

        public void GenerateNewTile()
        {
            var Labels = new Dictionary<int, Label>() 
            {
                { 0, label1 },
                { 1, label2 },
                { 2, label3 },
                { 3, label4 },
                { 4, label5 },
                { 5, label6 },
                { 6, label7 },
                { 7, label8 },
                { 8, label9 },
                { 9, label10 },
                { 10, label11 },
                { 11, label12 },
                { 12, label13 },
                { 13, label14 },
                { 14, label15 },
                { 15, label16 },
            };
            
            var rnd = new Random();
            var i = rnd.Next(16);
            
            if (Labels[i].Text == "")
            {
                if (rnd.Next(10) == 9)
                    Labels[i].Text = "4";
                else
                    Labels[i].Text = "2";
            }

            else
            {
                var j = i + 1;

                while (j != i)
                {
                    if (j >= 16)
                        j = 0;

                    if (Labels[j].Text == "")
                    {
                        if (rnd.Next(10) == 9)
                            Labels[j].Text = "4";
                        else
                            Labels[j].Text = "2";

                        break;
                    }

                    j++;
                }
            }
        }

        private void MenuItemStart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            var formL = new L();
            var formW = new W();

            if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" &&
                label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" &&
                label9.Text != "" && label10.Text != "" && label11.Text != "" && label12.Text != "" &&
                label13.Text != "" && label14.Text != "" && label15.Text != "" && label16.Text != "" &&
                label1.Text != label2.Text && label1.Text != label5.Text &&
                label2.Text != label3.Text && label2.Text != label6.Text &&
                label3.Text != label4.Text && label3.Text != label7.Text && label4.Text != label8.Text &&
                label5.Text != label6.Text && label5.Text != label9.Text &&
                label6.Text != label7.Text && label6.Text != label10.Text &&
                label7.Text != label8.Text && label7.Text != label11.Text && label8.Text != label12.Text &&
                label9.Text != label10.Text && label9.Text != label13.Text &&
                label10.Text != label11.Text && label10.Text != label14.Text &&
                label11.Text != label12.Text && label11.Text != label15.Text && label12.Text != label16.Text &&
                label13.Text != label14.Text && label14.Text != label15.Text && label15.Text != label16.Text)
                formL.Show();

            if (e.KeyCode == Keys.Left)
            {
                if (label3.Text != "")
                {
                    if (label4.Text == "")
                    {
                        label4.Text = label3.Text;
                        label3.Text = "";
                    }

                    else if (label4.Text == label3.Text)
                    {
                        label4.Text = $"{int.Parse(label4.Text) * 2}";
                        label3.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label4.Text)}";
                    }
                }

                if (label2.Text != "")
                {
                    if (label3.Text == "")
                    {
                        if (label4.Text == "")
                        {
                            label4.Text = label2.Text;
                            label2.Text = "";
                        }

                        else if (label4.Text == label2.Text)
                        {
                            label4.Text = $"{int.Parse(label4.Text) * 2}";
                            label2.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label4.Text)}";
                        }

                        else
                        {
                            label3.Text = label2.Text;
                            label2.Text = "";
                        }
                    }

                    else if (label3.Text == label2.Text)
                    {
                        label3.Text = $"{int.Parse(label3.Text) * 2}";
                        label2.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label3.Text)}";
                    }
                }

                if (label1.Text != "")
                {
                    if (label2.Text == "")
                    {
                        if (label3.Text == "")
                        {
                            if (label4.Text == "")
                            {
                                label4.Text = label1.Text;
                                label1.Text = "";
                            }

                            else if (label4.Text == label1.Text)
                            {
                                label4.Text = $"{int.Parse(label4.Text) * 2}";
                                label1.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label4.Text)}";
                            }

                            else
                            {
                                label3.Text = label1.Text;
                                label1.Text = "";
                            }
                        }

                        else if (label3.Text == label1.Text)
                        {
                            label3.Text = $"{int.Parse(label3.Text) * 2}";
                            label1.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label3.Text)}";
                        }

                        else
                        {
                            label2.Text = label1.Text;
                            label1.Text = "";
                        }
                    }

                    else if (label2.Text == label1.Text)
                    {
                        label2.Text = $"{int.Parse(label2.Text) * 2}";
                        label1.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label2.Text)}";
                    }
                }

                if (label7.Text != "")
                {
                    if (label8.Text == "")
                    {
                        label8.Text = label7.Text;
                        label7.Text = "";
                    }

                    else if (label8.Text == label7.Text)
                    {
                        label8.Text = $"{int.Parse(label8.Text) * 2}";
                        label7.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label8.Text)}";
                    }
                }

                if (label6.Text != "")
                {
                    if (label7.Text == "")
                    {
                        if (label8.Text == "")
                        {
                            label8.Text = label6.Text;
                            label6.Text = "";
                        }

                        else if (label8.Text == label6.Text)
                        {
                            label8.Text = $"{int.Parse(label8.Text) * 2}";
                            label6.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label8.Text)}";
                        }

                        else
                        {
                            label7.Text = label6.Text;
                            label6.Text = "";
                        }
                    }

                    else if (label7.Text == label6.Text)
                    {
                        label7.Text = $"{int.Parse(label7.Text) * 2}";
                        label6.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label7.Text)}";
                    }
                }

                if (label5.Text != "")
                {
                    if (label6.Text == "")
                    {
                        if (label7.Text == "")
                        {
                            if (label8.Text == "")
                            {
                                label8.Text = label5.Text;
                                label5.Text = "";
                            }

                            else if (label8.Text == label5.Text)
                            {
                                label8.Text = $"{int.Parse(label8.Text) * 2}";
                                label5.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label8.Text)}";
                            }

                            else
                            {
                                label7.Text = label5.Text;
                                label5.Text = "";
                            }
                        }

                        else if (label7.Text == label5.Text)
                        {
                            label7.Text = $"{int.Parse(label7.Text) * 2}";
                            label5.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label7.Text)}";
                        }

                        else
                        {
                            label6.Text = label5.Text;
                            label5.Text = "";
                        }
                    }

                    else if (label6.Text == label5.Text)
                    {
                        label6.Text = $"{int.Parse(label6.Text) * 2}";
                        label5.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label6.Text)}";
                    }
                }

                if (label11.Text != "")
                {
                    if (label12.Text == "")
                    {
                        label12.Text = label11.Text;
                        label11.Text = "";
                    }

                    else if (label12.Text == label11.Text)
                    {
                        label12.Text = $"{int.Parse(label12.Text) * 2}";
                        label11.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label12.Text)}";
                    }
                }

                if (label10.Text != "")
                {
                    if (label11.Text == "")
                    {
                        if (label12.Text == "")
                        {
                            label12.Text = label10.Text;
                            label10.Text = "";
                        }

                        else if (label12.Text == label10.Text)
                        {
                            label12.Text = $"{int.Parse(label12.Text) * 2}";
                            label10.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label12.Text)}";
                        }

                        else
                        {
                            label11.Text = label10.Text;
                            label10.Text = "";
                        }
                    }

                    else if (label11.Text == label10.Text)
                    {
                        label11.Text = $"{int.Parse(label11.Text) * 2}";
                        label10.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label11.Text)}";
                    }
                }

                if (label9.Text != "")
                {
                    if (label10.Text == "")
                    {
                        if (label11.Text == "")
                        {
                            if (label12.Text == "")
                            {
                                label12.Text = label9.Text;
                                label9.Text = "";
                            }

                            else if (label12.Text == label9.Text)
                            {
                                label12.Text = $"{int.Parse(label12.Text) * 2}";
                                label9.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label12.Text)}";
                            }

                            else
                            {
                                label11.Text = label9.Text;
                                label9.Text = "";
                            }
                        }

                        else if (label11.Text == label9.Text)
                        {
                            label11.Text = $"{int.Parse(label11.Text) * 2}";
                            label9.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label11.Text)}";
                        }

                        else
                        {
                            label10.Text = label9.Text;
                            label9.Text = "";
                        }
                    }

                    else if (label10.Text == label9.Text)
                    {
                        label10.Text = $"{int.Parse(label10.Text) * 2}";
                        label9.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label10.Text)}";
                    }
                }

                if (label15.Text != "")
                {
                    if (label16.Text == "")
                    {
                        label16.Text = label15.Text;
                        label15.Text = "";
                    }

                    else if (label16.Text == label15.Text)
                    {
                        label16.Text = $"{int.Parse(label16.Text) * 2}";
                        label15.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label16.Text)}";
                    }
                }

                if (label14.Text != "")
                {
                    if (label15.Text == "")
                    {
                        if (label16.Text == "")
                        {
                            label16.Text = label14.Text;
                            label14.Text = "";
                        }

                        else if (label16.Text == label14.Text)
                        {
                            label16.Text = $"{int.Parse(label16.Text) * 2}";
                            label14.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label16.Text)}";
                        }

                        else
                        {
                            label15.Text = label14.Text;
                            label14.Text = "";
                        }
                    }

                    else if (label15.Text == label14.Text)
                    {
                        label15.Text = $"{int.Parse(label15.Text) * 2}";
                        label14.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label15.Text)}";
                    }
                }

                if (label13.Text != "")
                {
                    if (label14.Text == "")
                    {
                        if (label15.Text == "")
                        {
                            if (label16.Text == "")
                            {
                                label16.Text = label13.Text;
                                label13.Text = "";
                            }

                            else if (label16.Text == label13.Text)
                            {
                                label16.Text = $"{int.Parse(label16.Text) * 2}";
                                label13.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label16.Text)}";
                            }

                            else
                            {
                                label15.Text = label13.Text;
                                label13.Text = "";
                            }
                        }

                        else if (label15.Text == label13.Text)
                        {
                            label15.Text = $"{int.Parse(label15.Text) * 2}";
                            label13.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label15.Text)}";
                        }

                        else
                        {
                            label14.Text = label13.Text;
                            label13.Text = "";
                        }
                    }

                    else if (label14.Text == label13.Text)
                    {
                        label14.Text = $"{int.Parse(label14.Text) * 2}";
                        label13.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label14.Text)}";
                    }
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (label2.Text != "")
                {
                    if (label1.Text == "")
                    {
                        label1.Text = label2.Text;
                        label2.Text = "";
                    }

                    else if (label1.Text == label2.Text)
                    {
                        label1.Text = $"{int.Parse(label1.Text) * 2}";
                        label2.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label1.Text)}";
                    }
                }

                if (label3.Text != "")
                {
                    if (label2.Text == "")
                    {
                        if (label1.Text == "")
                        {
                            label1.Text = label3.Text;
                            label3.Text = "";
                        }

                        else if (label1.Text == label3.Text)
                        {
                            label1.Text = $"{int.Parse(label1.Text) * 2}";
                            label3.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label1.Text)}";
                        }

                        else
                        {
                            label2.Text = label3.Text;
                            label3.Text = "";
                        }
                    }

                    else if (label3.Text == label2.Text)
                    {
                        label2.Text = $"{int.Parse(label2.Text) * 2}";
                        label3.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label2.Text)}";
                    }
                }

                if (label4.Text != "")
                {
                    if (label3.Text == "")
                    {
                        if (label2.Text == "")
                        {
                            if (label1.Text == "")
                            {
                                label1.Text = label4.Text;
                                label4.Text = "";
                            }

                            else if (label1.Text == label4.Text)
                            {
                                label1.Text = $"{int.Parse(label1.Text) * 2}";
                                label4.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label1.Text)}";
                            }

                            else
                            {
                                label2.Text = label4.Text;
                                label4.Text = "";
                            }
                        }

                        else if (label2.Text == label4.Text)
                        {
                            label2.Text = $"{int.Parse(label2.Text) * 2}";
                            label4.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label2.Text)}";
                        }

                        else
                        {
                            label3.Text = label4.Text;
                            label4.Text = "";
                        }
                    }

                    else if (label3.Text == label4.Text)
                    {
                        label3.Text = $"{int.Parse(label3.Text) * 2}";
                        label4.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label3.Text)}";
                    }
                }

                if (label6.Text != "")
                {
                    if (label5.Text == "")
                    {
                        label5.Text = label6.Text;
                        label6.Text = "";
                    }

                    else if (label5.Text == label6.Text)
                    {
                        label5.Text = $"{int.Parse(label5.Text) * 2}";
                        label6.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label5.Text)}";
                    }
                }

                if (label7.Text != "")
                {
                    if (label6.Text == "")
                    {
                        if (label5.Text == "")
                        {
                            label5.Text = label7.Text;
                            label7.Text = "";
                        }

                        else if (label5.Text == label7.Text)
                        {
                            label5.Text = $"{int.Parse(label5.Text) * 2}";
                            label7.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label5.Text)}";
                        }

                        else
                        {
                            label6.Text = label7.Text;
                            label7.Text = "";
                        }
                    }

                    else if (label7.Text == label6.Text)
                    {
                        label6.Text = $"{int.Parse(label6.Text) * 2}";
                        label7.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label6.Text)}";
                    }
                }

                if (label8.Text != "")
                {
                    if (label7.Text == "")
                    {
                        if (label6.Text == "")
                        {
                            if (label5.Text == "")
                            {
                                label5.Text = label8.Text;
                                label8.Text = "";
                            }

                            else if (label5.Text == label8.Text)
                            {
                                label5.Text = $"{int.Parse(label5.Text) * 2}";
                                label8.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label5.Text)}";
                            }

                            else
                            {
                                label6.Text = label8.Text;
                                label8.Text = "";
                            }
                        }

                        else if (label6.Text == label8.Text)
                        {
                            label6.Text = $"{int.Parse(label6.Text) * 2}";
                            label8.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label6.Text)}";
                        }

                        else
                        {
                            label7.Text = label8.Text;
                            label8.Text = "";
                        }
                    }

                    else if (label7.Text == label8.Text)
                    {
                        label7.Text = $"{int.Parse(label7.Text) * 2}";
                        label8.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label7.Text)}";
                    }
                }

                if (label10.Text != "")
                {
                    if (label9.Text == "")
                    {
                        label9.Text = label10.Text;
                        label10.Text = "";
                    }

                    else if (label9.Text == label10.Text)
                    {
                        label9.Text = $"{int.Parse(label9.Text) * 2}";
                        label10.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label9.Text)}";
                    }
                }

                if (label11.Text != "")
                {
                    if (label10.Text == "")
                    {
                        if (label9.Text == "")
                        {
                            label9.Text = label11.Text;
                            label11.Text = "";
                        }

                        else if (label9.Text == label11.Text)
                        {
                            label9.Text = $"{int.Parse(label9.Text) * 2}";
                            label11.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label9.Text)}";
                        }

                        else
                        {
                            label10.Text = label11.Text;
                            label11.Text = "";
                        }
                    }

                    else if (label10.Text == label11.Text)
                    {
                        label10.Text = $"{int.Parse(label10.Text) * 2}";
                        label11.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label10.Text)}";
                    }
                }

                if (label12.Text != "")
                {
                    if (label11.Text == "")
                    {
                        if (label10.Text == "")
                        {
                            if (label9.Text == "")
                            {
                                label9.Text = label12.Text;
                                label12.Text = "";
                            }

                            else if (label9.Text == label12.Text)
                            {
                                label9.Text = $"{int.Parse(label9.Text) * 2}";
                                label12.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label9.Text)}";
                            }

                            else
                            {
                                label10.Text = label12.Text;
                                label12.Text = "";
                            }
                        }

                        else if (label10.Text == label12.Text)
                        {
                            label10.Text = $"{int.Parse(label10.Text) * 2}";
                            label12.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label10.Text)}";
                        }

                        else
                        {
                            label11.Text = label12.Text;
                            label12.Text = "";
                        }
                    }

                    else if (label11.Text == label12.Text)
                    {
                        label11.Text = $"{int.Parse(label11.Text) * 2}";
                        label12.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label11.Text)}";
                    }
                }

                if (label14.Text != "")
                {
                    if (label13.Text == "")
                    {
                        label13.Text = label14.Text;
                        label14.Text = "";
                    }

                    else if (label13.Text == label14.Text)
                    {
                        label13.Text = $"{int.Parse(label13.Text) * 2}";
                        label14.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label13.Text)}";
                    }
                }

                if (label15.Text != "")
                {
                    if (label14.Text == "")
                    {
                        if (label13.Text == "")
                        {
                            label13.Text = label15.Text;
                            label15.Text = "";
                        }

                        else if (label13.Text == label15.Text)
                        {
                            label13.Text = $"{int.Parse(label13.Text) * 2}";
                            label15.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label13.Text)}";
                        }

                        else
                        {
                            label14.Text = label15.Text;
                            label15.Text = "";
                        }
                    }

                    else if (label14.Text == label15.Text)
                    {
                        label14.Text = $"{int.Parse(label14.Text) * 2}";
                        label15.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label14.Text)}";
                    }
                }

                if (label16.Text != "")
                {
                    if (label15.Text == "")
                    {
                        if (label14.Text == "")
                        {
                            if (label13.Text == "")
                            {
                                label13.Text = label16.Text;
                                label16.Text = "";
                            }

                            else if (label13.Text == label16.Text)
                            {
                                label13.Text = $"{int.Parse(label13.Text) * 2}";
                                label16.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label13.Text)}";
                            }

                            else
                            {
                                label14.Text = label16.Text;
                                label16.Text = "";
                            }
                        }

                        else if (label14.Text == label16.Text)
                        {
                            label14.Text = $"{int.Parse(label14.Text) * 2}";
                            label16.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label14.Text)}";
                        }

                        else
                        {
                            label15.Text = label16.Text;
                            label16.Text = "";
                        }
                    }

                    else if (label15.Text == label16.Text)
                    {
                        label15.Text = $"{int.Parse(label15.Text) * 2}";
                        label16.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label15.Text)}";
                    }
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (label8.Text != "")
                {
                    if (label4.Text == "")
                    {
                        label4.Text = label8.Text;
                        label8.Text = "";
                    }

                    else if (label4.Text == label8.Text)
                    {
                        label4.Text = $"{int.Parse(label4.Text) * 2}";
                        label8.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label4.Text)}";
                    }
                }

                if (label12.Text != "")
                {
                    if (label8.Text == "")
                    {
                        if (label4.Text == "")
                        {
                            label4.Text = label12.Text;
                            label12.Text = "";
                        }

                        else if (label4.Text == label12.Text)
                        {
                            label4.Text = $"{int.Parse(label4.Text) * 2}";
                            label12.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label4.Text)}";
                        }

                        else
                        {
                            label8.Text = label12.Text;
                            label12.Text = "";
                        }
                    }

                    else if (label8.Text == label12.Text)
                    {
                        label8.Text = $"{int.Parse(label8.Text) * 2}";
                        label12.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label8.Text)}";
                    }
                }

                if (label16.Text != "")
                {
                    if (label12.Text == "")
                    {
                        if (label8.Text == "")
                        {
                            if (label4.Text == "")
                            {
                                label4.Text = label16.Text;
                                label16.Text = "";
                            }

                            else if (label4.Text == label16.Text)
                            {
                                label4.Text = $"{int.Parse(label4.Text) * 2}";
                                label16.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label4.Text)}";
                            }

                            else
                            {
                                label8.Text = label16.Text;
                                label16.Text = "";
                            }
                        }

                        else if (label8.Text == label16.Text)
                        {
                            label8.Text = $"{int.Parse(label8.Text) * 2}";
                            label16.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label8.Text)}";
                        }

                        else
                        {
                            label12.Text = label16.Text;
                            label16.Text = "";
                        }
                    }

                    else if (label12.Text == label16.Text)
                    {
                        label12.Text = $"{int.Parse(label12.Text) * 2}";
                        label16.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label12.Text)}";
                    }
                }

                if (label7.Text != "")
                {
                    if (label3.Text == "")
                    {
                        label3.Text = label7.Text;
                        label7.Text = "";
                    }

                    else if (label3.Text == label7.Text)
                    {
                        label3.Text = $"{int.Parse(label3.Text) * 2}";
                        label7.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label3.Text)}";
                    }
                }

                if (label11.Text != "")
                {
                    if (label7.Text == "")
                    {
                        if (label3.Text == "")
                        {
                            label3.Text = label11.Text;
                            label11.Text = "";
                        }

                        else if (label3.Text == label11.Text)
                        {
                            label3.Text = $"{int.Parse(label3.Text) * 2}";
                            label11.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label3.Text)}";
                        }

                        else
                        {
                            label7.Text = label11.Text;
                            label11.Text = "";
                        }
                    }

                    else if (label7.Text == label11.Text)
                    {
                        label7.Text = $"{int.Parse(label7.Text) * 2}";
                        label11.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label7.Text)}";
                    }
                }

                if (label15.Text != "")
                {
                    if (label11.Text == "")
                    {
                        if (label7.Text == "")
                        {
                            if (label3.Text == "")
                            {
                                label3.Text = label15.Text;
                                label15.Text = "";
                            }

                            else if (label3.Text == label15.Text)
                            {
                                label3.Text = $"{int.Parse(label3.Text) * 2}";
                                label15.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label3.Text)}";
                            }

                            else
                            {
                                label7.Text = label15.Text;
                                label15.Text = "";
                            }
                        }

                        else if (label7.Text == label15.Text)
                        {
                            label7.Text = $"{int.Parse(label7.Text) * 2}";
                            label15.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label7.Text)}";
                        }

                        else
                        {
                            label11.Text = label15.Text;
                            label15.Text = "";
                        }
                    }

                    else if (label11.Text == label15.Text)
                    {
                        label11.Text = $"{int.Parse(label11.Text) * 2}";
                        label15.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label11.Text)}";
                    }
                }

                if (label6.Text != "")
                {
                    if (label2.Text == "")
                    {
                        label2.Text = label6.Text;
                        label6.Text = "";
                    }

                    else if (label2.Text == label6.Text)
                    {
                        label2.Text = $"{int.Parse(label2.Text) * 2}";
                        label6.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label2.Text)}";
                    }
                }

                if (label10.Text != "")
                {
                    if (label6.Text == "")
                    {
                        if (label2.Text == "")
                        {
                            label2.Text = label10.Text;
                            label10.Text = "";
                        }

                        else if (label2.Text == label10.Text)
                        {
                            label2.Text = $"{int.Parse(label2.Text) * 2}";
                            label10.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label2.Text)}";
                        }

                        else
                        {
                            label6.Text = label10.Text;
                            label10.Text = "";
                        }
                    }

                    else if (label6.Text == label10.Text)
                    {
                        label6.Text = $"{int.Parse(label6.Text) * 2}";
                        label10.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label6.Text)}";
                    }
                }

                if (label14.Text != "")
                {
                    if (label10.Text == "")
                    {
                        if (label6.Text == "")
                        {
                            if (label2.Text == "")
                            {
                                label2.Text = label14.Text;
                                label14.Text = "";
                            }

                            else if (label2.Text == label14.Text)
                            {
                                label2.Text = $"{int.Parse(label2.Text) * 2}";
                                label14.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label2.Text)}";
                            }

                            else
                            {
                                label6.Text = label14.Text;
                                label14.Text = "";
                            }
                        }

                        else if (label6.Text == label14.Text)
                        {
                            label6.Text = $"{int.Parse(label6.Text) * 2}";
                            label14.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label6.Text)}";
                        }

                        else
                        {
                            label10.Text = label14.Text;
                            label14.Text = "";
                        }
                    }

                    else if (label10.Text == label14.Text)
                    {
                        label10.Text = $"{int.Parse(label10.Text) * 2}";
                        label14.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label10.Text)}";
                    }
                }

                if (label5.Text != "")
                {
                    if (label1.Text == "")
                    {
                        label1.Text = label5.Text;
                        label5.Text = "";
                    }

                    else if (label1.Text == label5.Text)
                    {
                        label1.Text = $"{int.Parse(label1.Text) * 2}";
                        label5.Text = ""; 
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label1.Text)}";
                    }
                }

                if (label9.Text != "")
                {
                    if (label5.Text == "")
                    {
                        if (label1.Text == "")
                        {
                            label1.Text = label9.Text;
                            label9.Text = "";
                        }

                        else if (label1.Text == label9.Text)
                        {
                            label1.Text = $"{int.Parse(label1.Text) * 2}";
                            label9.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label1.Text)}";
                        }

                        else
                        {
                            label5.Text = label9.Text;
                            label9.Text = "";
                        }
                    }

                    else if (label5.Text == label9.Text)
                    {
                        label5.Text = $"{int.Parse(label5.Text) * 2}";
                        label9.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label5.Text)}";
                    }
                }

                if (label13.Text != "")
                {
                    if (label9.Text == "")
                    {
                        if (label5.Text == "")
                        {
                            if (label1.Text == "")
                            {
                                label1.Text = label13.Text;
                                label13.Text = "";
                            }

                            else if (label1.Text == label13.Text)
                            {
                                label1.Text = $"{int.Parse(label1.Text) * 2}";
                                label13.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label1.Text)}";
                            }

                            else
                            {
                                label5.Text = label13.Text;
                                label13.Text = "";
                            }
                        }

                        else if (label5.Text == label13.Text)
                        {
                            label5.Text = $"{int.Parse(label5.Text) * 2}";
                            label13.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label5.Text)}";
                        }

                        else
                        {
                            label9.Text = label13.Text;
                            label13.Text = "";
                        }
                    }

                    else if (label9.Text == label13.Text)
                    {
                        label9.Text = $"{int.Parse(label9.Text) * 2}";
                        label13.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label9.Text)}";
                    }
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (label12.Text != "")
                {
                    if (label16.Text == "")
                    {
                        label16.Text = label12.Text;
                        label12.Text = "";
                    }

                    else if (label16.Text == label12.Text)
                    {
                        label16.Text = $"{int.Parse(label16.Text) * 2}";
                        label12.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label16.Text)}";
                    }
                }

                if (label8.Text != "")
                {
                    if (label12.Text == "")
                    {
                        if (label16.Text == "")
                        {
                            label16.Text = label8.Text;
                            label8.Text = "";
                        }

                        else if (label16.Text == label8.Text)
                        {
                            label16.Text = $"{int.Parse(label16.Text) * 2}";
                            label8.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label16.Text)}";
                        }

                        else
                        {
                            label12.Text = label8.Text;
                            label8.Text = "";
                        }
                    }

                    else if (label12.Text == label8.Text)
                    {
                        label12.Text = $"{int.Parse(label12.Text) * 2}";
                        label8.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label12.Text)}";
                    }
                }

                if (label4.Text != "")
                {
                    if (label8.Text == "")
                    {
                        if (label12.Text == "")
                        {
                            if (label16.Text == "")
                            {
                                label16.Text = label4.Text;
                                label4.Text = "";
                            }

                            else if (label16.Text == label4.Text)
                            {
                                label16.Text = $"{int.Parse(label16.Text) * 2}";
                                label4.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label16.Text)}";
                            }

                            else
                            {
                                label12.Text = label4.Text;
                                label4.Text = "";
                            }
                        }

                        else if (label12.Text == label4.Text)
                        {
                            label12.Text = $"{int.Parse(label12.Text) * 2}";
                            label4.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label12.Text)}";
                        }

                        else
                        {
                            label8.Text = label4.Text;
                            label4.Text = "";
                        }
                    }

                    else if (label8.Text == label4.Text)
                    {
                        label8.Text = $"{int.Parse(label8.Text) * 2}";
                        label4.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label8.Text)}";
                    }
                }

                if (label11.Text != "")
                {
                    if (label15.Text == "")
                    {
                        label15.Text = label11.Text;
                        label11.Text = "";
                    }

                    else if (label15.Text == label11.Text)
                    {
                        label15.Text = $"{int.Parse(label15.Text) * 2}";
                        label11.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label15.Text)}";
                    }
                }

                if (label7.Text != "")
                {
                    if (label11.Text == "")
                    {
                        if (label15.Text == "")
                        {
                            label15.Text = label7.Text;
                            label7.Text = "";
                        }

                        else if (label15.Text == label7.Text)
                        {
                            label15.Text = $"{int.Parse(label15.Text) * 2}";
                            label7.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label15.Text)}";
                        }

                        else
                        {
                            label11.Text = label7.Text;
                            label7.Text = "";
                        }
                    }

                    else if (label11.Text == label7.Text)
                    {
                        label11.Text = $"{int.Parse(label11.Text) * 2}";
                        label7.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label11.Text)}";
                    }
                }

                if (label3.Text != "")
                {
                    if (label7.Text == "")
                    {
                        if (label11.Text == "")
                        {
                            if (label15.Text == "")
                            {
                                label15.Text = label3.Text;
                                label3.Text = "";
                            }

                            else if (label15.Text == label3.Text)
                            {
                                label15.Text = $"{int.Parse(label15.Text) * 2}";
                                label3.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label15.Text)}";
                            }

                            else
                            {
                                label11.Text = label3.Text;
                                label3.Text = "";
                            }
                        }

                        else if (label11.Text == label3.Text)
                        {
                            label11.Text = $"{int.Parse(label11.Text) * 2}";
                            label3.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label11.Text)}";
                        }

                        else
                        {
                            label7.Text = label3.Text;
                            label3.Text = "";
                        }
                    }

                    else if (label7.Text == label3.Text)
                    {
                        label7.Text = $"{int.Parse(label7.Text) * 2}";
                        label3.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label7.Text)}";
                    }
                }

                if (label10.Text != "")
                {
                    if (label14.Text == "")
                    {
                        label14.Text = label10.Text;
                        label10.Text = "";
                    }

                    else if (label14.Text == label10.Text)
                    {
                        label14.Text = $"{int.Parse(label14.Text) * 2}";
                        label10.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label14.Text)}";
                    }
                }

                if (label6.Text != "")
                {
                    if (label10.Text == "")
                    {
                        if (label14.Text == "")
                        {
                            label14.Text = label6.Text;
                            label6.Text = "";
                        }

                        else if (label14.Text == label6.Text)
                        {
                            label14.Text = $"{int.Parse(label14.Text) * 2}";
                            label6.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label14.Text)}";
                        }

                        else
                        {
                            label10.Text = label6.Text;
                            label6.Text = "";
                        }
                    }

                    else if (label10.Text == label6.Text)
                    {
                        label10.Text = $"{int.Parse(label10.Text) * 2}";
                        label6.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label10.Text)}";
                    }
                }

                if (label2.Text != "")
                {
                    if (label6.Text == "")
                    {
                        if (label10.Text == "")
                        {
                            if (label14.Text == "")
                            {
                                label14.Text = label2.Text;
                                label2.Text = "";
                            }

                            else if (label14.Text == label2.Text)
                            {
                                label14.Text = $"{int.Parse(label14.Text) * 2}";
                                label2.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label14.Text)}";
                            }

                            else
                            {
                                label10.Text = label2.Text;
                                label2.Text = "";
                            }
                        }

                        else if (label10.Text == label2.Text)
                        {
                            label10.Text = $"{int.Parse(label10.Text) * 2}";
                            label2.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label10.Text)}";
                        }

                        else
                        {
                            label6.Text = label2.Text;
                            label2.Text = "";
                        }
                    }

                    else if (label6.Text == label2.Text)
                    {
                        label6.Text = $"{int.Parse(label6.Text) * 2}";
                        label2.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label6.Text)}";
                    }
                }

                if (label9.Text != "")
                {
                    if (label13.Text == "")
                    {
                        label13.Text = label9.Text;
                        label9.Text = "";
                    }

                    else if (label13.Text == label9.Text)
                    {
                        label13.Text = $"{int.Parse(label13.Text) * 2}";
                        label9.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label13.Text)}";
                    }
                }

                if (label5.Text != "")
                {
                    if (label9.Text == "")
                    {
                        if (label13.Text == "")
                        {
                            label13.Text = label5.Text;
                            label5.Text = "";
                        }

                        else if (label13.Text == label5.Text)
                        {
                            label13.Text = $"{int.Parse(label13.Text) * 2}";
                            label5.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label13.Text)}";
                        }

                        else
                        {
                            label9.Text = label5.Text;
                            label5.Text = "";
                        }
                    }

                    else if (label9.Text == label5.Text)
                    {
                        label9.Text = $"{int.Parse(label9.Text) * 2}";
                        label5.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label9.Text)}";
                    }
                }

                if (label1.Text != "")
                {
                    if (label5.Text == "")
                    {
                        if (label9.Text == "")
                        {
                            if (label13.Text == "")
                            {
                                label13.Text = label1.Text;
                                label1.Text = "";
                            }

                            else if (label13.Text == label1.Text)
                            {
                                label13.Text = $"{int.Parse(label13.Text) * 2}";
                                label1.Text = "";
                                ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label13.Text)}";
                            }

                            else
                            {
                                label9.Text = label1.Text;
                                label1.Text = "";
                            }
                        }

                        else if (label9.Text == label1.Text)
                        {
                            label9.Text = $"{int.Parse(label9.Text) * 2}";
                            label1.Text = "";
                            ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label9.Text)}";
                        }

                        else
                        {
                            label5.Text = label1.Text;
                            label1.Text = "";
                        }
                    }

                    else if (label5.Text == label1.Text)
                    {
                        label5.Text = $"{int.Parse(label5.Text) * 2}";
                        label1.Text = "";
                        ScoreNumber.Text = $"{int.Parse(ScoreNumber.Text) + int.Parse(label5.Text)}";
                    }
                }
            }

            if (label1.Text == "2048" || label2.Text == "2048" || label3.Text == "2048" || label4.Text == "2048" || 
                label5.Text == "2048" || label6.Text == "2048" || label7.Text == "2048" || label8.Text == "2048" || 
                label9.Text == "2048" || label10.Text == "2048" || label11.Text == "2048" || label12.Text == "2048" || 
                label13.Text == "2048" || label14.Text == "2048" || label15.Text == "2048" || label16.Text == "2048")
                formW.Show();

            GenerateNewTile();
        }

        private void MenuItemBack_Click(object sender, EventArgs e)
        {

        }
    }
}

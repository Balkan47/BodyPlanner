using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Diät2
{
    public partial class Form1 : Form
    {
        double BMI;

        private long kcalsummelabel2;
        private long kcalsummelabel3;
        private long kcalsummelabel4;
        private long kcalsummelabel5;
        private long kcalsummelabel6;
        private long kcalsummelabel7;
        private long kcalsummelabel8;

        private long kcalsummelabel10;
        private long kcalsummelabel11;
        private long kcalsummelabel12;
        private long kcalsummelabel13;
        private long kcalsummelabel14;
        private long kcalsummelabel15;
        private long kcalsummelabel16;

        public Form1()
        {
            InitializeComponent();
            this.tabPage1.Text = "Kalorientabelle";
            this.tabPage2.Text = "BMI-Rechner";

            this.Tabelle.Anchor = AnchorStyles.None;
            this.Tabelle.Dock   = DockStyle.Fill;

            //this.Tabelle.Anchor = AnchorStyles.None;
            //this.Tabelle.Dock = DockStyle.Fill;

            this.groupBox2.Anchor = AnchorStyles.None;
            this.groupBox2.Dock = DockStyle.Fill;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            kcalsummelabel2 = 0;
            kcalsummelabel3 = 0;
            kcalsummelabel4 = 0;
            kcalsummelabel5 = 0;
            kcalsummelabel6 = 0;
            kcalsummelabel7 = 0;
            kcalsummelabel8 = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    kcalsummelabel2 += Convert.ToInt64(dataGridView1[1, i].Value);
                    kcalsummelabel3 += Convert.ToInt64(dataGridView1[3, i].Value);
                    kcalsummelabel4 += Convert.ToInt64(dataGridView1[5, i].Value);
                    kcalsummelabel5 += Convert.ToInt64(dataGridView1[7, i].Value);
                    kcalsummelabel6 += Convert.ToInt64(dataGridView1[9, i].Value);
                    kcalsummelabel7 += Convert.ToInt64(dataGridView1[11, i].Value);
                    kcalsummelabel8 += Convert.ToInt64(dataGridView1[13, i].Value);
                }
                catch (FormatException)
                {
                    MessageBox.Show(this, "Sie müssen eine Zahl eingeben !");
                }
            }

            label2.Text = kcalsummelabel2.ToString();
            label3.Text = kcalsummelabel3.ToString();
            label4.Text = kcalsummelabel4.ToString();
            label5.Text = kcalsummelabel5.ToString();
            label6.Text = kcalsummelabel6.ToString();
            label7.Text = kcalsummelabel7.ToString();
            label8.Text = kcalsummelabel8.ToString();
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            kcalsummelabel10 = 0;
            kcalsummelabel11 = 0;
            kcalsummelabel12 = 0;
            kcalsummelabel13 = 0;
            kcalsummelabel14 = 0;
            kcalsummelabel15 = 0;
            kcalsummelabel16 = 0;

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                try
                {
                    kcalsummelabel10 += Convert.ToInt64(dataGridView2[1, i].Value);
                    kcalsummelabel11 += Convert.ToInt64(dataGridView2[3, i].Value);
                    kcalsummelabel12 += Convert.ToInt64(dataGridView2[5, i].Value);
                    kcalsummelabel13 += Convert.ToInt64(dataGridView2[7, i].Value);
                    kcalsummelabel14 += Convert.ToInt64(dataGridView2[9, i].Value);
                    kcalsummelabel15 += Convert.ToInt64(dataGridView2[11, i].Value);
                    kcalsummelabel16 += Convert.ToInt64(dataGridView2[13, i].Value);
                }

                catch (FormatException)
                {
                    MessageBox.Show(this, "Sie müssen eine Zahl eingeben !");
                }
            }

            label10.Text = kcalsummelabel10.ToString();
            label11.Text = kcalsummelabel11.ToString();
            label12.Text = kcalsummelabel12.ToString();
            label13.Text = kcalsummelabel13.ToString();
            label14.Text = kcalsummelabel14.ToString();
            label15.Text = kcalsummelabel15.ToString();
            label16.Text = kcalsummelabel16.ToString();
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            label18.Text = (kcalsummelabel2 - kcalsummelabel10).ToString();
        }
        private void label3_TextChanged(object sender, EventArgs e)
        {
            label19.Text = (kcalsummelabel3 - kcalsummelabel11).ToString();
        }
        private void label4_TextChanged(object sender, EventArgs e)
        {
            label20.Text = (kcalsummelabel4 - kcalsummelabel12).ToString();
        }
        private void label5_TextChanged(object sender, EventArgs e)
        {
            label21.Text = (kcalsummelabel5 - kcalsummelabel13).ToString();
        }
        private void label6_TextChanged(object sender, EventArgs e)
        {
            label22.Text = (kcalsummelabel6 - kcalsummelabel14).ToString();
        }
        private void label7_TextChanged(object sender, EventArgs e)
        {
            label23.Text = (kcalsummelabel7 - kcalsummelabel15).ToString();
        }
        private void label8_TextChanged(object sender, EventArgs e)
        {
            label24.Text = (kcalsummelabel8 - kcalsummelabel16).ToString();
        }
        private void label18_TextChanged(object sender, EventArgs e)
        {
            string summe = (Convert.ToInt64(label18.Text) + Convert.ToInt64(label19.Text) +
                            Convert.ToInt64(label20.Text) + Convert.ToInt64(label21.Text) +
                            Convert.ToInt64(label22.Text) + Convert.ToInt64(label23.Text) +
                            Convert.ToInt64(label24.Text)).ToString();

            textbox.Text = "Dein Wochen Endergebnis sind kcal: " + summe;
        }

        private void label19_TextChanged(object sender, EventArgs e)
        {
            string summe = (Convert.ToInt64(label18.Text) + Convert.ToInt64(label19.Text) +
                            Convert.ToInt64(label20.Text) + Convert.ToInt64(label21.Text) +
                            Convert.ToInt64(label22.Text) + Convert.ToInt64(label23.Text) +
                            Convert.ToInt64(label24.Text)).ToString();

            textbox.Text = "Dein Wochen Endergebnis sind kcal: " + summe;
        }


        private void label20_TextChanged(object sender, EventArgs e)
        {
            string summe = (Convert.ToInt64(label18.Text) + Convert.ToInt64(label19.Text) +
                            Convert.ToInt64(label20.Text) + Convert.ToInt64(label21.Text) +
                            Convert.ToInt64(label22.Text) + Convert.ToInt64(label23.Text) +
                            Convert.ToInt64(label24.Text)).ToString();

            textbox.Text = "Dein Wochen Endergebnis sind kcal: " + summe;
        }


        private void label21_TextChanged(object sender, EventArgs e)
        {
            string summe = (Convert.ToInt64(label18.Text) + Convert.ToInt64(label19.Text) +
                            Convert.ToInt64(label20.Text) + Convert.ToInt64(label21.Text) +
                            Convert.ToInt64(label22.Text) + Convert.ToInt64(label23.Text) +
                            Convert.ToInt64(label24.Text)).ToString();

            textbox.Text = "Dein Wochen Endergebnis sind kcal: " + summe;
        }

        private void label22_TextChanged(object sender, EventArgs e)
        {
            string summe = (Convert.ToInt64(label18.Text) + Convert.ToInt64(label19.Text) +
                            Convert.ToInt64(label20.Text) + Convert.ToInt64(label21.Text) +
                            Convert.ToInt64(label22.Text) + Convert.ToInt64(label23.Text) +
                            Convert.ToInt64(label24.Text)).ToString();

            textbox.Text = "Dein Wochen Endergebnis sind kcal: " + summe;
        }

        private void label23_TextChanged(object sender, EventArgs e)
        {
            string summe = (Convert.ToInt64(label18.Text) + Convert.ToInt64(label19.Text) +
                            Convert.ToInt64(label20.Text) + Convert.ToInt64(label21.Text) +
                            Convert.ToInt64(label22.Text) + Convert.ToInt64(label23.Text) +
                            Convert.ToInt64(label24.Text)).ToString();

            textbox.Text = "Dein Wochen Endergebnis sind kcal: " + summe;
        }

        private void label24_TextChanged(object sender, EventArgs e)
        {
            string summe = (Convert.ToInt64(label18.Text) + Convert.ToInt64(label19.Text) +
                            Convert.ToInt64(label20.Text) + Convert.ToInt64(label21.Text) +
                            Convert.ToInt64(label22.Text) + Convert.ToInt64(label23.Text) +
                            Convert.ToInt64(label24.Text)).ToString();

            textbox.Text = "Dein Wochen Endergebnis sind kcal: " + summe;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("nahrung.txt");

            for (int x = 0; x < dataGridView1.Rows.Count; x++)
            {
                for (int i = 0; i <= 13; i++)
                {
                    if (dataGridView1.Rows[x].Cells[i].Value != null)
                    {
                        file.WriteLine(Convert.ToString(x) + "," + Convert.ToString(i) + "," + dataGridView1.Rows[x].Cells[i].Value);
                    }
                }
            }

            StreamWriter file2 = new StreamWriter("training.txt");

            for (int a = 0; a < dataGridView2.Rows.Count; a++)
            {
                for (int b = 0; b <= 13; b++)
                {
                    if (dataGridView2.Rows[a].Cells[b].Value != null)
                    {
                        file2.WriteLine(Convert.ToString(a) + "," + Convert.ToString(b) + "," + dataGridView2.Rows[a].Cells[b].Value);
                    }
                }
            }

            MessageBox.Show(this, "Speichern erfolgreich");

            file.Close();
            file2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BMI = (Convert.ToDouble(textBox1.Text) / (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox2.Text)));

                textBox3.Text = Convert.ToString(BMI);

                if (BMI <= 16.0)
                {
                    button2.BackColor = Color.DarkBlue;
                    textBox4.Text = "starkes Untergewicht";
                    textBox5.Text = "<16";
                    textBox6.Text = "Untergewicht";
                }
                else if (BMI >= 16.0 && BMI <= 17.0)
                {
                    button2.BackColor = Color.Blue;
                    textBox4.Text = "mäßiges Untergewicht";
                    textBox5.Text = "16,0-17,0";
                    textBox6.Text = "Untergewicht";
                }
                else if (BMI >= 17.0 && BMI <= 18.5)
                {
                    button2.BackColor = Color.SkyBlue;
                    textBox4.Text = "leichtes Untergewicht";
                    textBox5.Text = "17,0-18,5";
                    textBox6.Text = "Untergewicht";
                }
                else if (BMI >= 18.5 && BMI <= 25.0)
                {
                    button2.BackColor = Color.Green;
                    textBox4.Text = "Normalgewicht";
                    textBox5.Text = "18,5-25,0";
                    textBox6.Text = "Normalgewicht";
                }
                else if (BMI >= 25.0 && BMI <= 30.0)
                {
                    button2.BackColor = Color.Yellow;
                    textBox4.Text = "Präadipositas";
                    textBox5.Text = "25,0-30,0";
                    textBox6.Text = "Übergewicht";
                }
                else if (BMI >= 30.0 && BMI <= 35.0)
                {
                    button2.BackColor = Color.Orange;
                    textBox4.Text = "Adipositas Grad 1";
                    textBox5.Text = "30,0-35,0";
                    textBox6.Text = "starkes Übergewicht";
                }
                else if (BMI >= 35.0 && BMI <= 40.0)
                {
                    button2.BackColor = Color.OrangeRed;
                    textBox4.Text = "Adipositas Grad 2";
                    textBox5.Text = "35,0-40,0";
                    textBox6.Text = "starkes Übergewicht";
                }
                else if (BMI >= 40.0)
                {
                    button2.BackColor = Color.Red;
                    textBox4.Text = "Adipositas Grad 3";
                    textBox5.Text = ">40";
                    textBox6.Text = "starkes Übergewicht";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Bitte nur Zahlen eingeben !");
            }            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = 0;

                dataGridView1.Rows.Add();
                
                foreach (string item in File.ReadLines("nahrung.txt"))
                {
                    string[] zeile = item.Split(',');
                    int x = Convert.ToInt32(zeile[0]);
                    int i = Convert.ToInt32(zeile[1]);

                    if (temp != x)
                    {
                        dataGridView1.Rows.Add();
                        temp = x;
                    }

                    dataGridView1.Rows[x].Cells[i].Value = zeile[2];
                }

                int zahl = 0;

                dataGridView2.Rows.Add();

                foreach (string item in File.ReadLines("training.txt"))
                {
                    string[] zeile = item.Split(',');
                    int x = Convert.ToInt32(zeile[0]);
                    int i = Convert.ToInt32(zeile[1]);

                    if (zahl != x)
                    {
                        dataGridView2.Rows.Add();
                        zahl = x;
                    }

                    dataGridView2.Rows[x].Cells[i].Value = zeile[2];
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }      
    }
}

       
        
    


       

            

        
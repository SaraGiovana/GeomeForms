using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Windows.Forms;


namespace GeomeForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load (object sender , EventArgs e) 
        { rbCerc.Checked = true;
            InitializareControale();
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            gpRezultate.Visible = true;
            if(rbCerc.Checked)
            {
                Cerc c = new Cerc();
                c.Raza=Convert.ToDouble(txtIntro.Text);
                lblPerimetru.Text = "Lungimea cercului: " + c.Perimetru().ToString();
                lblArie.Text = "Aria cercului: " + c.Arie().ToString();
            }
            else if (rbCerc.Checked)
            {
                Triunghiech t = new Triunghiech();
                t.Latura = Convert.ToDouble(txtIntro.Text);
                lblPerimetru.Text = "Perimetrul triunghiului echilateral: " + t.Perimetru().ToString();
                lblArie.Text = "Aria triunghiului echilateral: " + t.Arie().ToString();
            }
            else

            {
                Patrat p = new Patrat();
                p.Latura = Convert.ToDouble(txtIntro.Text);
                lblPerimetru.Text = "Perimetrul pãtratului: " + p.Perimetru().ToString();
                lblArie.Text = "Aria pãtratului: " + p.Arie().ToString();
            }
        }
        private void InitializareControale()
            {
                gpRezultate.Visible = false;
                btnCalculeaza.Enabled = false;
                txtIntro.Clear();
                txtIntro.Focus();
            }

         private void txtIntro_TextChanged (object sender, EventArgs e)
        { 
            if(txtIntro.Text !="")
            {
                btnCalculeaza.Enabled = true;
            }
            else
            {
                btnCalculeaza.Enabled = false;
            }
        }
        private void rbCerc_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCerc.Checked)
                {
                gpIntro.Text = "Scrie valoarea razei cercului";
                }
                else if (rbCerc.Checked)
            {
                gpIntro.Text = "Scrie valoarea lungimii laturii triunghiului echilateral";
                }
                else
            { 
                gpIntro.Text = "Scrie valoarea laturii pãtratului";
                }
        InitializareControale();
        }   
        }
    }

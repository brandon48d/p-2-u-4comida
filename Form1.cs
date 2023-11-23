namespace practica_2__unidad_4
{
    public partial class Form1 : Form
    {
        int CantidadHamburguesas;
        int CantidadHotDog;
        int CantidadSandwich;
        int CantidadTe;
        int CantidadRefresco;
        int CantidadPapas;

        double TotalVta;
        double CostoHamburguesa;
        double CostoHotDog;
        double CostoSandwich;
        double CostoTe;
        double CostoRefresco;
        double CostoPapas;

        double Hamburguesa = 20.5;
        double HotDog = 19.25;
        double Sandwich = 17.5;
        double PapasFritas = 4.5;
        double Refresco = 4;
        double Te = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "";
            if (radioButton1.Checked == true) ;
            {
                CantidadHamburguesas = 1;
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadHotDog = 0;
                CantidadSandwich = 0;
                CantidadTe = 0;

                txtHamburguesa.Text = CantidadHamburguesas.ToString();
                txtRefresco.Text = CantidadRefresco.ToString();
                txtPapas.Text = CantidadPapas.ToString();


                txtHamburguesa.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;

                txtHotDog.Enabled = false;
                txtHotDog.Enabled = false;
                txtTe.Enabled = false;
                txtSandwich.Enabled = false;

                txtHotDog.Text = "";
                txtTe.Text = "";
                txtSandwich.Text = "";

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "";
            if (radioButton2.Checked == true)
            {
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadHotDog = 1;
                CantidadSandwich = 0;

                txtHotDog.Text = CantidadHotDog.ToString();
                txtRefresco.Text = CantidadRefresco.ToString();
                txtPapas.Text = CantidadPapas.ToString();

                txtHotDog.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;

                txtHamburguesa.Enabled = false;
                txtTe.Enabled = false;
                txtSandwich.Enabled = false;

                txtHamburguesa.Text = "";

                txtSandwich.Text = "";


            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "";
            if (radioButton3.Checked == true)
            {
                CantidadHamburguesas = 0;
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadHotDog = 0;
                CantidadSandwich = 1;
                CantidadTe = 0;

                txtSandwich.Text = CantidadPapas.ToString();
                txtRefresco.Text = CantidadRefresco.ToString();
                txtPapas.Text = CantidadPapas.ToString();


                txtSandwich.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;

                txtHotDog.Enabled = false;
                txtTe.Enabled = false;
                txtHamburguesa.Enabled = false;

                txtHamburguesa.Text = "";
                txtTe.Text = "";
                txtHotDog.Text = "";

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "";
            if (radioButton4.Checked == true)
            {
                txtHamburguesa.Enabled = true;
                txtHotDog.Enabled = true;
                txtSandwich.Enabled = true;
                txtTe.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;

                double CantidadHamburguesas = int.Parse(txtHamburguesa.Text);
                double CantidadHotdog = int.Parse(txtHotDog.Text);
                double CantidadSandwich = int.Parse(txtSandwich.Text);
                double CantidadTe = int.Parse(txtTe.Text);
                double CantidadRefresco = int.Parse(txtRefresco.Text);
                double CantidadPapas = int.Parse(txtPapas.Text);

            }
        }

        private void BotonCalcular_Click(object sender, EventArgs e)
        {
            CostoHamburguesa = (CantidadHamburguesas * Hamburguesa);
            CostoHotDog = (CantidadHotDog * HotDog);
            CostoSandwich = (CantidadSandwich * Sandwich);
            CostoTe = (CantidadTe * Te);
            CostoRefresco = (CantidadRefresco * Refresco);
            CostoPapas = (CantidadPapas * PapasFritas);
            TotalVta = CostoHamburguesa + CostoHotDog + CostoSandwich + CostoTe + CostoRefresco + CostoPapas;
            txtTotal.Text = TotalVta.ToString();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
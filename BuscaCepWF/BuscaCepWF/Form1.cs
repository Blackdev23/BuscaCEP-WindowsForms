using Refit;

namespace BuscaCepWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskCEP_Leave(object sender, EventArgs e)
        {

        }

        async Task BuscarCep(string cep)
        {
            try
            {
                var cepbuscar = RestService.For<IceApiService>("https://viacep.com.br/");
                var endereco = await cepbuscar.GetAddressAsync(cep);

                txtLogradouro.Text = endereco.Logradouro;
                txtMunicipio.Text = endereco.Localidade;
                txtBairro.Text = endereco.Bairro;
                txtComplemento2.Text = endereco.Complemento;
                txtEstado.Text = endereco.Uf;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n " + ex.Message);
            }
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            BuscarCep(maskCEP.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            string limpar = "";
            txtBairro.Text = limpar;
            txtEstado.Text = limpar;
            txtMunicipio.Text = limpar;
            txtLogradouro.Text = limpar;
            txtNumero.Text = limpar;
            maskCEP.Text = limpar;
            txtComplemento.Text = limpar;
            txtComplemento2.Text = limpar;
        }

        private void maskCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
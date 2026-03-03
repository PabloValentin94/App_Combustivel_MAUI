namespace App_Combustivel_MAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_verificar_Clicked(object sender, EventArgs e)
        {
            double preco_gasolina = double.Parse(txt_gasolina.Text);
            double preco_etanol = double.Parse(txt_etanol.Text);

            double equivalencia_etanol_gasolina = preco_gasolina * 0.70;

            if (preco_etanol > equivalencia_etanol_gasolina)
            {
                txt_resultado.Text = "A gasolina é mais econômica.";
            }
            else if (preco_etanol < equivalencia_etanol_gasolina)
            {
                txt_resultado.Text = "O etanol é mais econômico.";
            }
            else
            {
                txt_resultado.Text = "A escolha do combustível é indiferente.";
            }
        }
    }
}

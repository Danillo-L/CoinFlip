namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void JogarButton_Clicked(object sender, EventArgs e)
        {

            Moeda moeda = new Moeda();
            moeda.SortearLado();
            string selecao = SelecaoPicker.SelectedItem.ToString().ToLower();
            if (selecao == moeda.LadoSorteado)
            {
                ResultLabel.Text = $"Parabéns, você pediu {selecao} e deu {moeda.LadoSorteado}!";

            } else
            {
                ResultLabel.Text = $"Que pena, você pediu {selecao} e deu {moeda.LadoSorteado}!";
            }
            MoedaImage.Source = $"{moeda.LadoSorteado}.png";
         
        }
    }

}

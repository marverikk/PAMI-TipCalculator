namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SliderTipPercentage_ValueChanged(object sender, ValueChangedEventArgs e);
        {
            

        }

        private void OnBtn15Clicked(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 15;
        }

        private void OnBtn20Clicked(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 20;
        }

        private void OnRoundDownBtnClicked(object sender, EventArgs e)
        {
            //Calcular a gorjeta, arredondando para baixo
            double result = CalculateTip();
            double roundedResult = Math.Ceiling(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double TotalValue = roundedResult + amount;

            //Exibir a gorjeta
            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = TotalValue .ToString();
        }

        private void OnRoundUpBtnClicked(object sender, EventArgs e)
        {

        }

        private double CalculateTip()
        {
            //Uma função que calcule
            //Precisa receber o valor do pedido digitado pelo usuário
            //Receber o valor da porcentagem para calcular a gorjeta
            //Realizar o calculo da gorjeta
            //Exibir o valor na Label TotalTip
            
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double percent = SliderTipPercent.Value;

            //Calculo da gorjeta
            double result = amount * (percent/100);
            return result;
            
        }
    }

}


LabelPercentageValue.Text = Math.Round(SliderTipPercentage.Value).ToString(); 
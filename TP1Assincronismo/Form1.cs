using System.Diagnostics;

namespace TP1Assincronismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongTimeString();
        }

        private async Task<decimal> FolhaDePagamento()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            return 2000.50m;
        }

        private async Task<decimal> Impostos()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            return 1700.77m;
        }

        private async Task<decimal> Receitas()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            return 4100.80m;
        }

        private async Task<decimal> Despesas()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return 1500.15m;
        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
            lblMesagem.ForeColor = Color.Red;
            lblMesagem.Text = "Cálculos sendo realizados, aguarde...";


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var folhaPagamento = FolhaDePagamento();
            var impostos = Impostos();
            var receitas = Receitas();
            var despesas = Despesas();

            await Task.WhenAll(FolhaDePagamento(), Impostos(),
                Receitas(), Despesas());
            
            List<string> resultados = new List<string>
            {
                {"**- Resultado -**"},
                {$"folha de pagamento - R$ {folhaPagamento.Result}"},
                {$"Impostos - R$ {impostos.Result}"},
                {$"Receitas - R$ {receitas.Result}"},
                {$"Despesas - R$ {despesas.Result}"},
                {$"Todo processo durou: {stopwatch.ElapsedMilliseconds/1000} segundos"}
            };

            stopwatch.Stop();

            btnCalcular.Enabled = true;
            lblMesagem.ForeColor = Color.Green;
            lblMesagem.Text = "Cálculos finalizados com sucesso";

            listBoxResultado.DataSource = null;
            listBoxResultado.DataSource = resultados;           


        }   

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
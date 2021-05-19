namespace Cambios
{
    using Models;
    using Services;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        #region Atributes

        private NetworkService networkService;
        private ApiService apiService;

        #endregion

        #region Properties

        public List<Rate> Rates { get; set; }

        #endregion

        public MainForm()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            Rates = new List<Rate>();
            LoadRates();
        }

        private async void LoadRates()
        {
            labelResult.Text = "Updating rates...";

            var connection = networkService.CheckConnection();

            if (!connection.IsSuccess)
            {
                MessageBox.Show(connection.Message, "Error");
                return;
            }
            else
            {
                await LoadApiRates();
            }

            RatesPresentation();
        }

        private async Task LoadApiRates()
        {
            progressBarLoadRates.Value = 0;

            var response = await apiService.GetRates("http://cambios.somee.com", "/api/rates");

            Rates = response.Result as List<Rate>;
        }

        private void RatesPresentation()
        {
            comboBoxFrom.DataSource = Rates;
            comboBoxFrom.DisplayMember = "NameAndCode";

            comboBoxTo.BindingContext = new BindingContext();
            comboBoxTo.DataSource = Rates;
            comboBoxTo.DisplayMember = "NameAndCode";

            progressBarLoadRates.Value = 100;
            labelResult.Text = "Rates loaded.";
        }
    }
}
using Cambios.Models;
using Cambios.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cambios
{
    public partial class MainForm : Form
    {
        #region Atributes

        private NetworkService networkService;
        private ApiService apiService;
        private List<Rate> rates;
        private DialogService dialogService;
        private DataService dataService;

        #endregion

        public MainForm()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            dialogService = new DialogService();
            dataService = new DataService();
            LoadRates();
        }

        private async void LoadRates()
        {
            bool webLoad;

            labelResult.Text = "Updating rates...";

            var connection = networkService.CheckConnection();

            if (!connection.IsSuccess)
            {
                LoadLocalRates();
                webLoad = false;
            }
            else
            {
                await LoadApiRates();
                webLoad = true;
            }

            if (rates.Count == 0)
            {
                labelResult.Text = "No Internet or local data";
                labelStatus.Text = "First start";
                return;
            }

            RatesPresentation(webLoad);
        }

        private void LoadLocalRates()
        {
            rates = dataService.GetData();
        }

        private async Task LoadApiRates()
        {
            progressBarLoadRates.Value = 0;

            var response = await apiService.GetRates("http://cambios.somee.com", "/api/rates");

            rates = response.Result as List<Rate>;

            dataService.DeleteData();
            dataService.SaveData(rates);
        }

        private void RatesPresentation(bool webLoad)
        {
            rates = rates.OrderBy(x => x.Name).ToList();

            comboBoxFrom.DataSource = rates;
            comboBoxFrom.DisplayMember = "NameAndCode";

            comboBoxTo.BindingContext = new BindingContext();
            comboBoxTo.DataSource = rates;
            comboBoxTo.DisplayMember = "NameAndCode";

            labelResult.Text = "Rates updated";

            if (webLoad)
            {
                labelStatus.Text = $"Web data ({DateTime.Now.ToString("dd/MM/yyyy HH:mm")})";
            }
            else
            {
                labelStatus.Text = "Local data";
            }

            progressBarLoadRates.Value = 100;
            buttonConvert.Enabled = true;
            buttonChange.Enabled = true;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private void Convert()
        {
            if (string.IsNullOrEmpty(textBoxAmount.Text))
            {
                dialogService.ShowMessage("Error", "Insert an amount.");
                return;
            }

            double amount;

            if (!double.TryParse(textBoxAmount.Text, out amount))
            {
                dialogService.ShowMessage("Error", "Amount must be a number.");
                return;
            }

            if (comboBoxFrom.SelectedItem == null)
            {
                dialogService.ShowMessage("Error", "Select a currency to convert from.");
                return;
            }

            if (comboBoxTo.SelectedItem == null)
            {
                dialogService.ShowMessage("Error", "Select a currency to convert to.");
                return;
            }

            if (comboBoxFrom.SelectedItem == comboBoxTo.SelectedItem)
            {
                dialogService.ShowMessage("Error", "Select different currencies.");
                return;
            }

            var rateFrom = comboBoxFrom.SelectedItem as Rate;
            var rateTo = comboBoxTo.SelectedItem as Rate;

            var convertedAmount = amount / (double) rateFrom.TaxRate * (double) rateTo.TaxRate;

            labelResult.Text = string.Format
                (
                    "{0} {1:#,###0.00} = {2} {3:#,###0.00}",
                    rateFrom.Code,
                    amount,
                    rateTo.Code,
                    convertedAmount
                );
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            ChangeFromTo();
        }

        private void ChangeFromTo()
        {
            var aux = comboBoxFrom.SelectedItem;
            comboBoxFrom.SelectedItem = comboBoxTo.SelectedItem;
            comboBoxTo.SelectedItem = aux;

            Convert();
        }
    }
}

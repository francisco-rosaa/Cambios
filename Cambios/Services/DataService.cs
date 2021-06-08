using Cambios.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;

namespace Cambios.Services
{
    public class DataService
    {
        private SQLiteConnection connection;

        private SQLiteCommand command;

        private DialogService dialogService;

        public DataService()
        {
            dialogService = new DialogService();

            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }

            var path = @"Data\Rates.sqlite";

            try
            {
                connection = new SQLiteConnection("DataSource=" + path);
                connection.Open();

                string sqlCreate =
                    "create table if not exists Rates " +
                    "(RateId int, Code text, TaxRate real, Name text)";

                command = new SQLiteCommand(sqlCreate, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                dialogService.ShowMessage("Error", ex.Message);
            }
        }

        public void SaveData(List<Rate> rates)
        {
            try
            {
                foreach (Rate rate in rates)
                {
                    string sqlInsert = string.Format
                        (
                        "insert into Rates (RateId, Code, TaxRate, Name) " +
                        "values ({0}, '{1}', {2}, '{3}')",
                        rate.RateId,
                        rate.Code,
                        rate.TaxRate.ToString(CultureInfo.InvariantCulture.NumberFormat),
                        rate.Name
                        );

                    command = new SQLiteCommand(sqlInsert, connection);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                dialogService.ShowMessage("Error", ex.Message);
            }
        }

        public List<Rate> GetData()
        {
            List<Rate> rates = new List<Rate>();

            try
            {
                string sqlSelect =
                    "select RateId, Code, TaxRate, Name " +
                    "from Rates";

                command = new SQLiteCommand(sqlSelect, connection);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    rates.Add(new Rate
                    {
                        RateId = Convert.ToInt32(reader["RateId"]),
                        Code = reader["Code"].ToString(),
                        TaxRate = Convert.ToDouble(reader["TaxRate"]),
                        Name = reader["Name"].ToString()
                    });
                }

                connection.Close();

                return rates;
            }
            catch (Exception ex)
            {
                dialogService.ShowMessage("Error", ex.Message);

                return null;
            }
        }

        public void DeleteData()
        {
            try
            {
                string sqlDelete =
                    "delete from Rates";

                command = new SQLiteCommand(sqlDelete, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                dialogService.ShowMessage("Error", ex.Message);
            }
        }
    }
}

﻿namespace Cambios.Services
{
    using System.Windows.Forms;

    public class DialogService
    {
        public void ShowMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }
    }
}

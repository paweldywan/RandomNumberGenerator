using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDCore.Extensions;
using PDCore.Helpers;
using PDCore.Utils;

namespace RandomNumberGenerator
{
    /// <summary>
    /// Klasa częściowa, jest w kilku plikach, by zwiększyć czytelność i nie wyświetlać zbędnych informacje w ciele klasy.
    /// </summary>
    public partial class RandomNumberGenerratorForm : Form
    {
        /// <summary>
        /// Konstruktor odpowiada za przygotowanie danych, przypisanie zmiennych itd.
        /// </summary>
        public RandomNumberGenerratorForm()
        {
            InitializeComponent();

            SetUpControls();
        }

        private void SetUpControls()
        {
            WinFormsUtils.SetMinAndMaxAsInt(fromNumericUpDown, toNumericUpDown);

            amountNumericUpDown.SetMaxAsInt();
        }


        #region Events

        private void generateButton_Click(object sender, EventArgs e)
        {
            int[] result = WinFormsUtils.GetRandomNumbers(fromNumericUpDown, toNumericUpDown, amountNumericUpDown);

            resultListBox.AddItems(result);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            resultListBox.SetItemsTextToClipboard();
        }

        #endregion
    }
}

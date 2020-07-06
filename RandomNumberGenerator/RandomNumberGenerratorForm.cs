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
            fromNumericUpDown.Minimum = int.MinValue;
            fromNumericUpDown.Maximum = int.MaxValue;

            toNumericUpDown.Minimum = fromNumericUpDown.Minimum;
            toNumericUpDown.Maximum = fromNumericUpDown.Maximum;

            amountNumericUpDown.Maximum = fromNumericUpDown.Maximum;
        }


        #region Events

        private void generateButton_Click(object sender, EventArgs e)
        {
            var result = GetResult();

            resultListBox.AddItems(result);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            resultListBox.SetItemsTextToClipboard();
        }

        #endregion


        #region Logic

        private int[] GetResult()
        {
            int from = fromNumericUpDown.GetValueInt();

            int to = toNumericUpDown.GetValueInt();

            int amount = amountNumericUpDown.GetValueInt();


            int[] result = null;

            try
            {
                result = PDCore.Helpers.RandomNumberGenerator.Next(from, to, amount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd");
            }

            return result;
        }

        #endregion
    }
}

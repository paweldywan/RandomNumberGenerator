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

            fromNumericUpDown.Minimum = int.MinValue;
            fromNumericUpDown.Maximum = int.MaxValue;

            toNumericUpDown.Minimum = fromNumericUpDown.Minimum;
            toNumericUpDown.Maximum = fromNumericUpDown.Maximum;

            amountNumericUpDown.Maximum = fromNumericUpDown.Maximum;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var result = GetResult();

            ShowResult(result);
        }

        private void ShowResult(int[] result)
        {
            resultListBox.Items.Clear();

            if (result == null)
                return;

            result.ForEach(x => resultListBox.Items.Add(x));
        }

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

        private void Copy()
        {
            if (resultListBox.Items.Count > 0)
            {
                string result = string.Join(", ", resultListBox.Items.Cast<int>());

                Clipboard.SetText(result);
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Copy();
        }
    }
}

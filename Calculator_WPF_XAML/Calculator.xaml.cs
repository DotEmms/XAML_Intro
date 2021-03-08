using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Calculator_WPF_XAML
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        private ICalculations _calculations;

        private Operation _selectedOperator;
        private double _lastNumber, _result;
        public Calculator()
        {
            InitializeComponent();
            _calculations = new Calculations();
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            int selectedValue = 0;

            if (sender is Button senderButton)
            {
                selectedValue = int.Parse(senderButton.Content.ToString());
            }

            if (lblResult.Content.ToString() == "0")
            {
                lblResult.Content = selectedValue;
            }
            else
            {
                lblResult.Content = $"{lblResult.Content}{selectedValue}";
            }
        }
        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblResult.Content.ToString(), out _lastNumber))
            {
                lblResult.Content = "0";
            }

            if (sender == btnDivision)
            {
                _selectedOperator = Operation.Divide;
            }
            if (sender == btnPlus)
            {
                _selectedOperator = Operation.Add;
            }
            if (sender == btnMultiplication)
            {
                _selectedOperator = Operation.Multiply;
            }
            if (sender == btnMinus)
            {
                _selectedOperator = Operation.Subtract;
            }
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;

            if (double.TryParse(lblResult.Content.ToString(), out newNumber))
            {
                switch (_selectedOperator)
                {
                    case Operation.Add:
                        _result = _calculations.Add(_lastNumber, newNumber);
                        break;

                    case Operation.Subtract:
                        _result = _calculations.Subtract(_lastNumber, newNumber);
                        break;

                    case Operation.Multiply:
                        _result = _calculations.Multiply(_lastNumber, newNumber);
                        break;

                    case Operation.Divide:
                        _result = _calculations.Divide(_lastNumber, newNumber);
                        break;
                }

                lblResult.Content = _result;
            }
        }
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (lblResult.Content.ToString().Contains("."))
            {
                // Do nothing
            }
            else
            {
                lblResult.Content = $"{lblResult.Content}.";
            }
        }
        private void Reset()
        {
            lblResult.Content = 0;
            _lastNumber = 0;
            _result = 0;
        }

        public enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide,
        }
    }
}

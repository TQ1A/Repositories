using System;
using System.Windows;

namespace Task12_WPF
{
    public partial class MainWindow : Window
    {
        public event EventHandler MathAction = null;

        public char _math_symbol;
        public double _old_text;

        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
            TextBox1.Focus();
        }
        private void Button_Click(object sender, RoutedEventArgs e, char ch)
        {
            _math_symbol = ch;
            _old_text = Double.Parse(TextBox1.Text);
            TextBox1.Text = "";
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e, '+');
            TextBox1.Focus();
        }

        private void Subtract_Button_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e, '-');
            TextBox1.Focus();
        }

        private void Multiply_Button_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e, '*');
            TextBox1.Focus();
        }
        private void Divide_Button_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e, '/');
            TextBox1.Focus();
        }

        private void Count_Button_Click(object sender, RoutedEventArgs e)
        {
            MathAction.Invoke(sender, e);
            TextBox1.Focus();
        }
    }
}

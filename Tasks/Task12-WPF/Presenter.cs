using System;
namespace Task12_WPF
{
    internal class Presenter
    {
        readonly Model _model = new Model();
        readonly MainWindow _mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            _mainWindow.MathAction += MainWindow_MathAction;
        }

        private void MainWindow_MathAction(object? sender, EventArgs e)
        {
            double first = _mainWindow._old_text;
            double second = Double.Parse(_mainWindow.TextBox1.Text);
            char math_symbol = _mainWindow._math_symbol;
            string result = _model.SymbolAction(first, second, math_symbol).ToString();
            _mainWindow.TextBox1.Text = result;
        }
    }
}

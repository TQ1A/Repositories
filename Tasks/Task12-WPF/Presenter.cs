using System;
namespace Task12_WPF
{
    internal class Presenter
    {
        // TODO: CR: Маркин Евгений: 1. поля с _
        // readonly
        Model model;
        MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            // TODO: CR: Маркин Евгений: this. не используем
            this.mainWindow = mainWindow;
            this.model = new Model();
            this.mainWindow.MathAction += MainWindow_MathAction;
        }

        private void MainWindow_MathAction(object? sender, EventArgs e)
        {
            // TODO: CR: Маркин Евгений: нужно расписать каждое действие построчно.
            string result = this.model.SymbolAction(this.mainWindow._old_text, Double.Parse(this.mainWindow.TextBox1.Text), this.mainWindow._math_symbol).ToString();
            this.mainWindow.TextBox1.Text = result;
        }
    }
}

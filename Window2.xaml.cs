using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfLR2
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();

        }
        bool dialogRes;
        public bool DialogRes
        {
            get { return dialogRes; }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
                dialogRes = false;
            textBox1.Focus();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            dialogRes = true;
            Close();
        }

        public void button2_Click(object sender, RoutedEventArgs e)
        {
            Owner.Title = textBox1.Text;
            Owner.OwnedWindows[0].Title = textBox2.Text;
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox2 = (TextBox)sender;
            MessageBox.Show(textBox2.Text);
        }
    }
}

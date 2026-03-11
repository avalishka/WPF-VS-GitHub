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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_VS_GitHub
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void greetButton_Click(object sender, RoutedEventArgs e)
		{
			string name = nameTextBox.Text;
			if (string.IsNullOrWhiteSpace(name))
				MessageBox.Show("Пожалуйста, введите имя!");
			else
				MessageBox.Show($"Привет, {name}!");
		}
	}
}

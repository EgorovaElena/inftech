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

namespace sem5_lab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            processTextButton.Click += ProcessTextHandler;
        }

        public void ProcessTextHandler(object sender, RoutedEventArgs e)
        {
            int[,] matrix = ParseMatrix(inputTextBox.Text);
            ProcessMatrix(matrix);
            PrintMatrix(matrix);
        }

        public int[,] ParseMatrix(string text)
        {

            string[] rows = text.Split('\n');
            int rowCount = rows.Length;
            int colCount = rows[0].Split(' ').Length;
            int[,] matrix = new int[rowCount, colCount];
            for (int rowIdx = 0; rowIdx < rowCount; rowIdx++)
            {
                string row = rows[rowIdx];
                string[] numbers = row.Split(' ');
                for (int colIdx = 0; colIdx < numbers.Length; colIdx++)
                {
                    matrix[rowIdx, colIdx] = Int32.Parse(numbers[colIdx]);
                }
            }
            return matrix;
        }

        public void ProcessMatrix(int[,] matrix)
        {
            int rowCout = matrix.GetUpperBound(0) + 1;
            int colCount = matrix.Length / rowCout;
            for (int rowIdx = 0; rowIdx < rowCout - 1; rowIdx++)
            {
                for (int colIdx = 0; colIdx < colCount; colIdx++)
                {
                    matrix[rowIdx, colIdx] = matrix[rowIdx, colIdx] - matrix[rowCout - 1, colIdx];
                }
            }
        }

        public void PrintMatrix(int[,] matrix)
        {
            int rowCout = matrix.GetUpperBound(0) + 1;
            int colCount = matrix.Length / rowCout;
            StringBuilder sb = new StringBuilder("");
            for (int rowIdx = 0; rowIdx < rowCout; rowIdx++)
            {
                for (int colIdx = 0; colIdx < colCount; colIdx++)
                {
                    sb.Append(matrix[rowIdx, colIdx]);
                    sb.Append(" ");
                }
                sb.Append("\n");
            }

            outputTextBox.Text = sb.ToString();
        }


    }
}

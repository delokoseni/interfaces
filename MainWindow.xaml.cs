using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace interfaces
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<TableRow> Rows { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Rows = new ObservableCollection<TableRow>();
            Rows.Add(new TableRow
            {
                Empty = "1",
                Sum = "2",
                Data = "3",
                Number = "4",
                AccountingCost = "5",
                Products = "6",
                SpicesAndSalt = "7",
                Containers = "8",
                GlassContainers = "9",
                AccountingDepartmentMarks = "10"
            });
            Rows.Add(new TableRow
            {
                Empty = "I. Остаток на начало дня",
                Sum = "X"
            });
            Rows.Add(new TableRow
            {
                Empty = "II. Приход",
            });
            for(int i = 0; i < 19; i++)
            {
                Rows.Add(new TableRow
                {
                    Sum = "X"
                });
            }
            Rows.Add(new TableRow
            {
                Empty = "Итого по приходу",
                Sum = "X",
                Number = "X"
            });
            Rows.Add(new TableRow
            {
                Empty = "Итого с остатком",
                Sum = "X",
                Data = "X",
                Number = "X",
            });
            Rows.Add(new TableRow
            {
                Empty = "III. Расход"
            });
            for (int i = 0; i < 14; i++)
            {
                Rows.Add(new TableRow());
            }
            Rows.Add(new TableRow
            {
                Empty = "Итого по расходу",
            });
            Rows.Add(new TableRow
            {
                Empty = "IV. Остаток на конец дня",
                Sum = "X",
                Number = "X"
            });
            Rows.Add(new TableRow
            {
                Empty = "Фактический остаток",
                Sum = "X",
                Data = "X",
                Number = "X",
            });
            Rows.Add(new TableRow
            {
                Empty = "Излишки",
                Sum = "X",
                Data = "X",
                Number = "X",
            });
            Rows.Add(new TableRow
            {
                Empty = "Недостача",
                Sum = "X",
                Data = "X",
                Number = "X",
            });
            DataContext = this;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

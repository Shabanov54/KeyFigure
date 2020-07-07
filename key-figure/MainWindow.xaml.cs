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

namespace key_figure
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Contex contex;
        public MainWindow()
        {
            InitializeComponent();
            contex = new Contex();
            
        }
        private void Button_add_Click(object sender, RoutedEventArgs e)
        {
            contex.InputCode(text.Text);
            var codes = contex.GetCodes();
            var operation = new Operation();
            operation.Run(codes);
            var barcode = operation.GetBarcode();
            var output = new OutPut();
            output.Display_Barcode(codes,barcode, RadyCode);
        }

    }
}

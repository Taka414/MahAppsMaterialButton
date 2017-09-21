using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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

namespace MahMaterial
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    //public partial class MainWindow : Window
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Accented;
        }

        /// <summary>
        /// Plusボタン押したとき
        /// </summary>
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var mySettings = new MetroDialogSettings()
            {
                ColorScheme = MetroDialogOptions.ColorScheme
            };

            MessageDialogResult result = await this.ShowMessageAsync("ボタンが押されました。", "ダイアログを閉じるにはOKを押してください。");
        }
    }
}

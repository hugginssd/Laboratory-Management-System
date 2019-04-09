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

namespace Laboratory_Management_System.UI
{
    /// <summary>
    /// Interaction logic for UserCreateNewTest.xaml
    /// </summary>
    public partial class UserCreateNewTest : UserControl
    {
        public UserCreateNewTest()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            TxtLBound.Clear();
            TxtRate.Clear();
            TxtTestCode.Clear();
            TxtTestID.Clear();
            TxtTestName.Clear();
            CmbTestClass.SelectedItem = "";
            CmbTestUnits.SelectedItem = "";
        }

        private void BtnAddParameter_OnClick(object sender, RoutedEventArgs e)
        {
           
        }
    }
}

using ManageStaffDBApp.Model;
using ManageStaffDBApp.ViewModel;
using System.Text.RegularExpressions;
using System.Windows;

namespace ManageStaffDBApp.View
{
    /// <summary>
    /// Логика взаимодействия для EditPositionWindow.xaml
    /// </summary>
    public partial class EditPositionWindow : Window
    {
        public EditPositionWindow(Position positionToEdit)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.SelectedPosition = positionToEdit;
            DataManageVM.PositionName = positionToEdit.Name;
            DataManageVM.PositionMaxNumber = positionToEdit.MaxNumber;
            DataManageVM.PositionSalary = positionToEdit.Salary;
        }
        private void PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}

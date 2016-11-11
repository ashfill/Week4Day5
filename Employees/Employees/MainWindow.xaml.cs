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

namespace Employees
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Employye_Info> EmployeeInfo = new List<Employye_Info>();
        public MainWindow()
        {
            InitializeComponent();
            EmployeeList.ItemsSource = EmployeeInfo;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Employye_Info newEmp = new Employye_Info();
            newEmp.EmployeeName1 = textBox_name.Text;
            string EmpId = EmployyeIDBox.Text;
            newEmp.EmployeeID = Convert.ToInt32(EmpId);
            newEmp.EmployeeAddress1 = textbox_Address.Text;
            string EmpZip = textBox_Zip.Text;
            newEmp.EmployeeZipCode = Convert.ToInt32(EmpZip);
            string EmpHire = textBox_HireDate.Text;
            newEmp.EmployeeHireDate = Convert.ToDateTime(EmpHire);
            string EmpTerm = textBox_TermDate.Text;
            newEmp.EmployeeTerminationDate = Convert.ToDateTime(EmpTerm);

            EmployeeInfo.Add(newEmp);
            EmployeeList.ItemsSource = null;
            EmployeeList.ItemsSource = EmployeeInfo;
        }
    }
}

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

using System.Data.OleDb;
using System.Data;

namespace EasyCodeM2G
{
    /// <summary>
    /// SalesUser.xaml 的交互逻辑
    /// </summary>
    public partial class SalesUser : Window
    {
        public SalesUser()
        {
            InitializeComponent();
        }

        private DataTable previewDT = new DataTable();
        /// <summary>
        /// 选择本地现有的网页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectUrl_Click(object sender, RoutedEventArgs e)
        {
            btnLL.IsEnabled = false;
            string filename = string.Empty;
            Util.showDialog(out filename);
            txtLocalUrl.Text = filename;
            btnLL.IsEnabled = true; 
        }

        private void txtLocalUrl_TextChanged(object sender, TextChangedEventArgs e)
        {
            string strExcelPath = this.txtLocalUrl.Text;
            OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strExcelPath + ";" + "Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=1;\"");

            string _strSelectCMD = "select * from [Sheet1$]";
            OleDbDataAdapter _adapter = new OleDbDataAdapter(_strSelectCMD, objConn);
            DataSet _set = new DataSet();
            _adapter.Fill(_set, "Sheet1");
            previewDT = _set.Tables[0];
            Util.RemoveEmpty(previewDT);
            this.dgView.ItemsSource = previewDT.DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (previewDT != null)
            {

            }
        }
    }
}

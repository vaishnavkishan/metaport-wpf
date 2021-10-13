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

namespace MetaportTest1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PurchaseOrder purchaseOrder = new PurchaseOrder();
            mainFrame.Height = purchaseOrder.Height;
            mainFrame.Content = purchaseOrder;

            SidebarGrid.Width= 170;
            StatsbarGrid.Width =170;
            mainScrollbar.Width = System.Windows.SystemParameters.PrimaryScreenWidth - 370;
            mainFrame.Width = System.Windows.SystemParameters.PrimaryScreenWidth - 380;

        }

        private void InspectionNode_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Inspection inspection = new Inspection();
            mainFrame.Height = inspection.Height;
            mainFrame.MinWidth = inspection.MinWidth;
            mainFrame.Content = inspection;
        }
       
        private void PurchaseOrderNode_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PurchaseOrder purchaseOrder = new PurchaseOrder();
            mainFrame.Height = purchaseOrder.Height;
            mainFrame.MinWidth = purchaseOrder.MinWidth;
            mainFrame.Content = purchaseOrder;
        }

        private void GoodsReceiptNode_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            GoodsReceipt goodsReceipt=new GoodsReceipt();
            mainFrame.Height = goodsReceipt.Height;
            mainFrame.MinWidth = goodsReceipt.MinWidth;
            mainFrame.Content = goodsReceipt;
        }

        private void TreeViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
        }

        private void TreeViewItem_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            PurchaseOrder purchaseOrder = new PurchaseOrder();
            mainFrame.Height = purchaseOrder.Height;
            mainFrame.MinWidth = purchaseOrder.MinWidth;
            mainFrame.Content = purchaseOrder;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Width > 380)
            {
                mainScrollbar.Width = e.NewSize.Width - 370;
                mainFrame.Width = e.NewSize.Width - 380;
            }
        }

        private void POViewNode_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PurchaseOrderView purchaseOrderView = new PurchaseOrderView();
            mainFrame.Height = purchaseOrderView.Height;
            mainFrame.MinWidth = purchaseOrderView.MinWidth;
            mainFrame.Content = purchaseOrderView;
        } 
    }
}

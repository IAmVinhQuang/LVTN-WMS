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

namespace LVTN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Nút bấm vào trang nhập kho
        private void BtnNhapKho_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Trang.NhapkhoPage(); // Main là tên frame đã được đặt ở trong MainWindow.xaml
        }

        // Nút bấm vào trang chính
        private void BtnMainButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Trang.TrangchuPage();
        }

        // Nút bấm vào trang Cơ sở dũ liệu
        private void btnDlcsButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Trang.DlcsPage();
        }

        // Nút bấm vào trang QL Khách hàng
        private void btnQLKhachhangButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Trang.QLKhachhangPage();
        }

        // Nút bấm vào trang QL Nhà cung cấp
        private void btnQLNhaccButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Trang.QLNhaccPage();
        }

        // Nút bấm vào trang QL sản phẩm
        private void btnQLSanphamButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Trang.QLSanphamPage();
        }

        // Nút bấm vào trang QL tồn kho
        private void btnQLTonkhoButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Trang.QLTonkhoPage();
        }

        // Nút bấm vào trang xuất kho
        private void btnXuatkhoButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Trang.XuatkhoPage();
        }

        // Nút bấm vào trang vị trí
        private void btnVitriButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Trang.VitriPage();
        }

        // Nút bấm vào trang Thống kê
        private void btnThongkeButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Trang.ThongkePage();
        }


        // Nút bấm đăng xuất về lại LoginWindow
        private void btnDangxuatButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow LoginWindow = new LoginWindow();
            LoginWindow.Show();
            this.Close(); // Để tắt trang đang bật hiện thời
        }

        
    }
}

using System.Windows;
using System.Windows.Input;

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isDragging = false;
        private Point dragStartPoint = new Point();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void DraggableTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isDragging = true;
            dragStartPoint = e.GetPosition(draggableTextBlock);
            //draggableTextBlock.CaptureMouse(); // 捕获鼠标，确保在拖拽过程中接收所有鼠标事件
        }

        private void centerContent_MouseEnter(object sender, MouseButtonEventArgs e)
        {

        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            draggableTextBlock.ReleaseMouseCapture();

            if (isDragging)
            {
                var aaa = "";
            }
        }
    }
}
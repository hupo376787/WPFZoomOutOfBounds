using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp20
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void gridMain_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            try
            {
                if (MatrixTransform == null)
                    return;

                var pos = e.GetPosition(PART_MainImage);
                var scale = e.Delta > 0 ? 1.1 : 1 / 1.1;
                var matrix = MatrixTransform.Matrix;
                if (matrix.M11 <= 0.1 && e.Delta < 0)
                    return;
                MatrixTransform.Matrix = new Matrix(scale, 0, 0, scale, pos.X - (scale * pos.X), pos.Y - (scale * pos.Y)) * matrix;
            }
            catch (Exception ex)
            {

            }
        }
    }
}

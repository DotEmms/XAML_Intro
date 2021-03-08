using Revision.Models;
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
using System.Windows.Shapes;

namespace Revision
{
    /// <summary>
    /// Interaction logic for PieDetailView.xaml
    /// </summary>
    public partial class PieDetailView : Window
    {
        public Pie Pie { get; set; }
        public PieDetailView(Pie pie)
        {
            InitializeComponent();
            Pie = pie;

            this.DataContext = pie;
        }
    }
}

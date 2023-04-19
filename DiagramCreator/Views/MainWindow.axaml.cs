using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Input;
using Avalonia.VisualTree;
using DiagramCreator.ViewModels;
using System.Diagnostics;
using System.Linq;

namespace DiagramCreator.Views
{
    public partial class MainWindow : Window
    {
        private Point pointPointerPressed;
        private Point pointerPositionIntoShape;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(this);
        }
        private void OnPointerPressed(object? sender, PointerPressedEventArgs pointerPressedEventArgs)
        {
            Debug.WriteLine(pointerPressedEventArgs.Source);
            pointPointerPressed = pointerPressedEventArgs.GetPosition
                (
                this.GetVisualDescendants().OfType<Canvas>().FirstOrDefault());
        }
    }
    }
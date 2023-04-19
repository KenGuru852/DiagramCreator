using Avalonia.Controls;
using Avalonia.LogicalTree;
using DiagramCreator.Models;
using DiagramCreator.Views;
using DynamicData;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace DiagramCreator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private bool _IsStatic;

        public bool IsStatic
        {
            get { return _IsStatic; }
            set
            {
                this.RaiseAndSetIfChanged(ref _IsStatic, value);
            }
        }

        private bool _IsReadonly;

        public bool IsReadonly
        {
            get { return _IsReadonly; }
            set
            {
                this.RaiseAndSetIfChanged(ref _IsReadonly, value);
            }
        }

        private bool _IsDefault;

        public bool IsDefault
        {
            get { return _IsDefault; }
            set
            {
                this.RaiseAndSetIfChanged(ref _IsDefault, value);
            }
        }

        private string _NewAttrName;

        public string NewAttrName
        {
            get { return _NewAttrName; }
            set
            {
                this.RaiseAndSetIfChanged(ref _NewAttrName, value);
            }
        }
        private string _NewAttrType;

        public string NewAttrType
        {
            get { return _NewAttrType; }
            set
            {
                this.RaiseAndSetIfChanged(ref _NewAttrType, value);
            }
        }

        private string _DefaultSpec;

        public string DefaultSpec
        {
            get { return _DefaultSpec; }
            set
            {
                this.RaiseAndSetIfChanged(ref _DefaultSpec, value);
            }
        }

        private int _NewAttrAccNumber;

        public int NewAttrAccNumber
        {
            get { return _NewAttrAccNumber; }
            set
            {
                this.RaiseAndSetIfChanged(ref _NewAttrAccNumber, value);
            }
        }
        private int _NewAttrSterNumber;

        public int NewAttrSterNumber
        {
            get { return _NewAttrSterNumber; }
            set
            {
                this.RaiseAndSetIfChanged(ref _NewAttrSterNumber, value);
            }
        }
        private int _AttrNumber;

        public int AttrNumber
        {
            get { return _AttrNumber; }
            set
            {
                this.RaiseAndSetIfChanged(ref _AttrNumber, value);
            }
        }
        private int _ButtonNumber;

        public int ButtonNumber
        {
            get { return _ButtonNumber; }
            set
            {
                this.RaiseAndSetIfChanged(ref _ButtonNumber, value);
            }
        }
        public void PressButton1()
        {
            ButtonNumber = 1;
        }
        public void PressButton2()
        {
            ButtonNumber = 2;
        }
        public void PressButton3()
        {
            ButtonNumber = 3;
        }
        public void PressButton4()
        {
            ButtonNumber = 4;
        }
        public void PressButton5()
        {
            ButtonNumber = 5;
        }
        public void PressButton6()
        {
            ButtonNumber = 6;
        }

        private ObservableCollection<Diagramm> _allDiagramm;

        public ObservableCollection<Diagramm> allDiagramm
        {
            get { return _allDiagramm; }
            set
            {
                this.RaiseAndSetIfChanged(ref _allDiagramm, value);
            }
        }

        private ObservableCollection<Attributes> _AllAttributes;

        public ObservableCollection<Attributes> AllAttributes
        {
            get { return _AllAttributes; }
            set
            {
                this.RaiseAndSetIfChanged(ref _AllAttributes, value);
            }
        }

        private Canvas _newCanvas;
        public Canvas newCanvas
        {
            get { return _newCanvas; }
            set
            {
                this.RaiseAndSetIfChanged(ref _newCanvas, value);
            }
        }
        private AddDiagramm? AddWindow;
        public static MainWindowViewModel? newWindow { private get; set; }
        // public MainWindowViewModel() { }

        private readonly Canvas canv;
        public MainWindowViewModel(Window mw)
        {
            AttrNumber = -1;
            NewAttrAccNumber = -1;
            NewAttrSterNumber = -1;
            NewAttrName = "Название";
            NewAttrType = "Тип";
            DefaultSpec = "По умолчанию";
            IsDefault = IsStatic = IsReadonly = false;
            canv = mw.Find<Canvas>("canvas") ?? new Canvas();
            var panel = (Panel?)canv.Parent;
            allDiagramm = new ObservableCollection<Diagramm>();
            AllAttributes = new ObservableCollection<Attributes>();
            allDiagramm.Add(new Diagramm());
            ButtonNumber = 1;
        }
        public void AddDiagrammButton()
        {
            Window mw = new Window();
            AddWindow = new AddDiagramm { DataContext = this };
            AddWindow.Show();
        }
        public void AddAttrButton()
        {
            if (NewAttrAccNumber == -1 || NewAttrSterNumber == -1)
            {
                return;
            }
            AllAttributes.Add(new Attributes(NewAttrName, NewAttrType, NewAttrAccNumber, NewAttrSterNumber, IsReadonly, IsStatic, IsDefault, DefaultSpec));
            AttrNumber = -1;
            NewAttrAccNumber = -1;
            NewAttrSterNumber = -1;
            NewAttrName = "Название";
            NewAttrType = "Тип";
            DefaultSpec = "По умолчанию";
            IsDefault = IsStatic = IsReadonly = false;
        }
        public void DeleteAttrButton()
        {
            if (AttrNumber == -1)
            {
                return;
            }
            else
            {
                AllAttributes.RemoveAt(AttrNumber);
            }
        }
    }
}
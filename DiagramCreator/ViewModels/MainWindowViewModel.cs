using Avalonia.Controls;
using Avalonia.LogicalTree;
using DiagramCreator.Models;
using DiagramCreator.Views;
using DynamicData;
using ReactiveUI;
using System.Collections.Generic;
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

        private bool _MethIsStatic;

        public bool MethIsStatic
        {
            get { return _MethIsStatic; }
            set
            {
                this.RaiseAndSetIfChanged(ref _MethIsStatic, value);
            }
        }

        private bool _MethIsAbstract;

        public bool MethIsAbstract
        {
            get { return _MethIsAbstract; }
            set
            {
                this.RaiseAndSetIfChanged(ref _MethIsAbstract, value);
            }
        }

        private bool _MethIsVirtual;

        public bool MethIsVirtual
        {
            get { return _MethIsVirtual; }
            set
            {
                this.RaiseAndSetIfChanged(ref _MethIsVirtual, value);
            }
        }

        private bool _MethIsCreate;

        public bool MethIsCreate
        {
            get { return _MethIsCreate; }
            set
            {
                this.RaiseAndSetIfChanged(ref _MethIsCreate, value);
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

        private bool _DiagrammIsStatic;

        public bool DiagrammIsStatic
        {
            get { return _DiagrammIsStatic; }
            set
            {
                this.RaiseAndSetIfChanged(ref _DiagrammIsStatic, value);
            }
        }

        private bool _DiagrammIsAbstract;

        public bool DiagrammIsAbstract
        {
            get { return _DiagrammIsAbstract; }
            set
            {
                this.RaiseAndSetIfChanged(ref _DiagrammIsAbstract, value);
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
        private string _NewMethName;

        public string NewMethName
        {
            get { return _NewMethName; }
            set
            {
                this.RaiseAndSetIfChanged(ref _NewMethName, value);
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

        private string _NewMethType;

        public string NewMethType
        {
            get { return _NewMethType; }
            set
            {
                this.RaiseAndSetIfChanged(ref _NewMethType, value);
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

        private string _IsClassAbstract;

        public string IsClassAbstract
        {
            get { return _IsClassAbstract; }
            set
            {
                this.RaiseAndSetIfChanged(ref _IsClassAbstract, value);
            }
        }

        private string _IsClassStatic;

        public string IsClassStatic
        {
            get { return _IsClassStatic; }
            set
            {
                this.RaiseAndSetIfChanged(ref _IsClassStatic, value);
            }
        }

        private string _NewParamName;

        public string NewParamName
        {
            get { return _NewParamName; }
            set
            {
                this.RaiseAndSetIfChanged(ref _NewParamName, value);
            }
        }

        private string _NewClassName;

        public string NewClassName
        {
            get { return _NewClassName; }
            set
            {
                this.RaiseAndSetIfChanged(ref _NewClassName, value);
            }
        }

        private int _NewClassAccNumber;

        public int NewClassAccNumber
        {
            get { return _NewClassAccNumber; }
            set
            {
                this.RaiseAndSetIfChanged(ref _NewClassAccNumber, value);
            }
        }

        private int _NewClassSterNumber;

        public int NewClassSterNumber
        {
            get { return _NewClassSterNumber; }
            set
            {
                this.RaiseAndSetIfChanged(ref _NewClassSterNumber, value);
            }
        }

        private string _NewParamType;

        public string NewParamType
        {
            get { return _NewParamType; }
            set
            {
                this.RaiseAndSetIfChanged(ref _NewParamType, value);
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

        private int _MethNumber;

        public int MethNumber
        {
            get { return _MethNumber; }
            set
            {
                this.RaiseAndSetIfChanged(ref _MethNumber, value);
            }
        }

        private int _ParamNumber;

        public int ParamNumber
        {
            get { return _ParamNumber; }
            set
            {
                this.RaiseAndSetIfChanged(ref _ParamNumber, value);
            }
        }

        private int _NewMethAccNumber;

        public int NewMethAccNumber
        {
            get { return _NewMethAccNumber; }
            set
            {
                this.RaiseAndSetIfChanged(ref _NewMethAccNumber, value);
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

        private ObservableCollection<Methods> _AllMethods;

        public ObservableCollection<Methods> AllMethods
        {
            get { return _AllMethods; }
            set
            {
                this.RaiseAndSetIfChanged(ref _AllMethods, value);
            }
        }


        private ObservableCollection<Parametrs> _AllParametrs;

        public ObservableCollection<Parametrs> AllParametrs
        {
            get { return _AllParametrs; }
            set
            {
                this.RaiseAndSetIfChanged(ref _AllParametrs, value);
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
            NewMethAccNumber = -1;
            ParamNumber = -1;
            MethNumber = -1;
            NewClassSterNumber = -1;
            NewClassName = "Название";
            NewClassAccNumber = -1;
            NewAttrName = "Название";
            NewAttrType = "Тип";
            DefaultSpec = "По умолчанию";
            NewMethName = "Название";
            NewMethType = "Тип";
            NewParamName = "Название";
            NewParamType = "Тип";
            IsDefault = IsStatic = IsReadonly = false;
            canv = mw.Find<Canvas>("canvas") ?? new Canvas();
            var panel = (Panel?)canv.Parent;
            allDiagramm = new ObservableCollection<Diagramm>();
            AllAttributes = new ObservableCollection<Attributes>();
            AllMethods = new ObservableCollection<Methods>();
            AllParametrs = new ObservableCollection<Parametrs>();
            ButtonNumber = 1;
        }
        public void AddParametrButton()
        {
            AllParametrs.Add(new Parametrs(NewParamName, NewParamType));
            NewParamName = "Название";
            NewParamType = "Тип";
        }
        public void DeleteParametrButton()
        {
            if (ParamNumber == -1)
            {
                return;
            }
            AllParametrs.RemoveAt(ParamNumber);
        }
        public void AddDiagrammButton()
        {
            Window mw = new Window();
            AddWindow = new AddDiagramm { DataContext = this };
            AddWindow.Show();
        }
        
        public void NewDiagrammButton()
        {
            string[] allAcc = { "public", "protected", "private", "package" };
            if (NewClassAccNumber == -1 || NewClassSterNumber == -1)
            {
                return;
            }
            List<string> allAttrs = new List<string>();
            foreach (var item in AllAttributes)
            {
                string temp = "";
                if (item.AttrAccess == "Public")
                {
                    temp += "+ ";
                }
                else if (item.AttrAccess == "Protected")
                {
                    temp += "# ";
                }
                else if (item.AttrAccess == "Private")
                {
                    temp += "- ";
                }
                else if (item.AttrAccess == "Package")
                {
                    temp += "~ ";
                }
                // { "«event»", "«property»", "«required»" };
                temp += item.AttrSter;
                temp += " ";
                temp += item.AttrSpec;
                temp += " ";
                temp += item.AttrName;
                temp += ": ";
                temp += item.AttrType;
                allAttrs.Add(temp);
            }
            string ClassName = "";
            ClassName = NewClassName;
            string IsInt = "";
            string ForDiagramm = "";
            if (NewClassSterNumber == 2)
            {
                IsInt = "Yes";
            }
            if (NewClassSterNumber == 1)
            {
                IsClassAbstract = "Italic";
            }
            else
            {
                IsClassAbstract = "Normal";
            }
            if (NewClassSterNumber == 0)
            {
                IsClassStatic = "Underline";
            }
            else
            {
                IsClassStatic = "";
            }
            ForDiagramm = allAcc[NewClassAccNumber];
            allDiagramm.Add(new Diagramm(ClassName, IsClassStatic, IsClassAbstract, IsInt, ForDiagramm, allAttrs));
            NewClassSterNumber = -1;
            NewClassName = "Название";
            NewClassAccNumber = -1;
        }

        public void AddMethodButton()
        {
            string ParamForAdd = "(";
            if (NewMethAccNumber == -1)
            {
                return;
            }
            int n = AllParametrs.Count;
            int i = 0;
            foreach(var item in AllParametrs)
            {
                ParamForAdd += item.ParamName;
                ParamForAdd += " : ";
                ParamForAdd += item.ParamType;
                if (i != n - 1)
                {
                    ParamForAdd += ", ";
                }
                i++;
            }
            ParamForAdd += ")";
            AllMethods.Add(new Methods(NewMethName, NewMethType, NewMethAccNumber, MethIsAbstract, MethIsCreate, MethIsStatic, MethIsVirtual, ParamForAdd));
            NewMethName = "Название";
            NewMethType = "Тип";
            NewMethAccNumber = -1;
            MethIsAbstract = MethIsCreate = MethIsStatic = MethIsVirtual = false;
            AllParametrs.Clear();
        }
        public void DeleteMethodButton()
        {
            if (MethNumber == -1)
            {
                return;
            }
            AllMethods.RemoveAt(MethNumber);

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
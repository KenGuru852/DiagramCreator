using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramCreator.Models
{
    public class Diagramm
    {
        private string _DiagrammName;

        public string DiagrammName
        {
            get => _DiagrammName;
            set
            {
                _DiagrammName= value;
            }
        }

        private string _DiagrammAccess;

        public string DiagrammAccess
        {
            get => _DiagrammAccess;
            set
            {
                _DiagrammAccess = value;
            }
        }

        private string _IsClassAbstract;

        public string IsClassAbstract
        {
            get { return _IsClassAbstract; }
            set
            {
                _IsClassAbstract = value;
            }
        }

        private string _IsInterface;

        public string IsInterface
        {
            get { return _IsInterface; }
            set
            {
                _IsInterface = value;
            }
        }

        private TextDecorationCollection _IsClassStatic;

        public TextDecorationCollection IsClassStatic
        {
            get { return _IsClassStatic; }
            set
            {
                _IsClassStatic = value;
            }
        }

        private List<string> _AllAttributesDiagram;

        public List<string> AllAttributesDiagram
        {
            get => _AllAttributesDiagram;
            set
            {
                _AllAttributesDiagram = value;
            }
        }

        public Diagramm(string NewName, string Static, string Abstract, string IsInter, string Access, List<string> NewAllAttrs) 
        {
            _AllAttributesDiagram = new List<string>();
            foreach (var item in NewAllAttrs)
            {
                _AllAttributesDiagram.Add(item);
            }
           // _AllAttributesDiagram.Add(new string("<em>- property Рухидка: Малахитка</em>"));
            _DiagrammName = NewName; 
            _IsClassAbstract = Abstract;
            _DiagrammAccess = Access;
            if (IsInter == "Yes" )
            {
                IsInterface = "«interface»";
            }
            else { IsInterface = ""; }
            if (Static == "Underline")
            {
                _IsClassStatic = TextDecorationCollection.Parse("Underline");
            }
            else
            {
                _IsClassStatic = TextDecorationCollection.Parse("");
            }
        }

    }
}

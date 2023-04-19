using Avalonia;
using Avalonia.Controls.Shapes;
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
        private Points _MarginPoints;

        public Points MarginPoints
        {
            get => _MarginPoints;
            set
            {
                _MarginPoints= value;
            }
        }

        private Point _FirstPoint;
        public Point FirstPoint
        {
            get => _FirstPoint;
            set
            {
                _FirstPoint= value;
            }
        }

        public Diagramm() 
        {
            _DiagrammName = "RUHIDKAasgl.jasgkljadkglasjdgksdajlgsdkgjsdklgjRUHIDKAasgl.jasgkljadkglasjdgksdajlgsdkgjsdklgjRUHIDKAasgl.jasgkljadkglasjdgksdajlgsdkgjsdklgj"; 
        }

    }
}

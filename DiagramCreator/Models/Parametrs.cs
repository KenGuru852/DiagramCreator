using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramCreator.Models
{
    public class Parametrs
    {
        private string _ParamName;
        public string ParamName
        {
            get => _ParamName;
            set
            {
                _ParamName = value;
            }
        }
        private string _ParamType;
        public string ParamType
        {
            get => _ParamType;
            set
            {
                _ParamType = value;
            }
        }

        public Parametrs(string PName, string PType) 
        { 
            _ParamName = PName;
            _ParamType = PType;
        }
    }
}

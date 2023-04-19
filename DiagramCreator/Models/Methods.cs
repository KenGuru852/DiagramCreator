using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramCreator.Models
{
    public class Methods
    {
        private string _MethName;
        public string MethName
        {
            get => _MethName;
            set
            {
                _MethName = value;
            }
        }

        private string _MethSpec;
        public string MethSpec
        {
            get => _MethSpec;
            set
            {
                _MethSpec = value;
            }
        }

        private string _MethParam;
        public string MethParam
        {
            get => _MethParam;
            set
            {
                _MethParam = value;
            }
        }

        private string _MethType;
        public string MethType
        {
            get => _MethType;
            set
            {
                _MethType = value;
            }
        }

        private string _MethAccess;
        public string MethAccess
        {
            get => _MethAccess;
            set
            {
                _MethAccess = value;
            }
        }

        private bool _MIsStatic;

        public bool MIsStatic
        {
            get { return _MIsStatic; }
            set
            {
                _MIsStatic = value;
            }
        }

        private bool _MIsAbstract;

        public bool MIsAbstract
        {
            get { return _MIsAbstract; }
            set
            {
                _MIsAbstract = value;
            }
        }

        private bool _MIsVirtual;

        public bool MIsVirtual
        {
            get { return _MIsVirtual; }
            set
            {
                _MIsVirtual = value;
            }
        }

        private bool _MIsCreate;

        public bool MIsCreate
        {
            get { return _MIsCreate; }
            set
            {
                _MIsCreate = value;
            }
        }

        public Methods(string NewMethName, string NewMethType, int NewMethAcc, bool IA, bool IC, bool IS, bool IV, string Param)
        {
            string[] AllAccess = { "Public", "Protected", "Private", "Package" };
            _MethName = NewMethName;
            _MethType = NewMethType;
            _MethAccess = AllAccess[NewMethAcc];
            _MethSpec = "«";
            _MethParam = Param;
            if (IA)
            {
                _MethSpec += "abstract ";
            }
            if (IC)
            {
                _MethSpec += "create ";
            }
            if (IS)
            {
                _MethSpec += "static ";
            }
            if (IV)
            {
                _MethSpec += "virtual";
            }
            _MethSpec += "»";
            //"«abstract»

        }
    }
}

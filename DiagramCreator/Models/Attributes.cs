using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramCreator.Models
{
    public class Attributes
    {

        private string _AttrName;
        public string AttrName
        {
            get => _AttrName;
            set
            {
                _AttrName = value;
            }
        }
        private string _AttrType;
        public string AttrType
        {
            get => _AttrType;
            set
            {
                _AttrType = value;
            }
        }
        private string _AttrAccess;
        public string AttrAccess
        {
            get => _AttrAccess;
            set
            {
                _AttrAccess = value;
            }
        }
        private string _AttrSpec;
        public string AttrSpec
        {
            get => _AttrSpec;
            set
            {
                _AttrSpec = value;
            }
        }
        private string _AttrSter;
        public string AttrSter
        {
            get => _AttrSter;
            set
            {
                _AttrSter = value;
            }
        }
        public Attributes(string NewName, string NewType, int NewAccess, int NewSter, bool NewIsReadonly, bool NewIsStatic, bool NewIsDefault, string NewDefault)
        {
            string[] AllAccess = { "Public", "Protected", "Private", "Package" };
            string[] AllSter = { "«event»", "«property»", "«required»" };
            _AttrName = NewName;
            _AttrType = NewType;
            _AttrAccess = AllAccess[NewAccess];
            _AttrSpec = " ";
            _AttrSter = AllSter[NewSter];
            if (NewIsReadonly)
            {
                _AttrSpec += "readonly ";
            }
            if (NewIsStatic)
            {
                _AttrSpec += "static ";
            }
            if (NewIsDefault)
            {
                _AttrSpec += NewDefault;
            }
            //_AttrSter += AllSter[NewSter];
            //_AttrSter += "»";
            //_AttrSter = "«event property»";
        }
    }
}

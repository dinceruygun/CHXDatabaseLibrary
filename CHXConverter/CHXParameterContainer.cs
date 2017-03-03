using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXConverter
{
    public abstract class CHXParameterContainer
    {
        Type _dataType;
        List<CHXParameter> _itemList;

        public Type DataType
        {
            get
            {
                return _dataType;
            }

            set
            {
                _dataType = value;
            }
        }

        public List<CHXParameter> ItemList
        {
            get
            {
                return _itemList;
            }

            set
            {
                _itemList = value;
            }
        }

        public CHXParameterContainer()
        {
            _itemList = new List<CHXParameter>();
        }
    }
}

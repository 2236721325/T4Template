using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Shared.Commons
{
    public class FilterBuilder
    {
        private readonly StringBuilder _content;
        private bool _isFirstAppend;
        public FilterBuilder()
        {
            _content = new StringBuilder();
            _isFirstAppend = true;
        }
        public void And(string filter)
        {
            if(_isFirstAppend)
            {
                _isFirstAppend = false;
            }
            else
            {
                _content.Append(" && ");
            }
            _content.Append(filter);
        }
        public string Build()
        {
            return _content.ToString();
        }
    }
}

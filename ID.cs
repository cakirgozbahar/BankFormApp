using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class ID
    {
        private string _id;

        public ID(string id)
        {
            _id = id;
        }

        public string getID()
        {
            return this._id.Substring(0, 5) + "******";
        }
        public void setID(string id)
        {
            this._id = id;
        }
    }
}

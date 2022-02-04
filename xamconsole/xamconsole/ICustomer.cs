using System;
using System.Collections.Generic;
using System.Text;

namespace xamconsole
{
    interface ICustomer
    {
        void Create();
        bool Delete();
        bool SignIn();
        void Update();
    }
}

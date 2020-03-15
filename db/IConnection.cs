using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace election.db
{
    interface IConnection
    {
        void connection();

        void update();

        void paste();

        void del();

    }
}

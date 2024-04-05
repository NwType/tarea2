using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud3.Bss
{
    public class ClienteBss
    { 
        public DataTable ListarClienteBss()
        {
            return dal.ListarClienetesDal();
        }
    }
}

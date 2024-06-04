using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAMSDaLayer
{
    public interface IUserInterfaceSupportDAO <T>
    {
        List<T> GetAllRecords();
    }
}

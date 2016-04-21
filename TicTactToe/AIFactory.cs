using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTactToe
{
    public interface AIFactory
    {
        Button Turn(IEnumerable<Button> buttonList);
    }
}

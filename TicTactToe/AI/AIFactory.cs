using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTactToe
{
    public interface AIFactory
    {
        Button Turn(IEnumerable<Button> buttonList);
    }
}

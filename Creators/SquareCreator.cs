using lab3_rpm.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace lab3_rpm.Creators
{
    public abstract class SquareCreator
    {
        public abstract Square Create();
    }

    public class RedSquareCreator : SquareCreator
    {
        public override Square Create() =>
            new Square { Color = Colors.Red };
    }

    public class BlueSquareCreator : SquareCreator
    {
        public override Square Create() =>
            new Square { Color = Colors.Blue };
    }

    public class GreenSquareCreator : SquareCreator
    {
        public override Square Create() =>
            new Square { Color = Colors.Green };
    }
}

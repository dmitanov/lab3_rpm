using lab3_rpm.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace lab3_rpm.Creators
{
    public abstract class CircleCreator
    {
        public abstract Circle Create();
    }

    public class RedCircleCreator : CircleCreator
    {
        public override Circle Create() =>
            new Circle { Color = Colors.Red };
    }

    public class BlueCircleCreator : CircleCreator
    {
        public override Circle Create() =>
            new Circle { Color = Colors.Blue };
    }

    public class GreenCircleCreator : CircleCreator
    {
        public override Circle Create() =>
            new Circle { Color = Colors.Green };
    }
}

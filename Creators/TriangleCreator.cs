using lab3_rpm.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace lab3_rpm.Creators
{
    public abstract class TriangleCreator
    {
        public abstract Triangle Create();
    }

    public class RedTriangleCreator : TriangleCreator
    {
        public override Triangle Create() =>
            new Triangle { Color = Colors.Red };
    }

    public class BlueTriangleCreator : TriangleCreator
    {
        public override Triangle Create() =>
            new Triangle { Color = Colors.Blue };
    }

    public class GreenTriangleCreator : TriangleCreator
    {
        public override Triangle Create() =>
            new Triangle { Color = Colors.Green };
    }
}

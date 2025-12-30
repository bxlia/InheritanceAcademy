using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal interface IHaveDiagonal
    {
        double GetDiagonal(); //Любой метод объявленный ынцтри интерфейса по умолчанию является абстрактным и публичным
        void DrawDiagonal(System.Windows.Forms.PaintEventArgs e);
    }
}

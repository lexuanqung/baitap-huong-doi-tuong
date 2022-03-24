using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bai_7
{
    class ToaDo
    {
        string ten;
        float x, y;

        public ToaDo()
        {
        }

        public ToaDo(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public void setX(float NewX) { if (NewX > 0) this.x = NewX; else NewX = 0; }
        public void setY(float NewY) { if (NewY > 0) this.y = NewY; else NewY = 0; }
        public float getX() { return x; }
        public float getY() { return y; }

        public override string ToString()
        {
            return $"{this.ten}( {this.x},{this.y})";
        }
        
    }
}

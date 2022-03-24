using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_7
{
    class HinhTron : ToaDo
    {
        ToaDo tam;
        double bankinh;

        public double tinhChuvi()
        {
            return 2 * 3.14 * bankinh;
        }
        public double tinhDientich()
        {
            return 3.14 * bankinh * bankinh;
        }

        public HinhTron(ToaDo tam, double bankinh)
        {
            this.tam = tam;
            this.bankinh = bankinh;
        }

        public HinhTron()
        {
        }
        public void setTam(ToaDo NewToado) { this.tam = NewToado; }
        public void setBankinh(double NewBankinh) { this.bankinh = NewBankinh; }
        public ToaDo getTam() { return tam; }
        public double getBankinh (){ return bankinh; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

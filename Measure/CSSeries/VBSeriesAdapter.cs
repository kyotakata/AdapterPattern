using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measure.CSSeries
{

    internal class VBSeriesAdapter : CSSeriesBase
    {
        private VB.IVBSeries _vBSeries;    // Adapteeインターフェース(自分でnewしていたらコンポジションだが、今回は外部からインスタンスが与えられているので、集約を使用したAdapterという定義となる)

        /// <summary>
        /// コンストラクタ
        /// 外部からインスタンス与えられるので集約を使用したAdapter。
        /// </summary>
        /// <param name="vBSeries"></param>
        public VBSeriesAdapter(VB.IVBSeries vBSeries)
        {
            _vBSeries = vBSeries;
        }

        public override int GetMeasure()
        {
           return _vBSeries.GetValue();
        }
    }
}

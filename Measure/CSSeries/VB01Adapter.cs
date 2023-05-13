using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 使っていない
namespace Measure.CSSeries
{
    /// <summary>
    /// Object Adapterクラス(コンポジション)
    /// </summary>
    internal class VB01Adapter : ICSSeries
    {
        private VB.VB01 _vb01 = new VB.VB01();    // Adapteeをコンポジションしている。
        public int GetMeasure()
        {
            // 現状はAdapteeから取得してきた値をそのまま返却しているが、CSSeriesに合わせた分解能に調節してあげる場合の変換処理はここで行う。
            return _vb01.GetValue();
        }

        // VB01機能にはなく、現在CSSeriesにある機能がある場合はこのAdapterクラスに実装を書いて、違いを吸収する必要がある。
        //↓にICSSeriesの定義を実装して違いを吸収。
    }

    /// <summary>
    /// Class Adapterクラス(継承)
    /// </summary>
    //internal class VB01Adapter : VB.VB01, ICSSeries
    //{
    //    public int GetMeasure()
    //    {
    //        // 現状はAdapteeから取得してきた値をそのまま返却しているが、CSSeriesに合わせた分解能に調節してあげる場合の変換処理はここで行う。
    //        return base.GetValue();// VB01クラスのメソッドを使う
    //    }

    //    // VB01機能にはなく、現在CSSeriesにある機能がある場合はこのAdapterクラスに実装を書いて、違いを吸収する必要がある。
    //    //↓にICSSeriesの定義を実装して違いを吸収。
    //}

}

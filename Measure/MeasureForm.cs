using Measure.CSSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Measure
{
    /// <summary>
    /// MeasureFormクラス
    /// 現在はCSSeriesBase抽象クラスに対して実装されている。元々はICSSeriesインターフェースに対して実装されていた。
    /// このCSSeriesBase、ICSSeriesに対して実装することで、MeasureFormクラス(Clientコード)に対する修正がいらなくなる。
    /// </summary>
    public partial class MeasureForm : Form
    {
        private CSSeriesBase _csSeries;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="csSeries"></param>
        public MeasureForm(CSSeriesBase csSeries)
        {
            _csSeries = csSeries;

            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

        }

        private void MeasureButton_Click(object sender, EventArgs e)
        {
            MeasureLabel.Text = _csSeries.GetMeasure() + "m/s2";
        }
    }
}

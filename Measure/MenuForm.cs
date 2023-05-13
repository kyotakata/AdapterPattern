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
    /// MenuFormクラス
    /// ボタンを押すことでターゲットインターフェースに継承されているクラスの各インスタンスが生成される
    /// </summary>
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// CS01インスタンス生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            using (var f = new MeasureForm(new CS01()))
            {
                f.ShowDialog();
            }
        }

        /// <summary>
        /// CS02インスタンス生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            using (var f = new MeasureForm(new CS02()))
            {
                f.ShowDialog();
            }

        }


        /// <summary>
        /// VB01インスタンス生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            using (var f = new MeasureForm(new VBSeriesAdapter(new VB.VB01())))
            {
                f.ShowDialog();
            }

        }


        /// <summary>
        /// VB02インスタンス生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            using (var f = new MeasureForm(new VBSeriesAdapter(new VB.VB02())))
            {
                f.ShowDialog();
            }

        }

    }
}

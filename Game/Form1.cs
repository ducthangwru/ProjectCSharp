using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager chessBoad;
        PanelSpin panelSpin;
        #endregion

        public Form1()
        {
            InitializeComponent();
            chessBoad = new ChessBoardManager(pnlChessBoard);
            

            panelSpin = new PanelSpin(pnlSpin, pctbSpin, timerSpin, txbSpinCard, bntSpin, bntStop);
            panelSpin.startPanelSpin();
        }

        private void pnlChessBoard_Paint(object sender, PaintEventArgs e)
        {
            chessBoad.DrawChessBoard(e);
        }  
    }
}

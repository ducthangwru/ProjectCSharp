using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class PanelSpin
    {
        #region Properties
        private Panel pnlSpin;
        private TextBox txbSpin;
        private Button bntSpin;
        private Button bntStopSpin;
        private PictureBox pctbCard;
        private Timer timerSpin;
        
        private ImageList imageCards = new ImageList();

        private Bitmap cardRedUp = Game.Properties.Resources.RedCardUp;
        private Bitmap cardRedUp2 = Game.Properties.Resources.RedCardUp2;
        private Bitmap cardRedDown = Game.Properties.Resources.RedCardDown;
        private Bitmap cardRedDown2 = Game.Properties.Resources.RedCardDown2;
        private Bitmap cardGreenUp = Game.Properties.Resources.GreenCardUp;
        private Bitmap cardGreenUp2 = Game.Properties.Resources.GreenCardUp2;
        private Bitmap cardGreenDown = Game.Properties.Resources.GreenCardDown;
        private Bitmap cardGreenDown2 = Game.Properties.Resources.GreenCardDown2;

        private int index = 0;
        #endregion

        #region Initialize
        public PanelSpin(Panel pnlSpin, PictureBox pctbCard, Timer timerSpin,
            TextBox txbSpin, Button bntSpin, Button bntStop)
        {
            this.pnlSpin = pnlSpin;
            this.txbSpin = txbSpin;
            this.bntSpin = bntSpin;
            this.bntStopSpin = bntStop;
            this.pctbCard = pctbCard;
            this.timerSpin = timerSpin;
            addCard();
        }

        public Panel PnlSpin
        {
            get { return pnlSpin; }
            set { pnlSpin = value; }
        }

        public TextBox TxbSpin
        {
            get { return txbSpin; }
            set { txbSpin = value; }
        }

        public Button BntSpin
        {
            get { return bntSpin; }
            set { bntSpin = value; }
        }

        public Button BntStop
        {
            get { return bntStopSpin; }
            set { bntStopSpin = value; }
        }

        public PictureBox PctbCard
        {
            get { return pctbCard; }
            set { pctbCard = value; }
        }

        public Timer TimerSpin 
        {
            get { return timerSpin; }
            set { timerSpin = value; }
        }

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        #endregion

        #region Methods
        public void addCard()
        {
            imageCards.ImageSize = new Size(178, 197);
            imageCards.Images.Add(cardRedUp);
            imageCards.Images.Add(cardRedUp2);
            imageCards.Images.Add(cardRedDown);
            imageCards.Images.Add(cardRedDown2);
            imageCards.Images.Add(cardGreenUp);
            imageCards.Images.Add(cardGreenUp2);
            imageCards.Images.Add(cardGreenDown);
            imageCards.Images.Add(cardGreenDown2);
        }

        public Image spinCard()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            index = rnd.Next(0, 7);
            return imageCards.Images[index];
        }


        public void startPanelSpin()
        {
            bntSpin.Click += bntSpin_Click;
            this.timerSpin = new System.Windows.Forms.Timer();
            this.timerSpin.Tick += new EventHandler(timerSpin_Tick);
            this.timerSpin.Enabled = false;
            bntStopSpin.Click += bntStopSpin_Click;
        }

        private void bntSpin_Click(object sender, EventArgs e)
        {
            timerSpin.Start();

            if (!bntSpin.Enabled)
                bntSpin.Enabled = true;
        }

        public void randomCard()
        {
            pctbCard.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbCard.Image = spinCard();

            switch (index)
            {
                case 0:
                    txbSpin.Text = "Rùa đỏ tiến 1 bước!";
                    break;
                case 1:
                    txbSpin.Text = "Rùa đỏ tiến 2 bước!";
                    break;
                case 2:
                    txbSpin.Text = "Rùa đỏ lùi 1 bước!";
                    break;
                case 3:
                    txbSpin.Text = "Rùa đỏ lùi 2 bước!";
                    break;
                case 4:
                    txbSpin.Text = "Rùa xanh tiến 1 bước!";
                    break;
                case 5:
                    txbSpin.Text = "Rùa xanh tiến 2 bước!";
                    break;
                case 6:
                    txbSpin.Text = "Rùa xanh lùi 1 bước!";
                    break;
                case 7:
                    txbSpin.Text = "Rùa xanh lùi 2 bước!";
                    break;
            }
        }

        private void timerSpin_Tick(object sender, EventArgs e)
        {
            randomCard();
        }

        private void bntStopSpin_Click(object sender, EventArgs e)
        {
            timerSpin.Stop();
        }


        #endregion
    }   
}

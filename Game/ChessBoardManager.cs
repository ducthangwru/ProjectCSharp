using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        private ImageList map = new ImageList();

        private Bitmap mapStart = Game.Properties.Resources.start;
        private Bitmap mapFinish = Game.Properties.Resources.finish;
        private Bitmap mapLand = Game.Properties.Resources.land;
        public Panel ChessBoard
        {
            get {return chessBoard;}
            set {chessBoard = value;}
        }

        public ImageList Map
        {
            get { return map; }
            set { map = value; }
        }
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard)
        {
            this.chessBoard = chessBoard;

            map.Images.Add(mapStart);
            map.Images.Add(mapLand);
            map.Images.Add(mapLand);
            map.Images.Add(mapLand);
            map.Images.Add(mapLand);
            map.Images.Add(mapLand);
            map.Images.Add(mapLand);
            map.Images.Add(mapLand);
            map.Images.Add(mapFinish);
        }
        #endregion

        #region Methods
        public void DrawChessBoard(PaintEventArgs e)
        {
            map.ImageSize = new Size(Cons.CHESS_WIDTH, Cons.CHESS_HEIGHT);
            for (int i = 0; i < 9; i++)
            {
                RectangleF rect = new RectangleF(i * Cons.CHESS_WIDTH, Cons.CHESS_MAP[i] * Cons.CHESS_HEIGHT, Cons.CHESS_WIDTH, Cons.CHESS_HEIGHT);

                // Draw image to screen.
                e.Graphics.DrawImage(map.Images[i], rect);
            }
            //PictureBox pctbOld = new PictureBox() { Width = 0, Height = 0 };
            //for(int i = 0; i < 10; i++)
            //{
            //    PictureBox pctb = new PictureBox()
            //    {
            //        Width = Cons.CHESS_WIDTH,
            //        Height = Cons.CHESS_HEIGHT,
            //        Location = new Point(pctbOld.Location.X + pctbOld.Width, Cons.CHESS_MAP[i] * Cons.CHESS_HEIGHT)
            //    };
            //    pctb.SizeMode = PictureBoxSizeMode.StretchImage;

            //    if (i == 0)
            //    {
            //        pctb.Image = Game.Properties.Resources.start;
            //    } 
            //    else if (i == 8)
            //    {
            //        pctb.Image = Game.Properties.Resources.finish;
            //    }
            //    else
            //    {
            //        pctb.Image = Game.Properties.Resources.land;
            //    }

            //    chessBoard.Controls.Add(pctb);
            //    pctbOld = pctb;
            //}

            //pctbOld.Location = new Point(0, pctbOld.Location.Y + Cons.CHESS_HEIGHT);
            //pctbOld.Width = 0;
            //pctbOld.Height = 0;
        }

        //public int getIndexTurtleGreen()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        if() 
        //        {
        //            return i;
        //        }
        //    }
        //    return 0;
        //}

        public void Update(PanelSpin panelSpin)
        {
            switch (panelSpin.Index)
            {
                
            }
        }
        #endregion
    }
      
}

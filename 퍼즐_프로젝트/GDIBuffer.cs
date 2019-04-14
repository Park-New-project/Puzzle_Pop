using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace 퍼즐_프로젝트
{
    class GDIBuffer
    {
        public static GDIBuffer oInstance = null;
        private Graphics background;
        private Bitmap bitoffScreen;

        private int nWidth;
        private int nHeight;

        int getWidth() { return nWidth; }
        int getHeight() { return nHeight; }
        public Graphics getGraphics { get { return background; } }
        public Bitmap GetImages { get { return bitoffScreen; } }
        private GDIBuffer(int nW, int nH)
        {
            nWidth = nW;
            nHeight = nH;

            bitoffScreen = new Bitmap(nWidth, nHeight);
            background = Graphics.FromImage(bitoffScreen);
        }
        public static GDIBuffer Instance(int nW, int nH)
        {
            if (oInstance == null)
            {
                oInstance = new GDIBuffer(nW, nH);
            }
            return oInstance;
        }
        public static GDIBuffer Instance()
        {
            try
            {
                if (oInstance == null)
                {
                    throw (new Exception("instance 선언이 되지 않았습니다."));
                }
                return oInstance;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}

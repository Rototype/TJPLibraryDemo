using System;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;


namespace tjp_tester
{
    class tjp
    {

        // set the barcode encoder to be uesed
        public enum Encoder
        {
	        QR = 1,
            // DATA_MATRIX = 2
        };
        // set the encode mode (most part aree not implemented)
        public enum QRencodeMode {
	        QR_MODE_NUM = 0,   ///< Numeric mode
	        QR_MODE_AN,        ///< Alphabet-numeric mode
	        QR_MODE_8,         ///< 8-bit data mode
	        QR_MODE_KANJI,     ///< Kanji (shift-jis) mode
	        QR_MODE_STRUCTURE, ///< Internal use only
	        QR_MODE_ECI,       ///< ECI mode
	        QR_MODE_FNC1FIRST,  ///< FNC1, first position
	        QR_MODE_FNC1SECOND, ///< FNC1, second position
        };
        // set the error correction level
        public enum QRecLevel
        {
	        QR_ECLEVEL_L = 0, ///< lowest
	        QR_ECLEVEL_M,
	        QR_ECLEVEL_Q,
	        QR_ECLEVEL_H      ///< highest
        };

        [DllImport("tjp.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public extern static int SetBarcode(byte[] lpBuffer);

        [DllImport("tjp.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public extern static int StartInit();

        [DllImport("tjp.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public extern static int LoadInitBitmap(string BmpFilename, UInt32 Id);

        [DllImport("tjp.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public extern static int EndInit(string RbdFilename, byte[] lpBuffer, UInt32 Size);

        [DllImport("tjp.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public extern static int StartDocument();

        [DllImport("tjp.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public extern static int LoadDocumentBarcode(string BarcodeData, UInt32 Id, UInt32 Zoom);

        [DllImport("tjp.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public extern static int LoadDocumentField(string Field, UInt32 Id);

        [DllImport("tjp.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public extern static int EndDocument(UInt16 DocType, byte[] lpBuffer, UInt32 Size);

        [DllImport("tjp.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public extern static int GetDimensions(string RbdFilename, ref uint Width, ref uint Height);

    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace tjp_tester
{
/*
#define TJP_SUCCESS						0
#define TJP_ERR_OUT_OF_MEMORY			(-1)
#define TJP_ERR_INVALID_BUFFER			(-2)
#define TJP_ERR_INVALID_VALUE			(-3)
#define TJP_ERR_INTERNAL_ERROR			(-4)
#define TJP_ERR_OPEN_FILE_ERROR			(-5)
#define TJP_ERR_INVALID_BC_DEF			(-6)
#define TJP_ERR_BC_CREATION				(-7)
#define TJP_ERR_LOAD_BMP				(-8)
#define TJP_ERR_SAVE_RYG				(-9)
#define TJP_ERR_FILE_SIZE				(-10)
#define TJP_ERR_ENC_LOAD				(-11)
#define TJP_ERR_ENC_CONV				(-12)
#define TJP_ERR_ENC_SAVE				(-13)
#define TJP_ERR_SIZE_BMP				(-14)
*/

    public enum ErrorCodes
    {
        TJP_SUCCESS					= 0,
        TJP_ERR_OUT_OF_MEMORY		=(-1),
        TJP_ERR_INVALID_BUFFER		=(-2),
        TJP_ERR_INVALID_VALUE		=(-3),
        TJP_ERR_INTERNAL_ERROR		=(-4),
        TJP_ERR_OPEN_FILE_ERROR		=(-5),
        TJP_ERR_INVALID_BC_TYPE		=(-6),
        TJP_ERR_BC_CREATION			=(-7),
        TJP_ERR_LOAD_BMP			=(-8),
        TJP_ERR_SAVE_RYG			=(-9),
        TJP_ERR_FILE_SIZE           =(-10),
        TJP_ERR_ENC_LOAD			=(-11),
        TJP_ERR_ENC_CONV			=(-12),
        TJP_ERR_ENC_SAVE			=(-13),
        TJP_ERR_SIZE_BMP            =(-14)
    }

    
    class TjpErrors
    {
        public static string Get( int err) {
                return string.Format("{1}[{0}]", err, ((ErrorCodes)err)).ToString();
        }

        public static void Show(int err)
        {
            if (err == (int)ErrorCodes.TJP_SUCCESS)
                return;
            else 
                System.Windows.Forms.MessageBox.Show(
                    Get(err),
                    "Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error
                );
        }
    }
}

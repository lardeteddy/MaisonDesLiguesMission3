using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Ecc;
using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.Codec.Util;
using System.Drawing;

namespace MaisonDesLigues
{
    class QRCODE
    {
        /// <summary>
        /// Genére une image de Qr Code avec l'id de l'atelier, et le niveau de difficulté de celui ci
        /// </summary>
        /// <param name="input">Valeur du Qr Code</param>
        /// <param name="qrlevel">niveau de difficulté du Qr code</param>
        /// <returns></returns>
        public Image QRGen(string input, int qrlevel)
        {
            
            //encode mon qr code
            MessagingToolkit.QRCode.Codec.QRCodeEncoder qe = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            
            qe.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            
            qe.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L; // - Using LOW for more storage
            //niveau de difficulté du qr code
            qe.QRCodeVersion = qrlevel;
            //dessine le qr code
            System.Drawing.Bitmap bm = qe.Encode(input);

            return bm;

        }
    }
}

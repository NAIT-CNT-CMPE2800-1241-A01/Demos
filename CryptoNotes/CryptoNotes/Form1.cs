using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace CryptoNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_B_EncAES_Click(object sender, EventArgs e)
        {
// symmetric encryption values (pulled out to show how they could be used in different domains)
List<byte> aesIV = null;
List<byte> aeskey = null;
List<byte> thedata = null;

{
    //////////////////////////////////////////////////////////////////////
    // to encrypt:
    //////////////////////////////////////////////////////////////////////
    AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
    aes.KeySize = 256; // max size!
    aes.GenerateIV(); // redundant, done by CTOR
    aes.GenerateKey(); // redundant, done by CTOR
                        // key and IV must be same for e/d operations
                        // key is a secret, IV is not

    // save these to create the decryption part!
    aesIV = new List<byte>(aes.IV);
    aeskey = new List<byte>(aes.Key);

    // get desired data into a byte array, in this case a string from a textbox,
    //  but could be JSON, or any text/binary source
    byte[] byte_data = Encoding.UTF8.GetBytes(UI_TB_Text.Text);
    Console.WriteLine($"byte encoded size is {byte_data.Length}");
    Console.WriteLine(string.Join(", ", byte_data.Select(q => $"{q:X2}")));

    // create a stream in memory to hold encrypted data
    //  a memorystream is like a file (or any other stream), but exists only in memory
    MemoryStream msTarget = new MemoryStream();

    // create crypto stream that can write encrypted data as a stream into the memory stream
    // note options are to create an encryptor, in write mode
    CryptoStream cs = new CryptoStream(msTarget, aes.CreateEncryptor(), CryptoStreamMode.Write);

    // write the bytes into the encrypted stream (it writes to the memory stream)
    cs.Write(byte_data, 0, byte_data.Length);

    // all important, flush final data to stream (or it remains buffered)
    cs.FlushFinalBlock();

    // pull bytes from the memory stream, being sure to only observe the used length
    //  this is critical, as the capacity will be bigger than the used length
    Console.WriteLine($"encrypted size is {msTarget.Length}");
    Console.WriteLine(string.Join(", ", msTarget.GetBuffer().Take((int)msTarget.Length).Select(q => $"{q:X2}")));

    // save the data for decryption elsewhere
    // assume this is sent to 'the other side'
    thedata = new List<byte>(msTarget.GetBuffer().Take((int)msTarget.Length));
    //////////////////////////////////////////////////////////////////////            
}

{
    //////////////////////////////////////////////////////////////////////
    // to decrypt:
    //////////////////////////////////////////////////////////////////////
    // build an aes object with the same parameters to decrypt
    // must use the same key and IV as encryptor
    AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
    aes.Key = aeskey.ToArray();
    aes.IV = aesIV.ToArray();

    // build a memory stream wrapped around the source byte array (encrypted data)
    MemoryStream msWrapper = new MemoryStream(thedata.ToArray());

    // create the crypto stream that reads from the encrypted stream and can write to a decrypted stream
    CryptoStream cs = new CryptoStream(msWrapper, aes.CreateDecryptor(), CryptoStreamMode.Read);
                
    // create the target stream for the decrypted data
    MemoryStream msDecrypted = new MemoryStream();

    // copy the encrypted data to the output stream, decrypting as it does so
    cs.CopyTo(msDecrypted);

    // stream will be at end, so rewind if you want to operate it as a stream
    //msDecrypted.Seek(0, SeekOrigin.Begin); // not necessary if not using as stream

    // the decrypted stream now contains the decrypted byte array
    // be sure to only observe the used length
    // interpret the decrypted byte array as whatever it was (could be a JSON string)
    Console.WriteLine (Encoding.UTF8.GetString(msDecrypted.GetBuffer(), 0, (int)msDecrypted.Length));
}
        }
    }
}

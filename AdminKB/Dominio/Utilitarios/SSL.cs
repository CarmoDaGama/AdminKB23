using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio.Utilitarios
{
    public static class SSL
    {
        class DataHash
        {
            public DateTime DataHora { get; set; }
            public string CodigoAGT { get; set; }
            public decimal Total { get; set; }
            public string HashAnterior { get; set; }
        }
        private static string ChavePrivada
        {
            //cmd gera Chave privada: genrsa -out ChaveKsoftPrivada.pem 1024
            get
            {
                return "-----BEGIN RSA PRIVATE KEY-----" +
                        "\nMIICWwIBAAKBgQCjovdBpStOUsqAHqgM0MU4xPyyipBbFCEqOOATbyElrVc9JE55" +
                        "\nM5LEL/kqcmSvSvKy3lItWYhfonwaA3gLXBP3Om0ZFltyGKggt9VNRIdI/j8N4p5t" +
                        "\nkp4T3YX8rTKI2C4WYMmzTvZmx7wKLEdCNmbdVrhSTwq7xcH8A8IMthbeFwIDAQAB" +
                        "\nAoGAPawh/D+//pj9cSQcuhfE/QxhIPlQRsNjbIJbEXgEyip2gri4Sr3BRue9xN2w" +
                        "\nTNC2f+uClUz1NPYMR9Ge4MknTKAImzpIOWYAqX4KqRdy5svjhQItAO/xQ/XTsyN8" +
                        "\n4XRghhZaZuRU8ppMMfBSUOPlHA/HWh2ncRwPA+VGFSi2tIECQQDR5E+LcT3Qrrhc" +
                        "\neRJRLba/sSTRE4mUE+chKqJFqbhr6m/nh/oJvcrnvw3a2TxfCEcR7hUVjzQmKq1w" +
                        "\nW0FtyNRnAkEAx5Vl4+4FiRUl31v9klblDCjT6Fq557cdnPogFQioxslzE/iUbYT8" +
                        "\nEGxL6T6VOEa/12PHL0SR6PgxjXPekpka0QJAI1j84HHwxB04pTIqmItHVJ8joSZW" +
                        "\nLB7x9M72Rx8fFOWFdQucW1mgO0kcrzeYiDSfq3BaEqhsUuUrEln7+d4xjwJADHPU" +
                        "\n1KDQNZpdL490xcGoLtcJSbEHcl6peVbd05IjvatqA6/5ys+GTpwDLH1cIBPB+nVe" +
                        "\nQyO7GtcJeHLnSyxEUQJAIItvA+THgnC/nDn1XO2Gb61n4xZD6paPThj2GC7OuW+t" +
                        "\nNrZpeJ0QiWzum3gHLV5DDrSfOeyUofS16ARZQiZFsg==" +
                        "\n-----END RSA PRIVATE KEY-----";
            }
        }
        public static string ChavePublica
        {
            //cmd gera Chave publica: rsa -in ChaveKsoftPrivada.pem -out ChaveKsoftPublica.pem -outform PEM –pubout
            get
            {
                return "-----BEGIN PUBLIC KEY-----" +
                        "\nMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCjovdBpStOUsqAHqgM0MU4xPyy" +
                        "\nipBbFCEqOOATbyElrVc9JE55M5LEL/kqcmSvSvKy3lItWYhfonwaA3gLXBP3Om0Z" +
                        "\nFltyGKggt9VNRIdI/j8N4p5tkp4T3YX8rTKI2C4WYMmzTvZmx7wKLEdCNmbdVrhS" +
                        "\nTwq7xcH8A8IMthbeFwIDAQAB" +
                        "\n-----END PUBLIC KEY-----";
            }
        }

        public static string VersaoChavePrivada { get { return "1.0"; } }
        public static string RetornaCaracteresHashDoDoc(string hash)
        {
            return string.IsNullOrEmpty(hash) ? "0000" : RetornaCaracteres(hash).ToUpper();
        }

        private static string RetornaCaracteres(string hash)
        {
            if (string.IsNullOrEmpty(hash))
            {
                return "0000";
            }
            else
            {
                return hash[0] + "" + hash[10] + "" + hash[20] + "" + hash[30];
            }
        }

        public static string RetornaDadosHash(DateTime dataHora, string codAGT, decimal totalIliquido, string hashAnterior)
        {
            var extData = string.Empty;
            var strTotal = totalIliquido.ToString().Replace(",", ".");
            if (string.IsNullOrEmpty(hashAnterior))
            {
                extData = dataHora.ToString("yyyy-MM-dd").Trim() + ";"
                    + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss").Trim() + ";"
                    + codAGT.Trim() + ";"
                    + strTotal.Trim() + ";";
            }
            else
            {
                extData = dataHora.ToString("yyyy-MM-dd").Trim() + ";"
                    + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss").Trim() + ";"
                    + codAGT.Trim() + ";"
                    + strTotal.Trim() + ";"
                    + hashAnterior;
            }
            return extData;
        }
        public static string GerarHash(string dados)
        {
            var dadosHash = RetornaDadosHash(dados);
            string caminhoDoHash = RetornaCaminhoDoHash(dadosHash);

            string hashNameFile = "hash" + dadosHash.CodigoAGT.Split('/')[1];
            string file = caminhoDoHash + "\\" + hashNameFile + ".txt";
            string fileResulHash = caminhoDoHash + "\\" + hashNameFile + ".b64";

            // ======================= Criar o ficheiro ==========================================
            Ficheiro.SalvaFicheiro(file, dados);

            // ======================= End Criar o ficheiro ==========================================
            var executavelSSL = RetornaCaminhoOpenSSL();
            if (string.IsNullOrEmpty(executavelSSL) && !VerificaChaves(caminhoDoHash))
            {
                Console.WriteLine("Executavel OpenSSL Não encontrado!");
                return string.Empty;
            }
            else {
                // ---------------------------------- CMD Proccess --------------------------------------------------------------------

                Util.ExecutaComandoCMD(
                    "cd " + caminhoDoHash,
                    executavelSSL + " dgst -sha1 -sign ChaveKsoftPrivada.pem -out sha1.sign " + hashNameFile + ".txt",
                    executavelSSL + " enc -in sha1.sign -base64 -A -out " + hashNameFile + ".b64"
                );
                // ---------------------------------- END CMD Proccess --------------------------------------------------------------------

                StreamReader readH = File.OpenText(fileResulHash);

                string hashGerada = readH.ReadToEnd();
                readH.Close();
                Ficheiro.EliminaArquivo(caminhoDoHash + "\\sha1.sign");
                return hashGerada;
            }
        }

        private static bool VerificaChaves(string caminhoDoHash)
        {
            var chaveP = caminhoDoHash + @"\ChaveKsoftPrivada.pem";
            var chavePub = caminhoDoHash + @"\ChaveKsoftPublica.pem";
            if (!File.Exists(chaveP))
            {
                Ficheiro.SalvaFicheiro(chaveP, ChavePrivada);
            }
            if (!File.Exists(chavePub))
            {
                Ficheiro.SalvaFicheiro(chavePub, ChavePublica);
            }

            return File.Exists(chaveP) && File.Exists(chavePub);
        }

        private static string RetornaCaminhoOpenSSL()
        {
            string executavelSSL = "\"" + Application.StartupPath + "\\OpenSSL-Win64\\bin\\openssl.exe\"";
            if (!File.Exists(Application.StartupPath + "\\OpenSSL-Win64\\bin\\openssl.exe"))
            {
                executavelSSL = "\"C:\\Program Files\\OpenSSL-Win64\\bin\\openssl.exe\"";
                if (!File.Exists("C:\\Program Files\\OpenSSL-Win64\\bin\\openssl.exe"))
                {
                    return string.Empty;
                }
                else
                {
                    return executavelSSL;
                }
            }
            else
            {
                return executavelSSL;
            }
        }

        private static string RetornaCaminhoDaChave()
        {
            var path = Application.StartupPath + "\\KSoft_hash\\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        private static string RetornaCaminhoDoHash(DataHash dadosHash)
        {
            var serie = dadosHash.CodigoAGT.Split('/')[0];
            var path = Application.StartupPath + "\\KSoft_hash\\"; 
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var newPath = path + serie;
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }
            if (!File.Exists(newPath + "\\ChaveKsoftPrivada.pem"))
            {
                File.Copy(path + "ChaveKsoftPrivada.pem", newPath + "\\ChaveKsoftPrivada.pem");

            }
            if (!File.Exists(newPath + "\\ChaveKsoftPublica.pem"))
            {
                File.Copy(path + "\\ChaveKsoftPublica.pem", newPath + "\\ChaveKsoftPublica.pem");
            }
            return newPath;
        }

        private static DataHash RetornaDadosHash(string dados)
        {
            var splitDados = dados.Split(';');
            var strData = splitDados[1].Replace("T", " ");
            var data = Convert.ToDateTime(strData);
            var total = Convert.ToDecimal(splitDados[3]);
            return new DataHash
            {
                DataHora = data,
                CodigoAGT = splitDados[2], 
                Total = total, 
                HashAnterior = splitDados[4]
            };
        }

        public static string GerarCodigoDeAcesso(Usuario usuario)
        {
            var numeroAleatorio = new Random().Next(100000000, int.MaxValue).ToString();

            int posicaoDoId = RetorntaPosicaoDoId(usuario.UsuarioId);
            var oldCaracter = numeroAleatorio[posicaoDoId].ToString();
            var novocodigo = numeroAleatorio.Replace(oldCaracter, usuario.UsuarioId.ToString());
            return novocodigo;
        }

        private static int RetorntaPosicaoDoId(int usuarioId)
        {
            return Convert.ToInt32(usuarioId.ToString()[0].ToString());
        }
        static void MainTest()
        {
            //lets take a new CSP with a new 2048 bit rsa key pair
            var csp = new RSACryptoServiceProvider(1024);

            //how to get the private key
            var privKey = csp.ExportParameters(true);

            //and the public key ...
            var pubKey = csp.ExportParameters(false);

            //converting the public key into a string representation
            string pubKeyString;
            {
                //we need some buffer
                var sw = new System.IO.StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, pubKey);
                //get the string from the stream
                pubKeyString = sw.ToString();
            }

            //converting it back
            {
                //get a stream from the string
                var sr = new System.IO.StringReader(pubKeyString);
                //we need a deserializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //get the object back from the stream
                pubKey = (RSAParameters)xs.Deserialize(sr);
            }

            //conversion for the private key is no black magic either ... omitted

            //we have a public key ... let's get a new csp and load that key
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(pubKey);

            //we need some data to encrypt
            var plainTextData = "foobar";

            //for encryption, always handle bytes...
            var bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(plainTextData);

            //apply pkcs#1.5 padding and encrypt our data 
            var bytesCypherText = csp.Encrypt(bytesPlainTextData, false);

            //we might want a string representation of our cypher text... base64 will do
            var cypherText = Convert.ToBase64String(bytesCypherText);


            /*
             * some transmission / storage / retrieval
             * 
             * and we want to decrypt our cypherText
             */

            //first, get our bytes back from the base64 string ...
            bytesCypherText = Convert.FromBase64String(cypherText);

            //we want to decrypt, therefore we need a csp and load our private key
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(privKey);

            //decrypt and strip pkcs#1.5 padding
            bytesPlainTextData = csp.Decrypt(bytesCypherText, false);

            //get our original plainText back...
            plainTextData = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);
        }
    }

    class MyMainClass
    {
        private static void Prime()
        {
            byte[] toEncrypt;
            byte[] encrypted;
            byte[] signature;
            //Choose a small amount of data to encrypt.
            string original = "Hello";
            ASCIIEncoding myAscii = new ASCIIEncoding();

            //Create a sender and receiver.
            Sender mySender = new Sender();
            Receiver myReceiver = new Receiver();

            //Convert the data string to a byte array.
            toEncrypt = myAscii.GetBytes(original);

            //Encrypt data using receiver's public key.
            encrypted = mySender.EncryptData(myReceiver.PublicParameters, toEncrypt);

            //Hash the encrypted data and generate a signature on the hash
            // using the sender's private key.
            signature = mySender.HashAndSign(encrypted);

            Console.WriteLine("Original: {0}", original);

            //Verify the signature is authentic using the sender's public key.
            if (myReceiver.VerifyHash(mySender.PublicParameters, encrypted, signature))
            {
                //Decrypt the data using the receiver's private key.
                myReceiver.DecryptData(encrypted);
            }
            else
            {
                Console.WriteLine("Invalid signature");
            }
        }

        private static void ExportPrivateKey(RSACryptoServiceProvider csp, TextWriter outputStream)
        {
            if (csp.PublicOnly) throw new ArgumentException("CSP does not contain a private key", "csp");
            var parameters = csp.ExportParameters(true);
            using (var stream = new MemoryStream())
            {
                var writer = new BinaryWriter(stream);
                writer.Write((byte)0x30); // SEQUENCE
                using (var innerStream = new MemoryStream())
                {
                    var innerWriter = new BinaryWriter(innerStream);
                    EncodeIntegerBigEndian(innerWriter, new byte[] { 0x00 }); // Version
                    EncodeIntegerBigEndian(innerWriter, parameters.Modulus);
                    EncodeIntegerBigEndian(innerWriter, parameters.Exponent);
                    EncodeIntegerBigEndian(innerWriter, parameters.D);
                    EncodeIntegerBigEndian(innerWriter, parameters.P);
                    EncodeIntegerBigEndian(innerWriter, parameters.Q);
                    EncodeIntegerBigEndian(innerWriter, parameters.DP);
                    EncodeIntegerBigEndian(innerWriter, parameters.DQ);
                    EncodeIntegerBigEndian(innerWriter, parameters.InverseQ);
                    var length = (int)innerStream.Length;
                    EncodeLength(writer, length);
                    writer.Write(innerStream.GetBuffer(), 0, length);
                }

                var base64 = Convert.ToBase64String(stream.GetBuffer(), 0, (int)stream.Length).ToCharArray();
                outputStream.WriteLine("-----BEGIN RSA PRIVATE KEY-----");
                // Output as Base64 with lines chopped at 64 characters
                for (var i = 0; i < base64.Length; i += 64)
                {
                    outputStream.WriteLine(base64, i, Math.Min(64, base64.Length - i));
                }
                outputStream.WriteLine("-----END RSA PRIVATE KEY-----");
            }
        }

        private static void EncodeLength(BinaryWriter stream, int length)
        {
            if (length < 0) throw new ArgumentOutOfRangeException("length", "Length must be non-negative");
            if (length < 0x80)
            {
                // Short form
                stream.Write((byte)length);
            }
            else
            {
                // Long form
                var temp = length;
                var bytesRequired = 0;
                while (temp > 0)
                {
                    temp >>= 8;
                    bytesRequired++;
                }
                stream.Write((byte)(bytesRequired | 0x80));
                for (var i = bytesRequired - 1; i >= 0; i--)
                {
                    stream.Write((byte)(length >> (8 * i) & 0xff));
                }
            }
        }

        private static void EncodeIntegerBigEndian(BinaryWriter stream, byte[] value, bool forceUnsigned = true)
        {
            stream.Write((byte)0x02); // INTEGER
            var prefixZeros = 0;
            for (var i = 0; i < value.Length; i++)
            {
                if (value[i] != 0) break;
                prefixZeros++;
            }
            if (value.Length - prefixZeros == 0)
            {
                EncodeLength(stream, 1);
                stream.Write((byte)0);
            }
            else
            {
                if (forceUnsigned && value[prefixZeros] > 0x7f)
                {
                    // Add a prefix zero to force unsigned if the MSB is 1
                    EncodeLength(stream, value.Length - prefixZeros + 1);
                    stream.Write((byte)0);
                }
                else
                {
                    EncodeLength(stream, value.Length - prefixZeros);
                }
                for (var i = prefixZeros; i < value.Length; i++)
                {
                    stream.Write(value[i]);
                }
            }
        }
    }

    class Sender
    {
        RSAParameters rsaPubParams;
        RSAParameters rsaPrivateParams;

        public Sender()
        {
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();

            //Generate public and private key data.
            rsaPrivateParams = rsaCSP.ExportParameters(true);
            rsaPubParams = rsaCSP.ExportParameters(false);
            
        }

        public RSAParameters PublicParameters
        {
            get
            {
                return rsaPubParams;
            }
        }

        //Manually performs hash and then signs hashed value.
        public byte[] HashAndSign(byte[] encrypted)
        {
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();
            SHA1Managed hash = new SHA1Managed();
            byte[] hashedData;

            rsaCSP.ImportParameters(rsaPrivateParams);

            hashedData = hash.ComputeHash(encrypted);
            return rsaCSP.SignHash(hashedData, CryptoConfig.MapNameToOID("SHA1"));
        }

        //Encrypts using only the public key data.
        public byte[] EncryptData(RSAParameters rsaParams, byte[] toEncrypt)
        {
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();

            rsaCSP.ImportParameters(rsaParams);
            return rsaCSP.Encrypt(toEncrypt, false);
        }
    }

    class Receiver
    {
        RSAParameters rsaPubParams;
        RSAParameters rsaPrivateParams;

        public Receiver()
        {
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();

            //Generate public and private key data.
            rsaPrivateParams = rsaCSP.ExportParameters(true);
            rsaPubParams = rsaCSP.ExportParameters(false);
        }

        public RSAParameters PublicParameters
        {
            get
            {
                return rsaPubParams;
            }
        }

        //Manually performs hash and then verifies hashed value.
        public bool VerifyHash(RSAParameters rsaParams, byte[] signedData, byte[] signature)
        {
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();
            SHA1Managed hash = new SHA1Managed();
            byte[] hashedData;

            rsaCSP.ImportParameters(rsaParams);
            bool dataOK = rsaCSP.VerifyData(signedData, CryptoConfig.MapNameToOID("SHA1"), signature);
            hashedData = hash.ComputeHash(signedData);
            return rsaCSP.VerifyHash(hashedData, CryptoConfig.MapNameToOID("SHA1"), signature);
        }

        //Decrypt using the private key data.
        public void DecryptData(byte[] encrypted)
        {
            byte[] fromEncrypt;
            string roundTrip;
            ASCIIEncoding myAscii = new ASCIIEncoding();
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();

            rsaCSP.ImportParameters(rsaPrivateParams);
            fromEncrypt = rsaCSP.Decrypt(encrypted, false);
            roundTrip = myAscii.GetString(fromEncrypt);

            Console.WriteLine("RoundTrip: {0}", roundTrip);
        }
    }

}

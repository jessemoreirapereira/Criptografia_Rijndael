using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia
{
    class Cripto
    {
        public Cripto()
        {
        }

        public static string Decripta(string text, string password)
        {
            try
            {
                // Inistância da classe de criptografia
                RijndaelManaged _rijndaelManaged = new RijndaelManaged();

                // Recupera dado encriptado
                byte[] _textEncrypted = Convert.FromBase64String(text);

                // Salt que servirá de auxilio para criação da chave
                byte[] _salt = Encoding.ASCII.GetBytes(password.Length.ToString());

                // Recupera Chave
                PasswordDeriveBytes _key = new PasswordDeriveBytes(password, _salt);

                using (ICryptoTransform _decryptor = _rijndaelManaged.CreateDecryptor(_key.GetBytes(32), _key.GetBytes(16)))
                using (MemoryStream _memoryStream = new MemoryStream(_textEncrypted))
                {
                    // Realiza decriptografia
                    CryptoStream _cryptoStream = new CryptoStream(_memoryStream, _decryptor, CryptoStreamMode.Read);

                    byte[] _plainText = new byte[_textEncrypted.Length];

                    int _decryptedCount = _cryptoStream.Read(_plainText, 0, _plainText.Length);

                    // Retorna valor decriptografado
                    return Encoding.Unicode.GetString(_plainText, 0, _decryptedCount);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao Descriptografar: " + ex.Message);
            }
        }

        public static string Encripta(string text, string password)
        {
            try
            {
                // Instancia classe de criptografia
                RijndaelManaged _rijndaelManaged = new RijndaelManaged();

                byte[] _textUniCode = System.Text.Encoding.Unicode.GetBytes(text);

                // Salt que servirá de auxilio para criação da chave
                byte[] _salt = Encoding.ASCII.GetBytes(password.Length.ToString());

                // Recupera Chave
                PasswordDeriveBytes _key = new PasswordDeriveBytes(password, _salt);

                // Cria objeto Simétrico de criptografia
                using (ICryptoTransform _encryptor = _rijndaelManaged.CreateEncryptor(_key.GetBytes(32), _key.GetBytes(16)))
                using (MemoryStream _memoryStream = new MemoryStream())
                {
                    // Define o link entre valor original com a criptografia
                    CryptoStream _cryptoStream = new CryptoStream(_memoryStream, _encryptor, CryptoStreamMode.Write);

                    _cryptoStream.Write(_textUniCode, 0, _textUniCode.Length);

                    // Realiza "Deallocate" do objeto
                    _cryptoStream.FlushFinalBlock();

                    byte[] _cipherBytes = _memoryStream.ToArray();

                    return Convert.ToBase64String(_cipherBytes);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao Criptografar: " + ex.Message);
            }
        }


    }
}

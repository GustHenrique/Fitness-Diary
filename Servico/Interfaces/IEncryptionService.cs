using FitnessDiary.Entidades;

namespace FitnessDiary.Servico.Implementacoes
{
    public interface IEncryptionService
    {
        string Encrypt(string plainText);
        string Decrypt(string cipherText);
    }
}

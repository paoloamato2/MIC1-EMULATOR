namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class Utility
    {
        //metodo che converte un valore intero decimale in una stringa binaria con fissato numero di bit
        public static string ToBin(int value, int len)
        {
            return (len > 1 ? ToBin(value >> 1, len - 1) : null) + "01"[value & 1];
        }
    }
}
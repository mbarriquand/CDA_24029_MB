using System.Numerics;
using System.Text.RegularExpressions;

namespace MBarriquandTools
{
    public class RegexTools
    {
        public static bool FormatCarteBancaire(string _numCbAVerifier)
        {
            string RegexCB;
            RegexCB = @"^([0-9]{4}[ -]?){3}[0-9]{4}$";

            return Regex.IsMatch(_numCbAVerifier, RegexCB);

        }

        public static bool FormatEmail(string _emailAVerifier)
        {
            string RegexEmail;
            RegexEmail = @"^(([\w\.\-]+){2,64}@([\w\-\.?]+)((\.(\w){2,3})+){3,320)$";

            //v�rifier l'histoire du point apr�s le @

            return Regex.IsMatch(_emailAVerifier, RegexEmail);
        }

        public static bool FormatMdp(string _mdpAVerifier)
        {
            
            bool mdpOk = true;

            string regexLettresMinuscules = @"[a-z]{1,}";
            string regexLettresMajuscules = @"[A-Z]{1,}";
            string regexChiffres = @"[0-9]{1,}";
            string regexCaracteresSpeciaux = @"[^a-zA-Z0-9]+";

            if (!Regex.IsMatch(_mdpAVerifier, regexLettresMinuscules) || 
                !Regex.IsMatch(_mdpAVerifier, regexLettresMajuscules) ||
                !Regex.IsMatch(_mdpAVerifier, regexChiffres) ||
                !Regex.IsMatch(_mdpAVerifier, regexCaracteresSpeciaux) ||
                _mdpAVerifier.Length <= 12
                )
            {
                mdpOk = false;
            }

            return mdpOk;
            
        }

        public static bool FormatMdp20Char(string _mdpAVerifier20)
        {
            string regexLettresMinuscules = @"[a-z]{1,}";
            string regexLettresMajuscules = @"[A-Z]{1,}";
            string regexChiffres = @"[0-9]{1,}";
            string regexCaracteresSpeciaux = @"[^a-zA-Z0-9]+";

            if (!Regex.IsMatch(_mdpAVerifier20, regexLettresMinuscules) ||
                !Regex.IsMatch(_mdpAVerifier20, regexLettresMajuscules) ||
                !Regex.IsMatch(_mdpAVerifier20, regexChiffres) ||
                (!Regex.IsMatch(_mdpAVerifier20, regexCaracteresSpeciaux) &&
                _mdpAVerifier20.Length <= 20)
                )
            {
               return false;
            }

            return true;
        }

        public static bool FormatPrenomOuNom(string _nomAVerifier, int _longueurMinAcceptee)
        {
            Regex rgxPrenom = new Regex(@"^([a-z��������������A-Z\- ]{2," + _longueurMinAcceptee + "})$");

            // string rgxPrenom;
            // rgxPrenom = @"^([a-zA-Z\- ]{2,25})$";

            return rgxPrenom.IsMatch(_nomAVerifier);
        }

        public static bool FormatPrenomOuNom(string _prenomOuNomAVerifier)
        {
            return FormatPrenomOuNom(_prenomOuNomAVerifier, 30); // surcharge
        }
    }
    // TO DO :
    
    // Regex numeroTelephone
    //[0-79] plage de caract�re de 0 � 7 + le 9 (pour le num�ro de t�l�phone)

    // Regex URL

}
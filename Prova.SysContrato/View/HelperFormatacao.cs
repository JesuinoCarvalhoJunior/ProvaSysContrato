using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova.SysContrato.View
{
    public class HelperFormatacao
    {

        public static string FormataCPFCNPJ(string pCpfCnpj)
        {
            string result = "";
            if (pCpfCnpj.Length == 11)
            {
                return Convert.ToUInt64(pCpfCnpj).ToString(@"000\.000\.000\-00");
            }
            if (pCpfCnpj.Length == 14)
            {
                return Convert.ToUInt64(pCpfCnpj).ToString(@"00\.000\.000\/0000\-00");
            }

            if ((pCpfCnpj.Length != 11) && (pCpfCnpj.Length != 14))
            {
                result = pCpfCnpj;
            }
            return result;

        }
        public static string FormataCNPJ(string CNPJ)
        {

            return Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");

            // return String.Format(@"{0:00\.000\.000\/0000\-00}", CNPJ);
            /*
                        return string.Format("{0}.{1}.{2}/{3}-{4}",
                                    CNPJ.Substring(0, 2),
                                    CNPJ.Substring(2, 3),
                                    CNPJ.Substring(5, 3),
                                    CNPJ.Substring(8, 4),
                                 CNPJ.Substring(12, 2));
                                  */
        }

        public static string FormatCPF(string CPF)
        {
            return Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");
        }

        public static string RemoverFormatacao(string Codigo)
        {
            return Codigo.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);
        }


        public static string MascaraCPFCNPJ(string pCpfCnpj)
        {
            string result = "";
            if (pCpfCnpj.Length == 11)
            {
                result = pCpfCnpj.Insert(3, ".").Insert(7, ".").Insert(11, "-");
            }
            if (pCpfCnpj.Length == 14)
            {
                result = pCpfCnpj.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");
            }
            if ((pCpfCnpj.Length != 11) && (pCpfCnpj.Length != 14))
            {
                result = pCpfCnpj;
            }
            return result;
        }
    }
}

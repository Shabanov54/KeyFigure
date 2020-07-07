using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace key_figure
{
    public class Contex
    {
        long Codes  = 0;
        internal void InputCode(string addtxt)
        {
            try
            {
                if (addtxt.Length != 12)
                {
                    throw new Exception();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Выедено меньше или больше 12 симолов");
                throw new Exception();
            }
            finally
            {
                var code = Convert.ToInt64(addtxt);
                Codes = code;
            }
        }
        internal long GetCodes()
        {
            return Codes;
        }

    }
}

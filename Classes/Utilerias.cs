using System;
using System.Text;
using web2.Classes;
/*Mostrar en pantalla el valor capturado por el usuario en rotacion 13*/
namespace web2.Classes{
    public static class Utilerias{
            public static string Rotacion13(this string cad){
            string res = "";
            foreach(char c in cad){
                if(c >= 'a' && c <= 'z'){
                    res += (char)('a' + (c - 'a' + 13) % 26);
                }else if(c >= 'A' && c <= 'Z'){
                    res += (char)('A' + (c - 'A' + 13) % 26);
                }else{
                    res += c;
                }
            }
            return res;
        }
    }
}

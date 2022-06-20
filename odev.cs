using System;

class Odev{
    static String generateKey(String str, String key){
        int x = str.Length;
        for(int i = 0; i++){
            if(x==i)
                i=0;
                if(key.Length == str.Length)
                    break;
                key +=(key[i]);
        } 
        return key;
    }
    static String sifreMetin(String str, String key){
        String sifre_metin = "";

        for(int i=0; i<str.Length; i++;){
            int x=(str[i] + key[i]%26);
            x+='A';
            sifre_metin += (char)(x);
        }
        return sifre_metin;
    }
    static String originalText(String sifre_metin, String key){
        String orgin_text = "";
        for (int i=0; i<sifre_metin.Length&& i<key.Length; i++)
    }
}
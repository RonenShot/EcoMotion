using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EcoMotion.UTILITIES
{
    class ValidationsUtilities
    {
        //בדיקה האם מספר ת.ז חוקי ותקין
        public static bool LegalId(string s)
        {
            int x;
            if (!int.TryParse(s, out x))
                return false;
            if (s.Length < 5 || s.Length > 9)
                return false;
            for (int i = s.Length; i < 9; i++)
                s = "0" + s;
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                char c = s[i]; ;
                int k = ((i % 2) + 1) * (c - '0');
                if (k > 9)
                    k -= 9;
                sum += k;

            }
            return sum % 10 == 0;
        }
        // בדיקה האם מספר טלפון תקין 
        public static bool PhoneNumber(string num)
        {
            string pattern = @"\b0[2-4 7-9]-[2-9]\d{6}";
            Regex r = new Regex(pattern);
            return r.IsMatch(num);
        }
        // בדיקה האם שם תקין אותיות רק בעברית
        public static bool LegalName(string name)
        {
            string pattern = @"\b[א-ת- ]+";
            Regex r = new Regex(pattern);
            return r.IsMatch(name);
        }
        // בדיקת גיל
        public static int GetAge(DateTime d)
        {
            DateTime t = DateTime.Today;
            int age = t.Year - d.Year;
            if (t < d.AddYears(age)) age--;
            return age;
        }
        // בדיקה האם מספר גדול מ0 
        public static bool GreaterThanZero(int num)
        {
            return num > 0;
        }
        //בדיקה הם תו הוא אות עברית
        public static bool IsHebrewLetter(char c)
        {
            string otiyot = "'אבגדהוזחטיכלמנסעפצקרשתךםןףץ";
            if (otiyot.IndexOf(c) == -1)
                return false;
            return true;
        }
        //  בדיקה האם תו הוא תו אנגלי
        public static bool IsEnglishLetter(char c)
        {
            string otiyot = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'";
            if (otiyot.IndexOf(c) == -1)
                return false;
            return true;
        }
        // בדיקה האם תו הוא סיפרה 
        public static bool IsDigits(char c)
        {
            string digits = "0123456789";
            if (digits.IndexOf(c) == -1)
                return false;
            return true;
        }
        // בדיקה האם שם פריט חוקי
        public static bool IsLegalItemName(string word)
        {
            foreach (char c in word)
                if (IsDigits(c) == false && IsHebrewLetter(c) == false && c != '-' && c != ' ' && IsEnglishLetter(c) == false)
                    return false;
            return true;
        }
        //האם שם חוקי ללא ספרות או תווים משונים
        public static bool IsLegalName(string word)
        {
            foreach (char c in word)
                if (IsHebrewLetter(c) == false && IsEnglishLetter(c) == false && c != '-')
                    return false;
            return true;
        }
        // האם שם עיר חוקי כנ"ל
        public static bool IsLegalCity(string word)
        {
            foreach (char c in word)
                if (IsHebrewLetter(c) == false && IsEnglishLetter(c) == false && c != '-' && c != ' ')
                    return false;
            return true;
        }
        // האם תז חוקי באורך 9 ורק ספרות
        public static bool IsLegalId(string id)
        {
            string word = id;
            if (word.Length != 9)
                return false;
            foreach (char c in word)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        // בדיקה האם מחרוזת כולה מורכבת מספרות
        public static bool IsLegalDigit(string dig)
        {
            string digit = dig;
            foreach (char c in digit)
                if (digit.IndexOf(c) == -1)
                    return false;
            return true;
        }
        // בדיקה האם מיקוד נכון באורך 5 ורק ספרות
        public static bool IsLegalZipcode(string zip)
        {
            string zipcode = zip;
            if (zipcode.Length != 5)
                return false;
            foreach (char c in zipcode)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        // בדיקה האם מס כרטיס אשראי חוקי
        public static bool IsLegalCNumberVisa(string cnum)
        {
            string creditnumber = cnum;
            if (creditnumber.Length != 16)
                return false;
            foreach (char c in creditnumber)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        // בדיקה האם מס כרטיס אשראי אמריקן אקספרס חוקי
        public static bool IsLegalCNumberAmericanexpress(string cnum)
        {
            string creditnumber = cnum;
            if (creditnumber.Length != 15)
                return false;
            foreach (char c in creditnumber)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalThreeDig(string tdig)
        {
            string threedig = tdig;
            if (threedig.Length != 3)
                return false;
            foreach (char c in threedig)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalItemId(string id)
        {
            string word = id;
            if (word.Length != 4)
                return false;
            foreach (char c in word)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        //מחזיר את  הקידומת ללא מספר הטלפון  
        public static string SubPhon(string word)
        {
            string sub;
            if (word.Length == 11)
                sub = word.Substring(0, 3);
            else
                sub = word.Substring(0, 2);

            return sub;
        }
        //מחזיר את מספר הטלפון ללא הקידומת של הטלפון 
        public static string PhoneNum(string word)
        {
            string phone = "";
            if (word.Length == 11)
                phone = word.Substring(4);
            else
                phone = word.Substring(3);

            return phone;
        }
        public static bool IsPhoneNum(string word)
        {
            bool s = false;
            if (PhoneNum(word).Length == 7)
                s = true;
            return s;
        }
        //בדיקה אם המייל תקין
        public static bool IsMail(string st)
        {
            int x = 0, y = 0;
            bool AfterShtrodeltav = false;//אחרי שטרודל לא נקודה
            bool TavAfterPoint = false;//תו אחרי נקודה
            if (st[0] == '@')
                return false;
            for (int i = 1; i < st.Length; i++)
            {
                if (st[i] == '@')
                {
                    x = i;
                    if (st[i + 1] == '.')
                        return false;
                    else
                        AfterShtrodeltav = true;
                }
                if (st[i] == '.')
                {
                    y = i;
                    if (i + 1 != st.Length - 1)
                        TavAfterPoint = true;
                    else
                        return false;
                }
            }
            if ((x < y) && (AfterShtrodeltav == true) && (TavAfterPoint == true))
                return true;
            return false;
        }
        // בדיקת שם
        public static bool CheckName(char t)
        {
            return (char.IsLetter(t) || t == ' ' || t == '\b');
        }
        //בדיקת  טלפון  
        public static bool CheckTel(char t)
        {
            return (char.IsDigit(t) || t == '\b');
        }
        //בדיקת ת.ז ללא חישובים
        public static bool CheckID(char t)
        {
            return (char.IsDigit(t));
        }

        //בדיקת כתובת
        public static bool CheckAddres(char t)
        {
            return (char.IsLetterOrDigit(t) || t == '\b' || t == '-' || t == ' ');
        }
        //בדיקת פלאפון
        public static bool CheckPhone(string tel)
        {
            string pattern = @"\b05[0 2 3 4 5 7 8][2-9]\d{6}$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(tel);
        }
        //בדיקת טלפון
        public static bool CheckTelephone(string tel)
        {
            string phone = @"\b0[3 2 4 8 9 77 73 72 79][2-9]\d{6}$";
            Regex reg = new Regex(phone);
            return reg.IsMatch(tel);
        }


    }
}
